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
    public partial class SortedForm : Form
    {
        Form1 form1;
        static LinkedList<Computer> computers;
        static IOrderedEnumerable<Computer> SortedComp;
        public SortedForm()
        {
            InitializeComponent();
        }
        public SortedForm(Form1 form1, LinkedList<Computer> computer)
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

        private void sortButton_Click(object sender, EventArgs e)
        {
            if (chooseSortBy.SelectedIndex < 0)
            {
                partText.Text = "Выберите элемент по которому будет происходить сортировка ";
                chooseSortBy.BackColor = Color.Red;
                return;
            }
            if (computers.Count == 0 || computers == null)
            {
                partText.Text = "Список компьютеров пуст";
                return;
            }
            switch (chooseSortBy.SelectedIndex)
            {
                case 0:
                    SortedComp = SortBy.CapacityProc(computers);
                    break;
                case 1:
                    SortedComp = SortBy.RamSize(computers);
                    break;
            }
        }
        public static IOrderedEnumerable<Computer> SortedComputer()
        {
            return SortedComp;
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            form1.Enabled = true;
            this.Close();
        }
    }
}
