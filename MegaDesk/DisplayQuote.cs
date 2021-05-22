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
        double width;
        double depth;
        int numDrawers;
        int rushDays;
        string surfaceMaterial;
        string firstName;
        string lastName;

        public DisplayQuote(
            double width,
            double depth,
            int numDrawers,
            int rushDays,
            string surfaceMaterial,
            string firstName,
            string lastName
        )
        {
            InitializeComponent();
            this.width = width;
            this.depth = depth;
            this.numDrawers = numDrawers;
            this.rushDays = rushDays;
            this.surfaceMaterial = surfaceMaterial;
            this.firstName = firstName;
            this.lastName = lastName; 
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            quoteData.Text = $"Width: { width }";
        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
    }
}
