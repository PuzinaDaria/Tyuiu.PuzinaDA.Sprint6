namespace Tyuiu.PuzinaDA.Sprint6.Task1.V13
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
            textBoxCondition_PDA = new TextBox();
            textBoxCond_PDA = new TextBox();
            textBoxRes_PDA = new TextBox();
            textBoxResult_PDA = new TextBox();
            textBoxSV_PDA = new TextBox();
            textBoxFV_PDA = new TextBox();
            textBoxStartValue_PDA = new TextBox();
            textBoxStopValue_PDA = new TextBox();
            buttonDown_PDA = new Button();
            buttonQuestion_PDA = new Button();
            pictureBoxFormula_PDA = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_PDA).BeginInit();
            SuspendLayout();
            // 
            // textBoxCondition_PDA
            // 
            textBoxCondition_PDA.BackColor = SystemColors.Control;
            textBoxCondition_PDA.BorderStyle = BorderStyle.None;
            textBoxCondition_PDA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxCondition_PDA.Location = new Point(12, 35);
            textBoxCondition_PDA.Multiline = true;
            textBoxCondition_PDA.Name = "textBoxCondition_PDA";
            textBoxCondition_PDA.ReadOnly = true;
            textBoxCondition_PDA.Size = new Size(461, 257);
            textBoxCondition_PDA.TabIndex = 0;
            textBoxCondition_PDA.Text = "Вывести таблицу значений функции на заданном диапазоне:\r\n\r\n\r\n\r\n\r\n";
            // 
            // textBoxCond_PDA
            // 
            textBoxCond_PDA.BackColor = SystemColors.Control;
            textBoxCond_PDA.BorderStyle = BorderStyle.None;
            textBoxCond_PDA.Location = new Point(14, 9);
            textBoxCond_PDA.Name = "textBoxCond_PDA";
            textBoxCond_PDA.ReadOnly = true;
            textBoxCond_PDA.Size = new Size(200, 20);
            textBoxCond_PDA.TabIndex = 1;
            textBoxCond_PDA.Text = "Условие:";
            // 
            // textBoxRes_PDA
            // 
            textBoxRes_PDA.BackColor = SystemColors.Control;
            textBoxRes_PDA.BorderStyle = BorderStyle.None;
            textBoxRes_PDA.Location = new Point(489, 9);
            textBoxRes_PDA.Name = "textBoxRes_PDA";
            textBoxRes_PDA.ReadOnly = true;
            textBoxRes_PDA.Size = new Size(288, 20);
            textBoxRes_PDA.TabIndex = 2;
            textBoxRes_PDA.Text = "Результат";
            // 
            // textBoxResult_PDA
            // 
            textBoxResult_PDA.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_PDA.Location = new Point(489, 42);
            textBoxResult_PDA.Multiline = true;
            textBoxResult_PDA.Name = "textBoxResult_PDA";
            textBoxResult_PDA.ReadOnly = true;
            textBoxResult_PDA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_PDA.Size = new Size(288, 250);
            textBoxResult_PDA.TabIndex = 3;
            // 
            // textBoxSV_PDA
            // 
            textBoxSV_PDA.BackColor = SystemColors.Control;
            textBoxSV_PDA.BorderStyle = BorderStyle.None;
            textBoxSV_PDA.Location = new Point(12, 335);
            textBoxSV_PDA.Name = "textBoxSV_PDA";
            textBoxSV_PDA.ReadOnly = true;
            textBoxSV_PDA.Size = new Size(125, 20);
            textBoxSV_PDA.TabIndex = 4;
            textBoxSV_PDA.Text = "Старт шага:";
            // 
            // textBoxFV_PDA
            // 
            textBoxFV_PDA.BackColor = SystemColors.Control;
            textBoxFV_PDA.BorderStyle = BorderStyle.None;
            textBoxFV_PDA.Location = new Point(188, 335);
            textBoxFV_PDA.Name = "textBoxFV_PDA";
            textBoxFV_PDA.ReadOnly = true;
            textBoxFV_PDA.Size = new Size(125, 20);
            textBoxFV_PDA.TabIndex = 5;
            textBoxFV_PDA.Text = "Конец шага:";
            // 
            // textBoxStartValue_PDA
            // 
            textBoxStartValue_PDA.Location = new Point(12, 383);
            textBoxStartValue_PDA.Name = "textBoxStartValue_PDA";
            textBoxStartValue_PDA.Size = new Size(125, 27);
            textBoxStartValue_PDA.TabIndex = 6;
            // 
            // textBoxStopValue_PDA
            // 
            textBoxStopValue_PDA.Location = new Point(188, 383);
            textBoxStopValue_PDA.Name = "textBoxStopValue_PDA";
            textBoxStopValue_PDA.Size = new Size(125, 27);
            textBoxStopValue_PDA.TabIndex = 7;
            // 
            // buttonDown_PDA
            // 
            buttonDown_PDA.BackColor = SystemColors.Info;
            buttonDown_PDA.Location = new Point(492, 338);
            buttonDown_PDA.Name = "buttonDown_PDA";
            buttonDown_PDA.Size = new Size(285, 89);
            buttonDown_PDA.TabIndex = 8;
            buttonDown_PDA.Text = "Вычислить";
            buttonDown_PDA.UseVisualStyleBackColor = false;
            buttonDown_PDA.Click += buttonDown_PDA_Click;
            // 
            // buttonQuestion_PDA
            // 
            buttonQuestion_PDA.BackColor = SystemColors.ActiveCaption;
            buttonQuestion_PDA.Location = new Point(349, 338);
            buttonQuestion_PDA.Name = "buttonQuestion_PDA";
            buttonQuestion_PDA.Size = new Size(124, 89);
            buttonQuestion_PDA.TabIndex = 9;
            buttonQuestion_PDA.Text = "Справка";
            buttonQuestion_PDA.UseVisualStyleBackColor = false;
            buttonQuestion_PDA.Click += buttonQuestion_PDA_Click;
            // 
            // pictureBoxFormula_PDA
            // 
            pictureBoxFormula_PDA.Image = (Image)resources.GetObject("pictureBoxFormula_PDA.Image");
            pictureBoxFormula_PDA.Location = new Point(14, 110);
            pictureBoxFormula_PDA.Name = "pictureBoxFormula_PDA";
            pictureBoxFormula_PDA.Size = new Size(394, 47);
            pictureBoxFormula_PDA.TabIndex = 10;
            pictureBoxFormula_PDA.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxFormula_PDA);
            Controls.Add(buttonQuestion_PDA);
            Controls.Add(buttonDown_PDA);
            Controls.Add(textBoxStopValue_PDA);
            Controls.Add(textBoxStartValue_PDA);
            Controls.Add(textBoxFV_PDA);
            Controls.Add(textBoxSV_PDA);
            Controls.Add(textBoxResult_PDA);
            Controls.Add(textBoxRes_PDA);
            Controls.Add(textBoxCond_PDA);
            Controls.Add(textBoxCondition_PDA);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_PDA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCondition_PDA;
        private TextBox textBoxCond_PDA;
        private TextBox textBoxRes_PDA;
        private TextBox textBoxResult_PDA;
        private TextBox textBoxSV_PDA;
        private TextBox textBoxFV_PDA;
        private TextBox textBoxStartValue_PDA;
        private TextBox textBoxStopValue_PDA;
        private Button buttonDown_PDA;
        private Button buttonQuestion_PDA;
        private PictureBox pictureBoxFormula_PDA;
    }
}
