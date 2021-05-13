
namespace MegaDesk
{
    partial class SearchQuotes
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
            this.materialTypeSeachCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchedData = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // materialTypeSeachCombo
            // 
            this.materialTypeSeachCombo.FormattingEnabled = true;
            this.materialTypeSeachCombo.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.materialTypeSeachCombo.Location = new System.Drawing.Point(821, 134);
            this.materialTypeSeachCombo.Name = "materialTypeSeachCombo";
            this.materialTypeSeachCombo.Size = new System.Drawing.Size(468, 40);
            this.materialTypeSeachCombo.TabIndex = 0;
            this.materialTypeSeachCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(856, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search For Quotes by Material Type";
            // 
            // searchedData
            // 
            this.searchedData.Location = new System.Drawing.Point(657, 177);
            this.searchedData.Name = "searchedData";
            this.searchedData.Size = new System.Drawing.Size(910, 710);
            this.searchedData.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(1340, 128);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(150, 46);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.Location = new System.Drawing.Point(611, 128);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(150, 46);
            this.mainMenu.TabIndex = 4;
            this.mainMenu.Text = "Main Menu";
            this.mainMenu.UseVisualStyleBackColor = true;
            this.mainMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2052, 896);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchedData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialTypeSeachCombo);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox materialTypeSeachCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label searchedData;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button mainMenu;
    }
}