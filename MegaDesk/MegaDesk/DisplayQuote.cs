using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class DisplayQuote : Form
    {

        public DisplayQuote()
        {
            InitializeComponent();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            quoteData.Text = DatabaseHandler.GetLastQuote();
        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
    }
}
