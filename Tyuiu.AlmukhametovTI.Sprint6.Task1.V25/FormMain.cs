using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AlmukhametovTI.Sprint6.Task1.V25.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint6.Task1.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonPushMe_ATI_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart.Text);
                int stop = Convert.ToInt32(textBoxStop.Text);

                string strLine;

                int len = ds.GetMassFunction(start, stop).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(start, stop);

                textBoxResult_ATI.Text = "";

                textBoxResult_ATI.AppendText("+----------+----------------+" + Environment.NewLine);
                textBoxResult_ATI.AppendText("+    X     +     F(x)       |" + Environment.NewLine);
                textBoxResult_ATI.AppendText("+----------+----------------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |    {1, 7:f2}     |", start, valueArray[i]);
                    textBoxResult_ATI.AppendText(strLine + Environment.NewLine);
                    start++;
                }

                textBoxResult_ATI.AppendText("+----------+----------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПБ-23-3 Альмухаметов Тимур Ильясович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
