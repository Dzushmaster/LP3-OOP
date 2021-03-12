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
    public partial class SearchForm : Form
    {
        Form1 form1;
        static LinkedList<Computer>  computers;
        public SearchForm()
        {
            InitializeComponent();
        }
        public SearchForm(Form1 form1,LinkedList<Computer>  computer)
        {
            InitializeComponent();
            this.form1 = form1;
            computers = computer;
            form1.Enabled = false;
        }
        private void partText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CheckText.ForNames(sender, e))
                e.Handled = true;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (partText.TextLength == 0)
            {
                partText.Text = "Введите текст для поиска совпадений";
                return;
            }
            if(chooseSearchBy.SelectedIndex<0)
            {
                chooseSearchBy.BackColor = Color.Red;
                return;
            }
            if(computers.Count == 0)
            {
                partText.Text = "Список компьютеров пуст";
                return;
            }
            switch(chooseSearchBy.SelectedIndex)
            {
                case 0:
                    computers = SearchBy.NameComputer(computers,partText.Text);
                    break;
                case 1:
                    computers = SearchBy.MakerProc(computers, partText.Text);
                    break;
            }
        }
        public static  LinkedList<Computer>  SearchComputer()
        {
            return computers;
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            form1.Enabled = true;
            this.Close();
        }
    }
}
