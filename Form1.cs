using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subway_Sandwich_Order
{
    public partial class Form1 : Form
    {
        int counter;
        double totalPrice;
        string size = "";
        string toppings = "";
        string sides = "";

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            counter++;
            CalculatePrice();
            size = ""; toppings = ""; sides = "";
            lblTotalPrice.Text = "Total Price: " + totalPrice.ToString("C");
            lblTimesChanged.Text = counter + " times";
        }
        public void CalculatePrice()
        {
            totalPrice = 0;
            // size
            if (radFootlong.Checked)
            {
                totalPrice += 10.29;
                size += " Footlong, ";
            }
            else
            {
                totalPrice += 6.49;
                size += " 6-Inch, ";
            }
            // toppings
            if (chkSauce.Checked)
            {
                totalPrice += 0.5;
                toppings += " Sauce, ";
            }
            if (chkCheese.Checked)
            {
                totalPrice += 0.5;
                toppings += " Cheese, ";
            }
            if (chkTomato.Checked)
            {
                totalPrice += 0.1;
                toppings += " Tomato, ";
            }
            if (chkOnion.Checked)
            {
                totalPrice += 0.1;
                toppings += " Onion, ";
            }
            if (chkLettuce.Checked)
            {
                totalPrice += 0.1;
                toppings += " Lettuce, ";
            }
            if (chkMayo.Checked)
                toppings = " Mayonnaise, ";
            if (chkMustard.Checked)
                toppings += " Mustard, ";
            // sides
            if (chkIcedTea.Checked)
            {
                totalPrice += 3.99;
                sides += " Bottle of Iced Tea, ";
            }
            if (chkCoffee.Checked)
            {
                totalPrice += 1.99;
                sides += " Coffee, ";
            }
            if (chkChips.Checked)
            {
                totalPrice += 1.99;
                sides += " Bag of Chips, ";
            }
            if (chkCookie.Checked)
            {
                totalPrice += 0.99;
                sides += " Cookie, ";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Random generator = new Random();
            CalculatePrice();
            string title = "Order #" + generator.Next(1, 251);
            string message = "The price is " + totalPrice.ToString("C") + "; " + size + toppings + sides;
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
                Application.Restart();
            size = ""; toppings = ""; sides = "";

        }
    }
}
