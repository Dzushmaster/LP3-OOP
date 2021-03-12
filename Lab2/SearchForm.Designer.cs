
namespace Lab2
{
    partial class SearchForm
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
            this.partText = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.chooseSearchBy = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // partText
            // 
            this.partText.Location = new System.Drawing.Point(12, 12);
            this.partText.Multiline = true;
            this.partText.Name = "partText";
            this.partText.Size = new System.Drawing.Size(354, 31);
            this.partText.TabIndex = 0;
            this.partText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.partText_KeyPress);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(12, 88);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(117, 50);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(249, 88);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(117, 50);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // chooseSearchBy
            // 
            this.chooseSearchBy.FormattingEnabled = true;
            this.chooseSearchBy.Items.AddRange(new object[] {
            "Имя компьютера",
            "Производитель процессора"});
            this.chooseSearchBy.Location = new System.Drawing.Point(12, 58);
            this.chooseSearchBy.Name = "chooseSearchBy";
            this.chooseSearchBy.Size = new System.Drawing.Size(354, 24);
            this.chooseSearchBy.TabIndex = 3;
            this.chooseSearchBy.Text = "Поиск по";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 151);
            this.Controls.Add(this.chooseSearchBy);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.partText);
            this.Name = "SearchForm";
            this.Text = "Поиск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox partText;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ComboBox chooseSearchBy;
    }
}