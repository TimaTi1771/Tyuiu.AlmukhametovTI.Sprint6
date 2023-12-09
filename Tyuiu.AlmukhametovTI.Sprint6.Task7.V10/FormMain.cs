using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AlmukhametovTI.Sprint6.Task7.V10.Lib;
using static System.Windows.Forms.LinkLabel;

namespace Tyuiu.AlmukhametovTI.Sprint6.Task7.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
            saveFileDialogMatrix.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
        }

        static string openFilePath;
        static int rows;
        static int columns;

        DataService ds = new DataService();

        // метод чтения данных из файла 

        public int[,] LoadFromFileData(string path)
        {
            string fileData = File.ReadAllText(path);

            // Разделение на строки 

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Определяем количество строк и столбцов

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            // Выделите массив данных
            int[,] arrayValue = new int[rows, columns];

            // Заполняем массив данными 

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValue[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return arrayValue;
        }

        private void button_Help_ATI_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }      

        private void button_OpenFile_ATI_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;

            // Выделите массив данных

            int[,] arrayValue = new int[rows, columns];

            arrayValue = LoadFromFileData(openFilePath);

            dataGridViewInMatrix_ATI.RowCount = rows;
            dataGridViewInMatrix_ATI.ColumnCount = columns;
            dataGridViewOutMatrix_ATI.RowCount = rows;
            dataGridViewOutMatrix_ATI.ColumnCount = columns;

            // Задаём ширину столбцов dataGridViewInMatrix_ATI

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInMatrix_ATI.Columns[i].Width = 50;
                dataGridViewOutMatrix_ATI.Columns[i].Width = 50;
            }

            // Добавьте данные в dataGridViewInMatrix_ATI

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInMatrix_ATI.Rows[r].Cells[c].Value = arrayValue[r, c];
                }
            }
            arrayValue = ds.GetMatrix(LoadFromFileData(openFilePath));
            button_Done_ATI.Enabled = true;
        }

        private void button_Done_ATI_Click(object sender, EventArgs e)
        {
            // Выделите массив данных
            int[,] arrayValue = new int[rows, columns];
            arrayValue = ds.GetMatrix(LoadFromFileData(openFilePath));

            // Добавьте данные в  dataGridViewOutMatrix_ATI
            for( int r = 0; r < rows; r++)
            {
                for( int c = 0; c < columns; c++)
                {
                    dataGridViewOutMatrix_ATI.Rows[r].Cells[c].Value = arrayValue[r, c];
                }
            }
            button_Save_ATI.Enabled = true;
        }

        private void button_Save_ATI_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix.ShowDialog();

            string path = saveFileDialogMatrix.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutMatrix_ATI.RowCount; // количество строк
            int columns = dataGridViewOutMatrix_ATI.ColumnCount; // количество столбцов

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutMatrix_ATI.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutMatrix_ATI.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void button_Done_ATI_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Выполнить";
        }

        private void button_OpenFile_ATI_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Открыть файл";
        }

        private void button_Save_ATI_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Сохранить в файл";
        }

        private void button_Help_ATI_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Справка";
        }

       
    }
}
