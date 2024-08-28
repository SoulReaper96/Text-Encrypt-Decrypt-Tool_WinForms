using System.Security.Cryptography;
using System.Text;

namespace File_Encryption_Decryption_Tool
{
    public partial class TextEncryptDecryptTool : Form
    {
        private byte[]? aesKey;
        private byte[]? aesIV;

        public TextEncryptDecryptTool()
        {
            InitializeComponent();
        }

        private void Encrypt_btn_Click(object sender, EventArgs e)
        {
            string plainText = Encrypt_txtBox.Text;

            if (aesKey == null || aesIV == null)
            {
                MessageBox.Show("Please generate the key and IV first.");
                return;
            }

            byte[] encrypted = EncryptStringToBytes_Aes(plainText, aesKey, aesIV);
            Result_rtbBox.Text = Convert.ToBase64String(encrypted);
        }

        private void Decrypt_btn_Click(object sender, EventArgs e)
        {
            byte[] cipherText = Convert.FromBase64String(Decrypt_txtBox.Text);

            if (aesKey == null || aesIV == null)
            {
                MessageBox.Show("Please generate the key and IV first.");
                return;
            }

            string decrypted = DecryptStringFromBytes_Aes(cipherText, aesKey, aesIV);
            Result_rtbBox.Text = decrypted;
        }

        private void GenerateKey_btn_Click(object sender, EventArgs e)
        {
            GenerateAESKey();
        }

        static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

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

        static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

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

        private void GenerateAESKey()
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.GenerateKey();
                aesAlg.GenerateIV();

                aesKey = aesAlg.Key;
                aesIV = aesAlg.IV;

                Key_txtBox.Text = Convert.ToBase64String(aesKey);
                IV_txtBox.Text = Convert.ToBase64String(aesIV);
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
