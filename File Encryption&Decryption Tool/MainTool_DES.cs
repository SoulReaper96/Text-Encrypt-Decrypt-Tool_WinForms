using System.Security.Cryptography;

namespace File_Encryption_Decryption_Tool
{
    public partial class MainTool_DES : Form
    {
        //Use "12345678" as the Key
        private DSACryptoServiceProvider? _des;
        private byte[]? desKey;
        private byte[]? desIV;

        public MainTool_DES()
        {
            InitializeComponent();
        }

        private void Encrypt_btn_Click(object sender, EventArgs e)
        {
            string plainText = Encrypt_txtBox.Text;

            if (desKey == null || desIV == null)
            {
                MessageBox.Show("Please generate the key and IV first.");
                return;
            }

            byte[] encrypted = EncryptStringToBytes_DES(plainText, desKey, desIV);
            Result_rtbBox.Text = Convert.ToBase64String(encrypted);
        }

        private void Decrypt_btn_Click(object sender, EventArgs e)
        {
            byte[] cipherText = Convert.FromBase64String(Decrypt_txtBox.Text);

            if (desKey == null || desIV == null)
            {
                MessageBox.Show("Please generate the key and IV first.");
                return;
            }

            string decrypted = DecryptStringFromBytes_DES(cipherText, desKey, desIV);
            Result_rtbBox.Text = decrypted;
        }

        private void GenerateKey_btn_Click(object sender, EventArgs e)
        {
            GenerateDESKey();
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

        private void GenerateDESKey()
        {
            using (DESCryptoServiceProvider desAlg = new DESCryptoServiceProvider())
            {
                desAlg.GenerateKey();
                desAlg.GenerateIV();

                desKey = desAlg.Key;
                desIV = desAlg.IV;

                Key_txtBox.Text = Convert.ToBase64String(desKey);
                IV_txtBox.Text = Convert.ToBase64String(desIV);
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
