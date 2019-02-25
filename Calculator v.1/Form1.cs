using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_v._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNull_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnNull.Text;
            this.BackColor = System.Drawing.Color.LemonChiffon;
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            withNumber = double.TryParse(txtDisplay.Text, out numberCheck);
            if (!withNumber)
            {
                MessageBox.Show("Please enter a number.", "Warning!");
                txtDisplay.Clear();
            }
            else
            {
                txtDisplay.Text += btnComma.Text;
            }
            this.BackColor = System.Drawing.Color.Lavender;

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnOne.Text;
            this.BackColor = System.Drawing.Color.Khaki;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnTwo.Text;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnThree.Text;
            this.BackColor = System.Drawing.Color.Honeydew;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnFour.Text;
            this.BackColor = System.Drawing.Color.Goldenrod;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnFive.Text;
            this.BackColor = System.Drawing.Color.LightSalmon;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnSix.Text;
            this.BackColor = System.Drawing.Color.GhostWhite;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnSeven.Text;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnEight.Text;
            this.BackColor = System.Drawing.Color.Linen;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnNine.Text;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            this.BackColor = System.Drawing.Color.Cyan;
        }

        //Operators
        double total1 = 0;
        double total2 = 0;
        double numberCheck = 0;
        string theOperator;

        //Checker
        bool withNumber = false;
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            withNumber = double.TryParse(txtDisplay.Text, out numberCheck);
            if (!withNumber)
            {
                MessageBox.Show("Please enter a number.", "Warning!");
                txtDisplay.Clear();
            } else
            {
                total1 = total1 + double.Parse(txtDisplay.Text);
                txtDisplay.Clear();
                theOperator = "+";
            }
            this.BackColor = System.Drawing.Color.LightSeaGreen;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            withNumber = double.TryParse(txtDisplay.Text, out numberCheck);
            if (!withNumber)
            {
                MessageBox.Show("Please enter a number.", "Warning!");
                txtDisplay.Clear();
            }
            else
            {
                switch (theOperator)//in the round brackets is the parameter.
                {
                    case "+":
                        total2 = total1 + double.Parse(txtDisplay.Text);
                        txtDisplay.Text = total2.ToString();
                        total1 = 0;
                        break;
                    case "-":
                        total2 = total1 - double.Parse(txtDisplay.Text);
                        txtDisplay.Text = total2.ToString();
                        total1 = 0;
                        break;
                    case "*":
                        total2 = total1 * double.Parse(txtDisplay.Text);
                        txtDisplay.Text = total2.ToString();
                        total1 = 0;
                        break;
                    case "/":
                        total2 = total1 / double.Parse(txtDisplay.Text);
                        txtDisplay.Text = total2.ToString();
                        total1 = 0;
                        break;
                    default: break;
                }
            }
            this.BackColor = System.Drawing.Color.BurlyWood;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            withNumber = double.TryParse(txtDisplay.Text, out numberCheck);
            if (!withNumber)
            {
                MessageBox.Show("Please enter a number.", "Warning!");
                txtDisplay.Clear();
            }else
            {
                total1 += double.Parse(txtDisplay.Text);
                txtDisplay.Clear();
                theOperator = "-";
            }
            this.BackColor = System.Drawing.Color.Beige;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            withNumber = double.TryParse(txtDisplay.Text, out numberCheck);
            if (!withNumber)
            {
                MessageBox.Show("Please enter a number.", "Warning!");
                txtDisplay.Clear();
            }
            else
            {
                total1 += double.Parse(txtDisplay.Text);

                txtDisplay.Clear();
                theOperator = "*";
            }
            this.BackColor = System.Drawing.Color.AliceBlue;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            withNumber = double.TryParse(txtDisplay.Text, out numberCheck);
            if (!withNumber)
            {
                MessageBox.Show("Please enter a number.", "Warning!");
                txtDisplay.Clear();
            } else
            {
                total1 += double.Parse(txtDisplay.Text);
                txtDisplay.Clear();
                theOperator = "/";
            }
            this.BackColor = System.Drawing.Color.Azure;

        }

        //Commands

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really want to quit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
            
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
