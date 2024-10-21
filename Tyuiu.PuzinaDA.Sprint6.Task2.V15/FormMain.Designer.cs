namespace Tyuiu.PuzinaDA.Sprint6.Task2.V15
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            dataGridViewResult_PDA = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            fx = new DataGridViewTextBoxColumn();
            buttonDown_PDA = new Button();
            buttonQuestion_PDA = new Button();
            textBoxSV_PDA = new TextBox();
            textBoxStV_PDA = new TextBox();
            textBoxStartValue_PDA = new TextBox();
            textBoxStopValue_PDA = new TextBox();
            textBoxCondition_PDA = new TextBox();
            textBoxCond_PDA = new TextBox();
            textBoxRes_PDA = new TextBox();
            textBoxInPut_PDA = new TextBox();
            textBoxOutPut_PDA = new TextBox();
            pictureBoxFormula_PDA = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_PDA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_PDA).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewResult_PDA
            // 
            dataGridViewResult_PDA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_PDA.Columns.AddRange(new DataGridViewColumn[] { X, fx });
            dataGridViewResult_PDA.Location = new Point(611, 37);
            dataGridViewResult_PDA.Name = "dataGridViewResult_PDA";
            dataGridViewResult_PDA.ReadOnly = true;
            dataGridViewResult_PDA.RowHeadersVisible = false;
            dataGridViewResult_PDA.RowHeadersWidth = 51;
            dataGridViewResult_PDA.Size = new Size(177, 401);
            dataGridViewResult_PDA.TabIndex = 0;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 50;
            // 
            // fx
            // 
            fx.HeaderText = "f(x)";
            fx.MinimumWidth = 6;
            fx.Name = "fx";
            fx.ReadOnly = true;
            fx.Width = 125;
            // 
            // buttonDown_PDA
            // 
            buttonDown_PDA.BackColor = SystemColors.Info;
            buttonDown_PDA.Location = new Point(408, 333);
            buttonDown_PDA.Name = "buttonDown_PDA";
            buttonDown_PDA.Size = new Size(197, 105);
            buttonDown_PDA.TabIndex = 1;
            buttonDown_PDA.Text = "Вычислить";
            buttonDown_PDA.UseVisualStyleBackColor = false;
            buttonDown_PDA.Click += buttonDown_PDA_Click;
            // 
            // buttonQuestion_PDA
            // 
            buttonQuestion_PDA.BackColor = SystemColors.ActiveCaption;
            buttonQuestion_PDA.Location = new Point(319, 368);
            buttonQuestion_PDA.Name = "buttonQuestion_PDA";
            buttonQuestion_PDA.Size = new Size(83, 70);
            buttonQuestion_PDA.TabIndex = 2;
            buttonQuestion_PDA.Text = "Справка";
            buttonQuestion_PDA.UseVisualStyleBackColor = false;
            buttonQuestion_PDA.Click += buttonQuestion_PDA_Click;
            // 
            // textBoxSV_PDA
            // 
            textBoxSV_PDA.BackColor = SystemColors.Control;
            textBoxSV_PDA.BorderStyle = BorderStyle.None;
            textBoxSV_PDA.Location = new Point(12, 372);
            textBoxSV_PDA.Name = "textBoxSV_PDA";
            textBoxSV_PDA.ReadOnly = true;
            textBoxSV_PDA.Size = new Size(125, 20);
            textBoxSV_PDA.TabIndex = 3;
            textBoxSV_PDA.Text = "Начало шага:";
            // 
            // textBoxStV_PDA
            // 
            textBoxStV_PDA.BackColor = SystemColors.Control;
            textBoxStV_PDA.BorderStyle = BorderStyle.None;
            textBoxStV_PDA.Location = new Point(159, 372);
            textBoxStV_PDA.Name = "textBoxStV_PDA";
            textBoxStV_PDA.ReadOnly = true;
            textBoxStV_PDA.Size = new Size(125, 20);
            textBoxStV_PDA.TabIndex = 4;
            textBoxStV_PDA.Text = "Конец шага:";
            // 
            // textBoxStartValue_PDA
            // 
            textBoxStartValue_PDA.Location = new Point(12, 411);
            textBoxStartValue_PDA.Name = "textBoxStartValue_PDA";
            textBoxStartValue_PDA.Size = new Size(125, 27);
            textBoxStartValue_PDA.TabIndex = 5;
            // 
            // textBoxStopValue_PDA
            // 
            textBoxStopValue_PDA.Location = new Point(159, 411);
            textBoxStopValue_PDA.Name = "textBoxStopValue_PDA";
            textBoxStopValue_PDA.Size = new Size(125, 27);
            textBoxStopValue_PDA.TabIndex = 6;
            // 
            // textBoxCondition_PDA
            // 
            textBoxCondition_PDA.BackColor = SystemColors.Control;
            textBoxCondition_PDA.BorderStyle = BorderStyle.None;
            textBoxCondition_PDA.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxCondition_PDA.Location = new Point(12, 37);
            textBoxCondition_PDA.Multiline = true;
            textBoxCondition_PDA.Name = "textBoxCondition_PDA";
            textBoxCondition_PDA.ReadOnly = true;
            textBoxCondition_PDA.Size = new Size(404, 259);
            textBoxCondition_PDA.TabIndex = 7;
            textBoxCondition_PDA.Text = "Написать программу, которая выводит таблицу значений функции на заданном диапазоне:";
            // 
            // textBoxCond_PDA
            // 
            textBoxCond_PDA.BackColor = SystemColors.Control;
            textBoxCond_PDA.BorderStyle = BorderStyle.None;
            textBoxCond_PDA.Location = new Point(12, 11);
            textBoxCond_PDA.Name = "textBoxCond_PDA";
            textBoxCond_PDA.ReadOnly = true;
            textBoxCond_PDA.Size = new Size(183, 20);
            textBoxCond_PDA.TabIndex = 8;
            textBoxCond_PDA.Text = "Условие";
            // 
            // textBoxRes_PDA
            // 
            textBoxRes_PDA.BackColor = SystemColors.Control;
            textBoxRes_PDA.BorderStyle = BorderStyle.None;
            textBoxRes_PDA.Location = new Point(611, 7);
            textBoxRes_PDA.Name = "textBoxRes_PDA";
            textBoxRes_PDA.ReadOnly = true;
            textBoxRes_PDA.Size = new Size(177, 20);
            textBoxRes_PDA.TabIndex = 9;
            textBoxRes_PDA.Text = "Результат";
            // 
            // textBoxInPut_PDA
            // 
            textBoxInPut_PDA.BackColor = SystemColors.Control;
            textBoxInPut_PDA.BorderStyle = BorderStyle.None;
            textBoxInPut_PDA.Location = new Point(12, 311);
            textBoxInPut_PDA.Name = "textBoxInPut_PDA";
            textBoxInPut_PDA.ReadOnly = true;
            textBoxInPut_PDA.Size = new Size(125, 20);
            textBoxInPut_PDA.TabIndex = 10;
            textBoxInPut_PDA.Text = "Ввод данных:";
            // 
            // textBoxOutPut_PDA
            // 
            textBoxOutPut_PDA.BackColor = SystemColors.Control;
            textBoxOutPut_PDA.BorderStyle = BorderStyle.None;
            textBoxOutPut_PDA.Location = new Point(480, 7);
            textBoxOutPut_PDA.Name = "textBoxOutPut_PDA";
            textBoxOutPut_PDA.ReadOnly = true;
            textBoxOutPut_PDA.Size = new Size(125, 20);
            textBoxOutPut_PDA.TabIndex = 11;
            textBoxOutPut_PDA.Text = "Вывод данных:";
            // 
            // pictureBoxFormula_PDA
            // 
            pictureBoxFormula_PDA.Image = (Image)resources.GetObject("pictureBoxFormula_PDA.Image");
            pictureBoxFormula_PDA.Location = new Point(12, 116);
            pictureBoxFormula_PDA.Name = "pictureBoxFormula_PDA";
            pictureBoxFormula_PDA.Size = new Size(358, 47);
            pictureBoxFormula_PDA.TabIndex = 12;
            pictureBoxFormula_PDA.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxFormula_PDA);
            Controls.Add(textBoxOutPut_PDA);
            Controls.Add(textBoxInPut_PDA);
            Controls.Add(textBoxRes_PDA);
            Controls.Add(textBoxCond_PDA);
            Controls.Add(textBoxCondition_PDA);
            Controls.Add(textBoxStopValue_PDA);
            Controls.Add(textBoxStartValue_PDA);
            Controls.Add(textBoxStV_PDA);
            Controls.Add(textBoxSV_PDA);
            Controls.Add(buttonQuestion_PDA);
            Controls.Add(buttonDown_PDA);
            Controls.Add(dataGridViewResult_PDA);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 15 | Пузина Д. А.";
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_PDA).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_PDA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewResult_PDA;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn fx;
        private Button buttonDown_PDA;
        private Button buttonQuestion_PDA;
        private TextBox textBoxSV_PDA;
        private TextBox textBoxStV_PDA;
        private TextBox textBoxStartValue_PDA;
        private TextBox textBoxStopValue_PDA;
        private TextBox textBoxCondition_PDA;
        private TextBox textBoxCond_PDA;
        private TextBox textBoxRes_PDA;
        private TextBox textBoxInPut_PDA;
        private TextBox textBoxOutPut_PDA;
        private PictureBox pictureBoxFormula_PDA;
    }
}
