using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cashRegister
{
    public partial class Form1 : Form
    {
        int u235Counter;
        int u238Counter;
        int pu239Counter;
        double subTotal;
        double u235 = 130;
        double u238 = 110;
        double pu239 = 4500;
        double tax = 0.13;
        double taxAmount;
        double tendered;
        double change;
        double subTotal1;
        double subTotal2;
        double subTotal3;
        double total;

        public Form1()
        {
            InitializeComponent();
            checkBuy.Start();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBuy_Tick(object sender, EventArgs e)
        {
            u235Output.Text = $"{u235Counter}";
            u238Output.Text = $"{u238Counter}";
            pu239Output.Text = $"{pu239Counter}";

            if (u235Output.Text == "")
            {
                u235Output.Text = "0";
            }

            if (u238Output.Text == "")
            {
                u238Output.Text = "0";
            }

            if (pu239Output.Text == "")
            {
                pu239Output.Text = "0";
            }
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            subTotal1 = u235 * u235Counter;
            subTotal2 = u238 * u238Counter;
            subTotal3 = pu239 * pu239Counter;
            subTotal = subTotal1 + subTotal2 + subTotal3;

            subOutput.Text = $"{subTotal.ToString("C")}";

            taxAmount = tax * subTotal;

            taxOutput.Text = $"{taxAmount.ToString("C")}";

            total = taxAmount + subTotal;

            totalOutput.Text = $"{subTotal.ToString("C")}";
        }

        private void pu239costLabel_Click(object sender, EventArgs e)
        {

        }

        private void u235Label_Click(object sender, EventArgs e)
        {
            u235Counter = u235Counter + 1;
        }

        private void u238Label_Click(object sender, EventArgs e)
        {
            u238Counter = u238Counter + 1;
        }

        private void u235Output_TextChanged(object sender, EventArgs e)
        {

        }

        private void u238costLabel_Click(object sender, EventArgs e)
        {

        }

        private void u235costLabel_Click(object sender, EventArgs e)
        {

        }

        private void changeOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (tendered < total)
            {
                changeButton.Text = "Insufficient Funds";
            };

            change = total - tendered;
            subOutput.Text = $"{subTotal.ToString("C")}";
        }

        private void tenderedInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void tenderedLabel_Click(object sender, EventArgs e)
        {

        }

        private void sepatatorBox_Click(object sender, EventArgs e)
        {

        }

        private void totalOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void taxOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void subOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalLabel_Click(object sender, EventArgs e)
        {

        }

        private void taxLabel_Click(object sender, EventArgs e)
        {

        }

        private void subtotalLabel_Click(object sender, EventArgs e)
        {

        }

        private void pu239Output_TextChanged(object sender, EventArgs e)
        {

        }

        private void u238Output_TextChanged(object sender, EventArgs e)
        {

        }

        private void numberPu239Label_Click(object sender, EventArgs e)
        {

        }

        private void numberU238Label_Click(object sender, EventArgs e)
        {

        }

        private void numberU235Label_Click(object sender, EventArgs e)
        {

        }

        private void titlePic_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pu239Label_Click(object sender, EventArgs e)
        {
            pu239Counter = pu239Counter + 1;
        }

        private void orderBox_Click(object sender, EventArgs e)
        {

        }
    }
}