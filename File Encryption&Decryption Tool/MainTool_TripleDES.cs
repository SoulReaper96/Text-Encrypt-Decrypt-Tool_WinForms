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
    public partial class MainTool_TripleDES : Form
    {
        //Use "1234567890That's MyKun-" as the Key

        public MainTool_TripleDES()
        {
            InitializeComponent();
        }

        private void Encrypt_btn_Click(object sender, EventArgs e)
        {
            string plainText = Encrypt_txtBox.Text;
            string key = Key_txtBox.Text;

            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            byte[] ivBytes = new byte[8]; // Ensure IV is 8 bytes long
            Array.Copy(keyBytes, ivBytes, Math.Min(keyBytes.Length, ivBytes.Length));

            byte[] encrypted = EncryptStringToBytes_TripleDES(plainText, keyBytes, ivBytes);
            Result_rtbBox.Text = Convert.ToBase64String(encrypted);
        }

        private void Decrypt_btn_Click(object sender, EventArgs e)
        {
            byte[] cipherText = Convert.FromBase64String(Decrypt_txtBox.Text);
            string key = Key_txtBox.Text;

            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            byte[] ivBytes = new byte[8]; // Ensure IV is 8 bytes long
            Array.Copy(keyBytes, ivBytes, Math.Min(keyBytes.Length, ivBytes.Length));

            string decrypted = DecryptStringFromBytes_TripleDES(cipherText, keyBytes, ivBytes);
            Result_rtbBox.Text = decrypted;
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
    }
}
