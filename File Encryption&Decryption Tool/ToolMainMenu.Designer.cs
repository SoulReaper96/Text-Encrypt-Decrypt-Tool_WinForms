﻿namespace File_Encryption_Decryption_Tool
{
    partial class ToolMainMenu
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
            RSA_btn = new Button();
            AES_btn = new Button();
            DES_btn = new Button();
            TripleDES_btn = new Button();
            label1 = new Label();
            About_lbl = new Label();
            Close_pb = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Close_pb).BeginInit();
            SuspendLayout();
            // 
            // RSA_btn
            // 
            RSA_btn.BackColor = Color.Transparent;
            RSA_btn.FlatAppearance.BorderColor = Color.LightYellow;
            RSA_btn.FlatAppearance.BorderSize = 3;
            RSA_btn.FlatStyle = FlatStyle.Flat;
            RSA_btn.Font = new Font("Arial", 12F, FontStyle.Bold);
            RSA_btn.ForeColor = Color.Gold;
            RSA_btn.Location = new Point(74, 76);
            RSA_btn.Name = "RSA_btn";
            RSA_btn.Size = new Size(70, 70);
            RSA_btn.TabIndex = 2;
            RSA_btn.Text = "RSA";
            RSA_btn.UseVisualStyleBackColor = false;
            RSA_btn.Click += RSA_btn_Click;
            // 
            // AES_btn
            // 
            AES_btn.BackColor = Color.Transparent;
            AES_btn.FlatAppearance.BorderColor = Color.LightYellow;
            AES_btn.FlatAppearance.BorderSize = 3;
            AES_btn.FlatStyle = FlatStyle.Flat;
            AES_btn.Font = new Font("Arial", 12F, FontStyle.Bold);
            AES_btn.ForeColor = Color.Gold;
            AES_btn.Location = new Point(163, 76);
            AES_btn.Name = "AES_btn";
            AES_btn.Size = new Size(70, 70);
            AES_btn.TabIndex = 3;
            AES_btn.Text = "AES";
            AES_btn.UseVisualStyleBackColor = false;
            AES_btn.Click += AES_btn_Click;
            // 
            // DES_btn
            // 
            DES_btn.BackColor = Color.Transparent;
            DES_btn.FlatAppearance.BorderColor = Color.LightYellow;
            DES_btn.FlatAppearance.BorderSize = 3;
            DES_btn.FlatStyle = FlatStyle.Flat;
            DES_btn.Font = new Font("Arial", 12F, FontStyle.Bold);
            DES_btn.ForeColor = Color.Gold;
            DES_btn.Location = new Point(74, 161);
            DES_btn.Name = "DES_btn";
            DES_btn.Size = new Size(70, 70);
            DES_btn.TabIndex = 4;
            DES_btn.Text = "DES";
            DES_btn.UseVisualStyleBackColor = false;
            DES_btn.Click += DES_btn_Click;
            // 
            // TripleDES_btn
            // 
            TripleDES_btn.BackColor = Color.Transparent;
            TripleDES_btn.FlatAppearance.BorderColor = Color.LightYellow;
            TripleDES_btn.FlatAppearance.BorderSize = 3;
            TripleDES_btn.FlatStyle = FlatStyle.Flat;
            TripleDES_btn.Font = new Font("Arial", 10F, FontStyle.Bold);
            TripleDES_btn.ForeColor = Color.Gold;
            TripleDES_btn.Location = new Point(163, 162);
            TripleDES_btn.Name = "TripleDES_btn";
            TripleDES_btn.Size = new Size(70, 70);
            TripleDES_btn.TabIndex = 5;
            TripleDES_btn.Text = "TRIPLE DES";
            TripleDES_btn.UseVisualStyleBackColor = false;
            TripleDES_btn.Click += TripleDES_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 14F, FontStyle.Underline);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(0, 37);
            label1.Name = "label1";
            label1.Size = new Size(316, 22);
            label1.TabIndex = 0;
            label1.Text = "PLEASE SELECT A TOOL BELOW";
            // 
            // About_lbl
            // 
            About_lbl.AutoSize = true;
            About_lbl.BackColor = Color.Transparent;
            About_lbl.Font = new Font("Arial", 10F, FontStyle.Underline);
            About_lbl.ForeColor = Color.Gold;
            About_lbl.Location = new Point(251, 246);
            About_lbl.Name = "About_lbl";
            About_lbl.Size = new Size(44, 16);
            About_lbl.TabIndex = 6;
            About_lbl.Text = "About";
            About_lbl.Click += About_lbl_Click;
            // 
            // Close_pb
            // 
            Close_pb.BackColor = Color.Transparent;
            Close_pb.BackgroundImage = Properties.Resources.close_circle_line__1_;
            Close_pb.BackgroundImageLayout = ImageLayout.Stretch;
            Close_pb.Location = new Point(279, 9);
            Close_pb.Name = "Close_pb";
            Close_pb.Size = new Size(25, 25);
            Close_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            Close_pb.TabIndex = 45;
            Close_pb.TabStop = false;
            Close_pb.Click += Close_pb_Click;
            // 
            // ToolMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.istockphoto_913071832_612x612;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(316, 282);
            Controls.Add(Close_pb);
            Controls.Add(About_lbl);
            Controls.Add(TripleDES_btn);
            Controls.Add(DES_btn);
            Controls.Add(AES_btn);
            Controls.Add(RSA_btn);
            Controls.Add(label1);
            Font = new Font("Arial", 9F);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ToolMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ToolMainMenu";
            ((System.ComponentModel.ISupportInitialize)Close_pb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button RSA_btn;
        private Button AES_btn;
        private Button DES_btn;
        private Button TripleDES_btn;
        private Label label1;
        private Label About_lbl;
        private PictureBox Close_pb;
    }
}