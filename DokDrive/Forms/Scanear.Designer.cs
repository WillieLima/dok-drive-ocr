namespace DokDrive.Forms
{
    partial class Scanear
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            listScanners = new ListBox();
            label1 = new Label();
            btnScan = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnScan);
            panel1.Controls.Add(listScanners);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(26, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 345);
            panel1.TabIndex = 0;
            // 
            // listScanners
            // 
            listScanners.FormattingEnabled = true;
            listScanners.ItemHeight = 15;
            listScanners.Location = new Point(15, 56);
            listScanners.Name = "listScanners";
            listScanners.Size = new Size(235, 229);
            listScanners.TabIndex = 1;
            listScanners.SelectedIndexChanged += listScanners_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 19);
            label1.Name = "label1";
            label1.Size = new Size(161, 25);
            label1.TabIndex = 0;
            label1.Text = "Lista de scanners";
            // 
            // btnScan
            // 
            btnScan.Location = new Point(62, 301);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(124, 28);
            btnScan.TabIndex = 2;
            btnScan.Text = "Scanear";
            btnScan.UseVisualStyleBackColor = true;
            btnScan.Click += btnScan_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(357, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(405, 385);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Scanear
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Scanear";
            Text = "Scanear";
            Load += Scanear_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListBox listScanners;
        private Label label1;
        private Button btnScan;
        private PictureBox pictureBox1;
    }
}