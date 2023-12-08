namespace Tyuiu.AlmukhametovTI.Sprint6.Task3.V12
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatixTask_ATI = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDone_ATI = new System.Windows.Forms.Button();
            this.buttonSpravka_ATI = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewMatrixNew_ATI = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatixTask_ATI)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixNew_ATI)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewMatixTask_ATI);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условие";
            // 
            // dataGridViewMatixTask_ATI
            // 
            this.dataGridViewMatixTask_ATI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatixTask_ATI.ColumnHeadersVisible = false;
            this.dataGridViewMatixTask_ATI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewMatixTask_ATI.Location = new System.Drawing.Point(246, 19);
            this.dataGridViewMatixTask_ATI.Name = "dataGridViewMatixTask_ATI";
            this.dataGridViewMatixTask_ATI.RowHeadersVisible = false;
            this.dataGridViewMatixTask_ATI.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewMatixTask_ATI.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(190, 127);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Дана матрица 5 на 5 элементов\r\n-6 -13 -1 -7 10\r\n14 -18 18 1 11\r\n-2 -17 -15 -10 -8" +
    "\r\n19 -4 -6 -11 8\r\n-17 17 14 13 19\r\nЗаменить чётные значения в первой\r\nстроке на " +
    "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewMatrixNew_ATI);
            this.groupBox2.Controls.Add(this.buttonDone_ATI);
            this.groupBox2.Controls.Add(this.buttonSpravka_ATI);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(575, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вывод данных";
            // 
            // buttonDone_ATI
            // 
            this.buttonDone_ATI.Location = new System.Drawing.Point(97, 218);
            this.buttonDone_ATI.Name = "buttonDone_ATI";
            this.buttonDone_ATI.Size = new System.Drawing.Size(97, 43);
            this.buttonDone_ATI.TabIndex = 3;
            this.buttonDone_ATI.Text = "Выполнить";
            this.buttonDone_ATI.UseVisualStyleBackColor = true;
            this.buttonDone_ATI.Click += new System.EventHandler(this.buttonDone_ATI_Click);
            // 
            // buttonSpravka_ATI
            // 
            this.buttonSpravka_ATI.Location = new System.Drawing.Point(10, 218);
            this.buttonSpravka_ATI.Name = "buttonSpravka_ATI";
            this.buttonSpravka_ATI.Size = new System.Drawing.Size(59, 43);
            this.buttonSpravka_ATI.TabIndex = 2;
            this.buttonSpravka_ATI.Text = "?";
            this.buttonSpravka_ATI.UseVisualStyleBackColor = true;
            this.buttonSpravka_ATI.Click += new System.EventHandler(this.buttonSpravka_ATI_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Результат:";
            // 
            // dataGridViewMatrixNew_ATI
            // 
            this.dataGridViewMatrixNew_ATI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrixNew_ATI.ColumnHeadersVisible = false;
            this.dataGridViewMatrixNew_ATI.Location = new System.Drawing.Point(10, 49);
            this.dataGridViewMatrixNew_ATI.Name = "dataGridViewMatrixNew_ATI";
            this.dataGridViewMatrixNew_ATI.RowHeadersVisible = false;
            this.dataGridViewMatrixNew_ATI.Size = new System.Drawing.Size(184, 163);
            this.dataGridViewMatrixNew_ATI.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 40;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 40;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 294);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 3 | Вариант 12 | Альмухаметов Т. И.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatixTask_ATI)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixNew_ATI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDone_ATI;
        private System.Windows.Forms.Button buttonSpravka_ATI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewMatixTask_ATI;
        private System.Windows.Forms.DataGridView dataGridViewMatrixNew_ATI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

