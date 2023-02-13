using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Formats.Webp;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.Formats.Jpeg;
using Color = System.Drawing.Color;

namespace WebpConverter
{
    public partial class Form1 : Form
    {
        public string selectedFolderPath;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbxQuality.Items.AddRange(new object[] { 20, 40, 60, 80, 100 });
            cmbxFormat.Items.AddRange(new object[] { "PNG to JPG", "JPG to PNG", "PNG to Webp", "JPG to Webp" });
            cmbxQuality.SelectedIndex = 3;
            cmbxFormat.SelectedIndex = 0;
        }

        private void Open_Folder_Click(object sender, EventArgs e)
        {
            // Klasör seçme penceresini aç
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    label5.Text = "Source Folder: " + fbd.SelectedPath;
                    // Combobox'taki seçeneðe göre görselleri listbox'a ekle
                    foreach (string file in files)
                    {
                        string ext = Path.GetExtension(file);
                        if ((ext == ".jpg" || ext == ".JPG") && (cmbxFormat.SelectedIndex == 1 || cmbxFormat.SelectedIndex == 3))
                        {
                            listBox1.Items.Add(file);
                        }
                        else if ((ext == ".png" || ext == ".PNG") && (cmbxFormat.SelectedIndex == 0 || cmbxFormat.SelectedIndex == 2))
                        {
                            listBox1.Items.Add(file);
                        }
                    }
                }
            }
        }

        private void Select_Target_Click(object sender, EventArgs e)
        {
            // Hedef klasör seçme penceresini aç
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    label6.Text = "Target Folder: " + fbd.SelectedPath;
                    selectedFolderPath = fbd.SelectedPath;
                }
            }
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            // Hedef klasör yolunu al
            string targetPath = selectedFolderPath;
            // Klasördeki tüm görselleri al
            string[] files = listBox1.Items.OfType<string>().ToArray();
            // Her görseli dönüþtür

            if (listBox1.Items.Count == 0)
            {
                errorLabel.Text = "Please select a image!";
                errorLabel.ForeColor = Color.Red;
            }
                

            foreach (string file in files)
            {
                // Görsel dosya yolunu ve adýný al
                string fileName = Path.GetFileNameWithoutExtension(file);
                string fileExtension = Path.GetExtension(file);
                // Hedef dosya yolunu ve adýný oluþtur
                string targetFileWebp = Path.Combine(targetPath, fileName + ".webp");
                string targetFilePng = Path.Combine(targetPath, fileName + ".png");
                string targetFileJpg = Path.Combine(targetPath, fileName + ".jpg");


                int quality = (int)cmbxQuality.SelectedItem;
                int type = (int)cmbxFormat.SelectedIndex;
                using (Image<Rgba32> image = SixLabors.ImageSharp.Image.Load<Rgba32>(file))
                {
                    if (type == 0)
                    {
                        image.Save(targetFileJpg, new JpegEncoder() { Quality = quality });
                    }

                    if (type == 1)
                    {
                        image.SaveAsPng(targetFilePng, new PngEncoder());
                    }

                    if (type == 2 || type == 3)
                    {
                        image.Save(targetFileWebp, new WebpEncoder() { Quality = quality });
                    }
                }
                if (targetFileWebp != null)
                {
                    listBox2.Items.Add(targetFileWebp);
                }
                if (targetFilePng != null)
                {
                    listBox2.Items.Add(targetFilePng);
                }
                if (targetFileJpg != null)
                {
                    listBox2.Items.Add(targetFileJpg);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void Clear_Image_List_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Clear_Convert_Image_List_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }
    }
}