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

            listBoxResponses.Items.Clear();
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

            List<HttpResponseMessage> responses = new List<HttpResponseMessage>();
            using (var httpClient = new HttpClient())
            {
                foreach (string url in urls)
                {
                    if (stop) break;
                    try
                    {
                        var stopWatch = new Stopwatch();
                        stopWatch.Start();

                        var response = await httpClient.GetAsync(url);

                        stopWatch.Stop();
                        var responseTime = stopWatch.ElapsedMilliseconds;

                        response.RequestMessage.RequestUri = new Uri(url);
                        response.RequestMessage.Method = HttpMethod.Get;
                        responses.Add(response);
                        string item = response.RequestMessage.RequestUri + " - " + (int)response.StatusCode + " - " + response.ReasonPhrase + " " + (response.StatusCode == HttpStatusCode.OK ? "\u2714" : "\u2716") + " - " + "Response Time: " + responseTime + "ms";
                        label2.Text = $"Toplam: {urls.Count} adet url bulundu. Tarama durumu: {responses.Count}/{urls.Count}";
                        if (responses.Count == urls.Count)
                            MessageBox.Show("Ýþlem tamamlandý", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listBoxResponses.Items.Add(item);

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
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBoxResponses.Items.Clear();
        }

        private async void btnSaveResult_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (var item in listBoxResponses.Items)
                    {
                        writer.WriteLine(item);
                    }
                }
            }
        }
    }
}