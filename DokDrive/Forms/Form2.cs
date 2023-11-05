using Google.Cloud.Firestore;

namespace DokDrive
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private bool CheckIfUserAlreadyExist()
        {
            string username = textEmail2.Text.Trim();

            var db = FirestoreHelper.Database;
            DocumentReference docRef = db.Collection("Register").Document(username);
            Register data = docRef.GetSnapshotAsync().Result.ConvertTo<Register>();

            if(data != null)
            {
                return true;
            }
            return false;
        }
        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            var db = FirestoreHelper.Database;

            if(CheckIfUserAlreadyExist())
            {
                MessageBox.Show("Usuário já existe");
                return;

            }  
            
            var data = GetWriteData();
            DocumentReference docRef = db.Collection("Rgister").Document(data.Usuario);
            docRef.SetAsync(data);
            MessageBox.Show("Cadastrado com sucesso!");
            
        }
        private Register GetWriteData()
        {
            string username = textEmail2.Text.Trim();
            string password = Security.Encrypt(textSenha2.Text);
            string phone = textTelefone2.Text.Trim();

            return new Register()
            {
                Usuario = username,
                Senha = password,
                Telefone = phone
            };
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
