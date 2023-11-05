namespace DokDrive.Forms
{
    partial class Converter
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
            btnBrowserOutput = new Button();
            btnBrowserInput = new Button();
            outputPdfTextBox = new TextBox();
            inputPdfTextBox = new TextBox();
            btnConvert = new Button();
            folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // btnBrowserOutput
            // 
            btnBrowserOutput.Location = new Point(298, 110);
            btnBrowserOutput.Name = "btnBrowserOutput";
            btnBrowserOutput.Size = new Size(75, 23);
            btnBrowserOutput.TabIndex = 9;
            btnBrowserOutput.Text = "Browser";
            btnBrowserOutput.UseVisualStyleBackColor = true;
            btnBrowserOutput.Click += btnBrowserOutput_Click;
            // 
            // btnBrowserInput
            // 
            btnBrowserInput.Location = new Point(298, 65);
            btnBrowserInput.Name = "btnBrowserInput";
            btnBrowserInput.Size = new Size(75, 23);
            btnBrowserInput.TabIndex = 8;
            btnBrowserInput.Text = "Browser";
            btnBrowserInput.UseVisualStyleBackColor = true;
            btnBrowserInput.Click += btnBrowserInput_Click;
            // 
            // outputPdfTextBox
            // 
            outputPdfTextBox.Location = new Point(62, 110);
            outputPdfTextBox.Name = "outputPdfTextBox";
            outputPdfTextBox.Size = new Size(230, 23);
            outputPdfTextBox.TabIndex = 7;
            // 
            // inputPdfTextBox
            // 
            inputPdfTextBox.Location = new Point(62, 65);
            inputPdfTextBox.Name = "inputPdfTextBox";
            inputPdfTextBox.Size = new Size(230, 23);
            inputPdfTextBox.TabIndex = 6;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(139, 185);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(75, 23);
            btnConvert.TabIndex = 5;
            btnConvert.Text = "Converter";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // Converter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(434, 272);
            Controls.Add(btnBrowserOutput);
            Controls.Add(btnBrowserInput);
            Controls.Add(outputPdfTextBox);
            Controls.Add(inputPdfTextBox);
            Controls.Add(btnConvert);
            Name = "Converter";
            Text = "Converter";
            Load += Converter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBrowserOutput;
        private Button btnBrowserInput;
        private TextBox outputPdfTextBox;
        private TextBox inputPdfTextBox;
        private Button btnConvert;
        private FolderBrowserDialog folderBrowserDialog;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}