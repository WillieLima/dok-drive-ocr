using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DokDrive
{
    internal class FirestoreHelper
    {
        static string fireconfig = @"
        {
          ""type"": ""service_account"",
          ""project_id"": ""dokdrive-7a197"",
          ""private_key_id"": ""d84725ed6bc10acddcd5c855bfb0b44f64533619"",
          ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvAIBADANBgkqhkiG9w0BAQEFAASCBKYwggSiAgEAAoIBAQDS5b35P8WZ+PvN\ns9e+MHO+InPjOtWEnvk+sNOG+9cADcwmHM+82KiaxxpCXCPY+Z9pUbKrN8TpQmdQ\nup0xUYf3XFuG7li391/XefEupf2miGt2NxPE/yH+iiGrM4skCHkQPAdEKUasRXi5\nmxP9FbF4zbCtXi96kd2NYQTdVoPzLDSCpXDJdOH4zfj/odcmHpVjtHhrn8Scptkm\nawjUgvmnof//1SKo/z/2z3ke2GUgbHK3pyuv9nuKNxoH81TVtRuTSQ7E5sOaiY6j\nuSbZbO7BWUHXtZnNyVZwZB1Wi9AvcZxRPc+pH/EecT9a3LHuPthb5NwpzmZaE5hQ\nLu95ZKeNAgMBAAECggEAIPBEbkYlSuHOFCfbUYdYQHE5l9sTx5mbtIyiEPJK92Vw\nReCYmnZdSQVBRu2EpMoB+Y1Kwj6c2NCn+b4XuIDzIzFv0yBtR1hRxgHz5xUCS40B\nea5q/kjZyptQ3GAZwng3Tk+N0/m9YcEc9KIxqkTF2egISN+Nu09GYuMtAxPU2nj7\npMxXwAr0FExU9YlNQcGzSxVZWCOpY/tJKLM/Gy6R2CUVJKMxi0yBLZH6QqWNCHFa\nqbJrCNstccrVXZ7draGfeIq/9Jzb3Qp0u5IMlvJCFUisr5vC9AeJe2vhz0xVzdVD\nNwHaHPj+XDCOB7qF7eDyY6uykxA7T3Ic748oXmaceQKBgQDuTCdPzDIXKgm7/+PP\ntkh6bOjObZrLc9ndAm4cMMseG8E6uy7jrd31vIROYZpMFtKPniqXT970LTYWuuf+\nW6A8Ofk4hxdq6JU6/x9k7dY27v/+N0v5XIXDCKHgt+oQulF6wE1/XJ2fJsShypWB\nXuOVaDzAJwJEd1PkSsbR0X7hpQKBgQDikIFhBmWo7ltdAmMKSvdC96E98p1SwWdF\nO9gQXMWYCbtpDj5Pk1eM8OcsZjlCktrK62P2rZTN8xjIA9bglyxvmS7PjGDh6Szz\nG8Y3OBSenDN2M/mkJjIP3tlb/zZIL2BLRtgDWKe6NmCfSD8x5obqrLmd5u2cpqg1\ne6jhzFz5yQKBgHt2g0upzS4JPr/j5YFBvS2I7dm+GdxdarxCPRBoC2TPFn86aiHW\nfFCMWrRNh2by0CdO2FxLKoWyQvrl3bsAd/WcR86M14oxdNf7RKXDQCB4FbP9rGRH\nFpqlB1Hpl+EQ15RUvBJHxvalXG1DC9Dae+l19zvLOjaE6Lc4MuiUtTttAoGATn/J\nBAgGYyCq8S/phuBwiXhpGqCcF9dA48EXXJv4LnR4xa6UsleXxxKU1lJY1pMxUYt7\naDW+UBlBZdPGuKxITiZiDLFTxBJZa6Yc6Hb61fXC8tqRTWmagNsyrmhfs2UO1SYn\npAksnB1JHwcWNkDsUBUmfupLO7KWp2lAG3QGZtkCgYAu9lYZWHEBdhM/GzAFSBq4\nQ8VT5wwKlRsmO5ZWVJ+rpCpJLIKbIxRyTXOTGI35BeYLbmZOmIFMjtsc3cMczOsB\n7KU/vuO5MCxxg3Fmbg5VkdmjjYJiCff7fKlXCYCNPQ4bAQ0uOeXcAgjRg9qYabF+\nqxPJfI3bOzam9dl9CutKYA==\n-----END PRIVATE KEY-----\n"",
          ""client_email"": ""firebase-adminsdk-qyoe2@dokdrive-7a197.iam.gserviceaccount.com"",
          ""client_id"": ""118052744113219719126"",
          ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
          ""token_uri"": ""https://oauth2.googleapis.com/token"",
          ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
          ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-qyoe2%40dokdrive-7a197.iam.gserviceaccount.com"",
          ""universe_domain"": ""googleapis.com""
        }
        ";
        static string filepath = "";
        public static FirestoreDb? Database { get; private set; }

        public static void SetEnvironmentVariable()
        {
            filepath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetRandomFileName())) + ".json";
            File.WriteAllText(filepath, fireconfig);
            File.SetAttributes(filepath, FileAttributes.Hidden);
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filepath);
            Database = FirestoreDb.Create("dokdrive-7a197");
            File.Delete(filepath);
        }
    }
}
