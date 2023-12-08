namespace Tyuiu.AlmukhametovTI.Sprint6.Task4.V2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_stop_ATI = new System.Windows.Forms.TextBox();
            this.textBox_start_ATI = new System.Windows.Forms.TextBox();
            this.button_Done_ATI = new System.Windows.Forms.Button();
            this.button_Save_ATI = new System.Windows.Forms.Button();
            this.button_Spravka_ATI = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.chart_grafic_ATI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_grafic_ATI)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условие";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(355, 71);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox_stop_ATI);
            this.groupBox2.Controls.Add(this.textBox_start_ATI);
            this.groupBox2.Location = new System.Drawing.Point(396, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 101);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ввод данных";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Конец шага";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Старт шага";
            // 
            // textBox_stop_ATI
            // 
            this.textBox_stop_ATI.Location = new System.Drawing.Point(154, 42);
            this.textBox_stop_ATI.Name = "textBox_stop_ATI";
            this.textBox_stop_ATI.Size = new System.Drawing.Size(100, 20);
            this.textBox_stop_ATI.TabIndex = 1;
            // 
            // textBox_start_ATI
            // 
            this.textBox_start_ATI.Location = new System.Drawing.Point(15, 42);
            this.textBox_start_ATI.Name = "textBox_start_ATI";
            this.textBox_start_ATI.Size = new System.Drawing.Size(100, 20);
            this.textBox_start_ATI.TabIndex = 0;
            // 
            // button_Done_ATI
            // 
            this.button_Done_ATI.BackColor = System.Drawing.Color.DarkGreen;
            this.button_Done_ATI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Done_ATI.Location = new System.Drawing.Point(688, 22);
            this.button_Done_ATI.Name = "button_Done_ATI";
            this.button_Done_ATI.Size = new System.Drawing.Size(75, 82);
            this.button_Done_ATI.TabIndex = 2;
            this.button_Done_ATI.Text = "Выполнить";
            this.button_Done_ATI.UseVisualStyleBackColor = false;
            this.button_Done_ATI.Click += new System.EventHandler(this.button_Done_ATI_Click);
            // 
            // button_Save_ATI
            // 
            this.button_Save_ATI.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Save_ATI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Save_ATI.Location = new System.Drawing.Point(688, 138);
            this.button_Save_ATI.Name = "button_Save_ATI";
            this.button_Save_ATI.Size = new System.Drawing.Size(76, 82);
            this.button_Save_ATI.TabIndex = 3;
            this.button_Save_ATI.Text = "Сохранить";
            this.button_Save_ATI.UseVisualStyleBackColor = false;
            this.button_Save_ATI.Click += new System.EventHandler(this.button_Save_ATI_Click);
            // 
            // button_Spravka_ATI
            // 
            this.button_Spravka_ATI.BackColor = System.Drawing.Color.Cyan;
            this.button_Spravka_ATI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Spravka_ATI.Location = new System.Drawing.Point(689, 247);
            this.button_Spravka_ATI.Name = "button_Spravka_ATI";
            this.button_Spravka_ATI.Size = new System.Drawing.Size(75, 82);
            this.button_Spravka_ATI.TabIndex = 4;
            this.button_Spravka_ATI.Text = "Справка ";
            this.button_Spravka_ATI.UseVisualStyleBackColor = false;
            this.button_Spravka_ATI.Click += new System.EventHandler(this.button_Spravka_ATI_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_Result);
            this.groupBox3.Location = new System.Drawing.Point(13, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(208, 339);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вывод";
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(6, 19);
            this.textBox_Result.Multiline = true;
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Result.Size = new System.Drawing.Size(185, 314);
            this.textBox_Result.TabIndex = 0;
            // 
            // chart_grafic_ATI
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_grafic_ATI.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_grafic_ATI.Legends.Add(legend3);
            this.chart_grafic_ATI.Location = new System.Drawing.Point(227, 150);
            this.chart_grafic_ATI.Name = "chart_grafic_ATI";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart_grafic_ATI.Series.Add(series3);
            this.chart_grafic_ATI.Size = new System.Drawing.Size(438, 302);
            this.chart_grafic_ATI.TabIndex = 6;
            this.chart_grafic_ATI.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(383, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "График функции F(x)";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 470);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart_grafic_ATI);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_Spravka_ATI);
            this.Controls.Add(this.button_Save_ATI);
            this.Controls.Add(this.button_Done_ATI);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(808, 509);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 2 | Альмухаметов Т. И.";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_grafic_ATI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_stop_ATI;
        private System.Windows.Forms.TextBox textBox_start_ATI;
        private System.Windows.Forms.Button button_Done_ATI;
        private System.Windows.Forms.Button button_Save_ATI;
        private System.Windows.Forms.Button button_Spravka_ATI;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_grafic_ATI;
        private System.Windows.Forms.Label label3;
    }
}

