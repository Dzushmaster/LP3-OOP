
namespace Lab2
{
    partial class SortedForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chooseSortBy = new System.Windows.Forms.ComboBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.partText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chooseSortBy
            // 
            this.chooseSortBy.FormattingEnabled = true;
            this.chooseSortBy.Items.AddRange(new object[] {
            "Частота работы процессора",
            "Размер ОЗУ"});
            this.chooseSortBy.Location = new System.Drawing.Point(12, 69);
            this.chooseSortBy.Name = "chooseSortBy";
            this.chooseSortBy.Size = new System.Drawing.Size(354, 24);
            this.chooseSortBy.TabIndex = 7;
            this.chooseSortBy.Text = "Сортировать по";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(249, 99);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(117, 50);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(12, 99);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(117, 50);
            this.sortButton.TabIndex = 5;
            this.sortButton.Text = "Сортировка";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // partText
            // 
            this.partText.Location = new System.Drawing.Point(12, 12);
            this.partText.Multiline = true;
            this.partText.Name = "partText";
            this.partText.Size = new System.Drawing.Size(354, 51);
            this.partText.TabIndex = 4;
            this.partText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.partText_KeyPress);
            // 
            // SortedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 161);
            this.Controls.Add(this.chooseSortBy);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.partText);
            this.Name = "SortedForm";
            this.Text = "SortedForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox chooseSortBy;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.TextBox partText;
    }
}