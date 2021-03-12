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
    public partial class Form1 : Form
    {
        Form2 form2;
        ToolStripLabel dateLabel = new ToolStripLabel();
        ToolStripLabel timeLabel = new ToolStripLabel();
        ToolStripLabel infoLabel = new ToolStripLabel();
        ToolStripLabel lastEventLabel = new ToolStripLabel();
        ToolStripLabel sizeCompLabel = new ToolStripLabel();

        public Form1()
        {
            InitializeComponent();
            infoLabel.Text = "Дата и время: ";
            statusStrip1.Items.Add(infoLabel);
            statusStrip1.Items.Add(dateLabel);
            statusStrip1.Items.Add(timeLabel);
            statusStrip1.Items.Add(lastEventLabel);
            statusStrip1.Items.Add(sizeCompLabel);
            Timer timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }
    private void Form1_Load(object sender, EventArgs e)
        {
            enterToProcForm.Enabled = false;
        }

        private void typeOfComputerText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CheckText.ForNames(sender, e))
                e.Handled = true;
        }
        private void hddTypeText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CheckText.TextOnly(sender, e))
                e.Handled = true;
        }

        private void serializeInfoButton_Click(object sender, EventArgs e)
        {
            Computer computer = new Computer();
            if (Computer.GetAllComputers().Count == 0)
            {
                MessageBox.Show("Перед записью необходимо добавить компьютер, воспользуйтесь для этого кнопкой \"Добавить компьютер\"");
                return;
            }
            if (!computer.SerializeComputer(Computer.GetAllComputers()))
                MessageBox.Show("Some problems with recording");
        }

        private void unseriallizeTextButton_Click(object sender, EventArgs e)
        {
            LinkedList<Computer> computersFromFile = new LinkedList<Computer>();
            printInfoTextBox.Clear();
            computersFromFile = Computer.DeserializeComputer();
            if (computersFromFile == null){ printInfoTextBox.Text = "File with computers is empty"; return; }
            foreach (var item in computersFromFile)
            {
                printInfoTextBox.Text = printInfoTextBox.Text + '\n' + item.printFromFile();
            }
        }

        private void StandardButton_CheckedChanged(object sender, EventArgs e)
        {
            if (StandardButton.Checked)
                enterToProcForm.Enabled = false;
            else
                enterToProcForm.Enabled = true;
        }

        private void enterToProcForm_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            form2 = new Form2(this);
            form2.Show();
        }
        private bool checkFillingFields()
        {
            bool isOk = true; ;
            if (typeOfComputerText.TextLength == 0) { typeOfComputerText.BackColor = Color.Red; isOk = false; }
            else { typeOfComputerText.BackColor = Color.White; }

            if (RamType.SelectedIndex < 0) { RamType.BackColor = Color.Red; isOk = false; }
            else { RamType.BackColor = Color.White; }

            if (graphCardText.TextLength == 0) { graphCardText.BackColor = Color.Red; isOk = false; }
            else { graphCardText.BackColor = Color.White; }

            if (RamType.Text.Length == 0) { RamType.BackColor = Color.Red; isOk = false; }
            else { RamType.BackColor = Color.White; }

            if (hddTypeText.TextLength == 0) { hddTypeText.BackColor = Color.Red; isOk = false; }
            else { hddTypeText.BackColor = Color.White; }

            return isOk;
        }
        private void sumButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double computerCost = rand.Next(40,200);
            double cpuCost = rand.Next(100, 400);
            double videoCost = rand.Next(150, 500);
            int ramCost = Convert.ToInt32(ramSize.Value) * 12;
            int hddCost = Convert.ToInt32(hddSizeUpDown.Value) * 3;
            if(RamType.SelectedIndex>0)
                ramCost *= RamType.SelectedIndex;
            sumTextBox.Text = (computerCost + cpuCost + videoCost + ramCost + hddCost).ToString();
        }

        private void addCompToList_Click(object sender, EventArgs e)
        {
            if (!checkFillingFields())
                return;
            CPU cpu;
            if (!StandardButton.Checked)
            {
                cpu = form2.takeCPU();
                if(ValidationCPU.Validate(cpu).Count!=0)
                {
                    printInfoTextBox.Clear();
                    foreach (var item in ValidationCPU.Validate(cpu))
                    {
                        printInfoTextBox.Text += (item + '\n');
                    }
                    return;
                }
                Computer.AddComputer(monthCalendar.TodayDate.ToString(), graphCardText.Text, Convert.ToInt32(hddSizeUpDown.Value),
                                              hddTypeText.Text, Convert.ToInt32(ramSize.Value), RamType.SelectedItem.ToString(), typeOfComputerText.Text, cpu);
            }
            else
            {
                cpu = new CPU("stdMaker", "stdSeries", 120, 4, 64, 25);
                Computer.AddComputer(monthCalendar.TodayDate.ToString(), graphCardText.Text, Convert.ToInt32(hddSizeUpDown.Value),
                                 hddTypeText.Text, Convert.ToInt32(ramSize.Value), RamType.SelectedItem.ToString(), typeOfComputerText.Text, cpu);
            }
            sizeCompLabel.Text = "Количество компьютеров в базе: " + Computer.GetAllComputers().Count;
            lastEventLabel.Text = "Добавлен компьютер";
        }

        private void PrintInfoAboutProgram()
        {
            MessageBox.Show("Version 0.2.\nСоздатель: Каминский Дмитрий");
            lastEventLabel.Text = "Выведена инфа";
        }

        private void hideToolBar_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolStrip.Visible ? false : true;
            //toolStrip.Visible = toolStrip.Enabled;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(this,Computer.GetAllComputers());
            searchForm.Show();
            lastEventLabel.Text = "Совершен поиск";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            bool sorted = false;
            bool searched = false;
            Computer.SetSearchedComputers(SearchForm.SearchComputer());
            Computer.SortedComputer = SortedForm.SortedComputer();
            if (!CheckSizeSorted())
            {
                Computer.SaveSorted();
                sorted = true;
            }
            if (!CheckSizeSearched())
            {
                Computer.SaveSearched();
                searched = true;
            }
            checkAdd(sorted, searched);
            lastEventLabel.Text = "Произошло сохранение";
        }
        private void checkAdd(bool sorted, bool searched)
        {
            if(!sorted && !searched)
            {
                MessageBox.Show("Ошибка сохранения: Отсутствуют данные для записи");
                return;
            }
            if (sorted && searched)
            {
                MessageBox.Show("Успешно сохранено");
                return;
            }
            if(sorted && !searched)
            {
                MessageBox.Show("Сохранены компьютеры после сортировки");
                return;
            }
            MessageBox.Show("Сохранены компьютеры после поиска");
        }
        private bool CheckSizeSorted() =>Computer.SortedComputer == null || Computer.SortedComputer.Count() == 0;
        private bool CheckSizeSearched() => Computer.GetSearchedComputers() == null || Computer.GetSearchedComputers().Count == 0;

        private void Show_Click(object sender, EventArgs e)
        {
            printInfoTextBox.Clear();
            Computer.SetSearchedComputers(Computer.ShowSearchedComputers());
            if (Computer.GetSearchedComputers() != null)
            {
                printInfoTextBox.Text = "____SearchedComputers:\n____";
                foreach (Computer item in Computer.GetSearchedComputers())
                {
                    printInfoTextBox.Text += item.printFromFile();
                }
            }
            if (Computer.GetSortedComputers() != null)
            {
                Computer.SetSortedComputers(Computer.ShowSortedComputers());
                printInfoTextBox.Text += "\n____SortedComputers:\n____";
                foreach (Computer item in Computer.GetSortedComputers())
                {
                    printInfoTextBox.Text += item.printFromFile();
                }
            }
            lastEventLabel.Text = "Показаны элементы из отсортированных и файлов поиска";
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            SortedForm sortedForm = new SortedForm(this, Computer.GetAllComputers());
            sortedForm.Show();
            lastEventLabel.Text = "Произошла сортировка";
        }

        private void clearAddedComputers_Click(object sender, EventArgs e)=> Computer.ClearAddedComputers(Computer.GetAllComputers());

        private void deleteOneComputer_Click(object sender, EventArgs e)=>Computer.DeleteLastComputer(Computer.GetAllComputers());

        private void stepForward_Click(object sender, EventArgs e)
        {
            printInfoTextBox.Clear();
            string str;
            if ((str = Computer.StepForward(Computer.GetAllComputers()).printFromFile()) == null)
            {
                printInfoTextBox.Text = "Невозможно совершить шаг вперед";
                return;
            }
            printInfoTextBox.Text = str;
            lastEventLabel.Text = "Шаг вперед";
        }

        private void stepBack_Click(object sender, EventArgs e)
        {
            printInfoTextBox.Clear();
            printInfoTextBox.Text = Computer.StepBack(Computer.GetAllComputers()).printFromFile();
            lastEventLabel.Text = "Шаг назад";
        }
    }
}
