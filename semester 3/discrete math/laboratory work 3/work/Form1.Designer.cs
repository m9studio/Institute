﻿
namespace lab3dis
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
            this.ButtonFile = new System.Windows.Forms.Button();
            this.LabelFrom = new System.Windows.Forms.Label();
            this.TextBoxFrom = new System.Windows.Forms.TextBox();
            this.TextBoxTo = new System.Windows.Forms.TextBox();
            this.LabelTo = new System.Windows.Forms.Label();
            this.LabelTracer = new System.Windows.Forms.Label();
            this.ButtonTracer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonFile
            // 
            this.ButtonFile.Location = new System.Drawing.Point(12, 12);
            this.ButtonFile.Name = "ButtonFile";
            this.ButtonFile.Size = new System.Drawing.Size(75, 23);
            this.ButtonFile.TabIndex = 0;
            this.ButtonFile.Text = "Файл";
            this.ButtonFile.UseVisualStyleBackColor = true;
            this.ButtonFile.Click += new System.EventHandler(this.ButtonFile_Click);
            // 
            // LabelFrom
            // 
            this.LabelFrom.AutoSize = true;
            this.LabelFrom.Location = new System.Drawing.Point(66, 44);
            this.LabelFrom.Name = "LabelFrom";
            this.LabelFrom.Size = new System.Drawing.Size(21, 13);
            this.LabelFrom.TabIndex = 1;
            this.LabelFrom.Text = "Из";
            // 
            // TextBoxFrom
            // 
            this.TextBoxFrom.Location = new System.Drawing.Point(105, 41);
            this.TextBoxFrom.Name = "TextBoxFrom";
            this.TextBoxFrom.Size = new System.Drawing.Size(100, 20);
            this.TextBoxFrom.TabIndex = 2;
            // 
            // TextBoxTo
            // 
            this.TextBoxTo.Location = new System.Drawing.Point(105, 78);
            this.TextBoxTo.Name = "TextBoxTo";
            this.TextBoxTo.Size = new System.Drawing.Size(100, 20);
            this.TextBoxTo.TabIndex = 3;
            // 
            // LabelTo
            // 
            this.LabelTo.AutoSize = true;
            this.LabelTo.Location = new System.Drawing.Point(73, 81);
            this.LabelTo.Name = "LabelTo";
            this.LabelTo.Size = new System.Drawing.Size(14, 13);
            this.LabelTo.TabIndex = 4;
            this.LabelTo.Text = "В";
            // 
            // LabelTracer
            // 
            this.LabelTracer.AutoSize = true;
            this.LabelTracer.Location = new System.Drawing.Point(102, 118);
            this.LabelTracer.Name = "LabelTracer";
            this.LabelTracer.Size = new System.Drawing.Size(31, 13);
            this.LabelTracer.TabIndex = 5;
            this.LabelTracer.Text = "Путь";
            // 
            // ButtonTracer
            // 
            this.ButtonTracer.Location = new System.Drawing.Point(105, 12);
            this.ButtonTracer.Name = "ButtonTracer";
            this.ButtonTracer.Size = new System.Drawing.Size(75, 23);
            this.ButtonTracer.TabIndex = 6;
            this.ButtonTracer.Text = "Путь";
            this.ButtonTracer.UseVisualStyleBackColor = true;
            this.ButtonTracer.Click += new System.EventHandler(this.ButtonTracer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 175);
            this.Controls.Add(this.ButtonTracer);
            this.Controls.Add(this.LabelTracer);
            this.Controls.Add(this.LabelTo);
            this.Controls.Add(this.TextBoxTo);
            this.Controls.Add(this.TextBoxFrom);
            this.Controls.Add(this.LabelFrom);
            this.Controls.Add(this.ButtonFile);
            this.MaximumSize = new System.Drawing.Size(363, 214);
            this.MinimumSize = new System.Drawing.Size(363, 214);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonFile;
        private System.Windows.Forms.Label LabelFrom;
        private System.Windows.Forms.TextBox TextBoxFrom;
        private System.Windows.Forms.TextBox TextBoxTo;
        private System.Windows.Forms.Label LabelTo;
        private System.Windows.Forms.Label LabelTracer;
        private System.Windows.Forms.Button ButtonTracer;
    }
}

