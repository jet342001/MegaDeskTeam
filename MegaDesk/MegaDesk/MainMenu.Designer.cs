
namespace MegaDesk
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.viewQuotesButton = new System.Windows.Forms.Button();
            this.searchQuotesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.addNewQuoteButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // viewQuotesButton
            // 
            this.viewQuotesButton.Location = new System.Drawing.Point(194, 340);
            this.viewQuotesButton.Name = "viewQuotesButton";
            this.viewQuotesButton.Size = new System.Drawing.Size(304, 122);
            this.viewQuotesButton.TabIndex = 0;
            this.viewQuotesButton.Text = "View Quotes";
            this.viewQuotesButton.UseVisualStyleBackColor = true;
            this.viewQuotesButton.Click += new System.EventHandler(this.viewQuotesButton_Click);
            // 
            // searchQuotesButton
            // 
            this.searchQuotesButton.Location = new System.Drawing.Point(194, 481);
            this.searchQuotesButton.Name = "searchQuotesButton";
            this.searchQuotesButton.Size = new System.Drawing.Size(304, 122);
            this.searchQuotesButton.TabIndex = 1;
            this.searchQuotesButton.Text = "Search Quotes";
            this.searchQuotesButton.UseVisualStyleBackColor = true;
            this.searchQuotesButton.Click += new System.EventHandler(this.searchQuotesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(194, 623);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(304, 122);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addNewQuoteButton
            // 
            this.addNewQuoteButton.Location = new System.Drawing.Point(194, 197);
            this.addNewQuoteButton.Name = "addNewQuoteButton";
            this.addNewQuoteButton.Size = new System.Drawing.Size(304, 122);
            this.addNewQuoteButton.TabIndex = 3;
            this.addNewQuoteButton.Text = "Add New Quote";
            this.addNewQuoteButton.UseVisualStyleBackColor = true;
            this.addNewQuoteButton.Click += new System.EventHandler(this.addNewQuoteButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(904, 281);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(736, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1908, 936);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addNewQuoteButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.searchQuotesButton);
            this.Controls.Add(this.viewQuotesButton);
            this.Name = "MainMenu";
            this.Text = "MegaDesk";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewQuotesButton;
        private System.Windows.Forms.Button searchQuotesButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button addNewQuoteButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

