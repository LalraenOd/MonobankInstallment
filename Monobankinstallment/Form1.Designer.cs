namespace Monobankinstallment
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonCount = new System.Windows.Forms.Button();
            this.textbox_InstallSum = new System.Windows.Forms.TextBox();
            this.comboBox_InstallMonth = new System.Windows.Forms.ComboBox();
            this.richTextBox_InstallInfo = new System.Windows.Forms.RichTextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textbox_InstallPercent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCount
            // 
            this.buttonCount.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCount.Location = new System.Drawing.Point(16, 163);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(292, 35);
            this.buttonCount.TabIndex = 3;
            this.buttonCount.Text = "Рассчитать";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // textbox_InstallSum
            // 
            this.textbox_InstallSum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textbox_InstallSum.Location = new System.Drawing.Point(12, 27);
            this.textbox_InstallSum.Name = "textbox_InstallSum";
            this.textbox_InstallSum.Size = new System.Drawing.Size(144, 26);
            this.textbox_InstallSum.TabIndex = 0;
            this.textbox_InstallSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox_InstallSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_InstallSum_KeyPress);
            // 
            // comboBox_InstallMonth
            // 
            this.comboBox_InstallMonth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_InstallMonth.FormattingEnabled = true;
            this.comboBox_InstallMonth.Location = new System.Drawing.Point(227, 26);
            this.comboBox_InstallMonth.Name = "comboBox_InstallMonth";
            this.comboBox_InstallMonth.Size = new System.Drawing.Size(81, 27);
            this.comboBox_InstallMonth.TabIndex = 2;
            // 
            // richTextBox_InstallInfo
            // 
            this.richTextBox_InstallInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_InstallInfo.Location = new System.Drawing.Point(12, 61);
            this.richTextBox_InstallInfo.Name = "richTextBox_InstallInfo";
            this.richTextBox_InstallInfo.ReadOnly = true;
            this.richTextBox_InstallInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox_InstallInfo.Size = new System.Drawing.Size(296, 96);
            this.richTextBox_InstallInfo.TabIndex = 1000;
            this.richTextBox_InstallInfo.Text = "";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(12, 204);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(296, 35);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textbox_InstallPercent
            // 
            this.textbox_InstallPercent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textbox_InstallPercent.Location = new System.Drawing.Point(162, 27);
            this.textbox_InstallPercent.Name = "textbox_InstallPercent";
            this.textbox_InstallPercent.Size = new System.Drawing.Size(45, 26);
            this.textbox_InstallPercent.TabIndex = 1;
            this.textbox_InstallPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Сумма рассрочки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(176, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(233, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Месяцев";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 251);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_InstallPercent);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.richTextBox_InstallInfo);
            this.Controls.Add(this.comboBox_InstallMonth);
            this.Controls.Add(this.textbox_InstallSum);
            this.Controls.Add(this.buttonCount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Monobank™ Рассрочка by Lalraen©";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.TextBox textbox_InstallSum;
        private System.Windows.Forms.ComboBox comboBox_InstallMonth;
        private System.Windows.Forms.RichTextBox richTextBox_InstallInfo;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textbox_InstallPercent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

