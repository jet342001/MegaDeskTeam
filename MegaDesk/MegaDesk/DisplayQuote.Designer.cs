﻿
namespace MegaDesk
{
    partial class DisplayQuote
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
            this.label1 = new System.Windows.Forms.Label();
            this.quoteData = new System.Windows.Forms.Label();
            this.mainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(792, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Quote";
            // 
            // quoteData
            // 
            this.quoteData.Location = new System.Drawing.Point(461, 214);
            this.quoteData.Name = "quoteData";
            this.quoteData.Size = new System.Drawing.Size(881, 466);
            this.quoteData.TabIndex = 1;
            // 
            // mainMenu
            // 
            this.mainMenu.Location = new System.Drawing.Point(1192, 43);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(150, 46);
            this.mainMenu.TabIndex = 2;
            this.mainMenu.Text = "Main Menu";
            this.mainMenu.UseVisualStyleBackColor = true;
            this.mainMenu.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1834, 978);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.quoteData);
            this.Controls.Add(this.label1);
            this.Name = "DisplayQuote";
            this.Text = "Your Quote";
            this.Load += new System.EventHandler(this.DisplayQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label quoteData;
        private System.Windows.Forms.Button mainMenu;
    }
}