namespace Tyuiu.PuzinaDA.Sprint6.Task3.V19
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
            dataGridViewMatrix_PDA = new DataGridView();
            textBoxOutPut_PDA = new TextBox();
            textBoxCond_PDA = new TextBox();
            textBoxConditions_PDA = new TextBox();
            textBoxRes_PDA = new TextBox();
            buttonDown_PDA = new Button();
            buttonQuestion_PDA = new Button();
            dataGridViewResult_PDA = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_PDA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_PDA).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMatrix_PDA
            // 
            dataGridViewMatrix_PDA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_PDA.ColumnHeadersVisible = false;
            dataGridViewMatrix_PDA.Location = new Point(413, 78);
            dataGridViewMatrix_PDA.Name = "dataGridViewMatrix_PDA";
            dataGridViewMatrix_PDA.ReadOnly = true;
            dataGridViewMatrix_PDA.RowHeadersVisible = false;
            dataGridViewMatrix_PDA.RowHeadersWidth = 51;
            dataGridViewMatrix_PDA.Size = new Size(176, 186);
            dataGridViewMatrix_PDA.TabIndex = 0;
            // 
            // textBoxOutPut_PDA
            // 
            textBoxOutPut_PDA.BackColor = SystemColors.Control;
            textBoxOutPut_PDA.Location = new Point(612, 12);
            textBoxOutPut_PDA.Name = "textBoxOutPut_PDA";
            textBoxOutPut_PDA.ReadOnly = true;
            textBoxOutPut_PDA.Size = new Size(176, 27);
            textBoxOutPut_PDA.TabIndex = 1;
            textBoxOutPut_PDA.Text = "Вывод данных:";
            // 
            // textBoxCond_PDA
            // 
            textBoxCond_PDA.BackColor = SystemColors.Control;
            textBoxCond_PDA.Location = new Point(12, 12);
            textBoxCond_PDA.Name = "textBoxCond_PDA";
            textBoxCond_PDA.ReadOnly = true;
            textBoxCond_PDA.Size = new Size(191, 27);
            textBoxCond_PDA.TabIndex = 2;
            textBoxCond_PDA.Text = "Условие:";
            // 
            // textBoxConditions_PDA
            // 
            textBoxConditions_PDA.BackColor = SystemColors.Control;
            textBoxConditions_PDA.Location = new Point(12, 45);
            textBoxConditions_PDA.Multiline = true;
            textBoxConditions_PDA.Name = "textBoxConditions_PDA";
            textBoxConditions_PDA.ReadOnly = true;
            textBoxConditions_PDA.Size = new Size(380, 239);
            textBoxConditions_PDA.TabIndex = 3;
            textBoxConditions_PDA.Text = resources.GetString("textBoxConditions_PDA.Text");
            // 
            // textBoxRes_PDA
            // 
            textBoxRes_PDA.BackColor = SystemColors.Control;
            textBoxRes_PDA.Location = new Point(612, 45);
            textBoxRes_PDA.Name = "textBoxRes_PDA";
            textBoxRes_PDA.ReadOnly = true;
            textBoxRes_PDA.Size = new Size(176, 27);
            textBoxRes_PDA.TabIndex = 4;
            textBoxRes_PDA.Text = "Результат";
            // 
            // buttonDown_PDA
            // 
            buttonDown_PDA.BackColor = SystemColors.Info;
            buttonDown_PDA.Location = new Point(684, 270);
            buttonDown_PDA.Name = "buttonDown_PDA";
            buttonDown_PDA.Size = new Size(104, 29);
            buttonDown_PDA.TabIndex = 6;
            buttonDown_PDA.Text = "Выполнить";
            buttonDown_PDA.UseVisualStyleBackColor = false;
            buttonDown_PDA.Click += buttonDown_PDA_Click;
            // 
            // buttonQuestion_PDA
            // 
            buttonQuestion_PDA.BackColor = SystemColors.ActiveCaption;
            buttonQuestion_PDA.Location = new Point(645, 270);
            buttonQuestion_PDA.Name = "buttonQuestion_PDA";
            buttonQuestion_PDA.Size = new Size(33, 29);
            buttonQuestion_PDA.TabIndex = 7;
            buttonQuestion_PDA.Text = "?";
            buttonQuestion_PDA.UseVisualStyleBackColor = false;
            buttonQuestion_PDA.Click += buttonQuestion_PDA_Click;
            // 
            // dataGridViewResult_PDA
            // 
            dataGridViewResult_PDA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_PDA.ColumnHeadersVisible = false;
            dataGridViewResult_PDA.Location = new Point(612, 78);
            dataGridViewResult_PDA.Name = "dataGridViewResult_PDA";
            dataGridViewResult_PDA.ReadOnly = true;
            dataGridViewResult_PDA.RowHeadersVisible = false;
            dataGridViewResult_PDA.RowHeadersWidth = 51;
            dataGridViewResult_PDA.Size = new Size(176, 186);
            dataGridViewResult_PDA.TabIndex = 8;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 311);
            Controls.Add(dataGridViewResult_PDA);
            Controls.Add(buttonQuestion_PDA);
            Controls.Add(buttonDown_PDA);
            Controls.Add(textBoxRes_PDA);
            Controls.Add(textBoxConditions_PDA);
            Controls.Add(textBoxCond_PDA);
            Controls.Add(textBoxOutPut_PDA);
            Controls.Add(dataGridViewMatrix_PDA);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 19 | Пузина Д.  А.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_PDA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_PDA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewMatrix_PDA;
        private TextBox textBoxOutPut_PDA;
        private TextBox textBoxCond_PDA;
        private TextBox textBoxConditions_PDA;
        private TextBox textBoxRes_PDA;
        private Button buttonDown_PDA;
        private Button buttonQuestion_PDA;
        private DataGridView dataGridViewResult_PDA;
    }
}
