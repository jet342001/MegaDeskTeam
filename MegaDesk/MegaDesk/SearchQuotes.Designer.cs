
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
            this.errorBox = new System.Windows.Forms.Label();
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
            this.materialTypeSeachCombo.Location = new System.Drawing.Point(311, 158);
            this.materialTypeSeachCombo.Margin = new System.Windows.Forms.Padding(2);
            this.materialTypeSeachCombo.Name = "materialTypeSeachCombo";
            this.materialTypeSeachCombo.Size = new System.Drawing.Size(542, 33);
            this.materialTypeSeachCombo.TabIndex = 0;
            this.materialTypeSeachCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search For Quotes by Material Type";
            // 
            // searchedData
            // 
            this.searchedData.Location = new System.Drawing.Point(365, 277);
            this.searchedData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchedData.Name = "searchedData";
            this.searchedData.Size = new System.Drawing.Size(542, 346);
            this.searchedData.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(910, 150);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(173, 54);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.Location = new System.Drawing.Point(68, 150);
            this.mainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(173, 54);
            this.mainMenu.TabIndex = 4;
            this.mainMenu.Text = "Main Menu";
            this.mainMenu.UseVisualStyleBackColor = true;
            this.mainMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorBox
            // 
            this.errorBox.ForeColor = System.Drawing.Color.Red;
            this.errorBox.Location = new System.Drawing.Point(365, 126);
            this.errorBox.Name = "errorBox";
            this.errorBox.Size = new System.Drawing.Size(442, 25);
            this.errorBox.TabIndex = 5;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.errorBox);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchedData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialTypeSeachCombo);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label errorBox;
    }
}