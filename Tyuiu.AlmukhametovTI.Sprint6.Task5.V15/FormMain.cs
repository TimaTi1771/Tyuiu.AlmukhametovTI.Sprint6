using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AlmukhametovTI.Sprint6.Task5.V15.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint6.Task5.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutFileTask5V15.txt";

        private void button_Done_ATI_Click(object sender, EventArgs e)
        {
            dataGridView_ATI.ColumnCount = 2;
            dataGridView_ATI.Columns[0].Width = 20;
            dataGridView_ATI.Columns[1].Width = 50;

            this.chart_grafic_ATI.ChartAreas[0].AxisX.Title = "Ось X";
            this.chart_grafic_ATI.ChartAreas[0].AxisY.Title = "Ось Y";

            chart_grafic_ATI.Series[0].Points.Clear();

            double[] numArray = new double[ds.len];
            numArray = ds.LoadFromDataFile(path);
            for (int i = 0; i < numArray.Length; i++)
            {
                dataGridView_ATI.Rows.Add(Convert.ToString(i), Convert.ToString(numArray[i]));
                chart_grafic_ATI.Series[0].Points.AddXY(i, numArray[i]);
            }


        }

        private void button_Open_ATI_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void button_Help_ATI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5  выполнил студент группы ИИПБ-23-3 Альмухаметов Тимур Ильясович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
