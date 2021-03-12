
namespace Lab2
{
    partial class Form2
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
            this.closeButton = new System.Windows.Forms.Button();
            this.labelCreator = new System.Windows.Forms.Label();
            this.creatorText = new System.Windows.Forms.TextBox();
            this.labelSeries = new System.Windows.Forms.Label();
            this.seriesText = new System.Windows.Forms.TextBox();
            this.lableCoreSize = new System.Windows.Forms.Label();
            this.coreSizeText = new System.Windows.Forms.TextBox();
            this.labelMaxFreq = new System.Windows.Forms.Label();
            this.maxFreqText = new System.Windows.Forms.TextBox();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.capacityText = new System.Windows.Forms.TextBox();
            this.cashSizeText = new System.Windows.Forms.TextBox();
            this.labelCashSize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(123, 238);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(110, 46);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // labelCreator
            // 
            this.labelCreator.AutoSize = true;
            this.labelCreator.Location = new System.Drawing.Point(12, 21);
            this.labelCreator.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.labelCreator.Name = "labelCreator";
            this.labelCreator.Size = new System.Drawing.Size(110, 17);
            this.labelCreator.TabIndex = 1;
            this.labelCreator.Text = "Производитель";
            // 
            // creatorText
            // 
            this.creatorText.Location = new System.Drawing.Point(15, 41);
            this.creatorText.Name = "creatorText";
            this.creatorText.Size = new System.Drawing.Size(119, 22);
            this.creatorText.TabIndex = 2;
            this.creatorText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.creatorText_KeyPress);
            // 
            // labelSeries
            // 
            this.labelSeries.AutoSize = true;
            this.labelSeries.Location = new System.Drawing.Point(211, 21);
            this.labelSeries.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.labelSeries.Name = "labelSeries";
            this.labelSeries.Size = new System.Drawing.Size(49, 17);
            this.labelSeries.TabIndex = 3;
            this.labelSeries.Text = "Серия";
            // 
            // seriesText
            // 
            this.seriesText.Location = new System.Drawing.Point(214, 41);
            this.seriesText.Name = "seriesText";
            this.seriesText.Size = new System.Drawing.Size(119, 22);
            this.seriesText.TabIndex = 4;
            this.seriesText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.seriesText_KeyPress);
            // 
            // lableCoreSize
            // 
            this.lableCoreSize.AutoSize = true;
            this.lableCoreSize.Location = new System.Drawing.Point(12, 78);
            this.lableCoreSize.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.lableCoreSize.Name = "lableCoreSize";
            this.lableCoreSize.Size = new System.Drawing.Size(122, 17);
            this.lableCoreSize.TabIndex = 5;
            this.lableCoreSize.Text = "Количество ядер";
            // 
            // coreSizeText
            // 
            this.coreSizeText.BackColor = System.Drawing.SystemColors.Window;
            this.coreSizeText.Location = new System.Drawing.Point(15, 98);
            this.coreSizeText.Name = "coreSizeText";
            this.coreSizeText.Size = new System.Drawing.Size(119, 22);
            this.coreSizeText.TabIndex = 6;
            this.coreSizeText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coreSizeText_KeyPress);
            // 
            // labelMaxFreq
            // 
            this.labelMaxFreq.AutoSize = true;
            this.labelMaxFreq.Location = new System.Drawing.Point(211, 135);
            this.labelMaxFreq.Name = "labelMaxFreq";
            this.labelMaxFreq.Size = new System.Drawing.Size(94, 17);
            this.labelMaxFreq.TabIndex = 8;
            this.labelMaxFreq.Text = "MAX частота";
            // 
            // maxFreqText
            // 
            this.maxFreqText.Location = new System.Drawing.Point(214, 155);
            this.maxFreqText.Name = "maxFreqText";
            this.maxFreqText.Size = new System.Drawing.Size(119, 22);
            this.maxFreqText.TabIndex = 10;
            this.maxFreqText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coreSizeText_KeyPress);
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Location = new System.Drawing.Point(12, 135);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(93, 17);
            this.labelCapacity.TabIndex = 11;
            this.labelCapacity.Text = "Разрядность";
            // 
            // capacityText
            // 
            this.capacityText.Location = new System.Drawing.Point(15, 155);
            this.capacityText.Name = "capacityText";
            this.capacityText.Size = new System.Drawing.Size(119, 22);
            this.capacityText.TabIndex = 12;
            this.capacityText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coreSizeText_KeyPress);
            // 
            // cashSizeText
            // 
            this.cashSizeText.Location = new System.Drawing.Point(214, 98);
            this.cashSizeText.Name = "cashSizeText";
            this.cashSizeText.Size = new System.Drawing.Size(119, 22);
            this.cashSizeText.TabIndex = 13;
            this.cashSizeText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coreSizeText_KeyPress);
            // 
            // labelCashSize
            // 
            this.labelCashSize.AutoSize = true;
            this.labelCashSize.Location = new System.Drawing.Point(211, 78);
            this.labelCashSize.Name = "labelCashSize";
            this.labelCashSize.Size = new System.Drawing.Size(94, 17);
            this.labelCashSize.TabIndex = 14;
            this.labelCashSize.Text = "Размер кэша";
            this.labelCashSize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 326);
            this.ControlBox = false;
            this.Controls.Add(this.labelCashSize);
            this.Controls.Add(this.cashSizeText);
            this.Controls.Add(this.capacityText);
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.maxFreqText);
            this.Controls.Add(this.labelMaxFreq);
            this.Controls.Add(this.coreSizeText);
            this.Controls.Add(this.lableCoreSize);
            this.Controls.Add(this.seriesText);
            this.Controls.Add(this.labelSeries);
            this.Controls.Add(this.creatorText);
            this.Controls.Add(this.labelCreator);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label labelCreator;
        private System.Windows.Forms.TextBox creatorText;
        private System.Windows.Forms.Label labelSeries;
        private System.Windows.Forms.TextBox seriesText;
        private System.Windows.Forms.Label lableCoreSize;
        private System.Windows.Forms.TextBox coreSizeText;
        private System.Windows.Forms.Label labelMaxFreq;
        private System.Windows.Forms.TextBox maxFreqText;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.TextBox capacityText;
        private System.Windows.Forms.TextBox cashSizeText;
        private System.Windows.Forms.Label labelCashSize;
    }
}