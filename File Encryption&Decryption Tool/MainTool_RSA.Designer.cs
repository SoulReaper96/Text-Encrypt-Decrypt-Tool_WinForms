﻿namespace File_Encryption_Decryption_Tool
{
    partial class MainTool_RSA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Result_rtbBox = new RichTextBox();
            Result_lbl = new Label();
            DecryptText_lbl = new Label();
            Decrypt_txtBox = new TextBox();
            Decrypt_btn = new Button();
            EncryptText_lbl = new Label();
            Encrypt_btn = new Button();
            Encrypt_txtBox = new TextBox();
            SuspendLayout();
            // 
            // Result_rtbBox
            // 
            Result_rtbBox.Font = new Font("Arial", 11F);
            Result_rtbBox.Location = new Point(98, 78);
            Result_rtbBox.Name = "Result_rtbBox";
            Result_rtbBox.Size = new Size(283, 111);
            Result_rtbBox.TabIndex = 42;
            Result_rtbBox.Text = "";
            // 
            // Result_lbl
            // 
            Result_lbl.AutoSize = true;
            Result_lbl.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Result_lbl.Location = new Point(34, 80);
            Result_lbl.Name = "Result_lbl";
            Result_lbl.Size = new Size(58, 19);
            Result_lbl.TabIndex = 40;
            Result_lbl.Text = "Result";
            // 
            // DecryptText_lbl
            // 
            DecryptText_lbl.AutoSize = true;
            DecryptText_lbl.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            DecryptText_lbl.Location = new Point(11, 37);
            DecryptText_lbl.Name = "DecryptText_lbl";
            DecryptText_lbl.Size = new Size(106, 16);
            DecryptText_lbl.TabIndex = 39;
            DecryptText_lbl.Text = "Text to Decrypt:";
            // 
            // Decrypt_txtBox
            // 
            Decrypt_txtBox.Font = new Font("Arial", 9F);
            Decrypt_txtBox.Location = new Point(123, 35);
            Decrypt_txtBox.Name = "Decrypt_txtBox";
            Decrypt_txtBox.Size = new Size(246, 21);
            Decrypt_txtBox.TabIndex = 38;
            // 
            // Decrypt_btn
            // 
            Decrypt_btn.Font = new Font("Arial", 9F);
            Decrypt_btn.Location = new Point(375, 34);
            Decrypt_btn.Name = "Decrypt_btn";
            Decrypt_btn.Size = new Size(75, 23);
            Decrypt_btn.TabIndex = 37;
            Decrypt_btn.Text = "DECRYPT";
            Decrypt_btn.UseVisualStyleBackColor = true;
            Decrypt_btn.Click += Decrypt_btn_Click;
            // 
            // EncryptText_lbl
            // 
            EncryptText_lbl.AutoSize = true;
            EncryptText_lbl.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            EncryptText_lbl.Location = new Point(12, 10);
            EncryptText_lbl.Name = "EncryptText_lbl";
            EncryptText_lbl.Size = new Size(105, 16);
            EncryptText_lbl.TabIndex = 36;
            EncryptText_lbl.Text = "Text to Encrypt:";
            // 
            // Encrypt_btn
            // 
            Encrypt_btn.Font = new Font("Arial", 9F);
            Encrypt_btn.Location = new Point(375, 7);
            Encrypt_btn.Name = "Encrypt_btn";
            Encrypt_btn.Size = new Size(75, 23);
            Encrypt_btn.TabIndex = 35;
            Encrypt_btn.Text = "ENCRYPT";
            Encrypt_btn.UseVisualStyleBackColor = true;
            Encrypt_btn.Click += Encrypt_btn_Click;
            // 
            // Encrypt_txtBox
            // 
            Encrypt_txtBox.Font = new Font("Arial", 9F);
            Encrypt_txtBox.Location = new Point(123, 8);
            Encrypt_txtBox.Name = "Encrypt_txtBox";
            Encrypt_txtBox.Size = new Size(246, 21);
            Encrypt_txtBox.TabIndex = 34;
            // 
            // MainTool_RSA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(460, 229);
            Controls.Add(Result_rtbBox);
            Controls.Add(Result_lbl);
            Controls.Add(DecryptText_lbl);
            Controls.Add(Decrypt_txtBox);
            Controls.Add(Decrypt_btn);
            Controls.Add(EncryptText_lbl);
            Controls.Add(Encrypt_btn);
            Controls.Add(Encrypt_txtBox);
            Font = new Font("Arial", 9F);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "MainTool_RSA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainTool_RSA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox Result_rtbBox;
        private Label Result_lbl;
        private Label DecryptText_lbl;
        private TextBox Decrypt_txtBox;
        private Button Decrypt_btn;
        private Label EncryptText_lbl;
        private Button Encrypt_btn;
        private TextBox Encrypt_txtBox;
    }
}