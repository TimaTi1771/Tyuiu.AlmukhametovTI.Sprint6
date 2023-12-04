namespace Tyuiu.AlmukhametovTI.Sprint6.Task0.V10
{
    partial class Form1
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
            this.BoxUslovie = new System.Windows.Forms.GroupBox();
            this.boxvvoda = new System.Windows.Forms.GroupBox();
            this.textvvoda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vivoddannix = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rezult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.Button();
            this.BoxUslovie.SuspendLayout();
            this.boxvvoda.SuspendLayout();
            this.vivoddannix.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoxUslovie
            // 
            this.BoxUslovie.Controls.Add(this.label4);
            this.BoxUslovie.Controls.Add(this.label2);
            this.BoxUslovie.Location = new System.Drawing.Point(12, 28);
            this.BoxUslovie.Name = "BoxUslovie";
            this.BoxUslovie.Size = new System.Drawing.Size(467, 136);
            this.BoxUslovie.TabIndex = 0;
            this.BoxUslovie.TabStop = false;
            this.BoxUslovie.Text = "Условие  ";
            // 
            // boxvvoda
            // 
            this.boxvvoda.Controls.Add(this.label1);
            this.boxvvoda.Controls.Add(this.textvvoda);
            this.boxvvoda.Location = new System.Drawing.Point(12, 190);
            this.boxvvoda.Name = "boxvvoda";
            this.boxvvoda.Size = new System.Drawing.Size(262, 96);
            this.boxvvoda.TabIndex = 3;
            this.boxvvoda.TabStop = false;
            this.boxvvoda.Text = "Ввод данных";
            // 
            // textvvoda
            // 
            this.textvvoda.BackColor = System.Drawing.SystemColors.Menu;
            this.textvvoda.Location = new System.Drawing.Point(7, 55);
            this.textvvoda.Name = "textvvoda";
            this.textvvoda.Size = new System.Drawing.Size(100, 20);
            this.textvvoda.TabIndex = 0;
            this.textvvoda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textvvoda_KeyPress);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вычислить выражение по формуле";
            // 
            // vivoddannix
            // 
            this.vivoddannix.Controls.Add(this.rezult);
            this.vivoddannix.Controls.Add(this.label3);
            this.vivoddannix.Location = new System.Drawing.Point(298, 190);
            this.vivoddannix.Name = "vivoddannix";
            this.vivoddannix.Size = new System.Drawing.Size(181, 96);
            this.vivoddannix.TabIndex = 4;
            this.vivoddannix.TabStop = false;
            this.vivoddannix.Text = "Вывод данных";
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
            // rezult
            // 
            this.rezult.Location = new System.Drawing.Point(10, 55);
            this.rezult.Name = "rezult";
            this.rezult.ReadOnly = true;
            this.rezult.Size = new System.Drawing.Size(124, 20);
            this.rezult.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "F(x)= a * x^3 + b * x^2 + c * x * 2";
            // 
            // textBoxResult
            // 
            this.textBoxResult.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.Location = new System.Drawing.Point(25, 317);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(121, 43);
            this.textBoxResult.TabIndex = 5;
            this.textBoxResult.Text = "Выполнить ";
            this.textBoxResult.UseVisualStyleBackColor = true;
            this.textBoxResult.Click += new System.EventHandler(this.knopka_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.vivoddannix);
            this.Controls.Add(this.boxvvoda);
            this.Controls.Add(this.BoxUslovie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 10 | Альмухаметов Т. И.";
            this.BoxUslovie.ResumeLayout(false);
            this.BoxUslovie.PerformLayout();
            this.boxvvoda.ResumeLayout(false);
            this.boxvvoda.PerformLayout();
            this.vivoddannix.ResumeLayout(false);
            this.vivoddannix.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BoxUslovie;
        private System.Windows.Forms.GroupBox boxvvoda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textvvoda;
        private System.Windows.Forms.GroupBox vivoddannix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rezult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button textBoxResult;
    }
}

