namespace Tyuiu.AlmukhametovTI.Sprint6.Task0.V10
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
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boxvvoda = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textVarA = new System.Windows.Forms.TextBox();
            this.vivoddannix = new System.Windows.Forms.GroupBox();
            this.textBoxRezult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBoxTask.SuspendLayout();
            this.boxvvoda.SuspendLayout();
            this.vivoddannix.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.textBox1);
            this.groupBoxTask.Controls.Add(this.label4);
            this.groupBoxTask.Location = new System.Drawing.Point(12, 28);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(467, 136);
            this.groupBoxTask.TabIndex = 0;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие  ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 111);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Вычислить выражение по формуле ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "F(x)= a * x^3 + b * x^2 + c * x * 2";
            // 
            // boxvvoda
            // 
            this.boxvvoda.Controls.Add(this.label1);
            this.boxvvoda.Controls.Add(this.textVarA);
            this.boxvvoda.Location = new System.Drawing.Point(12, 190);
            this.boxvvoda.Name = "boxvvoda";
            this.boxvvoda.Size = new System.Drawing.Size(262, 96);
            this.boxvvoda.TabIndex = 3;
            this.boxvvoda.TabStop = false;
            this.boxvvoda.Text = "Ввод данных";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Переменная X";
            // 
            // textVarA
            // 
            this.textVarA.BackColor = System.Drawing.SystemColors.Menu;
            this.textVarA.Location = new System.Drawing.Point(7, 55);
            this.textVarA.Name = "textVarA";
            this.textVarA.Size = new System.Drawing.Size(100, 20);
            this.textVarA.TabIndex = 0;
            //this.textVarA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textVarA_KeyPress);
            // 
            // vivoddannix
            // 
            this.vivoddannix.Controls.Add(this.textBoxRezult);
            this.vivoddannix.Controls.Add(this.label3);
            this.vivoddannix.Location = new System.Drawing.Point(298, 190);
            this.vivoddannix.Name = "vivoddannix";
            this.vivoddannix.Size = new System.Drawing.Size(181, 96);
            this.vivoddannix.TabIndex = 4;
            this.vivoddannix.TabStop = false;
            this.vivoddannix.Text = "Вывод данных";
            // 
            // textBoxRezult
            // 
            this.textBoxRezult.Location = new System.Drawing.Point(10, 55);
            this.textBoxRezult.Name = "textBoxRezult";
            this.textBoxRezult.ReadOnly = true;
            this.textBoxRezult.Size = new System.Drawing.Size(124, 20);
            this.textBoxRezult.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Результат";
            // 
            // buttonDone
            // 
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone.Location = new System.Drawing.Point(12, 304);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(121, 43);
            this.buttonDone.TabIndex = 5;
            this.buttonDone.Text = "Выполнить ";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(185, 304);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(52, 43);
            this.buttonHelp.TabIndex = 6;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(521, 450);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.vivoddannix);
            this.Controls.Add(this.boxvvoda);
            this.Controls.Add(this.groupBoxTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 10 | Альмухаметов Т. И.";
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            this.boxvvoda.ResumeLayout(false);
            this.boxvvoda.PerformLayout();
            this.vivoddannix.ResumeLayout(false);
            this.vivoddannix.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.GroupBox boxvvoda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textVarA;
        private System.Windows.Forms.GroupBox vivoddannix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRezult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonHelp;
    }
}

