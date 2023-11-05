using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Tesseract;

namespace DokDrive.Forms
{
    public partial class Converter : Form
    {
        public Converter()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();


            string inputPdfPath = inputPdfTextBox.Text;
            string outputPdfPath = outputPdfTextBox.Text;

            try
            {
                using(PdfReader pdfReader = new PdfReader(inputPdfPath))
                using(FileStream fs = new FileStream(outputPdfPath, FileMode.Create))
                using(Document doc = new Document())
                using(PdfWriter pdfWriter = PdfWriter.GetInstance(doc, fs))
                {
                    doc.Open();
                    PdfContentByte pdfContentByte = pdfWriter.DirectContent;
                    for(int page = 1; page <= pdfReader.NumberOfPages; page++)
                    {
                        PdfImportedPage pdfImportedPage = pdfWriter.GetImportedPage(pdfReader, page);
                        pdfContentByte.AddTemplate(pdfImportedPage, 0, 0);
                    }
                    doc.Close();
                }

                using(var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
                using(var img = Pix.LoadFromFile(outputPdfPath))
                using(var page = engine.Process(img))
                {
                    File.WriteAllText(outputPdfPath.Replace(".pdf", ".txt"), page.GetText());
                }

                MessageBox.Show("PDF convertido com sucesso para um PDF pesquisável e também extraído o texto.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void btnBrowserInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Arquivos PDF (*.pdf)|*.pdf";

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                inputPdfTextBox.Text = dlg.FileName;
            }
        }

        private void btnBrowserOutput_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedDirectory = folderBrowserDialog1.SelectedPath;
                outputPdfTextBox.Text = selectedDirectory;
            }
        }

        private void Converter_Load(object sender, EventArgs e)
        {

        }
    }
}
