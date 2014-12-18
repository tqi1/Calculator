using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();              // Set text display for buttons
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnOne.Text;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)         // Clear button
        {
           

            txtDisplay.Clear();

        }

            

        private void btnMinus_Click(object sender, EventArgs e)        // Button Minus
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            minusButtonClicked = true;
            plusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
        }

        private void btnMultiply_Click(object sender, EventArgs e)      // Button Multiply
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            minusButtonClicked = false;
            plusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = true;

        }

        private void btnDivide_Click(object sender, EventArgs e)        // Button Divide
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            minusButtonClicked = false;
            plusButtonClicked = false;
            divideButtonClicked = true;
            multiplyButtonClicked = false;

        }

        private void btnPoint_Click(object sender, EventArgs e)         // Button Point
        {
            txtDisplay.Text = txtDisplay.Text + btnPoint.Text;
        }

        double total1 = 0;                      // Declare variables, Boolean Globals
        double total2 = 0;

        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool divideButtonClicked = false;
        bool multiplyButtonClicked = false;


        private void btnPlus_Click(object sender, EventArgs e)          // Button Plus
        {
            total1 += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            plusButtonClicked = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)        // Button Equals if/else
        {


                 if (plusButtonClicked == true)
            {

                total2 = total1 + double.Parse(txtDisplay.Text);
            }

                 else if (minusButtonClicked == true)
            {

                total2 = total1 - double.Parse(txtDisplay.Text);
            }

                 else if (multiplyButtonClicked == true)
            {

                total2 = total1 * double.Parse(txtDisplay.Text);

            }

                 else if (divideButtonClicked == true)
            {

                total2 = total1 / double.Parse(txtDisplay.Text);


            }

            txtDisplay.Text = total2.ToString();
            total1 = 0;

        }
    }

}
    
            


            

    
       
        
    


