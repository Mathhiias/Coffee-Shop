/*
 * Name : Anju Chawla
 * Date: Sep. 28, 2017
 * Purpose:This application allows the user to select multiple coffee type
 * in various quantities.
 * The amount due is displayed.
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Sales
{
    public partial class frmCoffeeShop : Form
    {
       
        public frmCoffeeShop()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //calculates the amount for a selected coffee and accumulates
            //the subtotal too since customer can order more than 
            //one coffee in different quantities

            //local variables-do not have a default value
           

                      


        }

        private void frmCoffeeShop_Load(object sender, EventArgs e)
        {
           

        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear the user input and get back to start default state
            ClearInput();

        }

        private void ClearInput()
        {
          
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the form
           
        }
    }
}
