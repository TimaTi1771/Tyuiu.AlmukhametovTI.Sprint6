namespace Tyuiu.AlmukhametovTI.Sprint6.Task6.V30
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.button_OpenFile_ATI = new System.Windows.Forms.Button();
            this.button_Done_ATI = new System.Windows.Forms.Button();
            this.button_Help_ATI = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxСonclusion_ATI = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxLoadFile_ATI = new System.Windows.Forms.TextBox();
            this.textBoxResult_ATI = new System.Windows.Forms.TextBox();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBoxСonclusion_ATI.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_OpenFile_ATI
            // 
            this.button_OpenFile_ATI.BackColor = System.Drawing.Color.Green;
            this.button_OpenFile_ATI.Location = new System.Drawing.Point(1, 1);
            this.button_OpenFile_ATI.Name = "button_OpenFile_ATI";
            this.button_OpenFile_ATI.Size = new System.Drawing.Size(75, 58);
            this.button_OpenFile_ATI.TabIndex = 0;
            this.button_OpenFile_ATI.Text = "Открыть файл";
            this.toolTip.SetToolTip(this.button_OpenFile_ATI, "Открыть файл\r\nВыберите нужный файл для обработки \r\n");
            this.button_OpenFile_ATI.UseVisualStyleBackColor = false;
            this.button_OpenFile_ATI.Click += new System.EventHandler(this.button_OpenFile_ATI_Click);
            // 
            // button_Done_ATI
            // 
            this.button_Done_ATI.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_Done_ATI.Location = new System.Drawing.Point(82, 1);
            this.button_Done_ATI.Name = "button_Done_ATI";
            this.button_Done_ATI.Size = new System.Drawing.Size(75, 58);
            this.button_Done_ATI.TabIndex = 1;
            this.button_Done_ATI.Text = "Выполнить ";
            this.toolTip.SetToolTip(this.button_Done_ATI, "Выполнить \r\n");
            this.button_Done_ATI.UseVisualStyleBackColor = false;
            this.button_Done_ATI.Click += new System.EventHandler(this.button_Done_ATI_Click);
            // 
            // button_Help_ATI
            // 
            this.button_Help_ATI.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Help_ATI.Location = new System.Drawing.Point(713, 1);
            this.button_Help_ATI.Name = "button_Help_ATI";
            this.button_Help_ATI.Size = new System.Drawing.Size(75, 58);
            this.button_Help_ATI.TabIndex = 2;
            this.button_Help_ATI.Text = "Справка ";
            this.toolTip.SetToolTip(this.button_Help_ATI, "Сведения о программе \r\n");
            this.button_Help_ATI.UseVisualStyleBackColor = false;
            this.button_Help_ATI.Click += new System.EventHandler(this.button_Help_ATI_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 76);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBoxСonclusion_ATI
            // 
            this.groupBoxСonclusion_ATI.Controls.Add(this.textBoxLoadFile_ATI);
            this.groupBoxСonclusion_ATI.Location = new System.Drawing.Point(13, 163);
            this.groupBoxСonclusion_ATI.Name = "groupBoxСonclusion_ATI";
            this.groupBoxСonclusion_ATI.Size = new System.Drawing.Size(393, 275);
            this.groupBoxСonclusion_ATI.TabIndex = 4;
            this.groupBoxСonclusion_ATI.TabStop = false;
            this.groupBoxСonclusion_ATI.Text = "Ввод";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxResult_ATI);
            this.groupBox3.Location = new System.Drawing.Point(412, 163);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 275);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вывод";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(768, 50);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // textBoxLoadFile_ATI
            // 
            this.textBoxLoadFile_ATI.Location = new System.Drawing.Point(7, 20);
            this.textBoxLoadFile_ATI.Multiline = true;
            this.textBoxLoadFile_ATI.Name = "textBoxLoadFile_ATI";
            this.textBoxLoadFile_ATI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLoadFile_ATI.Size = new System.Drawing.Size(380, 249);
            this.textBoxLoadFile_ATI.TabIndex = 0;
            // 
            // textBoxResult_ATI
            // 
            this.textBoxResult_ATI.Location = new System.Drawing.Point(6, 20);
            this.textBoxResult_ATI.Multiline = true;
            this.textBoxResult_ATI.Name = "textBoxResult_ATI";
            this.textBoxResult_ATI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_ATI.Size = new System.Drawing.Size(364, 249);
            this.textBoxResult_ATI.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            this.openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Подсказка ";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxСonclusion_ATI);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Help_ATI);
            this.Controls.Add(this.button_Done_ATI);
            this.Controls.Add(this.button_OpenFile_ATI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 30 | Альмухаметов Т. И.";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxСonclusion_ATI.ResumeLayout(false);
            this.groupBoxСonclusion_ATI.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_OpenFile_ATI;
        private System.Windows.Forms.Button button_Done_ATI;
        private System.Windows.Forms.Button button_Help_ATI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxСonclusion_ATI;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxLoadFile_ATI;
        private System.Windows.Forms.TextBox textBoxResult_ATI;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

