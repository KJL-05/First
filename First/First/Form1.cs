using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
                int op1Number = int.Parse(this.textBoxOp1.Text);
                int op2Number = int.Parse(this.textBoxOp2.Text);
                int result = op1Number + op2Number;
                this.labelResult.Text = result.ToString();
            }
            catch(Exception ex) 
            {
                this.labelResult.Text = ex.Message;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int op1Number = int.Parse(this.textBoxOp1.Text);
                int op2Number = int.Parse(this.textBoxOp2.Text);
                int result = op1Number - op2Number;
                this.labelResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                this.labelResult.Text = ex.Message;
            }
        }

        private void buttonmMul_Click(object sender, EventArgs e)
        {
            try
            {
                int op1Number = int.Parse(this.textBoxOp1.Text);
                int op2Number = int.Parse(this.textBoxOp2.Text);
                int result = op1Number * op2Number;
                this.labelResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                this.labelResult.Text = ex.Message;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int op1Number = int.Parse(this.textBoxOp1.Text);
                int op2Number = int.Parse(this.textBoxOp2.Text);
                int result = op1Number / op2Number;
                this.labelResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                this.labelResult.Text = ex.Message;
            }
        }

    }
}
