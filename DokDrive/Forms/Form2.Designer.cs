namespace DokDrive
{
    partial class Form2
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
            buttonSignUp = new Button();
            label3 = new Label();
            label2 = new Label();
            textSenha2 = new TextBox();
            textEmail2 = new TextBox();
            label1 = new Label();
            label4 = new Label();
            textTelefone2 = new TextBox();
            SuspendLayout();
            // 
            // buttonSignUp
            // 
            buttonSignUp.Location = new Point(351, 343);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(122, 30);
            buttonSignUp.TabIndex = 13;
            buttonSignUp.Text = "Inscreva-se";
            buttonSignUp.UseVisualStyleBackColor = true;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(219, 275);
            label3.Name = "label3";
            label3.Size = new Size(53, 17);
            label3.TabIndex = 11;
            label3.Text = "Senha: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(219, 170);
            label2.Name = "label2";
            label2.Size = new Size(50, 17);
            label2.TabIndex = 10;
            label2.Text = "Email: ";
            // 
            // textSenha2
            // 
            textSenha2.Location = new Point(275, 272);
            textSenha2.Name = "textSenha2";
            textSenha2.PlaceholderText = "  ********";
            textSenha2.Size = new Size(307, 23);
            textSenha2.TabIndex = 9;
            textSenha2.UseSystemPasswordChar = true;
            // 
            // textEmail2
            // 
            textEmail2.Location = new Point(275, 169);
            textEmail2.Name = "textEmail2";
            textEmail2.PlaceholderText = "  Insira seu email";
            textEmail2.Size = new Size(307, 23);
            textEmail2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 50.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(304, 58);
            label1.Name = "label1";
            label1.Size = new Size(252, 80);
            label1.TabIndex = 7;
            label1.Text = "Demo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(200, 208);
            label4.Name = "label4";
            label4.Size = new Size(69, 17);
            label4.TabIndex = 15;
            label4.Text = "Telefone: ";
            // 
            // textTelefone2
            // 
            textTelefone2.Location = new Point(275, 207);
            textTelefone2.Name = "textTelefone2";
            textTelefone2.PlaceholderText = "  Insira seu telefone";
            textTelefone2.Size = new Size(307, 23);
            textTelefone2.TabIndex = 14;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(textTelefone2);
            Controls.Add(buttonSignUp);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textSenha2);
            Controls.Add(textEmail2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSignUp;
        private Label label3;
        private Label label2;
        private TextBox textSenha2;
        private TextBox textEmail2;
        private Label label1;
        private Label label4;
        private TextBox textTelefone2;
    }
}