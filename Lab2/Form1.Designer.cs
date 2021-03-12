namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.typeOfComputer = new System.Windows.Forms.Label();
            this.typeOfComputerText = new System.Windows.Forms.TextBox();
            this.graphCardLable = new System.Windows.Forms.Label();
            this.graphCardText = new System.Windows.Forms.TextBox();
            this.OZUSizeLabel = new System.Windows.Forms.Label();
            this.ramSize = new System.Windows.Forms.NumericUpDown();
            this.OZUTypeLabel = new System.Windows.Forms.Label();
            this.hddSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.hddSizeLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chooseAnotherProc = new System.Windows.Forms.RadioButton();
            this.StandardButton = new System.Windows.Forms.RadioButton();
            this.procLabel = new System.Windows.Forms.Label();
            this.RamType = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.sumButton = new System.Windows.Forms.Button();
            this.printInfoTextBox = new System.Windows.Forms.TextBox();
            this.unseriallizeTextButton = new System.Windows.Forms.Button();
            this.serializeInfoButton = new System.Windows.Forms.Button();
            this.enterToProcForm = new System.Windows.Forms.Button();
            this.hddTypeLabel = new System.Windows.Forms.Label();
            this.hddTypeText = new System.Windows.Forms.TextBox();
            this.addCompToList = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Search = new System.Windows.Forms.ToolStripMenuItem();
            this.Sort = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Show_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolBar = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.searchButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripButton();
            this.clearAddedComputers = new System.Windows.Forms.ToolStripButton();
            this.deleteOneComputer = new System.Windows.Forms.ToolStripButton();
            this.stepForward = new System.Windows.Forms.ToolStripButton();
            this.stepBack = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ramSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hddSizeUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // typeOfComputer
            // 
            this.typeOfComputer.AutoSize = true;
            this.typeOfComputer.Location = new System.Drawing.Point(11, 44);
            this.typeOfComputer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeOfComputer.Name = "typeOfComputer";
            this.typeOfComputer.Size = new System.Drawing.Size(117, 17);
            this.typeOfComputer.TabIndex = 0;
            this.typeOfComputer.Text = "Тип компьютера";
            // 
            // typeOfComputerText
            // 
            this.typeOfComputerText.Location = new System.Drawing.Point(14, 66);
            this.typeOfComputerText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeOfComputerText.Multiline = true;
            this.typeOfComputerText.Name = "typeOfComputerText";
            this.typeOfComputerText.Size = new System.Drawing.Size(160, 22);
            this.typeOfComputerText.TabIndex = 1;
            this.typeOfComputerText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.typeOfComputerText_KeyPress);
            // 
            // graphCardLable
            // 
            this.graphCardLable.AutoSize = true;
            this.graphCardLable.Location = new System.Drawing.Point(11, 96);
            this.graphCardLable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.graphCardLable.Name = "graphCardLable";
            this.graphCardLable.Size = new System.Drawing.Size(87, 17);
            this.graphCardLable.TabIndex = 2;
            this.graphCardLable.Text = "Видеокарта";
            // 
            // graphCardText
            // 
            this.graphCardText.Location = new System.Drawing.Point(14, 119);
            this.graphCardText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.graphCardText.Multiline = true;
            this.graphCardText.Name = "graphCardText";
            this.graphCardText.Size = new System.Drawing.Size(160, 22);
            this.graphCardText.TabIndex = 3;
            this.graphCardText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.typeOfComputerText_KeyPress);
            // 
            // OZUSizeLabel
            // 
            this.OZUSizeLabel.AutoSize = true;
            this.OZUSizeLabel.Location = new System.Drawing.Point(11, 148);
            this.OZUSizeLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OZUSizeLabel.Name = "OZUSizeLabel";
            this.OZUSizeLabel.Size = new System.Drawing.Size(117, 17);
            this.OZUSizeLabel.TabIndex = 4;
            this.OZUSizeLabel.Text = "Размер ОЗУ(ГБ)";
            // 
            // ramSize
            // 
            this.ramSize.Location = new System.Drawing.Point(14, 171);
            this.ramSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ramSize.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.ramSize.Name = "ramSize";
            this.ramSize.Size = new System.Drawing.Size(160, 22);
            this.ramSize.TabIndex = 6;
            // 
            // OZUTypeLabel
            // 
            this.OZUTypeLabel.AutoSize = true;
            this.OZUTypeLabel.Location = new System.Drawing.Point(11, 199);
            this.OZUTypeLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OZUTypeLabel.Name = "OZUTypeLabel";
            this.OZUTypeLabel.Size = new System.Drawing.Size(66, 17);
            this.OZUTypeLabel.TabIndex = 7;
            this.OZUTypeLabel.Text = "Тип ОЗУ";
            // 
            // hddSizeUpDown
            // 
            this.hddSizeUpDown.Location = new System.Drawing.Point(14, 274);
            this.hddSizeUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hddSizeUpDown.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.hddSizeUpDown.Name = "hddSizeUpDown";
            this.hddSizeUpDown.Size = new System.Drawing.Size(160, 22);
            this.hddSizeUpDown.TabIndex = 10;
            // 
            // hddSizeLabel
            // 
            this.hddSizeLabel.AutoSize = true;
            this.hddSizeLabel.Location = new System.Drawing.Point(11, 251);
            this.hddSizeLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hddSizeLabel.Name = "hddSizeLabel";
            this.hddSizeLabel.Size = new System.Drawing.Size(162, 17);
            this.hddSizeLabel.TabIndex = 9;
            this.hddSizeLabel.Text = "Размер жесткого диска";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(11, 402);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(99, 17);
            this.DateLabel.TabIndex = 11;
            this.DateLabel.Text = "Дата покупки";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(14, 430);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chooseAnotherProc);
            this.panel1.Controls.Add(this.StandardButton);
            this.panel1.Location = new System.Drawing.Point(288, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 55);
            this.panel1.TabIndex = 13;
            // 
            // chooseAnotherProc
            // 
            this.chooseAnotherProc.AutoSize = true;
            this.chooseAnotherProc.Location = new System.Drawing.Point(3, 30);
            this.chooseAnotherProc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chooseAnotherProc.Name = "chooseAnotherProc";
            this.chooseAnotherProc.Size = new System.Drawing.Size(134, 21);
            this.chooseAnotherProc.TabIndex = 1;
            this.chooseAnotherProc.Text = "Выбрать другой";
            this.chooseAnotherProc.UseVisualStyleBackColor = true;
            this.chooseAnotherProc.CheckedChanged += new System.EventHandler(this.StandardButton_CheckedChanged);
            // 
            // StandardButton
            // 
            this.StandardButton.AutoSize = true;
            this.StandardButton.Checked = true;
            this.StandardButton.Location = new System.Drawing.Point(3, 2);
            this.StandardButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StandardButton.Name = "StandardButton";
            this.StandardButton.Size = new System.Drawing.Size(118, 21);
            this.StandardButton.TabIndex = 0;
            this.StandardButton.TabStop = true;
            this.StandardButton.Text = "Стандартный";
            this.StandardButton.UseVisualStyleBackColor = true;
            this.StandardButton.CheckedChanged += new System.EventHandler(this.StandardButton_CheckedChanged);
            // 
            // procLabel
            // 
            this.procLabel.AutoSize = true;
            this.procLabel.Location = new System.Drawing.Point(284, 44);
            this.procLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.procLabel.Name = "procLabel";
            this.procLabel.Size = new System.Drawing.Size(80, 17);
            this.procLabel.TabIndex = 14;
            this.procLabel.Text = "Процессор";
            // 
            // RamType
            // 
            this.RamType.FormattingEnabled = true;
            this.RamType.Items.AddRange(new object[] {
            "U-DIMM",
            "R-DIMM",
            "TL-DIMM",
            "PB-DIMM"});
            this.RamType.Location = new System.Drawing.Point(14, 220);
            this.RamType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RamType.Name = "RamType";
            this.RamType.Size = new System.Drawing.Size(159, 24);
            this.RamType.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(357, 414);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 223);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // sumTextBox
            // 
            this.sumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumTextBox.Location = new System.Drawing.Point(357, 367);
            this.sumTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sumTextBox.Multiline = true;
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.ReadOnly = true;
            this.sumTextBox.Size = new System.Drawing.Size(304, 38);
            this.sumTextBox.TabIndex = 18;
            // 
            // sumButton
            // 
            this.sumButton.Location = new System.Drawing.Point(357, 325);
            this.sumButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(304, 34);
            this.sumButton.TabIndex = 19;
            this.sumButton.Text = "Стоимость";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click);
            // 
            // printInfoTextBox
            // 
            this.printInfoTextBox.Location = new System.Drawing.Point(700, 148);
            this.printInfoTextBox.Margin = new System.Windows.Forms.Padding(11, 2, 3, 2);
            this.printInfoTextBox.MaxLength = 60000;
            this.printInfoTextBox.Multiline = true;
            this.printInfoTextBox.Name = "printInfoTextBox";
            this.printInfoTextBox.ReadOnly = true;
            this.printInfoTextBox.Size = new System.Drawing.Size(304, 489);
            this.printInfoTextBox.TabIndex = 20;
            // 
            // unseriallizeTextButton
            // 
            this.unseriallizeTextButton.Location = new System.Drawing.Point(700, 105);
            this.unseriallizeTextButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.unseriallizeTextButton.Name = "unseriallizeTextButton";
            this.unseriallizeTextButton.Size = new System.Drawing.Size(304, 37);
            this.unseriallizeTextButton.TabIndex = 21;
            this.unseriallizeTextButton.Text = "Прочитать";
            this.unseriallizeTextButton.UseVisualStyleBackColor = true;
            this.unseriallizeTextButton.Click += new System.EventHandler(this.unseriallizeTextButton_Click);
            // 
            // serializeInfoButton
            // 
            this.serializeInfoButton.Location = new System.Drawing.Point(700, 62);
            this.serializeInfoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serializeInfoButton.Name = "serializeInfoButton";
            this.serializeInfoButton.Size = new System.Drawing.Size(304, 37);
            this.serializeInfoButton.TabIndex = 22;
            this.serializeInfoButton.Text = "Записать";
            this.serializeInfoButton.UseVisualStyleBackColor = true;
            this.serializeInfoButton.Click += new System.EventHandler(this.serializeInfoButton_Click);
            // 
            // enterToProcForm
            // 
            this.enterToProcForm.Location = new System.Drawing.Point(287, 122);
            this.enterToProcForm.Name = "enterToProcForm";
            this.enterToProcForm.Size = new System.Drawing.Size(148, 24);
            this.enterToProcForm.TabIndex = 23;
            this.enterToProcForm.Text = "Выбрать процессор";
            this.enterToProcForm.UseVisualStyleBackColor = true;
            this.enterToProcForm.Click += new System.EventHandler(this.enterToProcForm_Click);
            // 
            // hddTypeLabel
            // 
            this.hddTypeLabel.AutoSize = true;
            this.hddTypeLabel.Location = new System.Drawing.Point(11, 308);
            this.hddTypeLabel.Name = "hddTypeLabel";
            this.hddTypeLabel.Size = new System.Drawing.Size(138, 17);
            this.hddTypeLabel.TabIndex = 24;
            this.hddTypeLabel.Text = "Тип жесткого диска";
            // 
            // hddTypeText
            // 
            this.hddTypeText.Location = new System.Drawing.Point(14, 328);
            this.hddTypeText.Multiline = true;
            this.hddTypeText.Name = "hddTypeText";
            this.hddTypeText.Size = new System.Drawing.Size(160, 24);
            this.hddTypeText.TabIndex = 25;
            this.hddTypeText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hddTypeText_KeyPress);
            // 
            // addCompToList
            // 
            this.addCompToList.Location = new System.Drawing.Point(357, 274);
            this.addCompToList.Name = "addCompToList";
            this.addCompToList.Size = new System.Drawing.Size(304, 35);
            this.addCompToList.TabIndex = 26;
            this.addCompToList.Text = "Добавить компьютер";
            this.addCompToList.UseVisualStyleBackColor = true;
            this.addCompToList.Click += new System.EventHandler(this.addCompToList_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Search,
            this.Sort,
            this.Save,
            this.Show_Menu,
            this.hideToolBar,
            this.AboutProgram});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1017, 28);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Search
            // 
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(66, 26);
            this.Search.Text = "Поиск";
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Sort
            // 
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(128, 26);
            this.Sort.Text = "Сортировка по";
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(97, 26);
            this.Save.Text = "Сохранить";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Show_Menu
            // 
            this.Show_Menu.Name = "Show_Menu";
            this.Show_Menu.Size = new System.Drawing.Size(87, 26);
            this.Show_Menu.Text = "Показать";
            this.Show_Menu.Click += new System.EventHandler(this.Show_Click);
            // 
            // hideToolBar
            // 
            this.hideToolBar.Name = "hideToolBar";
            this.hideToolBar.Size = new System.Drawing.Size(229, 26);
            this.hideToolBar.Text = "Скрыть панель инструментов";
            this.hideToolBar.Click += new System.EventHandler(this.hideToolBar_Click);
            // 
            // AboutProgram
            // 
            this.AboutProgram.Name = "AboutProgram";
            this.AboutProgram.Size = new System.Drawing.Size(118, 26);
            this.AboutProgram.Text = "О программе";
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchButton,
            this.toolStripLabel1,
            this.clearAddedComputers,
            this.deleteOneComputer,
            this.stepForward,
            this.stepBack});
            this.toolStrip.Location = new System.Drawing.Point(0, 28);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1017, 27);
            this.toolStrip.TabIndex = 28;
            this.toolStrip.Text = "toolStrip1";
            // 
            // searchButton
            // 
            this.searchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(57, 28);
            this.searchButton.Text = "Search";
            this.searchButton.ToolTipText = "Search";
            this.searchButton.Click += new System.EventHandler(this.Search_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(48, 28);
            this.toolStripLabel1.Text = "Sorte";
            this.toolStripLabel1.Click += new System.EventHandler(this.Sort_Click);
            // 
            // clearAddedComputers
            // 
            this.clearAddedComputers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.clearAddedComputers.Image = ((System.Drawing.Image)(resources.GetObject("clearAddedComputers.Image")));
            this.clearAddedComputers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearAddedComputers.Name = "clearAddedComputers";
            this.clearAddedComputers.Size = new System.Drawing.Size(168, 28);
            this.clearAddedComputers.Text = "Clear added computers";
            this.clearAddedComputers.Click += new System.EventHandler(this.clearAddedComputers_Click);
            // 
            // deleteOneComputer
            // 
            this.deleteOneComputer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteOneComputer.Image = ((System.Drawing.Image)(resources.GetObject("deleteOneComputer.Image")));
            this.deleteOneComputer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteOneComputer.Name = "deleteOneComputer";
            this.deleteOneComputer.Size = new System.Drawing.Size(154, 28);
            this.deleteOneComputer.Text = "Delete one computer";
            this.deleteOneComputer.Click += new System.EventHandler(this.deleteOneComputer_Click);
            // 
            // stepForward
            // 
            this.stepForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stepForward.Image = ((System.Drawing.Image)(resources.GetObject("stepForward.Image")));
            this.stepForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stepForward.Name = "stepForward";
            this.stepForward.Size = new System.Drawing.Size(67, 28);
            this.stepForward.Text = "Forward";
            this.stepForward.Click += new System.EventHandler(this.stepForward_Click);
            // 
            // stepBack
            // 
            this.stepBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stepBack.Image = ((System.Drawing.Image)(resources.GetObject("stepBack.Image")));
            this.stepBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stepBack.Name = "stepBack";
            this.stepBack.Size = new System.Drawing.Size(44, 24);
            this.stepBack.Text = "Back";
            this.stepBack.Click += new System.EventHandler(this.stepBack_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 629);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1017, 26);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(67, 20);
            this.toolStripStatusLabel1.Text = "toolStrip";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 655);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.addCompToList);
            this.Controls.Add(this.hddTypeText);
            this.Controls.Add(this.hddTypeLabel);
            this.Controls.Add(this.enterToProcForm);
            this.Controls.Add(this.serializeInfoButton);
            this.Controls.Add(this.unseriallizeTextButton);
            this.Controls.Add(this.printInfoTextBox);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.sumTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RamType);
            this.Controls.Add(this.procLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.hddSizeUpDown);
            this.Controls.Add(this.hddSizeLabel);
            this.Controls.Add(this.OZUTypeLabel);
            this.Controls.Add(this.ramSize);
            this.Controls.Add(this.OZUSizeLabel);
            this.Controls.Add(this.graphCardText);
            this.Controls.Add(this.graphCardLable);
            this.Controls.Add(this.typeOfComputerText);
            this.Controls.Add(this.typeOfComputer);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ramSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hddSizeUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label typeOfComputer;
        private System.Windows.Forms.TextBox typeOfComputerText;
        private System.Windows.Forms.Label graphCardLable;
        private System.Windows.Forms.TextBox graphCardText;
        private System.Windows.Forms.Label OZUSizeLabel;
        private System.Windows.Forms.NumericUpDown ramSize;
        private System.Windows.Forms.Label OZUTypeLabel;
        private System.Windows.Forms.NumericUpDown hddSizeUpDown;
        private System.Windows.Forms.Label hddSizeLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton StandardButton;
        private System.Windows.Forms.RadioButton chooseAnotherProc;
        private System.Windows.Forms.Label procLabel;
        private System.Windows.Forms.ComboBox RamType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox sumTextBox;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.TextBox printInfoTextBox;
        private System.Windows.Forms.Button unseriallizeTextButton;
        private System.Windows.Forms.Button serializeInfoButton;
        private System.Windows.Forms.Button enterToProcForm;
        private System.Windows.Forms.Label hddTypeLabel;
        private System.Windows.Forms.TextBox hddTypeText;
        private System.Windows.Forms.Button addCompToList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Search;
        private System.Windows.Forms.ToolStripMenuItem Sort;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem AboutProgram;
        private System.Windows.Forms.ToolStripMenuItem hideToolBar;
        private System.Windows.Forms.ToolStripMenuItem Show_Menu;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton searchButton;
        private System.Windows.Forms.ToolStripButton toolStripLabel1;
        private System.Windows.Forms.ToolStripButton clearAddedComputers;
        private System.Windows.Forms.ToolStripButton deleteOneComputer;
        private System.Windows.Forms.ToolStripButton stepForward;
        private System.Windows.Forms.ToolStripButton stepBack;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

