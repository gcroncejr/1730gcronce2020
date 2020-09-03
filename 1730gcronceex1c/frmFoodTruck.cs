using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1730gcronceex1c
{
    public partial class gcronce1c1 : Form
    {
        public gcronce1c1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btcCalculate_Click(object sender, EventArgs e)
        {
            txtHotDogsSubtotal.Text = (
                4.0m * Convert.ToDecimal(txtHotDogs2.Text)
                ).ToString("0.00");
            txtHamburgersSubtotal.Text = (
               5.0m * Convert.ToDecimal(txtHamburgers2.Text)
               ).ToString("0.00");
            txtPretaxTotal.Text = (
               Convert.ToDecimal(txtHotDogsSubtotal.Text) + Convert.ToDecimal(txtHamburgersSubtotal.Text)
               ).ToString("0.00");
            txtTax.Text = (Convert.ToString("0.62"));
            txtTotalTotal.Text = (
                Convert.ToDecimal(txtPretaxTotal.Text) * Convert.ToDecimal(txtTax.Text)
                ).ToString("0.00");
            btnClear.Focus();
            

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHotDogs2.Text = "0.00";
            txtHamburgers2.Text = "0.00";
            txtHotDogsSubtotal.Text = "";
            txtHamburgersSubtotal.Text = "";
            txtPretaxTotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";

            txtHotDogs1.Focus();
        }
    }
}
