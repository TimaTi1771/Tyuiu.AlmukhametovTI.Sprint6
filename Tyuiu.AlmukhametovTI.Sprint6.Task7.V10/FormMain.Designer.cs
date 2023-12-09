namespace Tyuiu.AlmukhametovTI.Sprint6.Task7.V10
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_Help_ATI = new System.Windows.Forms.Button();
            this.button_Save_ATI = new System.Windows.Forms.Button();
            this.button_OpenFile_ATI = new System.Windows.Forms.Button();
            this.button_Done_ATI = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewInMatrix_ATI = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutMatrix_ATI = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix = new System.Windows.Forms.SaveFileDialog();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix_ATI)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix_ATI)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1270, 100);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_Help_ATI);
            this.groupBox3.Controls.Add(this.button_Save_ATI);
            this.groupBox3.Controls.Add(this.button_OpenFile_ATI);
            this.groupBox3.Controls.Add(this.button_Done_ATI);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1270, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Условие";
            // 
            // button_Help_ATI
            // 
            this.button_Help_ATI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Help_ATI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Help_ATI.BackgroundImage")));
            this.button_Help_ATI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Help_ATI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Help_ATI.Location = new System.Drawing.Point(1183, 20);
            this.button_Help_ATI.Name = "button_Help_ATI";
            this.button_Help_ATI.Size = new System.Drawing.Size(75, 74);
            this.button_Help_ATI.TabIndex = 4;
            this.toolTipButton.SetToolTip(this.button_Help_ATI, "Справка ");
            this.button_Help_ATI.UseVisualStyleBackColor = true;
            this.button_Help_ATI.Click += new System.EventHandler(this.button_Help_ATI_Click);
            this.button_Help_ATI.MouseEnter += new System.EventHandler(this.button_Help_ATI_MouseEnter);
            // 
            // button_Save_ATI
            // 
            this.button_Save_ATI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Save_ATI.BackgroundImage")));
            this.button_Save_ATI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Save_ATI.Enabled = false;
            this.button_Save_ATI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save_ATI.Location = new System.Drawing.Point(680, 19);
            this.button_Save_ATI.Name = "button_Save_ATI";
            this.button_Save_ATI.Size = new System.Drawing.Size(75, 74);
            this.button_Save_ATI.TabIndex = 3;
            this.toolTipButton.SetToolTip(this.button_Save_ATI, "Сохранить файл");
            this.button_Save_ATI.UseVisualStyleBackColor = true;
            this.button_Save_ATI.Click += new System.EventHandler(this.button_Save_ATI_Click);
            this.button_Save_ATI.MouseEnter += new System.EventHandler(this.button_Save_ATI_MouseEnter);
            // 
            // button_OpenFile_ATI
            // 
            this.button_OpenFile_ATI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_OpenFile_ATI.BackgroundImage")));
            this.button_OpenFile_ATI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_OpenFile_ATI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OpenFile_ATI.Location = new System.Drawing.Point(585, 19);
            this.button_OpenFile_ATI.Name = "button_OpenFile_ATI";
            this.button_OpenFile_ATI.Size = new System.Drawing.Size(75, 74);
            this.button_OpenFile_ATI.TabIndex = 2;
            this.toolTipButton.SetToolTip(this.button_OpenFile_ATI, "Открыть файл");
            this.button_OpenFile_ATI.UseVisualStyleBackColor = true;
            this.button_OpenFile_ATI.Click += new System.EventHandler(this.button_OpenFile_ATI_Click);
            this.button_OpenFile_ATI.MouseEnter += new System.EventHandler(this.button_OpenFile_ATI_MouseEnter);
            // 
            // button_Done_ATI
            // 
            this.button_Done_ATI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Done_ATI.BackgroundImage")));
            this.button_Done_ATI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Done_ATI.Enabled = false;
            this.button_Done_ATI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Done_ATI.Location = new System.Drawing.Point(495, 19);
            this.button_Done_ATI.Name = "button_Done_ATI";
            this.button_Done_ATI.Size = new System.Drawing.Size(75, 74);
            this.button_Done_ATI.TabIndex = 1;
            this.toolTipButton.SetToolTip(this.button_Done_ATI, "Выполнить");
            this.button_Done_ATI.UseVisualStyleBackColor = true;
            this.button_Done_ATI.Click += new System.EventHandler(this.button_Done_ATI_Click);
            this.button_Done_ATI.MouseEnter += new System.EventHandler(this.button_Done_ATI_MouseEnter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(458, 77);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 377);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewInMatrix_ATI);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(591, 377);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод:";
            // 
            // dataGridViewInMatrix_ATI
            // 
            this.dataGridViewInMatrix_ATI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInMatrix_ATI.ColumnHeadersVisible = false;
            this.dataGridViewInMatrix_ATI.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewInMatrix_ATI.Location = new System.Drawing.Point(2, 15);
            this.dataGridViewInMatrix_ATI.Name = "dataGridViewInMatrix_ATI";
            this.dataGridViewInMatrix_ATI.RowHeadersVisible = false;
            this.dataGridViewInMatrix_ATI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewInMatrix_ATI.Size = new System.Drawing.Size(584, 360);
            this.dataGridViewInMatrix_ATI.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.splitter2);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(600, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(670, 377);
            this.panel3.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewOutMatrix_ATI);
            this.groupBox2.Location = new System.Drawing.Point(9, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(655, 378);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вывод";
            // 
            // dataGridViewOutMatrix_ATI
            // 
            this.dataGridViewOutMatrix_ATI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutMatrix_ATI.ColumnHeadersVisible = false;
            this.dataGridViewOutMatrix_ATI.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewOutMatrix_ATI.Location = new System.Drawing.Point(0, 15);
            this.dataGridViewOutMatrix_ATI.Name = "dataGridViewOutMatrix_ATI";
            this.dataGridViewOutMatrix_ATI.RowHeadersVisible = false;
            this.dataGridViewOutMatrix_ATI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOutMatrix_ATI.Size = new System.Drawing.Size(653, 361);
            this.dataGridViewOutMatrix_ATI.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            this.openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTipButton
            // 
            this.toolTipButton.IsBalloon = true;
            this.toolTipButton.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton.ToolTipTitle = "Подсказка ";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 377);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Padding = new System.Windows.Forms.Padding(5);
            this.splitter2.Size = new System.Drawing.Size(3, 377);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 477);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | вариант  10 | Альмухаметов Т. И.";
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix_ATI)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix_ATI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Help_ATI;
        private System.Windows.Forms.Button button_Save_ATI;
        private System.Windows.Forms.Button button_OpenFile_ATI;
        private System.Windows.Forms.Button button_Done_ATI;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridViewInMatrix_ATI;
        private System.Windows.Forms.DataGridView dataGridViewOutMatrix_ATI;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.ToolTip toolTipButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
    }
}

