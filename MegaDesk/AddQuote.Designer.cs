
namespace MegaDesk
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            this.widthLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.depthInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.successLabel = new System.Windows.Forms.Label();
            this.drawersInput = new System.Windows.Forms.NumericUpDown();
            this.rushDaysInput = new System.Windows.Forms.NumericUpDown();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.surfaceMaterialInput = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.drawersInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rushDaysInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(117, 134);
            this.widthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(39, 15);
            this.widthLabel.TabIndex = 0;
            this.widthLabel.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Depth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 255);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Drawers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Surface Material";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rush Order Days";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "First Name";
            // 
            // firstNameInput
            // 
            this.firstNameInput.Location = new System.Drawing.Point(234, 78);
            this.firstNameInput.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(262, 23);
            this.firstNameInput.TabIndex = 7;
            this.firstNameInput.Validating += new System.ComponentModel.CancelEventHandler(this.fNameValidating);
            // 
            // lastNameInput
            // 
            this.lastNameInput.Location = new System.Drawing.Point(234, 104);
            this.lastNameInput.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(262, 23);
            this.lastNameInput.TabIndex = 12;
            this.lastNameInput.Validating += new System.ComponentModel.CancelEventHandler(this.lNameValidating);
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(234, 133);
            this.widthInput.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(262, 23);
            this.widthInput.TabIndex = 13;
            this.widthInput.Validating += new System.ComponentModel.CancelEventHandler(this.widthValidating);
            // 
            // depthInput
            // 
            this.depthInput.Location = new System.Drawing.Point(234, 163);
            this.depthInput.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(262, 23);
            this.depthInput.TabIndex = 14;
            this.depthInput.Validating += new System.ComponentModel.CancelEventHandler(this.depthValidating);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(358, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 39);
            this.label7.TabIndex = 18;
            this.label7.Text = "Desk Quote Form";
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Location = new System.Drawing.Point(605, 182);
            this.mainMenuButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(174, 22);
            this.mainMenuButton.TabIndex = 19;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(605, 134);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(174, 22);
            this.submitButton.TabIndex = 20;
            this.submitButton.Text = "Submit Quote";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(605, 88);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(174, 22);
            this.clearButton.TabIndex = 21;
            this.clearButton.Text = "Clear Quote";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(453, 299);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 15);
            this.errorLabel.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(535, 224);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(302, 180);
            this.label8.TabIndex = 23;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.Location = new System.Drawing.Point(352, 395);
            this.successLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(0, 15);
            this.successLabel.TabIndex = 24;
            // 
            // drawersInput
            // 
            this.drawersInput.Location = new System.Drawing.Point(234, 255);
            this.drawersInput.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.drawersInput.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.drawersInput.Name = "drawersInput";
            this.drawersInput.Size = new System.Drawing.Size(261, 23);
            this.drawersInput.TabIndex = 25;
            // 
            // rushDaysInput
            // 
            this.rushDaysInput.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.rushDaysInput.Location = new System.Drawing.Point(234, 193);
            this.rushDaysInput.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.rushDaysInput.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.rushDaysInput.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.rushDaysInput.Name = "rushDaysInput";
            this.rushDaysInput.Size = new System.Drawing.Size(261, 23);
            this.rushDaysInput.TabIndex = 26;
            this.rushDaysInput.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // surfaceMaterialInput
            // 
            this.surfaceMaterialInput.FormattingEnabled = true;
            this.surfaceMaterialInput.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.surfaceMaterialInput.Location = new System.Drawing.Point(234, 224);
            this.surfaceMaterialInput.Name = "surfaceMaterialInput";
            this.surfaceMaterialInput.Size = new System.Drawing.Size(262, 23);
            this.surfaceMaterialInput.TabIndex = 27;
            this.surfaceMaterialInput.Text = "Select one";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 413);
            this.Controls.Add(this.surfaceMaterialInput);
            this.Controls.Add(this.rushDaysInput);
            this.Controls.Add(this.drawersInput);
            this.Controls.Add(this.successLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.depthInput);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.lastNameInput);
            this.Controls.Add(this.firstNameInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.widthLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "AddQuote";
            this.Text = "Desk Quote Form";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drawersInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rushDaysInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox firstNameInput;
        private System.Windows.Forms.TextBox lastNameInput;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.TextBox depthInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label successLabel;
        private System.Windows.Forms.NumericUpDown drawersInput;
        private System.Windows.Forms.NumericUpDown rushDaysInput;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox surfaceMaterialInput;
    }
}