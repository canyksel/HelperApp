using System.Net.Http;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net;
using System.Collections;
using System.Diagnostics;
using System.Security.Policy;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using System.Data;
using HttpResponseApp.Models;

namespace HttpResponseApp
{
    public partial class Form1 : Form
    {
        private bool stop = false;
        public Form1()
        {
            InitializeComponent();

            ContextMenuStrip contextMenu = new ContextMenuStrip();

            ToolStripMenuItem copyMenuItem = new ToolStripMenuItem();
            copyMenuItem.Text = "Kopyala";
            contextMenu.Items.Add(copyMenuItem);

            listBoxUrlList.ContextMenuStrip = contextMenu;

            copyMenuItem.Click += CopyMenuItem_Click;
        }

        private async void CopyMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxUrlList.SelectedItem != null)
            {
                Clipboard.SetText(listBoxUrlList.SelectedItem.ToString());
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUrls.Text))
            {
                MessageBox.Show("Lütfen tarama yapmak istediðiniz URL'i giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            stop = false;
            checkBoxLighthouse.Enabled = false;
            linkLabel1.Enabled = false;
            btnSaveResult.Enabled = false;

            listBoxUrlList.Items.Clear();
            List<string> urls = new List<string>();

            string mainLink = txtUrls.Text.TrimEnd('/');
            if (mainLink.Contains("sitemap.xml"))
            {
                urls = await GetAllLinksFromSitemapAsync(mainLink);
            }
            else
            {
                string sitemapLink = await GetSitemapLinkFromRobotsTxtAsync(mainLink);
                urls = await GetAllLinksFromSitemapAsync(sitemapLink);
                listBoxUrlList.Items.AddRange(urls.ToArray());
                if (string.IsNullOrWhiteSpace(sitemapLink))
                {
                    MessageBox.Show("Robots.txt dosyasýnda sitemap.xml bulunamadý!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            async Task<string> GetSitemapLinkFromRobotsTxtAsync(string url)
            {
                string robotsTxt = string.Empty;
                using (var httpClient = new HttpClient())
                {
                    try
                    {
                        robotsTxt = await httpClient.GetStringAsync(url + "/robots.txt");
                    }
                    catch (Exception)
                    {
                        return string.Empty;
                    }
                }

                if (!string.IsNullOrWhiteSpace(robotsTxt))
                {
                    string[] lines = robotsTxt.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.TrimEntries);
                    foreach (string line in lines)
                    {
                        if (line.StartsWith("Sitemap:"))
                        {
                            return line.Replace("Sitemap:", "").Trim();
                        }
                    }
                }
                return string.Empty;
            }

            async Task<List<string>> GetAllLinksFromSitemapAsync(string url)
            {
                List<string> links = new List<string>();
                using (var httpClient = new HttpClient())
                {
                    var xml = await httpClient.GetStringAsync(url);
                    var htmlDoc = new HtmlAgilityPack.HtmlDocument();
                    htmlDoc.LoadHtml(xml);

                    var nodes = htmlDoc.DocumentNode.SelectNodes("//loc");
                    if (nodes != null)
                    {
                        foreach (var node in nodes)
                        {
                            links.Add(node.InnerHtml);
                        }
                    }
                }
                return links;
            }

            async Task<AnalyticsModel> GetPerformanceResult(string url)
            {
                string apiUrl = "https://www.googleapis.com/pagespeedonline/v5/runPagespeed?url=" + url;

                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(apiUrl);
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var json = JObject.Parse(jsonString);

                    var performanceScore = decimal.Parse(json["lighthouseResult"]["categories"]["performance"]?["score"]?.ToString());
                    var lcpScore = json["lighthouseResult"]["audits"]["largest-contentful-paint"]["displayValue"]?.ToString() ?? "N/A";
                    var fcpScore = json["lighthouseResult"]["audits"]["first-contentful-paint"]["displayValue"]?.ToString() ?? "N/A";
                    var clsScore = json["lighthouseResult"]["audits"]["cumulative-layout-shift"]["displayValue"]?.ToString() ?? "N/A";

                    var model = new AnalyticsModel()
                    {
                        PerformanceScore = performanceScore * 100,
                        LCPScore = lcpScore,
                        FCPScore = fcpScore,
                        CLSScore = clsScore,
                    };

                    return model;
                }
            }

            //async Task<Dictionary<string, string>> GetPerformanceResult(string url)
            //{
            //    string apiUrl = "https://www.googleapis.com/pagespeedonline/v5/runPagespeed?url=" + url;

            //    using (var client = new HttpClient())
            //    {
            //        var response = await client.GetAsync(apiUrl);
            //        var jsonString = await response.Content.ReadAsStringAsync();
            //        var json = JObject.Parse(jsonString);

            //        var result = new Dictionary<string, string>();
            //        result.Add("performanceScore", json["lighthouseResult"]["categories"]["performance"]?["score"]?.ToString() ?? "N/A");
            //        result.Add("lcpScore", json["lighthouseResult"]["audits"]["largest-contentful-paint"]["displayValue"]?.ToString() ?? "N/A");
            //        result.Add("fcpScore", json["lighthouseResult"]["audits"]["first-contentful-paint"]["displayValue"]?.ToString() ?? "N/A");
            //        result.Add("clsScore", json["lighthouseResult"]["audits"]["cumulative-layout-shift"]["displayValue"]?.ToString() ?? "N/A");

            //        return result;
            //    }
            //}

            List<HttpResponseMessage> responses = new List<HttpResponseMessage>();

            using (var httpClient = new HttpClient())
            {
                foreach (string url in urls)
                {
                    if (stop) break;
                    try
                    {
                        label2.Text = $"Toplam: {urls.Count} adet url bulundu. Tarama durumu: {responses.Count}/{urls.Count}";

                        var stopWatch = new Stopwatch();
                        stopWatch.Start();

                        var response = await httpClient.GetAsync(url);

                        stopWatch.Stop();
                        var responseTime = stopWatch.ElapsedMilliseconds;

                        response.RequestMessage.RequestUri = new Uri(url);
                        response.RequestMessage.Method = HttpMethod.Get;
                        responses.Add(response);
                        //string item = response.RequestMessage.RequestUri + " - " + (int)response.StatusCode + " - " + response.ReasonPhrase + " " + (response.StatusCode == HttpStatusCode.OK ? "\u2714" : "\u2716") + " - " + "Response Time: " + responseTime + "ms" + (performanceResult != null ? " - " + $"Performance result: {performanceResult}" : "");
                        if (responses.Count == urls.Count)
                            MessageBox.Show("Ýþlem tamamlandý", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        var dataGridViewRow = new DataGridViewRow();

                        var statusCellStyle = new DataGridViewCellStyle();
                        var performanceCellStyle = new DataGridViewCellStyle();
                        var responseTimeCellStyle = new DataGridViewCellStyle();

                        var analiyticsResult = new AnalyticsModel();

                        if (checkBoxLighthouse.Checked)
                        {
                            analiyticsResult = await GetPerformanceResult(url);
                        }
                        else
                        {
                            analiyticsResult = new AnalyticsModel();
                        }


                        // Durum koduna göre hücre arka plan rengi ayarlanýyor
                        if ((int)response.StatusCode == 200)
                        {
                            statusCellStyle.BackColor = Color.LightGreen;
                        }
                        else if ((int)response.StatusCode == 500)
                        {
                            statusCellStyle.BackColor = Color.LightPink;
                        }

                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            if (responseTime < 100)
                            {
                                responseTimeCellStyle.BackColor = Color.MediumSpringGreen;
                            }
                            else if (100 < responseTime && responseTime < 300)
                            {
                                responseTimeCellStyle.BackColor = Color.LightGreen;
                            }

                            else if (300 < responseTime && responseTime < 1000)
                            {
                                responseTimeCellStyle.BackColor = Color.LightGoldenrodYellow;
                            }

                            else if (1000 < responseTime && responseTime < 2000)
                            {
                                responseTimeCellStyle.BackColor = Color.LightPink;
                            }
                            else
                            {
                                responseTimeCellStyle.BackColor = Color.IndianRed;
                            }
                        }

                        if (checkBoxLighthouse.Checked)
                        {
                            if (analiyticsResult.PerformanceScore >= 90)
                                performanceCellStyle.BackColor = Color.LightGreen;
                            else if (50 <= analiyticsResult.PerformanceScore && analiyticsResult.PerformanceScore <= 89)
                                performanceCellStyle.BackColor = Color.LightGoldenrodYellow;
                            else
                                performanceCellStyle.BackColor = Color.LightPink;
                        }

                        dataGridViewRow.CreateCells(dataGridView1);
                        dataGridViewRow.Cells[0].Value = response.RequestMessage.RequestUri.ToString();
                        dataGridViewRow.Cells[1].Value = (int)response.StatusCode;
                        dataGridViewRow.Cells[2].Value = responseTime.ToString() + "ms";
                        dataGridViewRow.Cells[3].Value = response.ReasonPhrase + " " + (response.StatusCode == HttpStatusCode.OK ? "\u2714" : "\u2716");
                        dataGridViewRow.Cells[4].Value = analiyticsResult.PerformanceScore ?? 0;
                        dataGridViewRow.Cells[5].Value = analiyticsResult.FCPScore ?? "-";
                        dataGridViewRow.Cells[6].Value = analiyticsResult.LCPScore ?? "-";
                        dataGridViewRow.Cells[7].Value = analiyticsResult.CLSScore ?? "-";

                        // Hücrelerin DataGridViewCellStyle özellikleri ayarlanýyor
                        dataGridViewRow.Cells[1].Style = statusCellStyle;
                        dataGridViewRow.Cells[2].Style = responseTimeCellStyle;
                        dataGridViewRow.Cells[3].Style = statusCellStyle;
                        dataGridViewRow.Cells[4].Style = performanceCellStyle;


                        dataGridView1.Rows.Add(dataGridViewRow);

                        //Delay 3 second
                        await Task.Delay(3000);
                    }
                    catch (Exception ex)
                    {
                        HttpResponseMessage r = new HttpResponseMessage();
                        r.RequestMessage = new HttpRequestMessage();
                        r.RequestMessage.RequestUri = new Uri(url);
                        r.RequestMessage.Method = HttpMethod.Get;
                        r.StatusCode = HttpStatusCode.BadRequest;
                        r.ReasonPhrase = ex.Message;
                        responses.Add(r);
                    }
                }
            }
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ýþlemi durdurmak istediðinizden emin misiniz?", "Stop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                stop = true;
                checkBoxLighthouse.Enabled = true;
                linkLabel1.Enabled = true;
                btnSaveResult.Enabled = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
             
        private async void btnSaveResult_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    // Sütun baþlýklarýný yazdýr
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        writer.Write(dataGridView1.Columns[i].HeaderText + "\t");
                    }
                    writer.WriteLine();

                    // Satýrlarý yazdýr
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            if (row.Cells[i].Value != null)
                            {
                                writer.Write(row.Cells[i].Value.ToString() + "\t");
                            }
                            else
                            {
                                writer.Write("\t");
                            }
                        }
                        writer.WriteLine();
                    }
                }

                MessageBox.Show("Kayýt iþlemi tamamlandý.");
            }
        }

      /*   -------------- Method -2 Must be improve   -----------   */
        /* private async void btnSaveResult_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            if (row.Cells[i].Value != null)
                            {
                                writer.Write(row.Cells[i].Value.ToString() + "\t");
                            }
                            else
                            {
                                writer.Write("\t");
                            }
                        }
                        writer.WriteLine();
                    }
                }
                MessageBox.Show("Kayýt iþlemi tamamlandý.");
            }
        } */
    }
}