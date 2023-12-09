using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AlmukhametovTI.Sprint6.Task6.V30.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint6.Task6.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;
        private void button_Done_ATI_Click(object sender, EventArgs e)
        {
            string str = "";
            textBoxResult_ATI.Text = ds.CollectTextFromFile(str,openFilePath);
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
            textBoxLoadFile_ATI.Text = File.ReadAllText(openFilePath);
            groupBoxСonclusion_ATI.Text = groupBoxСonclusion_ATI.Text + " " + openFileDialogTask.FileName;
            button_Done_ATI.Enabled = true;
        }
    }
}
