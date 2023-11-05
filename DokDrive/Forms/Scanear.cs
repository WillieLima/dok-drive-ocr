using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;
using System.IO;

namespace DokDrive.Forms
{
    public partial class Scanear : Form
    {
        public Scanear()
        {
            InitializeComponent();
        }

        private void listScanners_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Scanear_Load(object sender, EventArgs e)
        {
            try
            {
                var deviceManager = new DeviceManager();

                for(int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
                {
                    if(deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                    {
                        continue;
                    }
                    listScanners.Items.Add(deviceManager.DeviceInfos[i].Properties["Name"].get_Value());
                }
            }
            catch(COMException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            try
            {
                var deviceMangager = new DeviceManager();

                DeviceInfo AvailableScanner = null;

                for(int i = 0; i <= deviceMangager.DeviceInfos.Count; i++)
                {
                    if(deviceMangager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                    {
                        continue;
                    }
                    AvailableScanner = deviceMangager.DeviceInfos[i];

                    break;
                }

                var device = AvailableScanner.Connect();

                var scannerItem = device.Items[1];

                var imgFile = (ImageFile)scannerItem.Transfer(FormatID.wiaFormatJPEG);

                var path = @"D:\scan\ScanImg.jpg";

                if(File.Exists(path))
                {
                    File.Delete(path);
                }

                imgFile.SaveFile(path);

                pictureBox1.ImageLocation = path;
            }
            catch(COMException ex)
            {

                throw;
            }
        }
    }
}
