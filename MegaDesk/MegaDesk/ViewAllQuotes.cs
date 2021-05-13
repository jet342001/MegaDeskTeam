using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            List<DeskQuote> deskQuotes = DatabaseHandler.GetAllJsonQuotes();
            // HERE IS WHERE YOU WILL PARSE THE LIST OF DESK QUOTES TO DISPLAY THEM
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
    }
}
