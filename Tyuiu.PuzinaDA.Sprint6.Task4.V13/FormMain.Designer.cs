namespace Tyuiu.PuzinaDA.Sprint6.Task4.V13
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonSave_PDA = new Button();
            buttonDown_PDA = new Button();
            buttonQuestion_PDA = new Button();
            panelCond_PDA = new Panel();
            groupBoxCond_PDA = new GroupBox();
            pictureBoxFormula_PDA = new PictureBox();
            textBoxCondition_PDA = new TextBox();
            panelInPut_PDA = new Panel();
            groupBox1 = new GroupBox();
            textBoxStopValue_PDA = new TextBox();
            textBoxStartValue_PDA = new TextBox();
            textBoxSpV_PDA = new TextBox();
            textBoxSV_PDA = new TextBox();
            panelOutPut_PDA = new Panel();
            splitter1 = new Splitter();
            groupBoxOutPut_PDA = new GroupBox();
            textBoxResult_PDA = new TextBox();
            panelCond_PDA.SuspendLayout();
            groupBoxCond_PDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_PDA).BeginInit();
            panelInPut_PDA.SuspendLayout();
            groupBox1.SuspendLayout();
            panelOutPut_PDA.SuspendLayout();
            groupBoxOutPut_PDA.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSave_PDA
            // 
            buttonSave_PDA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSave_PDA.BackColor = Color.MistyRose;
            buttonSave_PDA.Location = new Point(681, 16);
            buttonSave_PDA.Name = "buttonSave_PDA";
            buttonSave_PDA.Size = new Size(99, 91);
            buttonSave_PDA.TabIndex = 3;
            buttonSave_PDA.Text = "Сохранить";
            buttonSave_PDA.UseVisualStyleBackColor = false;
            buttonSave_PDA.Click += buttonSave_PDA_Click;
            // 
            // buttonDown_PDA
            // 
            buttonDown_PDA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDown_PDA.BackColor = SystemColors.ActiveCaption;
            buttonDown_PDA.Location = new Point(567, 12);
            buttonDown_PDA.Name = "buttonDown_PDA";
            buttonDown_PDA.Size = new Size(108, 104);
            buttonDown_PDA.TabIndex = 2;
            buttonDown_PDA.Text = "Вывести";
            buttonDown_PDA.UseVisualStyleBackColor = false;
            buttonDown_PDA.Click += buttonDown_PDA_Click;
            // 
            // buttonQuestion_PDA
            // 
            buttonQuestion_PDA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonQuestion_PDA.BackColor = SystemColors.Info;
            buttonQuestion_PDA.Location = new Point(475, 23);
            buttonQuestion_PDA.Name = "buttonQuestion_PDA";
            buttonQuestion_PDA.Size = new Size(85, 82);
            buttonQuestion_PDA.TabIndex = 1;
            buttonQuestion_PDA.Text = "Справка";
            buttonQuestion_PDA.UseVisualStyleBackColor = false;
            buttonQuestion_PDA.Click += buttonQuestion_PDA_Click;
            // 
            // panelCond_PDA
            // 
            panelCond_PDA.Controls.Add(buttonSave_PDA);
            panelCond_PDA.Controls.Add(buttonQuestion_PDA);
            panelCond_PDA.Controls.Add(buttonDown_PDA);
            panelCond_PDA.Controls.Add(groupBoxCond_PDA);
            panelCond_PDA.Dock = DockStyle.Top;
            panelCond_PDA.Location = new Point(0, 0);
            panelCond_PDA.Name = "panelCond_PDA";
            panelCond_PDA.Size = new Size(792, 130);
            panelCond_PDA.TabIndex = 14;
            // 
            // groupBoxCond_PDA
            // 
            groupBoxCond_PDA.Controls.Add(pictureBoxFormula_PDA);
            groupBoxCond_PDA.Controls.Add(textBoxCondition_PDA);
            groupBoxCond_PDA.Location = new Point(0, 0);
            groupBoxCond_PDA.Name = "groupBoxCond_PDA";
            groupBoxCond_PDA.Size = new Size(469, 130);
            groupBoxCond_PDA.TabIndex = 0;
            groupBoxCond_PDA.TabStop = false;
            groupBoxCond_PDA.Text = "Условие";
            // 
            // pictureBoxFormula_PDA
            // 
            pictureBoxFormula_PDA.Image = (Image)resources.GetObject("pictureBoxFormula_PDA.Image");
            pictureBoxFormula_PDA.Location = new Point(7, 75);
            pictureBoxFormula_PDA.Name = "pictureBoxFormula_PDA";
            pictureBoxFormula_PDA.Size = new Size(273, 49);
            pictureBoxFormula_PDA.TabIndex = 1;
            pictureBoxFormula_PDA.TabStop = false;
            // 
            // textBoxCondition_PDA
            // 
            textBoxCondition_PDA.BackColor = SystemColors.Control;
            textBoxCondition_PDA.Dock = DockStyle.Fill;
            textBoxCondition_PDA.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxCondition_PDA.Location = new Point(3, 23);
            textBoxCondition_PDA.Multiline = true;
            textBoxCondition_PDA.Name = "textBoxCondition_PDA";
            textBoxCondition_PDA.ReadOnly = true;
            textBoxCondition_PDA.Size = new Size(463, 104);
            textBoxCondition_PDA.TabIndex = 0;
            textBoxCondition_PDA.Text = "Написать программу, которая выводит таблицу значений функции f(x) на заданном диапазоне  [-5; 5]";
            // 
            // panelInPut_PDA
            // 
            panelInPut_PDA.Controls.Add(groupBox1);
            panelInPut_PDA.Dock = DockStyle.Left;
            panelInPut_PDA.Location = new Point(0, 130);
            panelInPut_PDA.Name = "panelInPut_PDA";
            panelInPut_PDA.Size = new Size(361, 303);
            panelInPut_PDA.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxStopValue_PDA);
            groupBox1.Controls.Add(textBoxStartValue_PDA);
            groupBox1.Controls.Add(textBoxSpV_PDA);
            groupBox1.Controls.Add(textBoxSV_PDA);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(361, 303);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод данных:";
            // 
            // textBoxStopValue_PDA
            // 
            textBoxStopValue_PDA.Location = new Point(198, 101);
            textBoxStopValue_PDA.Name = "textBoxStopValue_PDA";
            textBoxStopValue_PDA.Size = new Size(148, 27);
            textBoxStopValue_PDA.TabIndex = 3;
            // 
            // textBoxStartValue_PDA
            // 
            textBoxStartValue_PDA.Location = new Point(12, 101);
            textBoxStartValue_PDA.Name = "textBoxStartValue_PDA";
            textBoxStartValue_PDA.Size = new Size(148, 27);
            textBoxStartValue_PDA.TabIndex = 2;
            // 
            // textBoxSpV_PDA
            // 
            textBoxSpV_PDA.BackColor = SystemColors.Control;
            textBoxSpV_PDA.Location = new Point(198, 52);
            textBoxSpV_PDA.Name = "textBoxSpV_PDA";
            textBoxSpV_PDA.ReadOnly = true;
            textBoxSpV_PDA.Size = new Size(148, 27);
            textBoxSpV_PDA.TabIndex = 1;
            textBoxSpV_PDA.Text = "Конец шага:";
            // 
            // textBoxSV_PDA
            // 
            textBoxSV_PDA.BackColor = SystemColors.Control;
            textBoxSV_PDA.Location = new Point(12, 52);
            textBoxSV_PDA.Name = "textBoxSV_PDA";
            textBoxSV_PDA.ReadOnly = true;
            textBoxSV_PDA.Size = new Size(148, 27);
            textBoxSV_PDA.TabIndex = 0;
            textBoxSV_PDA.Text = "Старт шага:";
            // 
            // panelOutPut_PDA
            // 
            panelOutPut_PDA.Controls.Add(splitter1);
            panelOutPut_PDA.Controls.Add(groupBoxOutPut_PDA);
            panelOutPut_PDA.Dock = DockStyle.Fill;
            panelOutPut_PDA.Location = new Point(361, 130);
            panelOutPut_PDA.Name = "panelOutPut_PDA";
            panelOutPut_PDA.Size = new Size(431, 303);
            panelOutPut_PDA.TabIndex = 16;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 303);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // groupBoxOutPut_PDA
            // 
            groupBoxOutPut_PDA.Controls.Add(textBoxResult_PDA);
            groupBoxOutPut_PDA.Dock = DockStyle.Fill;
            groupBoxOutPut_PDA.Location = new Point(0, 0);
            groupBoxOutPut_PDA.Name = "groupBoxOutPut_PDA";
            groupBoxOutPut_PDA.Size = new Size(431, 303);
            groupBoxOutPut_PDA.TabIndex = 1;
            groupBoxOutPut_PDA.TabStop = false;
            groupBoxOutPut_PDA.Text = "Вывод данных:";
            // 
            // textBoxResult_PDA
            // 
            textBoxResult_PDA.Dock = DockStyle.Fill;
            textBoxResult_PDA.Location = new Point(3, 23);
            textBoxResult_PDA.Multiline = true;
            textBoxResult_PDA.Name = "textBoxResult_PDA";
            textBoxResult_PDA.ReadOnly = true;
            textBoxResult_PDA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_PDA.Size = new Size(425, 277);
            textBoxResult_PDA.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 433);
            Controls.Add(panelOutPut_PDA);
            Controls.Add(panelInPut_PDA);
            Controls.Add(panelCond_PDA);
            MinimumSize = new Size(810, 480);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 13 | Пузина Д. А.";
            panelCond_PDA.ResumeLayout(false);
            groupBoxCond_PDA.ResumeLayout(false);
            groupBoxCond_PDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_PDA).EndInit();
            panelInPut_PDA.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelOutPut_PDA.ResumeLayout(false);
            groupBoxOutPut_PDA.ResumeLayout(false);
            groupBoxOutPut_PDA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonSave_PDA;
        private Button buttonDown_PDA;
        private Button buttonQuestion_PDA;
        private Panel panelCond_PDA;
        private GroupBox groupBoxCond_PDA;
        private PictureBox pictureBoxFormula_PDA;
        private TextBox textBoxCondition_PDA;
        private Panel panelInPut_PDA;
        private GroupBox groupBox1;
        private TextBox textBoxStopValue_PDA;
        private TextBox textBoxStartValue_PDA;
        private TextBox textBoxSpV_PDA;
        private TextBox textBoxSV_PDA;
        private Panel panelOutPut_PDA;
        private GroupBox groupBoxOutPut_PDA;
        private TextBox textBoxResult_PDA;
        private Splitter splitter1;
    }
}
