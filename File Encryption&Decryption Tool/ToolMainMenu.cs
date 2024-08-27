using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Encryption_Decryption_Tool
{
    public partial class ToolMainMenu : Form
    {
        public ToolMainMenu()
        {
            InitializeComponent();
        }

        private void RSA_btn_Click(object sender, EventArgs e)
        {
            MainTool_RSA tool_RSA = new MainTool_RSA();
            tool_RSA.Show();
            this.Hide();
        }

        private void AES_btn_Click(object sender, EventArgs e)
        {
            TextEncryptDecryptTool tool_AES = new TextEncryptDecryptTool();
            tool_AES.Show();
            this.Hide();
        }

        private void DES_btn_Click(object sender, EventArgs e)
        {
            MainTool_DES tool_DES = new MainTool_DES();
            tool_DES.Show();
            this.Hide();
        }

        private void TripleDES_btn_Click(object sender, EventArgs e)
        {
            MainTool_TripleDES tool_TripleDES = new MainTool_TripleDES();
            tool_TripleDES.Show();
            this.Hide();
        }
    }
}
