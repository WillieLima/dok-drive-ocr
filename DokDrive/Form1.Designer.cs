namespace DokDrive
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textEmail = new TextBox();
            textSenha = new TextBox();
            label2 = new Label();
            label3 = new Label();
            buttonLogin = new Button();
            buttonSignUpPage = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 50.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(272, 27);
            label1.Name = "label1";
            label1.Size = new Size(252, 80);
            label1.TabIndex = 0;
            label1.Text = "Demo";
            label1.Click += label1_Click;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(243, 138);
            textEmail.Name = "textEmail";
            textEmail.PlaceholderText = "  Insira seu email";
            textEmail.Size = new Size(307, 23);
            textEmail.TabIndex = 1;
            // 
            // textSenha
            // 
            textSenha.Location = new Point(243, 214);
            textSenha.Name = "textSenha";
            textSenha.PlaceholderText = "  ********";
            textSenha.Size = new Size(307, 23);
            textSenha.TabIndex = 2;
            textSenha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(187, 141);
            label2.Name = "label2";
            label2.Size = new Size(50, 17);
            label2.TabIndex = 3;
            label2.Text = "Email: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(187, 217);
            label3.Name = "label3";
            label3.Size = new Size(53, 17);
            label3.TabIndex = 4;
            label3.Text = "Senha: ";
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(327, 274);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(122, 30);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonSignUpPage
            // 
            buttonSignUpPage.Location = new Point(327, 331);
            buttonSignUpPage.Name = "buttonSignUpPage";
            buttonSignUpPage.Size = new Size(122, 30);
            buttonSignUpPage.TabIndex = 6;
            buttonSignUpPage.Text = "Inscreva-se";
            buttonSignUpPage.UseVisualStyleBackColor = true;
            buttonSignUpPage.Click += buttonSignUpPage_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSignUpPage);
            Controls.Add(buttonLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textSenha);
            Controls.Add(textEmail);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textEmail;
        private TextBox textSenha;
        private Label label2;
        private Label label3;
        private Button buttonLogin;
        private Button buttonSignUpPage;
    }
}