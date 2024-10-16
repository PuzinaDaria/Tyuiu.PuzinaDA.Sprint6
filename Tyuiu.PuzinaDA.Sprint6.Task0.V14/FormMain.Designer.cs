namespace Tyuiu.PuzinaDA.Sprint6.Task0.V14
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
            buttonOutput_PDA = new Button();
            textBoxCond_PDA = new TextBox();
            textBoxInput_PDA = new TextBox();
            textBoxOutput_PDA = new TextBox();
            textBoxX_PDA = new TextBox();
            textBoxIntX_PDA = new TextBox();
            textBoxRes_PDA = new TextBox();
            textBoxResult_PDA = new TextBox();
            pictureBoxFormula_PDA = new PictureBox();
            textBoxCondition_PDA = new TextBox();
            buttonQuestion_PDA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_PDA).BeginInit();
            SuspendLayout();
            // 
            // buttonOutput_PDA
            // 
            buttonOutput_PDA.Location = new Point(307, 322);
            buttonOutput_PDA.Name = "buttonOutput_PDA";
            buttonOutput_PDA.Size = new Size(170, 79);
            buttonOutput_PDA.TabIndex = 0;
            buttonOutput_PDA.Text = "Вычислить\r\n";
            buttonOutput_PDA.UseVisualStyleBackColor = true;
            buttonOutput_PDA.Click += buttonOutput_PDA_Click;
            // 
            // textBoxCond_PDA
            // 
            textBoxCond_PDA.BackColor = SystemColors.Control;
            textBoxCond_PDA.BorderStyle = BorderStyle.None;
            textBoxCond_PDA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxCond_PDA.Location = new Point(13, 17);
            textBoxCond_PDA.Multiline = true;
            textBoxCond_PDA.Name = "textBoxCond_PDA";
            textBoxCond_PDA.ReadOnly = true;
            textBoxCond_PDA.Size = new Size(428, 193);
            textBoxCond_PDA.TabIndex = 1;
            textBoxCond_PDA.Text = "Вычислить выражение по формуле:";
            // 
            // textBoxInput_PDA
            // 
            textBoxInput_PDA.BackColor = SystemColors.Control;
            textBoxInput_PDA.BorderStyle = BorderStyle.None;
            textBoxInput_PDA.Location = new Point(13, 274);
            textBoxInput_PDA.Name = "textBoxInput_PDA";
            textBoxInput_PDA.ReadOnly = true;
            textBoxInput_PDA.Size = new Size(271, 20);
            textBoxInput_PDA.TabIndex = 2;
            textBoxInput_PDA.Text = "Ввод данных:";
            // 
            // textBoxOutput_PDA
            // 
            textBoxOutput_PDA.BackColor = SystemColors.Control;
            textBoxOutput_PDA.BorderStyle = BorderStyle.None;
            textBoxOutput_PDA.Location = new Point(498, 274);
            textBoxOutput_PDA.Name = "textBoxOutput_PDA";
            textBoxOutput_PDA.ReadOnly = true;
            textBoxOutput_PDA.Size = new Size(271, 20);
            textBoxOutput_PDA.TabIndex = 3;
            textBoxOutput_PDA.Text = "Вывод данных:";
            // 
            // textBoxX_PDA
            // 
            textBoxX_PDA.BackColor = SystemColors.Menu;
            textBoxX_PDA.BorderStyle = BorderStyle.None;
            textBoxX_PDA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxX_PDA.Location = new Point(146, 322);
            textBoxX_PDA.Name = "textBoxX_PDA";
            textBoxX_PDA.ReadOnly = true;
            textBoxX_PDA.Size = new Size(18, 27);
            textBoxX_PDA.TabIndex = 4;
            textBoxX_PDA.Text = "X";
            // 
            // textBoxIntX_PDA
            // 
            textBoxIntX_PDA.Location = new Point(114, 355);
            textBoxIntX_PDA.Name = "textBoxIntX_PDA";
            textBoxIntX_PDA.Size = new Size(77, 27);
            textBoxIntX_PDA.TabIndex = 5;
            textBoxIntX_PDA.KeyPress += textBoxIntX_KeyPress;
            // 
            // textBoxRes_PDA
            // 
            textBoxRes_PDA.BackColor = SystemColors.Control;
            textBoxRes_PDA.BorderStyle = BorderStyle.None;
            textBoxRes_PDA.Location = new Point(595, 322);
            textBoxRes_PDA.Name = "textBoxRes_PDA";
            textBoxRes_PDA.ReadOnly = true;
            textBoxRes_PDA.Size = new Size(113, 20);
            textBoxRes_PDA.TabIndex = 6;
            textBoxRes_PDA.Text = "Результат:";
            // 
            // textBoxResult_PDA
            // 
            textBoxResult_PDA.Location = new Point(557, 355);
            textBoxResult_PDA.Name = "textBoxResult_PDA";
            textBoxResult_PDA.ReadOnly = true;
            textBoxResult_PDA.Size = new Size(151, 27);
            textBoxResult_PDA.TabIndex = 7;
            // 
            // pictureBoxFormula_PDA
            // 
            pictureBoxFormula_PDA.Image = (Image)resources.GetObject("pictureBoxFormula_PDA.Image");
            pictureBoxFormula_PDA.Location = new Point(361, 17);
            pictureBoxFormula_PDA.Name = "pictureBoxFormula_PDA";
            pictureBoxFormula_PDA.Size = new Size(139, 72);
            pictureBoxFormula_PDA.TabIndex = 8;
            pictureBoxFormula_PDA.TabStop = false;
            // 
            // textBoxCondition_PDA
            // 
            textBoxCondition_PDA.BackColor = SystemColors.Control;
            textBoxCondition_PDA.BorderStyle = BorderStyle.None;
            textBoxCondition_PDA.Location = new Point(19, 4);
            textBoxCondition_PDA.Name = "textBoxCondition_PDA";
            textBoxCondition_PDA.ReadOnly = true;
            textBoxCondition_PDA.Size = new Size(145, 20);
            textBoxCondition_PDA.TabIndex = 9;
            textBoxCondition_PDA.Text = "Условие:";
            // 
            // buttonQuestion_PDA
            // 
            buttonQuestion_PDA.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonQuestion_PDA.Location = new Point(261, 367);
            buttonQuestion_PDA.Name = "buttonQuestion_PDA";
            buttonQuestion_PDA.Size = new Size(40, 34);
            buttonQuestion_PDA.TabIndex = 10;
            buttonQuestion_PDA.Text = "?";
            buttonQuestion_PDA.UseVisualStyleBackColor = true;
            buttonQuestion_PDA.Click += buttonQuestion_PDA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonQuestion_PDA);
            Controls.Add(textBoxCondition_PDA);
            Controls.Add(pictureBoxFormula_PDA);
            Controls.Add(textBoxResult_PDA);
            Controls.Add(textBoxRes_PDA);
            Controls.Add(textBoxIntX_PDA);
            Controls.Add(textBoxX_PDA);
            Controls.Add(textBoxOutput_PDA);
            Controls.Add(textBoxInput_PDA);
            Controls.Add(textBoxCond_PDA);
            Controls.Add(buttonOutput_PDA);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Спринт 6 | Таск 0 | Вариант 14 | Пузина Д. А.";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_PDA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOutput_PDA;
        private TextBox textBoxCond_PDA;
        private TextBox textBoxInput_PDA;
        private TextBox textBoxOutput_PDA;
        private TextBox textBoxX_PDA;
        private TextBox textBoxIntX_PDA;
        private TextBox textBoxRes_PDA;
        private TextBox textBoxResult_PDA;
        private PictureBox pictureBoxFormula_PDA;
        private TextBox textBoxCondition_PDA;
        private Button buttonQuestion_PDA;
    }
}
