using System.Security.Cryptography;
using System.Text;

namespace File_Encryption_Decryption_Tool
{
    public partial class TextEncryptDecryptTool : Form
    {
        //Use "Thats my Kung Fu" as the key

        public TextEncryptDecryptTool()
        {
            InitializeComponent();
        }

        private void Encrypt_btn_Click(object sender, EventArgs e)
        {
            string plainText = Encrypt_txtBox.Text;
            string key = Key_txtBox.Text;

            byte[] encrypted = EncryptStringToBytes_Aes(plainText, Encoding.UTF8.GetBytes(key), Encoding.UTF8.GetBytes(key));
            Result_rtbBox.Text = Convert.ToBase64String(encrypted);
        }

        private void Decrypt_btn_Click(object sender, EventArgs e)
        {
            byte[] cipherText = Convert.FromBase64String(Decrypt_txtBox.Text);
            string key = Key_txtBox.Text;

            string decrypted = DecryptStringFromBytes_Aes(cipherText, Encoding.UTF8.GetBytes(key), Encoding.UTF8.GetBytes(key));
            Result_rtbBox.Text = decrypted;
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
        
    }
}
