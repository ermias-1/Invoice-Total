using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice_Total
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* This program calculates the Invoice total
             * and the discount amount based on
             * the discount percent when a user
             * inters the subtotal of the invoice   */

            // Get the subtotal amount from the user
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);

            //Set the discountPercent variable based on
            // the value of the subtotal variable
            decimal discountPercent = 0m;

            if (subtotal >= 500)
            {
                discountPercent = .2m;

            }
            else if (subtotal >= 250 && subtotal < 500)
            {
                discountPercent = .15m;

            }
            else if (subtotal >= 100 && subtotal < 250)
            {
                discountPercent = .1m;
            }

            // Calculate and assign the values for
            // the discountAmount and invoiceTotal variables
            decimal discountAmount = subtotal * discountPercent;
            decimal invoiceTotal = subtotal - discountAmount;

            // Format the values and display them
            txtDiscountPercent.Text = discountPercent.ToString("p1"); //percent format with 1 decimal place

            txtDiscountAmount.Text = discountAmount.ToString("c"); // currency format

            txtTotal.Text = invoiceTotal.ToString("c");

            // Move the focus to the Subtotal text box
            txtSubtotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
