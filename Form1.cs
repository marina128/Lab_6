using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double a = 0, b = 0, c = 0;
        char op;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(label1.Text.Replace('.', ','));
            switch (op)
            {
                case '+':
                    c = a + b;
                    break;
                case '-':
                    c = a - b;
                    break;
                case '*':
                    c = a * b;
                    break;
                case '/':
                    c = a / b;
                    break;
            }
            label1.Text = c.ToString();
            Clipboard.SetText(c.ToString());
        }

        private void button_op_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(label1.Text.Replace('.', ','));
            op = (sender as Button).Text[0];
            label1.Text = "";
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Add:
                    button_op_Click(button11, e);
                    break;
                case Keys.Subtract:
                    button_op_Click(button12, e);
                    break;
                case Keys.Multiply:
                    button_op_Click(button9, e);
                    break;
                case Keys.Divide:
                    button_op_Click(button5, e);
                    break;
                case Keys.NumPad0:
                    button_num_Click(button3, e);
                    break;
                case Keys.NumPad1:
                    button_num_Click(button6, e);
                    break;
                case Keys.NumPad2:
                    button_num_Click(button7, e);
                    break;
                case Keys.NumPad3:
                    button_num_Click(button8, e);
                    break;
                case Keys.NumPad4:
                    button_num_Click(button13, e);
                    break;
                case Keys.NumPad5:
                    button_num_Click(button14, e);
                    break;
                case Keys.NumPad6:
                    button_num_Click(button15, e);
                    break;
                case Keys.NumPad7:
                    button_num_Click(button16, e);
                    break;
                case Keys.NumPad8:
                    button_num_Click(button17, e);
                    break;
                case Keys.NumPad9:
                    button_num_Click(button18, e);
                    break;
                case Keys.Delete:
                    button_clear_Click(button2, e);
                    break;
                case Keys.Decimal:
                    button_num_Click(button4, e);
                    break;
            }
        }

        private void button_num_Click(object sender, EventArgs e)
        {
            label1.Text += (sender as Button).Text;
        }
    }
}
