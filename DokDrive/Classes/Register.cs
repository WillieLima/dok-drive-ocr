using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DokDrive
{
    [FirestoreData]
    public class Register
    {
        [FirestoreProperty]
        public string Usuario { get; set; }
        [FirestoreProperty]
        public string Senha { get; set; }
        [FirestoreProperty]
        public string Telefone { get; set; }  
    }
}
