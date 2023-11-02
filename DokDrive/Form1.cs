using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Google.Cloud.Firestore;

namespace DokDrive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonSignUpPage_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textEmail.Text.Trim();
            string password = textSenha.Text;

            var db = FirestoreHelper.Database;
            DocumentReference docRef = db.Collection("Rgister").Document(username);
            Register data = docRef.GetSnapshotAsync().Result.ConvertTo<Register>();

            if (data != null )
            {
                if(password == Security.Decrypt(data.Senha))
                {
                    MessageBox.Show("Logado com sucesso!");
                    Home hm = new Home();
                    hm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Falhou!");
                }
            }
            else
            {
                MessageBox.Show("Falhou!");
            }            
        }        
    }
}