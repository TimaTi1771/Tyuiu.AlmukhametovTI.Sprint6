using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AlmukhametovTI.Sprint6.Task0.V10.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint6.Task0.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }                                                                          
        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxRezult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textVarA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }                                                                                                 

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИИПб-23-3 Альмухаметов Тимур Ильясович", "Сообщение");
        }
    }
}
