using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double temp1, temp2;
        string op;

        private void OneBtn_Click(object sender, EventArgs e)
        {
            if (screenTxtb.Text == "0")
            {
                screenTxtb.Text = "1";
            }
            else
            {
                screenTxtb.Text += "1";
            }
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            if (screenTxtb.Text == "0")
            {
                screenTxtb.Text = "2";
            }
            else
            {
                screenTxtb.Text += "2";
            }
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            if (screenTxtb.Text == "0")
            {
                screenTxtb.Text = "3";
            }
            else
            {
                screenTxtb.Text += "3";
            }
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            if (screenTxtb.Text == "0")
            {
                screenTxtb.Text = "4";
            }
            else
            {
                screenTxtb.Text += "4";
            }
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            if (screenTxtb.Text == "0")
            {
                screenTxtb.Text = "5";
            }
            else
            {
                screenTxtb.Text += "5";
            }
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            if (screenTxtb.Text == "0")
            {
                screenTxtb.Text = "6";
            }
            else
            {
                screenTxtb.Text += "6";
            }
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            if (screenTxtb.Text == "0")
            {
                screenTxtb.Text = "7";
            }
            else
            {
                screenTxtb.Text += "7";
            }
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            if (screenTxtb.Text == "0")
            {
                screenTxtb.Text = "8";
            }
            else
            {
                screenTxtb.Text += "8";
            }
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            if (screenTxtb.Text == "0")
            {
                screenTxtb.Text = "9";
            }
            else
            {
                screenTxtb.Text += "9";
            }
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {

            if (screenTxtb.Text == "0")
            {
                screenTxtb.Text = "0";
            }
            else
            {
                screenTxtb.Text += "0";
            }

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (screenTxtb.Text == "0")
            {
                screenTxtb.Text = "0";
            }
            else
            {
                if (screenTxtb.TextLength == 1)
                {
                    screenTxtb.Text = "0";
                }
                else
                {
                    screenTxtb.Text = screenTxtb.Text.Remove(screenTxtb.TextLength - 1, 1);
                }
            }
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            temp1 = double.Parse(screenTxtb.Text);
            op = "+";
            infoLbl.Text = screenTxtb.Text + "+";
            screenTxtb.Text = "0";
        }

        private void equalBtn_Click_1(object sender, EventArgs e)
        {
            temp2 = double.Parse(screenTxtb.Text);
            if (op == "+")
            {
                screenTxtb.Text = (temp1 + temp2).ToString();
                infoLbl.Text = "";
            }
            else if (op == "-")
            {
                screenTxtb.Text = (temp1 - temp2).ToString();
                infoLbl.Text = "";
            }
            else if (op == "*")
            {
                screenTxtb.Text = (temp1 * temp2).ToString();
                infoLbl.Text = "";
            }
            else if (op == "/")
            {
                if (temp2 == 0)
                {
                    screenTxtb.Text = "Impossible";
                    infoLbl.Text = "";
                }
                else
                {
                    screenTxtb.Text = (temp1 / temp2).ToString();
                    infoLbl.Text = "";
                }
            }
            else if (op == "X^Y")
            {
                screenTxtb.Text = (Math.Pow(temp1, temp2)).ToString();
                infoLbl.Text = $"{temp1}^{temp2}";
            }
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            temp1 = double.Parse(screenTxtb.Text);
            op = "-";
            infoLbl.Text = screenTxtb.Text + "-";
            screenTxtb.Text = "0";
        }

        private void multBtn_Click(object sender, EventArgs e)
        {
            temp1 = double.Parse(screenTxtb.Text);
            op = "*";
            infoLbl.Text = screenTxtb.Text + "*";
            screenTxtb.Text = "0";
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            temp1 = double.Parse(screenTxtb.Text);
            op = "/";
            infoLbl.Text = screenTxtb.Text + "/";
            screenTxtb.Text = "0";
        }

        private void squareBtn_Click(object sender, EventArgs e)
        {
            double num = double.Parse(screenTxtb.Text);
            infoLbl.Text = $"{num}^2";
            num = Math.Pow(num, 2);
            screenTxtb.Text = num.ToString();
        }

        private void RandSquare_Btn_Click(object sender, EventArgs e)
        {
            temp1 = double.Parse(screenTxtb.Text);
            op = "X^Y";
            infoLbl.Text = screenTxtb.Text + "^";
            screenTxtb.Text = "0";
        }

        private void pointBtn_Click(object sender, EventArgs e)
        {
            if (screenTxtb.Text == "0")
            {
                screenTxtb.Text = "0";
            }
            if (!screenTxtb.Text.Contains(","))
            {
                screenTxtb.Text += ",";
            }
        }

        private void negativeOrPozitiveBtn_Click(object sender, EventArgs e)
        {
            if (screenTxtb.Text == "0")
            {
                screenTxtb.Text = "0";
            }
            else
            {
                if (!screenTxtb.Text.Contains("-"))
                {
                    screenTxtb.Text = $"-{screenTxtb.Text}";
                }
                else
                {
                    screenTxtb.Text = screenTxtb.Text.Replace("-", "");
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            screenTxtb.Text = "0";
            infoLbl.Text = "";
        }
    }
}