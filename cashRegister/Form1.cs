using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

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
        double change;
        double subTotal1;
        double subTotal2;
        double subTotal3;
        double total;
        double tendered;
        

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

            totalOutput.Text = $"{total.ToString("C")}";

            changeButton.Enabled = true;

            tenderedInput.Enabled = true;
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
        private void pu239Label_Click(object sender, EventArgs e)
        {
            pu239Counter = pu239Counter + 1;
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
            tendered = Convert.ToDouble(tenderedInput.Text);

            change = tendered - total;

            if (tendered < total)
            {
                changeButton.Text = "Insufficient Funds";
            }

            changeOutput.Text = $"{change.ToString("C")}";

            printButton.Enabled = true;
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

        private void orderBox_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            u235Counter = 0;
            u238Counter = 0;
            pu239Counter = 0;
            subTotal = 0;
            taxAmount = 0;
            tendered = 0;
            change = 0;

            subTotal1 = u235 * u235Counter;
            subTotal2 = u238 * u238Counter;
            subTotal3 = pu239 * pu239Counter;
            subTotal = subTotal1 + subTotal2 + subTotal3;

            subOutput.Text = $"{subTotal.ToString("C")}";

            taxAmount = tax * subTotal;

            taxOutput.Text = $"{taxAmount.ToString("C")}";

            total = taxAmount + subTotal;

            totalOutput.Text = $"{total.ToString("C")}";

            changeOutput.Text = $"{change.ToString("C")}";

            tenderedInput.Text = $"{tendered.ToString("")}";

            recieptbox1.Visible = false;
            titleLabel2.Visible = false;

            recieptbox2.Visible = false;
            recieptLabel1.Visible = false;
            recieptLabel2.Visible = false;

            recieptBox3.Visible = false;
            u235recieptlabel.Visible = false;
            u238recieptlabel2.Visible = false;
            pu239recieptlabel3.Visible = false;

            recieptBox4.Visible = false;
            subrecieptLabel.Visible = false;
            taxrecieptLabel.Visible = false;
            totalrecieptLabel.Visible = false;

            recieptbox5.Visible = false;
            tenderedrecieptlabel.Visible = false;
            changerecieptlabel.Visible = false;

            recieptbox6.Visible = false;
            messagerecieptlabel.Visible = false;


            changeButton.Enabled = false;
            printButton.Enabled = false;
        }

        private void printButton_Click(object sender, EventArgs e)
        {

        }

        private void printButton_Click_1(object sender, EventArgs e)
        {
            recieptbox1.Visible = true;
            titleLabel2.Visible = true;
            Refresh();
            Thread.Sleep(500);

            recieptbox2.Visible = true;
            recieptLabel1.Visible = true;
            recieptLabel2.Visible = true;
            Refresh();
            Thread.Sleep(500);

            recieptBox3.Visible = true;
            
            

            pu239recieptlabel3.Visible = true;
            u235recieptlabel.Visible = true;
            u235recieptlabel.Text = $"Uranium-235     x{u235Counter}     {subTotal1.ToString("C")}";
            Refresh();
            Thread.Sleep(500);

            u238recieptlabel2.Visible = true;
            u238recieptlabel2.Text = $"Uranium-238     x{u238Counter}     {subTotal2.ToString("C")}";
            Refresh();
            Thread.Sleep(500);

            pu239recieptlabel3.Visible = true;
            pu239recieptlabel3.Text = $"Plutonium-239   x{pu239Counter}     {subTotal3.ToString("C")}";
            Refresh();
            Thread.Sleep(500);

            
            
            recieptBox4.Visible = true;
            subrecieptLabel.Visible = true;
            subrecieptLabel.Text = $"Subtotal               {subTotal.ToString("C")}";
            Refresh();
            Thread.Sleep(500);

            taxrecieptLabel.Visible = true;
            taxrecieptLabel.Text = $"Tax                    {taxAmount.ToString("C")}";
            Refresh();
            Thread.Sleep(500);

            totalrecieptLabel.Visible = true;
            totalrecieptLabel.Text = $"Total                  {total.ToString("C")}";
            Refresh();
            Thread.Sleep(500);



            tenderedrecieptlabel.Visible = true;
            recieptbox5.Visible = true;
            tenderedrecieptlabel.Text = $"Tendered               {tendered.ToString("C")}";
            Refresh();
            Thread.Sleep(500);

            changerecieptlabel.Visible = true;
            changerecieptlabel.Text = $"Change                 {change.ToString("C")}";
            Refresh();
            Thread.Sleep(500);



            recieptbox6.Visible = true;
            messagerecieptlabel.Visible = true;
            messagerecieptlabel.Text = $"We are not liable for the \nconsumer's use of these \nitems after they are purchased.";

        }
    }
}

///recieptbox1.Visible = false;
///titleLabel2.Visible = false;

///recieptbox2.Visible = false;
///recieptLabel1.Visible = false;
///recieptLabel2.Visible = false;

///recieptBox3.Visible = false;
///u235recieptlabel.Visible = false;
///u238recieptlabel2.Visible = false;
///pu239recieptlabel3.Visible = false;

///recieptBox4.Visible = false;
///subrecieptLabel.Visible = false;
///taxrecieptLabel.Visible = false;
///totalrecieptLabel.Visible = false;

///recieptbox5.Visible = false;
///tenderedrecieptlabel.Visible = false;
///changerecieptlabel.Visible = false;

///recieptbox6.Visible = false;
///messagerecieptlabel.Visible = false;
///
/// 
/// 
/// This should go into changeButton
/// 
/// 
///if (tendered < total)
///{
///    printButton.Enabled = false;
///}
///
///if (tendered < total)
///{
///   changeOutput.Text = "Pay More!";
///}