using DokDrive.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DokDrive
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            var scan = new Scanear();
            scan.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            var view = new Visualizar();
            view.Show();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            var convert = new Converter();
            convert.Show();
        }
    }
}
