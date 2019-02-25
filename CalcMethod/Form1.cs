using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

        double numOne = 0;  
        double numTwo = 0;  
        private void button1_Click(object sender, EventArgs e)
        {
            numOne = double.Parse(txtInput.Text);
            numTwo = double.Parse(txtInput2.Text);

            if(chckAdd.CheckState == CheckState.Checked)
            {
                double sum = numOne + numTwo;
                txtOutput.Text = sum.ToString();
            } else if(chckSub.CheckState == CheckState.Checked)
            {
                double sub = numOne - numTwo;
                txtOutput.Text = sub.ToString();
            }else if(chckMul.CheckState == CheckState.Checked)
            {
                double mul = numOne * numTwo;
                txtOutput.Text = mul.ToString();
            }else if(chckDiv.CheckState == CheckState.Checked)
            {
                if(numTwo == 0)
                {
                    MessageBox.Show("Second Number can not be zero", "Caution");
                } else
                { 
                double div = numOne / numTwo;
                txtOutput.Text = div.ToString();
                }
            }
        

        }

        

        private void chckAdd_CheckedChanged(object sender, EventArgs e)
        {
            //double sum = double.Parse(txtInput.Text) + double.Parse(txtInput2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtInput2.Clear();
            txtOutput.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("Sure?", "Confirmation", MessageBoxButtons.OKCancel);
            //if(DialogResult == DialogResult.OK)
            //{
                
            //}
            Application.Exit();
        }
    }
}
