namespace File_Encryption_Decryption_Tool
{
    partial class MainTool_DES
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
            Key_lbl = new Label();
            Result_rtbBox = new RichTextBox();
            Key_txtBox = new TextBox();
            Result_lbl = new Label();
            DecryptText_lbl = new Label();
            Decrypt_txtBox = new TextBox();
            Decrypt_btn = new Button();
            EncryptText_lbl = new Label();
            Encrypt_btn = new Button();
            Encrypt_txtBox = new TextBox();
            Return_pb = new PictureBox();
            Close_pb = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Return_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Close_pb).BeginInit();
            SuspendLayout();
            // 
            // Key_lbl
            // 
            Key_lbl.AutoSize = true;
            Key_lbl.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            Key_lbl.Location = new Point(12, 47);
            Key_lbl.Name = "Key_lbl";
            Key_lbl.Size = new Size(101, 16);
            Key_lbl.TabIndex = 23;
            Key_lbl.Text = "Algorithm Key:";
            // 
            // Result_rtbBox
            // 
            Result_rtbBox.Font = new Font("Arial", 11F);
            Result_rtbBox.Location = new Point(76, 143);
            Result_rtbBox.Name = "Result_rtbBox";
            Result_rtbBox.Size = new Size(283, 111);
            Result_rtbBox.TabIndex = 22;
            Result_rtbBox.Text = "";
            // 
            // Key_txtBox
            // 
            Key_txtBox.Font = new Font("Arial", 9F);
            Key_txtBox.Location = new Point(123, 45);
            Key_txtBox.Name = "Key_txtBox";
            Key_txtBox.Size = new Size(246, 21);
            Key_txtBox.TabIndex = 21;
            // 
            // Result_lbl
            // 
            Result_lbl.AutoSize = true;
            Result_lbl.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Result_lbl.Location = new Point(12, 145);
            Result_lbl.Name = "Result_lbl";
            Result_lbl.Size = new Size(58, 19);
            Result_lbl.TabIndex = 20;
            Result_lbl.Text = "Result";
            // 
            // DecryptText_lbl
            // 
            DecryptText_lbl.AutoSize = true;
            DecryptText_lbl.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            DecryptText_lbl.Location = new Point(11, 104);
            DecryptText_lbl.Name = "DecryptText_lbl";
            DecryptText_lbl.Size = new Size(106, 16);
            DecryptText_lbl.TabIndex = 19;
            DecryptText_lbl.Text = "Text to Decrypt:";
            // 
            // Decrypt_txtBox
            // 
            Decrypt_txtBox.Font = new Font("Arial", 9F);
            Decrypt_txtBox.Location = new Point(123, 102);
            Decrypt_txtBox.Name = "Decrypt_txtBox";
            Decrypt_txtBox.Size = new Size(246, 21);
            Decrypt_txtBox.TabIndex = 18;
            // 
            // Decrypt_btn
            // 
            Decrypt_btn.Font = new Font("Arial", 9F);
            Decrypt_btn.Location = new Point(375, 101);
            Decrypt_btn.Name = "Decrypt_btn";
            Decrypt_btn.Size = new Size(75, 23);
            Decrypt_btn.TabIndex = 17;
            Decrypt_btn.Text = "DECRYPT";
            Decrypt_btn.UseVisualStyleBackColor = true;
            Decrypt_btn.Click += Decrypt_btn_Click;
            // 
            // EncryptText_lbl
            // 
            EncryptText_lbl.AutoSize = true;
            EncryptText_lbl.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            EncryptText_lbl.Location = new Point(12, 77);
            EncryptText_lbl.Name = "EncryptText_lbl";
            EncryptText_lbl.Size = new Size(105, 16);
            EncryptText_lbl.TabIndex = 16;
            EncryptText_lbl.Text = "Text to Encrypt:";
            // 
            // Encrypt_btn
            // 
            Encrypt_btn.Font = new Font("Arial", 9F);
            Encrypt_btn.Location = new Point(375, 74);
            Encrypt_btn.Name = "Encrypt_btn";
            Encrypt_btn.Size = new Size(75, 23);
            Encrypt_btn.TabIndex = 15;
            Encrypt_btn.Text = "ENCRYPT";
            Encrypt_btn.UseVisualStyleBackColor = true;
            Encrypt_btn.Click += Encrypt_btn_Click;
            // 
            // Encrypt_txtBox
            // 
            Encrypt_txtBox.Font = new Font("Arial", 9F);
            Encrypt_txtBox.Location = new Point(123, 75);
            Encrypt_txtBox.Name = "Encrypt_txtBox";
            Encrypt_txtBox.Size = new Size(246, 21);
            Encrypt_txtBox.TabIndex = 14;
            // 
            // Return_pb
            // 
            Return_pb.BackgroundImage = Properties.Resources.arrow_go_back_line;
            Return_pb.BackgroundImageLayout = ImageLayout.Stretch;
            Return_pb.Location = new Point(10, 7);
            Return_pb.Name = "Return_pb";
            Return_pb.Size = new Size(25, 25);
            Return_pb.TabIndex = 37;
            Return_pb.TabStop = false;
            // 
            // Close_pb
            // 
            Close_pb.BackgroundImage = Properties.Resources.close_circle_line__1_;
            Close_pb.BackgroundImageLayout = ImageLayout.Stretch;
            Close_pb.Location = new Point(433, 7);
            Close_pb.Name = "Close_pb";
            Close_pb.Size = new Size(25, 25);
            Close_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            Close_pb.TabIndex = 44;
            Close_pb.TabStop = false;
            // 
            // MainTool_DES
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(470, 280);
            Controls.Add(Close_pb);
            Controls.Add(Return_pb);
            Controls.Add(Key_lbl);
            Controls.Add(Result_rtbBox);
            Controls.Add(Key_txtBox);
            Controls.Add(Result_lbl);
            Controls.Add(DecryptText_lbl);
            Controls.Add(Decrypt_txtBox);
            Controls.Add(Decrypt_btn);
            Controls.Add(EncryptText_lbl);
            Controls.Add(Encrypt_btn);
            Controls.Add(Encrypt_txtBox);
            Font = new Font("Arial", 9F);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainTool_DES";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainTool_DES";
            ((System.ComponentModel.ISupportInitialize)Return_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)Close_pb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Key_lbl;
        private RichTextBox Result_rtbBox;
        private TextBox Key_txtBox;
        private Label Result_lbl;
        private Label DecryptText_lbl;
        private TextBox Decrypt_txtBox;
        private Button Decrypt_btn;
        private Label EncryptText_lbl;
        private Button Encrypt_btn;
        private TextBox Encrypt_txtBox;
        private PictureBox Return_pb;
        private PictureBox Close_pb;
    }
}