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
            string data = "width,depth,surface_material,num_drawers,rush_days,first_name,last_name,total_price";
            data += DatabaseHandler.FindQuotes(materialTypeSeachCombo.SelectedItem.ToString().ToLower());
            searchedData.Text = data;
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
