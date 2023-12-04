namespace Tyuiu.AlmukhametovTI.Sprint6.Task1.V25
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
            this.BoxTask = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Box77 = new System.Windows.Forms.GroupBox();
            this.textBoxStop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonPushMe_ATI = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxResult_ATI = new System.Windows.Forms.TextBox();
            this.BoxTask.SuspendLayout();
            this.Box77.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoxTask
            // 
            this.BoxTask.Controls.Add(this.textBox1);
            this.BoxTask.Location = new System.Drawing.Point(12, 12);
            this.BoxTask.Name = "BoxTask";
            this.BoxTask.Size = new System.Drawing.Size(515, 196);
            this.BoxTask.TabIndex = 0;
            this.BoxTask.TabStop = false;
            this.BoxTask.Text = "Условие";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(491, 157);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Протабулировать функцию F(x) на заданном диапазоне.\r\nРезультат вывести в виде таб" +
    "лицы.";
            // 
            // Box77
            // 
            this.Box77.Controls.Add(this.textBoxStop);
            this.Box77.Controls.Add(this.label2);
            this.Box77.Controls.Add(this.label1);
            this.Box77.Controls.Add(this.textBoxStart);
            this.Box77.Location = new System.Drawing.Point(18, 214);
            this.Box77.Name = "Box77";
            this.Box77.Size = new System.Drawing.Size(312, 85);
            this.Box77.TabIndex = 1;
            this.Box77.TabStop = false;
            this.Box77.Text = "Ввод данных";
            // 
            // textBoxStop
            // 
            this.textBoxStop.Location = new System.Drawing.Point(180, 39);
            this.textBoxStop.Name = "textBoxStop";
            this.textBoxStop.Size = new System.Drawing.Size(100, 20);
            this.textBoxStop.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Конец шага:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Старт шага:";
            // 
            // textBoxStart
            // 
            this.textBoxStart.Location = new System.Drawing.Point(6, 39);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart.TabIndex = 0;
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonHelp.Location = new System.Drawing.Point(345, 214);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(74, 85);
            this.buttonHelp.TabIndex = 2;
            this.buttonHelp.Text = "Справка ";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonPushMe_ATI
            // 
            this.buttonPushMe_ATI.BackColor = System.Drawing.Color.Green;
            this.buttonPushMe_ATI.Location = new System.Drawing.Point(425, 214);
            this.buttonPushMe_ATI.Name = "buttonPushMe_ATI";
            this.buttonPushMe_ATI.Size = new System.Drawing.Size(102, 85);
            this.buttonPushMe_ATI.TabIndex = 3;
            this.buttonPushMe_ATI.Text = "Выполнить";
            this.buttonPushMe_ATI.UseVisualStyleBackColor = false;
            this.buttonPushMe_ATI.Click += new System.EventHandler(this.buttonPushMe_ATI_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxResult_ATI);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(533, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 287);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вывод данных";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Результат";
            // 
            // textBoxResult_ATI
            // 
            this.textBoxResult_ATI.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_ATI.Location = new System.Drawing.Point(10, 35);
            this.textBoxResult_ATI.Multiline = true;
            this.textBoxResult_ATI.Name = "textBoxResult_ATI";
            this.textBoxResult_ATI.ReadOnly = true;
            this.textBoxResult_ATI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_ATI.Size = new System.Drawing.Size(239, 246);
            this.textBoxResult_ATI.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 327);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonPushMe_ATI);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.Box77);
            this.Controls.Add(this.BoxTask);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 1 | Вариант 25 | Альмухаметов Т. И.";
            this.BoxTask.ResumeLayout(false);
            this.BoxTask.PerformLayout();
            this.Box77.ResumeLayout(false);
            this.Box77.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BoxTask;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox Box77;
        private System.Windows.Forms.TextBox textBoxStop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonPushMe_ATI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxResult_ATI;
    }
}

