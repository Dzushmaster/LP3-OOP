using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form2 : Form
    {
        Form1 form1;
        CPU cpu;
        private bool checkFillingFields()
        {
            bool isOk = true; ;
            if (creatorText.TextLength == 0) { creatorText.BackColor = Color.Red; isOk = false; }
            else { creatorText.BackColor = Color.White; }

            if (seriesText.TextLength == 0)   { seriesText.BackColor = Color.Red;   isOk = false; }
            else { seriesText.BackColor = Color.White;  }
            
            if (coreSizeText.TextLength == 0) { coreSizeText.BackColor = Color.Red;   isOk = false; }
            else { coreSizeText.BackColor= Color.White; }
            
            if (cashSizeText.TextLength == 0) { cashSizeText.BackColor = Color.Red; isOk = false; }
            else { cashSizeText.BackColor= Color.White; }
            
            if (capacityText.TextLength == 0) { capacityText.BackColor = Color.Red; isOk = false; }
            else { capacityText.BackColor= Color.White; }
            
            if (maxFreqText.TextLength == 0)  {  maxFreqText.BackColor = Color.Red; isOk = false; }
            else { maxFreqText.BackColor= Color.White; }
            
            return isOk;
        }
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void creatorText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CheckText.ForNames(sender, e))
            {
                creatorText.BackColor = Color.White;
                e.Handled = true;
            }
        }

        private void seriesText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CheckText.TextAndDigit(sender, e))
            {
                seriesText.BackColor = Color.White;
                e.Handled = true;
            }
            
        }

        private void coreSizeText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CheckText.NumbersOnly(sender, e))
            {
                coreSizeText.BackColor = Color.White;
                cashSizeText.BackColor = Color.White;
                maxFreqText.BackColor = Color.White;
                capacityText.BackColor = Color.White;
                e.Handled = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void closeButton_Click(object sender, EventArgs e)
        {
            if (!checkFillingFields())
                return;
            cpu = new CPU(creatorText.Text, seriesText.Text, Convert.ToInt32(maxFreqText.Text),
              Convert.ToInt32(coreSizeText.Text), Convert.ToInt32(capacityText.Text),
              Convert.ToInt32(cashSizeText.Text));
            this.Close();
            form1.Enabled = true;
        }
        public CPU takeCPU()
        {
            if (cpu == null)
                return new CPU();
            return cpu;
        }
    }
}
