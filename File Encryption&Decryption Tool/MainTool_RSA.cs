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
    public partial class MainTool_RSA : Form
    {
        //No key required

        private RSACryptoServiceProvider rsa;

        public MainTool_RSA()
        {
            InitializeComponent();
            InitializeRSA();
        }

        private void InitializeRSA()
        {
            rsa = new RSACryptoServiceProvider(2048); // 2048-bit key size
        }

        private void Encrypt_btn_Click(object sender, EventArgs e)
        {
            string plainText = Encrypt_txtBox.Text;
            string encryptedText = EncryptWithRSA(plainText);
            Result_rtbBox.Text = encryptedText;
        }

        private void Decrypt_btn_Click(object sender, EventArgs e)
        {
            string encryptedText = Decrypt_txtBox.Text;
            string decryptedText = DecryptWithRSA(encryptedText);
            Result_rtbBox.Text = decryptedText;
        }

        private string EncryptWithRSA(string plainText)
        {
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] encryptedBytes = rsa.Encrypt(plainBytes, false); // false for PKCS#1 v1.5 padding
            return Convert.ToBase64String(encryptedBytes);
        }

        private string DecryptWithRSA(string encryptedText)
        {
            byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
            byte[] decryptedBytes = rsa.Decrypt(encryptedBytes, false); // false for PKCS#1 v1.5 padding
            return Encoding.UTF8.GetString(decryptedBytes);
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
