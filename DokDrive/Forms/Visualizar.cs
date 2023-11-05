using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfiumViewer;
using System.IO;

namespace DokDrive.Forms
{
    public partial class Visualizar : Form
    {
        PdfiumViewer.PdfViewer pdfViewer;
        public Visualizar()
        {
            InitializeComponent();
            pdfViewer = new PdfViewer();
            this.Controls.Add(pdfViewer);
        }

        private void abrirPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                openfile(dialog.FileName);
            }
        }
        public void openfile(string filepath)
        {
            byte[] bytes = System.IO.File.ReadAllBytes(filepath);
            var stream = new MemoryStream(bytes);
            PdfDocument pdfDocument = PdfDocument.Load(stream);
            pdfViewer.Document = pdfDocument;
        }
    }
}
