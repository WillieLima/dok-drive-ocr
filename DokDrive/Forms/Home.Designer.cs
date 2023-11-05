namespace DokDrive
{
    partial class Home
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
            label1 = new Label();
            label2 = new Label();
            btnScan = new Button();
            btnView = new Button();
            btnConvert = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(197, 42);
            label1.Name = "label1";
            label1.Size = new Size(382, 86);
            label1.TabIndex = 0;
            label1.Text = "Bem vindo!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(213, 158);
            label2.Name = "label2";
            label2.Size = new Size(363, 32);
            label2.TabIndex = 1;
            label2.Text = "Escolher o que pretende fazer:";
            // 
            // btnScan
            // 
            btnScan.Location = new Point(349, 226);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(100, 35);
            btnScan.TabIndex = 2;
            btnScan.Text = "Scanear";
            btnScan.UseVisualStyleBackColor = true;
            btnScan.Click += btnScan_Click;
            // 
            // btnView
            // 
            btnView.Location = new Point(349, 277);
            btnView.Name = "btnView";
            btnView.Size = new Size(100, 35);
            btnView.TabIndex = 3;
            btnView.Text = "Visualizar";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(349, 327);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(100, 35);
            btnConvert.TabIndex = 4;
            btnConvert.Text = "Converter";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConvert);
            Controls.Add(btnView);
            Controls.Add(btnScan);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Home";
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnScan;
        private Button btnView;
        private Button btnConvert;
    }
}