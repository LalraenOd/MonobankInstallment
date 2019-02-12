using System;
using System.Windows.Forms;

namespace Monobankinstallment
{
    public partial class Form1 : Form
    {
        int startMonth = 3;
        int endMonth = 24;

        public Form1()
        {
            InitializeComponent();
            textbox_InstallPercent.Text = "1,9";

            for (int i = startMonth; i <= endMonth; i++)
            {
                comboBox_InstallMonth.Items.Add(i);
            }
            comboBox_InstallMonth.SelectedIndex = 0;
        }

        private void PrintInfo(int installSum, double installSumPerMonth, double installFinalSum, double installOverPayment)
        {
            richTextBox_InstallInfo.Text = string.Format(
                "Сумма рассрочки:\t\t{0} грн.\n" +
                "Сумма выплаты в месяц:\t{1} грн.\n" +
                "Сумма переплаты:\t\t{2} грн.\n" +
                "Общая сумма:\t\t\t{3} грн.",
                installSum, Math.Round(installSumPerMonth, 2), Math.Round(installOverPayment, 2), Math.Round(installFinalSum, 2));
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            var installSum = Int32.Parse(textbox_InstallSum.Text);
            if (installSum < 1000)
                MessageBox.Show("Сумма должна быть больше 1000!");

            var installPercent = Double.Parse(textbox_InstallPercent.Text) / 100;
            var installDuration = Int32.Parse(comboBox_InstallMonth.Text);

            var installSumPerMonth = (installSum / installDuration) + (installSum * installPercent);
            var installFinalSum = installSumPerMonth * installDuration;
            var installOverPayment = installFinalSum - installSum;

            PrintInfo(installSum, installSumPerMonth, installFinalSum, installOverPayment);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textbox_InstallSum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                buttonCount_Click(sender, e);
            }
        }
    }
}
