using System.Security.Cryptography;

namespace File_Encryption_Decryption_Tool
{
    public partial class MainTool_TripleDES : Form
    {
        //Use "1234567890That's MyKun-" as the Key
        private byte[]? tripdesKey;
        private byte[]? tripdesIV;

        public MainTool_TripleDES()
        {
            InitializeComponent();
        }

        private void Encrypt_btn_Click(object sender, EventArgs e)
        {
            string plainText = Encrypt_txtBox.Text;

            if (tripdesKey == null || tripdesIV == null)
            {
                MessageBox.Show("Please generate the key and IV first.");
                return;
            }

            byte[] encrypted = EncryptStringToBytes_TripleDES(plainText, tripdesKey, tripdesIV);
            Result_rtbBox.Text = Convert.ToBase64String(encrypted);
        }

        private void Decrypt_btn_Click(object sender, EventArgs e)
        {
            byte[] cipherText = Convert.FromBase64String(Decrypt_txtBox.Text);

            if (tripdesKey == null || tripdesIV == null)
            {
                MessageBox.Show("Please generate the key and IV first.");
                return;
            }

            string decrypted = DecryptStringFromBytes_TripleDES(cipherText, tripdesKey, tripdesIV);
            Result_rtbBox.Text = decrypted;
        }

        private void GenerateKey_btn_Click(object sender, EventArgs e)
        {
            GenerateTripleDESKey();
        }

        static byte[] EncryptStringToBytes_TripleDES(string plainText, byte[] Key, byte[] IV)
        {
            using (TripleDESCryptoServiceProvider tripleDesAlg = new TripleDESCryptoServiceProvider())
            {
                tripleDesAlg.Key = Key;
                tripleDesAlg.IV = IV;

                ICryptoTransform encryptor = tripleDesAlg.CreateEncryptor(tripleDesAlg.Key, tripleDesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        return msEncrypt.ToArray();
                    }
                }
            }
        }

        static string DecryptStringFromBytes_TripleDES(byte[] cipherText, byte[] Key, byte[] IV)
        {
            using (TripleDESCryptoServiceProvider tripleDesAlg = new TripleDESCryptoServiceProvider())
            {
                tripleDesAlg.Key = Key;
                tripleDesAlg.IV = IV;

                ICryptoTransform decryptor = tripleDesAlg.CreateDecryptor(tripleDesAlg.Key, tripleDesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }

        private void GenerateTripleDESKey()
        {
            using (TripleDESCryptoServiceProvider tripleDesAlg = new TripleDESCryptoServiceProvider())
            {
                tripleDesAlg.GenerateKey();
                tripleDesAlg.GenerateIV();

                tripdesKey = tripleDesAlg.Key;
                tripdesIV = tripleDesAlg.IV;

                Key_txtBox.Text = Convert.ToBase64String(tripdesKey);
                IV_txtBox.Text = Convert.ToBase64String(tripdesIV);
            }
        }

        private void Return_pb_Click(object sender, EventArgs e)
        {
            ToolMainMenu mainMenu = new ToolMainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void Close_pb_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
