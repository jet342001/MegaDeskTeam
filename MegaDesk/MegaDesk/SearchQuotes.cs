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
           // searchedData.Text = "Select a value from the drop down.";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (materialTypeSeachCombo.Text.ToString() == "")
            {
                errorBox.Text = "Please select an item from the dropdown menu below";
                return;
            }
            else
            {
                errorBox.Text = "";
            }

            List<DeskQuote> filteredDeskQuotes = DatabaseHandler.SearchDeskQuotes(materialTypeSeachCombo.SelectedItem.ToString());
            // THIS IS THE LIST OF DESK QUOTES THAT MATCH THE STRING INPUT FOR THE MATERIAL TYPE
            // HERE IS WHERE YOU NEED TO LOAD THEM IN FROM A LIST OF DESK QUOTE 

            searchedData.Text = "";

            foreach (var quote in filteredDeskQuotes)
            {
                searchedData.Text += "Order Date and Time: " + quote.quoteDate + "\n";
                searchedData.Text += "Full Name: " + quote.customerFirstName + " " + quote.customerLastName + "\n";
                searchedData.Text += "Surface Material: " + quote.desk.surfaceMaterialType + "\n";
                searchedData.Text += "Total Price: " + quote.totalPrice.ToString("C2") + "\n";
                searchedData.Text += "\n";
            }



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
