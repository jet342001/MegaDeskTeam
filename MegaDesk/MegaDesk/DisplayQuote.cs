using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Globalization;

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
        double totalPrice;
        double rushPrice;

        public DisplayQuote(
            double width,
            double depth,
            int numDrawers,
            int rushDays,
            string surfaceMaterial,
            string firstName,
            string lastName,
            double totalPrice,
            double rushPrice
            
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
            this.totalPrice = totalPrice;
            this.rushPrice = rushPrice;
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {

            quoteData.Text = $"Name: { firstName } { lastName }\n" +
                $"Width: { width }\n" +
                $"Depth: {depth}\n" +
                $"Number of Drawers: { numDrawers }\n" +
                $"Surface Material: { surfaceMaterial }\n" +
                $"Rush Days: { rushDays }\n" +
                $"Rush Price: { rushPrice.ToString("C2") }\n" +
                $"Total Price: { totalPrice.ToString("C2") }\n";
        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
    }
}
