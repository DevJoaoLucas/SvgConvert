using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ImageMagick;

namespace SvgConvert
{
    public partial class Form1 : Form
    {
        private List<string> arquivosSelecionados = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelecionarArquivos_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Imagens|*.svg;*.jpg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                foreach (string filename in openFileDialog.FileNames)
                {
                    lbArquivos.Items.Add(filename);
                }
            }
        }


        private void btnConverter_Click(object sender, EventArgs e)
        {

            if (lbArquivos.Items.Count == 0)
            {
                MessageBox.Show("Por favor, selecione pelo menos um arquivo para converter.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (cbxTipoConvert.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um tipo de conversão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (string.IsNullOrWhiteSpace(txtDiretorioSaida.Text) || !Directory.Exists(txtDiretorioSaida.Text))
            {
                MessageBox.Show("Por favor, selecione um diretório de saída válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (string filename in lbArquivos.Items)
            {
                string extensao = Path.GetExtension(filename).ToLower();

                string diretorioSaida = txtDiretorioSaida.Text;
                string tipoConversao = cbxTipoConvert.SelectedItem.ToString().ToLower();

                try
                {
                    using (MagickImage image = new MagickImage(filename))
                    {
                        string caminhoSaida = Path.Combine(diretorioSaida, Path.GetFileNameWithoutExtension(filename) + "." + tipoConversao);

                        image.Write(caminhoSaida);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao converter o arquivo {Path.GetFileName(filename)}: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            lbArquivos.Items.Clear();

            MessageBox.Show("Conversão concluída!");
        }

        private void PreencherComboBoxTipos()
        {
            cbxTipoConvert.Items.Add("SVG");

            cbxTipoConvert.Items.Add("BMP");
            cbxTipoConvert.Items.Add("GIF");
            cbxTipoConvert.Items.Add("JPEG");
            cbxTipoConvert.Items.Add("PNG");
            cbxTipoConvert.Items.Add("TIFF");
            cbxTipoConvert.Items.Add("ICO");
            cbxTipoConvert.Items.Add("WebP");

            cbxTipoConvert.Items.Add("PBM");
            cbxTipoConvert.Items.Add("PGM");
            cbxTipoConvert.Items.Add("PPM");
            cbxTipoConvert.Items.Add("HDR");
            cbxTipoConvert.Items.Add("RGB");
            cbxTipoConvert.Items.Add("RGBA");
            cbxTipoConvert.Items.Add("CMYK");
            cbxTipoConvert.Items.Add("CMYKA");
            cbxTipoConvert.Items.Add("YUV");
            cbxTipoConvert.Items.Add("YUVA");
            cbxTipoConvert.Items.Add("GRAY");
            cbxTipoConvert.Items.Add("PAL");
            cbxTipoConvert.Items.Add("MAP");
            cbxTipoConvert.Items.Add("DIB");
            cbxTipoConvert.Items.Add("PDF");
            cbxTipoConvert.Items.Add("XPM");
            cbxTipoConvert.Items.Add("XBM");
            cbxTipoConvert.Items.Add("WMF");
            cbxTipoConvert.Items.Add("EMF");
            cbxTipoConvert.Items.Add("DDS");
            cbxTipoConvert.Items.Add("OTB");
            cbxTipoConvert.Items.Add("STEGANO");
            cbxTipoConvert.Items.Add("FITS");
            cbxTipoConvert.Items.Add("MTV");
            cbxTipoConvert.Items.Add("VIFF");
            cbxTipoConvert.Items.Add("MONO");
            cbxTipoConvert.Items.Add("MPC");
            cbxTipoConvert.Items.Add("MPEG");
            cbxTipoConvert.Items.Add("MPR");
            cbxTipoConvert.Items.Add("MSP");
            cbxTipoConvert.Items.Add("TXT");
            cbxTipoConvert.Items.Add("JPG");
            cbxTipoConvert.Items.Add("TGA");
            cbxTipoConvert.Items.Add("WEBP");
            cbxTipoConvert.Items.Add("JP2");
            cbxTipoConvert.Items.Add("DPX");
            cbxTipoConvert.Items.Add("AI");
            cbxTipoConvert.Items.Add("PS");
            cbxTipoConvert.Items.Add("EPS");
            cbxTipoConvert.Items.Add("PS2");
            cbxTipoConvert.Items.Add("EPS2");
            cbxTipoConvert.Items.Add("PS3");
            cbxTipoConvert.Items.Add("EPS3");
            cbxTipoConvert.Items.Add("EPI");
            cbxTipoConvert.Items.Add("PDF");
            cbxTipoConvert.Items.Add("PDF");
            cbxTipoConvert.Items.Add("PSB");
            cbxTipoConvert.Items.Add("PDF");
            cbxTipoConvert.Items.Add("FAX");
            cbxTipoConvert.Items.Add("TIFF64");
            cbxTipoConvert.Items.Add("PTIF");
            cbxTipoConvert.Items.Add("BMP2");
            cbxTipoConvert.Items.Add("BMP3");
            cbxTipoConvert.Items.Add("GIF87");
            cbxTipoConvert.Items.Add("GIF89");
            cbxTipoConvert.Items.Add("MIFF");
            cbxTipoConvert.Items.Add("MNG");
            cbxTipoConvert.Items.Add("M2V");
            cbxTipoConvert.Items.Add("MPV");
            cbxTipoConvert.Items.Add("MVG");
            cbxTipoConvert.Items.Add("MVG");
            cbxTipoConvert.Items.Add("PLASMA");
            cbxTipoConvert.Items.Add("PNG00");
            cbxTipoConvert.Items.Add("PNG24");
            cbxTipoConvert.Items.Add("PNG32");
            cbxTipoConvert.Items.Add("PNG48");
            cbxTipoConvert.Items.Add("PNG64");
            cbxTipoConvert.Items.Add("PNG8");
            cbxTipoConvert.Items.Add("PNG8");
            cbxTipoConvert.Items.Add("PNM");
            cbxTipoConvert.Items.Add("PWP");
            cbxTipoConvert.Items.Add("RGB565");
            cbxTipoConvert.Items.Add("RGB565");
            cbxTipoConvert.Items.Add("RGB565");
            cbxTipoConvert.Items.Add("RGB565");
            cbxTipoConvert.Items.Add("RLE");
            cbxTipoConvert.Items.Add("SCT");
            cbxTipoConvert.Items.Add("SFW");
            cbxTipoConvert.Items.Add("SGI");
            cbxTipoConvert.Items.Add("SHTML");
            cbxTipoConvert.Items.Add("TEXT");
            cbxTipoConvert.Items.Add("TILE");
            cbxTipoConvert.Items.Add("TIM");
            cbxTipoConvert.Items.Add("TIM");
            cbxTipoConvert.Items.Add("TIM2");
            cbxTipoConvert.Items.Add("TIM2");
            cbxTipoConvert.Items.Add("TTC");
            cbxTipoConvert.Items.Add("TTF");
            cbxTipoConvert.Items.Add("TXT1");
            cbxTipoConvert.Items.Add("TXT2");
            cbxTipoConvert.Items.Add("TXT3");
            cbxTipoConvert.Items.Add("TXT4");
            cbxTipoConvert.Items.Add("TXT5");
            cbxTipoConvert.Items.Add("TXT6");
            cbxTipoConvert.Items.Add("TXT7");
            cbxTipoConvert.Items.Add("TXT8");
            cbxTipoConvert.Items.Add("TXT9");
            cbxTipoConvert.Items.Add("TXT10");
            cbxTipoConvert.Items.Add("TXT11");
            cbxTipoConvert.Items.Add("TXT12");
            cbxTipoConvert.Items.Add("UTF");
            cbxTipoConvert.Items.Add("UYVY");
            cbxTipoConvert.Items.Add("VDA");
            cbxTipoConvert.Items.Add("VICAR");
            cbxTipoConvert.Items.Add("VID");
            cbxTipoConvert.Items.Add("VIFF");
            cbxTipoConvert.Items.Add("VIPS");
            cbxTipoConvert.Items.Add("VLPG");
            cbxTipoConvert.Items.Add("WAD");
            cbxTipoConvert.Items.Add("WBMP");
            cbxTipoConvert.Items.Add("WPG");
            cbxTipoConvert.Items.Add("X3F");
            cbxTipoConvert.Items.Add("XBM");
            cbxTipoConvert.Items.Add("XCF");
            cbxTipoConvert.Items.Add("XPM");
            cbxTipoConvert.Items.Add("XV");
            cbxTipoConvert.Items.Add("YCbCr");
            cbxTipoConvert.Items.Add("YCbCrA");
            cbxTipoConvert.Items.Add("YUV");
            cbxTipoConvert.Items.Add("YUV");
            cbxTipoConvert.Items.Add("YUV");
            cbxTipoConvert.Items.Add("YUV");
        }

        private void lbArquivos_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = lbArquivos.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches)
                {
                    // Exibir um menu de contexto para exclusão do item
                    ContextMenu contextMenu = new ContextMenu();
                    contextMenu.MenuItems.Add(new MenuItem("Excluir item", ExcluirItem_Click));
                    lbArquivos.ContextMenu = contextMenu;
                }
            }
        }

        private void ExcluirItem_Click(object sender, EventArgs e)
        {

            if (lbArquivos.SelectedItem != null)
            {
                lbArquivos.Items.Remove(lbArquivos.SelectedItem);
            }
        }

        private void btnDiretorioSaida_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {

                folderBrowserDialog.ShowNewFolderButton = true;

                DialogResult result = folderBrowserDialog.ShowDialog();


                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {

                    txtDiretorioSaida.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PreencherComboBoxTipos();


            cbxTipoConvert.SelectedIndex = 0;
        }
    }
}
