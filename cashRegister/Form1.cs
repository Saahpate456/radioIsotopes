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
using System.Media;

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
        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                tendered = Convert.ToDouble(tenderedInput.Text);

                change = tendered - total;

                if (tendered < total)
                {
                    changeButton.Text = "Insufficient Funds";
                    printButton.Enabled = false;
                }
                if (tendered > 0)
                {
                    printButton.Enabled = true;
                }
                changeOutput.Text = $"{change.ToString("C")}";
            }
            catch
            {
                changeButton.ForeColor = Color.Red;
                changeOutput.Text = "Come on...";
                tenderedInput.Text = "Seriously?";
            }
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            changeButton.Enabled = false;

            printButton.Enabled = false;

            u235Counter = 0;
            u238Counter = 0;
            pu239Counter = 0;
            subTotal = 0;
            taxAmount = 0;
            tendered = 0;
            change = 0;

            subOutput.Text = $"{subTotal.ToString("C")}";

            taxAmount = tax * subTotal;

            taxOutput.Text = $"{taxAmount.ToString("C")}";

            total = taxAmount + subTotal;

            totalOutput.Text = $"{total.ToString("C")}";

            changeOutput.Text = $"{change.ToString("C")}";

            tenderedInput.Text = $"{tendered.ToString("")}";

            changeButton.Text = $"Calculate Change";

            changeButton.ForeColor = Color.Black;

            outputLabel.Visible = false;
        }

        private void printButton_Click_1(object sender, EventArgs e)
        {
            outputLabel.Visible = true;

            SoundPlayer player = new SoundPlayer(Properties.Resources.recieptSound);

            player.Play();

            outputLabel.Text += $"\n        Radioisotope Market ";
            Refresh();
            Thread.Sleep(500);

            outputLabel.Text += $"\n  Uranium-235    x{u235Counter}  {subTotal1.ToString("C")}";
            Refresh();
            Thread.Sleep(500);


            outputLabel.Text += $"\n  Uranium-238    x{u238Counter}  {subTotal2.ToString("C")}";
            Refresh();
            Thread.Sleep(500);


            outputLabel.Text += $"\n  Plutonium-239  x{pu239Counter}  {subTotal3.ToString("C")}";
            Refresh();
            Thread.Sleep(500);


            outputLabel.Text += $"\n\n\n  Subtotal           {subTotal.ToString("C")}";
            Refresh();
            Thread.Sleep(500);


            outputLabel.Text += $"\n  Tax                {taxAmount.ToString("C")}";
            Refresh();
            Thread.Sleep(500);


            outputLabel.Text += $"\n  Total              {total.ToString("C")}";
            Refresh();
            Thread.Sleep(500);


            outputLabel.Text += $"\n\n\n  Tendered           {tendered.ToString("C")}";
            Refresh();
            Thread.Sleep(500);


            outputLabel.Text += $"\n  Change             {change.ToString("C")}";
            Refresh();
            Thread.Sleep(500);


            outputLabel.Text += $"\n\n\n  We are not liable for the\n  consumer's use of these\n  items after they are purchased.";

        }

        private void removeButton1_Click(object sender, EventArgs e)
        {
            u235Counter = u235Counter - 1;
        }

        private void removeButton2_Click(object sender, EventArgs e)
        {
            u238Counter = u238Counter - 1;
        }

        private void removeButton3_Click(object sender, EventArgs e)
        {
            pu239Counter = pu239Counter - 1;
        }
    }
}