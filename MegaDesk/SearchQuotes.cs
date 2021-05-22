using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            searchedData.Text = "Select a value from the drop down.";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            List<DeskQuote> deskQuotes = DatabaseHandler.SearchDeskQuotes(materialTypeSeachCombo.SelectedItem.ToString().ToLower());
            // THIS IS THE LIST OF DESK QUOTES THAT MATCH THE STRING INPUT FOR THE MATERIAL TYPE
            // HERE IS WHERE YOU NEED TO LOAD THEM IN FROM A LIST OF DESK QUOTE OBJECTS
            searchedData.Text = "Successfully clicked the button.";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
    }
}
