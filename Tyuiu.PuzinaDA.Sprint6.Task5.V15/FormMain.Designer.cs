namespace Tyuiu.PuzinaDA.Sprint6.Task5.V15
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
            panelCond_PDA = new Panel();
            groupBoxCond_PDA = new GroupBox();
            buttonDown_PDA = new Button();
            buttonOpen_PDA = new Button();
            buttonQuestion_PDA = new Button();
            textBoxConditions_PDA = new TextBox();
            panelOutPut_PDA = new Panel();
            groupBoxOutPut_PDA = new GroupBox();
            dataGridViewOutPut_PDA = new DataGridView();
            panelGraf_PDA = new Panel();
            splitter_PDA = new Splitter();
            panelCond_PDA.SuspendLayout();
            groupBoxCond_PDA.SuspendLayout();
            panelOutPut_PDA.SuspendLayout();
            groupBoxOutPut_PDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_PDA).BeginInit();
            panelGraf_PDA.SuspendLayout();
            SuspendLayout();
            // 
            // panelCond_PDA
            // 
            panelCond_PDA.Controls.Add(groupBoxCond_PDA);
            panelCond_PDA.Dock = DockStyle.Top;
            panelCond_PDA.Location = new Point(0, 0);
            panelCond_PDA.Name = "panelCond_PDA";
            panelCond_PDA.Size = new Size(800, 75);
            panelCond_PDA.TabIndex = 0;
            // 
            // groupBoxCond_PDA
            // 
            groupBoxCond_PDA.Controls.Add(buttonDown_PDA);
            groupBoxCond_PDA.Controls.Add(buttonOpen_PDA);
            groupBoxCond_PDA.Controls.Add(buttonQuestion_PDA);
            groupBoxCond_PDA.Controls.Add(textBoxConditions_PDA);
            groupBoxCond_PDA.Dock = DockStyle.Fill;
            groupBoxCond_PDA.Location = new Point(0, 0);
            groupBoxCond_PDA.Name = "groupBoxCond_PDA";
            groupBoxCond_PDA.Size = new Size(800, 75);
            groupBoxCond_PDA.TabIndex = 0;
            groupBoxCond_PDA.TabStop = false;
            groupBoxCond_PDA.Text = "Условие";
            // 
            // buttonDown_PDA
            // 
            buttonDown_PDA.BackColor = SystemColors.GradientInactiveCaption;
            buttonDown_PDA.Location = new Point(486, 12);
            buttonDown_PDA.Name = "buttonDown_PDA";
            buttonDown_PDA.Size = new Size(97, 57);
            buttonDown_PDA.TabIndex = 3;
            buttonDown_PDA.Text = "Выполнить";
            buttonDown_PDA.UseVisualStyleBackColor = false;
            buttonDown_PDA.Click += buttonDown_PDA_Click;
            // 
            // buttonOpen_PDA
            // 
            buttonOpen_PDA.BackColor = SystemColors.Info;
            buttonOpen_PDA.Location = new Point(589, 12);
            buttonOpen_PDA.Name = "buttonOpen_PDA";
            buttonOpen_PDA.Size = new Size(97, 57);
            buttonOpen_PDA.TabIndex = 2;
            buttonOpen_PDA.Text = "Открыть файл";
            buttonOpen_PDA.UseVisualStyleBackColor = false;
            buttonOpen_PDA.Click += buttonOpen_PDA_Click;
            // 
            // buttonQuestion_PDA
            // 
            buttonQuestion_PDA.BackColor = Color.MistyRose;
            buttonQuestion_PDA.Location = new Point(692, 12);
            buttonQuestion_PDA.Name = "buttonQuestion_PDA";
            buttonQuestion_PDA.Size = new Size(96, 57);
            buttonQuestion_PDA.TabIndex = 1;
            buttonQuestion_PDA.Text = "Справка";
            buttonQuestion_PDA.UseVisualStyleBackColor = false;
            buttonQuestion_PDA.Click += buttonQuestion_PDA_Click;
            // 
            // textBoxConditions_PDA
            // 
            textBoxConditions_PDA.Location = new Point(12, 22);
            textBoxConditions_PDA.Multiline = true;
            textBoxConditions_PDA.Name = "textBoxConditions_PDA";
            textBoxConditions_PDA.ReadOnly = true;
            textBoxConditions_PDA.Size = new Size(388, 47);
            textBoxConditions_PDA.TabIndex = 0;
            textBoxConditions_PDA.Text = "Прочитать данные из файла InPutFileTask5V15.txt. Вывести в dataGridView.Вывести все числа от 2 до 7. Построить диаграмму по этим значениям.";
            // 
            // panelOutPut_PDA
            // 
            panelOutPut_PDA.Controls.Add(groupBoxOutPut_PDA);
            panelOutPut_PDA.Dock = DockStyle.Left;
            panelOutPut_PDA.Location = new Point(0, 75);
            panelOutPut_PDA.Name = "panelOutPut_PDA";
            panelOutPut_PDA.Size = new Size(214, 375);
            panelOutPut_PDA.TabIndex = 1;
            // 
            // groupBoxOutPut_PDA
            // 
            groupBoxOutPut_PDA.Controls.Add(dataGridViewOutPut_PDA);
            groupBoxOutPut_PDA.Dock = DockStyle.Fill;
            groupBoxOutPut_PDA.Location = new Point(0, 0);
            groupBoxOutPut_PDA.Name = "groupBoxOutPut_PDA";
            groupBoxOutPut_PDA.Size = new Size(214, 375);
            groupBoxOutPut_PDA.TabIndex = 0;
            groupBoxOutPut_PDA.TabStop = false;
            groupBoxOutPut_PDA.Text = "Вывод данных";
            // 
            // dataGridViewOutPut_PDA
            // 
            dataGridViewOutPut_PDA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutPut_PDA.ColumnHeadersVisible = false;
            dataGridViewOutPut_PDA.Dock = DockStyle.Fill;
            dataGridViewOutPut_PDA.Location = new Point(3, 23);
            dataGridViewOutPut_PDA.Name = "dataGridViewOutPut_PDA";
            dataGridViewOutPut_PDA.ReadOnly = true;
            dataGridViewOutPut_PDA.RowHeadersVisible = false;
            dataGridViewOutPut_PDA.RowHeadersWidth = 51;
            dataGridViewOutPut_PDA.Size = new Size(208, 349);
            dataGridViewOutPut_PDA.TabIndex = 0;
            // 
            // panelGraf_PDA
            // 
            panelGraf_PDA.Controls.Add(splitter_PDA);
            panelGraf_PDA.Dock = DockStyle.Fill;
            panelGraf_PDA.Location = new Point(214, 75);
            panelGraf_PDA.Name = "panelGraf_PDA";
            panelGraf_PDA.Size = new Size(586, 375);
            panelGraf_PDA.TabIndex = 2;
            // 
            // splitter_PDA
            // 
            splitter_PDA.Location = new Point(0, 0);
            splitter_PDA.Name = "splitter_PDA";
            splitter_PDA.Size = new Size(4, 375);
            splitter_PDA.TabIndex = 0;
            splitter_PDA.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelGraf_PDA);
            Controls.Add(panelOutPut_PDA);
            Controls.Add(panelCond_PDA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 15 | Пузина Д. А.";
            panelCond_PDA.ResumeLayout(false);
            groupBoxCond_PDA.ResumeLayout(false);
            groupBoxCond_PDA.PerformLayout();
            panelOutPut_PDA.ResumeLayout(false);
            groupBoxOutPut_PDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_PDA).EndInit();
            panelGraf_PDA.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCond_PDA;
        private Panel panelOutPut_PDA;
        private Panel panelGraf_PDA;
        private GroupBox groupBoxCond_PDA;
        private TextBox textBoxConditions_PDA;
        private GroupBox groupBoxOutPut_PDA;
        private DataGridView dataGridViewOutPut_PDA;
        private Splitter splitter_PDA;
        private Button buttonDown_PDA;
        private Button buttonOpen_PDA;
        private Button buttonQuestion_PDA;
    }
}
