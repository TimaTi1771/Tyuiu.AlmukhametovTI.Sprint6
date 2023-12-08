namespace Tyuiu.AlmukhametovTI.Sprint6.Task5.V15
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chart_grafic_ATI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_Done_ATI = new System.Windows.Forms.Button();
            this.button_Open_ATI = new System.Windows.Forms.Button();
            this.button_Help_ATI = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_ATI = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_grafic_ATI)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ATI)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условие";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(381, 33);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Прочитать данные из файла InPutFileTask5.txt. Вывести в dstaGringWiew\r\nчисла от 2" +
    " до 7 и построить диаграмму по этим значениям.";
            // 
            // chart_grafic_ATI
            // 
            chartArea6.Name = "ChartArea1";
            this.chart_grafic_ATI.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart_grafic_ATI.Legends.Add(legend6);
            this.chart_grafic_ATI.Location = new System.Drawing.Point(246, 120);
            this.chart_grafic_ATI.Name = "chart_grafic_ATI";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart_grafic_ATI.Series.Add(series6);
            this.chart_grafic_ATI.Size = new System.Drawing.Size(392, 300);
            this.chart_grafic_ATI.TabIndex = 1;
            this.chart_grafic_ATI.Text = "chart1";
            // 
            // button_Done_ATI
            // 
            this.button_Done_ATI.BackColor = System.Drawing.Color.Green;
            this.button_Done_ATI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Done_ATI.Location = new System.Drawing.Point(455, 12);
            this.button_Done_ATI.Name = "button_Done_ATI";
            this.button_Done_ATI.Size = new System.Drawing.Size(75, 64);
            this.button_Done_ATI.TabIndex = 2;
            this.button_Done_ATI.Text = "Выполнить";
            this.button_Done_ATI.UseVisualStyleBackColor = false;
            this.button_Done_ATI.Click += new System.EventHandler(this.button_Done_ATI_Click);
            // 
            // button_Open_ATI
            // 
            this.button_Open_ATI.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_Open_ATI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Open_ATI.Location = new System.Drawing.Point(563, 12);
            this.button_Open_ATI.Name = "button_Open_ATI";
            this.button_Open_ATI.Size = new System.Drawing.Size(75, 64);
            this.button_Open_ATI.TabIndex = 3;
            this.button_Open_ATI.Text = "Открыть файл";
            this.button_Open_ATI.UseVisualStyleBackColor = false;
            this.button_Open_ATI.Click += new System.EventHandler(this.button_Open_ATI_Click);
            // 
            // button_Help_ATI
            // 
            this.button_Help_ATI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_Help_ATI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Help_ATI.Location = new System.Drawing.Point(674, 12);
            this.button_Help_ATI.Name = "button_Help_ATI";
            this.button_Help_ATI.Size = new System.Drawing.Size(75, 64);
            this.button_Help_ATI.TabIndex = 4;
            this.button_Help_ATI.Text = "Справка ";
            this.button_Help_ATI.UseVisualStyleBackColor = false;
            this.button_Help_ATI.Click += new System.EventHandler(this.button_Help_ATI_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_ATI);
            this.groupBox2.Location = new System.Drawing.Point(19, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 324);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вывод данны:";
            // 
            // dataGridView_ATI
            // 
            this.dataGridView_ATI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ATI.ColumnHeadersVisible = false;
            this.dataGridView_ATI.Location = new System.Drawing.Point(7, 19);
            this.dataGridView_ATI.Name = "dataGridView_ATI";
            this.dataGridView_ATI.RowHeadersVisible = false;
            this.dataGridView_ATI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_ATI.Size = new System.Drawing.Size(187, 298);
            this.dataGridView_ATI.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_Help_ATI);
            this.Controls.Add(this.button_Open_ATI);
            this.Controls.Add(this.button_Done_ATI);
            this.Controls.Add(this.chart_grafic_ATI);
            this.Controls.Add(this.groupBox1);
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 15 | Альмухаметов Т.И.";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_grafic_ATI)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ATI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_grafic_ATI;
        private System.Windows.Forms.Button button_Done_ATI;
        private System.Windows.Forms.Button button_Open_ATI;
        private System.Windows.Forms.Button button_Help_ATI;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_ATI;
    }
}

