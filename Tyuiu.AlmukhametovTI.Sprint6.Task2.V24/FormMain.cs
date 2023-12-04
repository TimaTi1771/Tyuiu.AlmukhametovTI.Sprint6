using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AlmukhametovTI.Sprint6.Task2.V24.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint6.Task2.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart.Text);
                int stop = Convert.ToInt32(textBoxStop.Text);

                int len = ds.GetMassFunction(start, stop).Length;
                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(start, stop);

                this.charFunction.Titles.Add("График функции F(x)");

                this.charFunction.ChartAreas[0].AxisX.Title = "Ось X";
                this.charFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.DataGridViewFunction.Rows.Add(Convert.ToString(start), Convert.ToString(valueArray[i]));

                    this.charFunction.Series[0].Points.AddXY(start, valueArray[i]);
                    start++;
                }
            }       
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.White;
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПБ-23-3 Альмухаметов Тимур Ильясович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

    
    

