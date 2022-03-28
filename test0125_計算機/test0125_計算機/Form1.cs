using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0125_計算機
{
    public partial class Form1 : Form
    {
        double op1,op2;
        string op;
        //是否清除螢幕
        bool D =false;

       
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (D)
            {
                label1.Text = "0";
                D = false;
            }


            if (label1.Text == "0")
            {
                label1.Text = button.Text;
            }
            else
            {
                label1.Text += button.Text;
            }

        }

        private void button加減乘除_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
           
                op = Convert.ToString(button.Text);
                op1 = Convert.ToDouble(label1.Text);
                D = true;

        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            op2 = Convert.ToDouble(label1.Text);
            
            switch (op)
            {
                case "+":         
                    label1.Text = ""+(op1 + op2);
                    break;
                case "-":
                    label1.Text = "" + (op1 - op2);
                    break;
                case "*":
                    label1.Text = "" + (op1 * op2);
                    break;
                case "/":
                    label1.Text = "" + (op1 / op2);
                    break;
                
          
            

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
        }

        //double
        private void button12_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            label1.Text+=button.Text;
            if (label1.Text.IndexOf(".")<0)
            {
                label1.Text = label1.Text + ".";
            }
        }

        //AC
        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}
