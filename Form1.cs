using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Code_Practice_Checkboxes_Radio_Buttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SandwichDefault();

        } // Form1()

        private void btnMakeSandwich_Click(object sender, EventArgs e)
        {
            CalculateSandwich();
        }

        public void SandwichDefault()
        {
            rbWhite.Checked = true;
            rbNone.Checked = true;
        }
        
        public void CalculateSandwich()
        {
            string displayReciept = "Zack's Sammies\n\n";
            displayReciept += $"Sandwich: {tbSandwich.Text}\n\n";

            //{ sandwichCost.ToString("c")}
            double sandwichCost = 0;

            if (chkCheese.Checked)
            {
                sandwichCost += 1;
                displayReciept += "Cheese - $1.00\n";
            }
            if (chkChicken.Checked)
            {
                sandwichCost += 3;
                displayReciept += "Chicken - $3.00\n";
            }
            if (chkBacon.Checked)
            {
                sandwichCost += 2;
                displayReciept += "Bacon - $2.00\n";
            }
            if (chkPepperoncini.Checked)
            {
                sandwichCost += 1.5;
                displayReciept += "Pepperoncini - $1.50\n";
            }
            if (chkPeppers.Checked)
            {
                sandwichCost += 1.5;
                displayReciept += "Peppers - $1.50\n";
            }
            if (chkMayo.Checked)
            {
                sandwichCost += .5;
                displayReciept += "Mayo - $.50\n";
            }
            if (chkHouseSauce.Checked)
            {
                sandwichCost += 1;
                displayReciept += "House Sauce - $1.00\n";
            }
            if (chkBeef.Checked)
            {
                sandwichCost += 3.5;
                displayReciept += "Beef - $3.50\n";
            }

            if (rbWhite.Checked)
            {
                sandwichCost += 5;
                displayReciept += "Bread: White - $5.00\n";
            }
            else if (rbSourdough.Checked)
            {
                sandwichCost += 6;
                displayReciept += "Bread: Sourdough - $6.00\n";
            }
            else if (rbWheat.Checked)
            {
                sandwichCost += 5.5;
                displayReciept += "Bread: Wheat - $5.50\n";
            }
            else
            {
                sandwichCost += 7;
                displayReciept += "Bread: Foccaccia - $7.00\n";
            }

            if (rbNone.Checked)
            {
                displayReciept += "Heat: None\n\n";
            }
            else if (rbMild.Checked)
            {
                displayReciept += "Heat: Mild\n\n";
            }
            else if (rbMedium.Checked)
            {
                displayReciept += "Heat: Medium\n\n";
            }
            else
            {
                displayReciept += "Heat: Hot\n\n";
            }

            displayReciept += $"Subtotal: {sandwichCost.ToString("c")}\n\n";

            double taxPercent = .1;
            double taxAmount = CalculateTax(sandwichCost, taxPercent);

            displayReciept += $"Tax: {taxAmount.ToString("c")}\n\n";

            double finalCost = sandwichCost + taxAmount;

            displayReciept += $"Total: {finalCost.ToString("c")}";

            rtbDisplay.Text = displayReciept;
        }

        public double CalculateTax(double sandwichCost, double taxPercent)
        {
            return sandwichCost * taxPercent;
        }

        // In this exercise, you will practice working with your checkboxes and radio buttons.

            // Create a winform that has

            // 1 Textbox: For the name of the sandwich

            // 3 Group Boxes: 1 for each set of radio buttons, and 1 for your toppings. Make sure they display the correct name of the item.

            // 2 Sets of Radio buttons:

            //        Set 1: Bread - 4 Options.You can use the ones I provided or choose your own

            //        Set 2: Heat - 4 Options.You can make up your own or the ones I provide

            // 1 Set of Checkboxes for Toppings - Give 8 toppings

            // 1 Rich Text Box to display the sandwich information

            // 1 Label that is used to display the name of the sandwich 

            // 1 Button that displays all the information.

            // See the assignment page for an animated gif of the expected result

            // You can design it however you like



    } // class

} // namespace
