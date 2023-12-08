using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AlmukhametovTI.Sprint6.Task3.V12.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint6.Task3.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = new int[5, 5]  { {-6,-13,-1,-7,10},
                                            {14,-18,18,1,11},
                                            {-2,-17,-15,-10,-8},
                                            {19,-4,-6,-11,8},
                                            {-17,17,14,13,19}};


        private void buttonDone_ATI_Click(object sender, EventArgs e)
        {
            int[,] array = ds.Calculate(matrix);
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            dataGridViewMatrixNew_ATI.ColumnCount = columns;
            dataGridViewMatrixNew_ATI.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrixNew_ATI.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrixNew_ATI.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            dataGridViewMatixTask_ATI.ColumnCount = columns;
            dataGridViewMatixTask_ATI.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatixTask_ATI.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatixTask_ATI.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }
        private void buttonSpravka_ATI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИИПБ-23-3 Альмухаметов Тимур Ильясович ", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
    }
}



