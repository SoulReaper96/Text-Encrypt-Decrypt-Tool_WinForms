using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Encryption_Decryption_Tool
{
    public partial class MainTool_DES : Form
    {
        //Use "12345678" as the Key

        private DSACryptoServiceProvider _des;

        public MainTool_DES()
        {
            InitializeComponent();
        }

        private void Encrypt_btn_Click(object sender, EventArgs e)
        {
            string plainText = Encrypt_txtBox.Text;
            string key = Key_txtBox.Text;

            byte[] encrypted = EncryptStringToBytes_DES(plainText, Encoding.UTF8.GetBytes(key), Encoding.UTF8.GetBytes(key));
            Result_rtbBox.Text = Convert.ToBase64String(encrypted);
        }

        private void Decrypt_btn_Click(object sender, EventArgs e)
        {
            byte[] cipherText = Convert.FromBase64String(Decrypt_txtBox.Text);
            string key = Key_txtBox.Text;

            string decrypted = DecryptStringFromBytes_DES(cipherText, Encoding.UTF8.GetBytes(key), Encoding.UTF8.GetBytes(key));
            Result_rtbBox.Text = decrypted;
        }

        static byte[] EncryptStringToBytes_DES(string plainText, byte[] Key, byte[] IV)
        {
            using (DESCryptoServiceProvider desAlg = new DESCryptoServiceProvider())
            {
                desAlg.Key = Key;
                desAlg.IV = IV;

                ICryptoTransform encryptor = desAlg.CreateEncryptor(desAlg.Key, desAlg.IV);

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

        static string DecryptStringFromBytes_DES(byte[] cipherText, byte[] Key, byte[] IV)
        {
            using (DESCryptoServiceProvider desAlg = new DESCryptoServiceProvider())
            {
                desAlg.Key = Key;
                desAlg.IV = IV;

                ICryptoTransform decryptor = desAlg.CreateDecryptor(desAlg.Key, desAlg.IV);

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
