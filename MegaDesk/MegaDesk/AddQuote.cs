using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MegaDesk
{
    public partial class AddQuote : Form
    {

        double width;
        double depth;
        int rushDays;
        int numDrawers;
        string surfaceMaterial;
        string firstName;
        string lastName;
        Desk desk = new Desk();
        DeskQuote deskQuote = new DeskQuote();
        public static string data;

        public AddQuote()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void clear()
        {
            widthInput.Text = String.Empty;
            depthInput.Text = String.Empty;
            drawersInput.Text = String.Empty;
            lastNameInput.Text = String.Empty;
            firstNameInput.Text = String.Empty;
            rushDaysInput.Value = 3;
            surfaceMaterialInput.Text = "Oak";
            errorLabel.Text = String.Empty;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                width = Convert.ToDouble(widthInput.Text);
                depth = Convert.ToDouble(depthInput.Text);
                numDrawers = Convert.ToInt32(drawersInput.Value);
                rushDays = Convert.ToInt32(rushDaysInput.Value);
                surfaceMaterial = surfaceMaterialInput.Text;
                firstName = firstNameInput.Text;
                lastName = lastNameInput.Text;
                desk.SetDepth(depth);
                desk.SetNumDrawers(numDrawers);
                desk.SetWidth(width);
                desk.SetSurfaceMaterial(surfaceMaterial);
                deskQuote.SetDesk(desk);
                deskQuote.SetRushOrderDays(rushDays);
                deskQuote.SetCustomerFirstName(firstName);
                deskQuote.SetCustomerLastName(lastName);
                if (deskQuote.CheckValidInputs() == true)
                {
                    double totalPrice = deskQuote.GetTotalPrice();
                    data = deskQuote.QuoteToString();
                    DatabaseHandler.StoreJsonQuote(deskQuote);
                    DisplayQuote displayQuote = new DisplayQuote();
                    displayQuote.Show();
                    this.Hide();
                }
                else
                {
                    errorLabel.Text = "Error with your dimensions. Please see key. Thank you.";
                }
            }
            catch (IOException er)
            {
                errorLabel.Text = "Error with submission" + er.Message;
            }
            catch (FormatException fr)
            {
                errorLabel.Text = "Error with submission" + fr.Message;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            surfaceMaterialInput.Text = "Oak";
        }
    }
}
