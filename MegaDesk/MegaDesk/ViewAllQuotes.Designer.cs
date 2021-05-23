
namespace MegaDesk
{
    partial class ViewAllQuotes
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
            this.allQuotesLabel = new System.Windows.Forms.Label();
            this.mainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(682, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "View All Quotes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // allQuotesLabel
            // 
            this.allQuotesLabel.Location = new System.Drawing.Point(380, 149);
            this.allQuotesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.allQuotesLabel.Name = "allQuotesLabel";
            this.allQuotesLabel.Size = new System.Drawing.Size(769, 565);
            this.allQuotesLabel.TabIndex = 3;
            // 
            // mainMenu
            // 
            this.mainMenu.Location = new System.Drawing.Point(975, 30);
            this.mainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(115, 36);
            this.mainMenu.TabIndex = 4;
            this.mainMenu.Text = "Main Menu";
            this.mainMenu.UseVisualStyleBackColor = true;
            this.mainMenu.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 727);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.allQuotesLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label allQuotesLabel;
        private System.Windows.Forms.Button mainMenu;
    }
}