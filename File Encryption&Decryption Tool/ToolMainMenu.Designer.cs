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
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 17F, FontStyle.Underline);
            label1.Location = new Point(13, 9);
            label1.Name = "label1";
            label1.Size = new Size(359, 26);
            label1.TabIndex = 0;
            label1.Text = "WELCOME TO THE MAIN MENU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15F);
            label2.Location = new Point(31, 39);
            label2.Name = "label2";
            label2.Size = new Size(323, 23);
            label2.TabIndex = 1;
            label2.Text = "PLEASE SELECT A TOOL BELOW";
            // 
            // ToolMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(384, 361);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 9F);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "ToolMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ToolMainMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
    }
}