using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Calculator : Form
    {
        private bool dividedByZero = false;
        private bool wasPoint = false;
        private double numb1, numb2;
        private char symbol = ' ';
        private double Result;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            isDividedByZero();
            textBox1.Text += (sender as Button).Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || isDividedByZero())
                return;
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (isDividedByZero())
                return;
            if(TextBoxIsEmpty())
                return;
            numb2 = Convert.ToDouble(textBox1.Text);
            if (!ChooseSymbol())
                return;
            wasPoint = false;
            textBox1.Text = numb1.ToString();
            numb2 = 0; symbol = ' ';
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            numb1 = 0;
            numb2 = 0;
            symbol = ' ';
        }
        private bool isDividedByZero()
        {
            if (dividedByZero)
            {
                textBox1.Clear();
                dividedByZero = false;
                return true;
            }
            return false;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0)
                if (textBox1.Text[0] == '-')
                    textBox1.Text.Remove(0, 1);
                else
                    textBox1.Text = '-' + textBox1.Text;
        }

        private void button12_Click(object sender, EventArgs e)//point
        {
            if (textBox1.Text.Length == 0)
                return;
            if (!wasPoint)
            {
                button1_Click(sender, e);
                wasPoint = true;
                return;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (isDividedByZero())
                return;
            wasPoint = false;
            numb1 = Convert.ToDouble(textBox1.Text);
            symbol = (sender as Button).Text[0];
            textBox1.Clear();
        }
        private bool ChooseSymbol()
        {
            try
            {
                switch (symbol)
                {
                    case '+':
                        numb1 += numb2;
                        Result = numb1;
                        break;
                    case '-':
                        numb1 -= numb2;
                        Result = numb1;
                        break;
                    case '*':
                        numb1 *= numb2;
                        Result = numb1;
                        break;
                    case '/':
                        {
                            if (0 == numb2)
                            {
                                dividedByZero = true;
                                throw new Exception("You can't divide by 0");
                            }
                            numb1 /= numb2;
                            Result = numb1;
                            break;
                        }
                    case '%':
                        numb1 %= numb2;
                        Result = numb1;
                        break;
                    case 'f':
                        numb1 = (int)(numb1 / numb2);
                        Result = numb1;
                        break;
                    default:
                        textBox1.Text = numb2.ToString();
                        break;
                }
            }
            catch (Exception exc)
            {
                textBox1.Text = exc.Message;
                return false;
            }
            return true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            printResult();
        }

        private void printResult()
        {
            textBox1.Text = Result.ToString();
        }
        private bool TextBoxIsEmpty()
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Please, enter the second number");
                return true;
            }
            return false;

        }
    }
}
