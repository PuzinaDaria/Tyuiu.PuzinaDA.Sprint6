namespace Tyuiu.PuzinaDA.Sprint6.Task7.V25
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelButtons_PDA = new Panel();
            buttonQuestion_PDA = new Button();
            buttonSave_PDA = new Button();
            buttonDown_PDA = new Button();
            buttonOpen_PDA = new Button();
            panelCond_PDA = new Panel();
            groupBoxCond_PDA = new GroupBox();
            textBoxCond_PDA = new TextBox();
            panelIn_PDA = new Panel();
            groupBoxIn_PDA = new GroupBox();
            dataGridViewIn_PDA = new DataGridView();
            splitter_PDA = new Splitter();
            panelOut_PDA = new Panel();
            groupBoxOut_PDA = new GroupBox();
            dataGridViewOut_PDA = new DataGridView();
            openFileDialog_PDA = new OpenFileDialog();
            toolTip_PDA = new ToolTip(components);
            saveFileDialog_PDA = new SaveFileDialog();
            toolTipDown_PDA = new ToolTip(components);
            toolTipSave_PDA = new ToolTip(components);
            toolTipQuestion_PDA = new ToolTip(components);
            panelButtons_PDA.SuspendLayout();
            panelCond_PDA.SuspendLayout();
            groupBoxCond_PDA.SuspendLayout();
            panelIn_PDA.SuspendLayout();
            groupBoxIn_PDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_PDA).BeginInit();
            panelOut_PDA.SuspendLayout();
            groupBoxOut_PDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_PDA).BeginInit();
            SuspendLayout();
            // 
            // panelButtons_PDA
            // 
            panelButtons_PDA.Controls.Add(buttonQuestion_PDA);
            panelButtons_PDA.Controls.Add(buttonSave_PDA);
            panelButtons_PDA.Controls.Add(buttonDown_PDA);
            panelButtons_PDA.Controls.Add(buttonOpen_PDA);
            panelButtons_PDA.Dock = DockStyle.Top;
            panelButtons_PDA.Location = new Point(0, 0);
            panelButtons_PDA.Name = "panelButtons_PDA";
            panelButtons_PDA.Size = new Size(800, 64);
            panelButtons_PDA.TabIndex = 0;
            // 
            // buttonQuestion_PDA
            // 
            buttonQuestion_PDA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonQuestion_PDA.Image = (Image)resources.GetObject("buttonQuestion_PDA.Image");
            buttonQuestion_PDA.Location = new Point(741, 12);
            buttonQuestion_PDA.Name = "buttonQuestion_PDA";
            buttonQuestion_PDA.Size = new Size(47, 46);
            buttonQuestion_PDA.TabIndex = 3;
            toolTipQuestion_PDA.SetToolTip(buttonQuestion_PDA, "Сведения о программе\r\n");
            buttonQuestion_PDA.UseVisualStyleBackColor = true;
            buttonQuestion_PDA.Click += buttonQuestion_PDA_Click;
            // 
            // buttonSave_PDA
            // 
            buttonSave_PDA.Enabled = false;
            buttonSave_PDA.Image = (Image)resources.GetObject("buttonSave_PDA.Image");
            buttonSave_PDA.Location = new Point(120, 12);
            buttonSave_PDA.Name = "buttonSave_PDA";
            buttonSave_PDA.Size = new Size(48, 46);
            buttonSave_PDA.TabIndex = 2;
            toolTipSave_PDA.SetToolTip(buttonSave_PDA, "Сохранить обработанные данные в файл в формате CSV\r\n");
            buttonSave_PDA.UseVisualStyleBackColor = true;
            buttonSave_PDA.Click += buttonSave_PDA_Click;
            // 
            // buttonDown_PDA
            // 
            buttonDown_PDA.Enabled = false;
            buttonDown_PDA.Image = (Image)resources.GetObject("buttonDown_PDA.Image");
            buttonDown_PDA.Location = new Point(67, 12);
            buttonDown_PDA.Name = "buttonDown_PDA";
            buttonDown_PDA.Size = new Size(47, 46);
            buttonDown_PDA.TabIndex = 1;
            toolTipDown_PDA.SetToolTip(buttonDown_PDA, "Выполнить обработку данных\r\n");
            buttonDown_PDA.UseVisualStyleBackColor = true;
            buttonDown_PDA.Click += buttonDown_PDA_Click;
            // 
            // buttonOpen_PDA
            // 
            buttonOpen_PDA.Image = (Image)resources.GetObject("buttonOpen_PDA.Image");
            buttonOpen_PDA.Location = new Point(12, 12);
            buttonOpen_PDA.Name = "buttonOpen_PDA";
            buttonOpen_PDA.Size = new Size(49, 46);
            buttonOpen_PDA.TabIndex = 0;
            toolTip_PDA.SetToolTip(buttonOpen_PDA, "Открыть файл для обработки в формате данных CSV");
            buttonOpen_PDA.UseVisualStyleBackColor = true;
            buttonOpen_PDA.Click += buttonOpen_PDA_Click;
            // 
            // panelCond_PDA
            // 
            panelCond_PDA.Controls.Add(groupBoxCond_PDA);
            panelCond_PDA.Dock = DockStyle.Top;
            panelCond_PDA.Location = new Point(0, 64);
            panelCond_PDA.Name = "panelCond_PDA";
            panelCond_PDA.Size = new Size(800, 94);
            panelCond_PDA.TabIndex = 1;
            // 
            // groupBoxCond_PDA
            // 
            groupBoxCond_PDA.Controls.Add(textBoxCond_PDA);
            groupBoxCond_PDA.Dock = DockStyle.Fill;
            groupBoxCond_PDA.Location = new Point(0, 0);
            groupBoxCond_PDA.Name = "groupBoxCond_PDA";
            groupBoxCond_PDA.Size = new Size(800, 94);
            groupBoxCond_PDA.TabIndex = 0;
            groupBoxCond_PDA.TabStop = false;
            groupBoxCond_PDA.Text = "Условие";
            // 
            // textBoxCond_PDA
            // 
            textBoxCond_PDA.Dock = DockStyle.Fill;
            textBoxCond_PDA.Location = new Point(3, 23);
            textBoxCond_PDA.Multiline = true;
            textBoxCond_PDA.Name = "textBoxCond_PDA";
            textBoxCond_PDA.ReadOnly = true;
            textBoxCond_PDA.Size = new Size(794, 68);
            textBoxCond_PDA.TabIndex = 0;
            textBoxCond_PDA.Text = resources.GetString("textBoxCond_PDA.Text");
            // 
            // panelIn_PDA
            // 
            panelIn_PDA.Controls.Add(groupBoxIn_PDA);
            panelIn_PDA.Dock = DockStyle.Left;
            panelIn_PDA.Location = new Point(0, 158);
            panelIn_PDA.Name = "panelIn_PDA";
            panelIn_PDA.Size = new Size(406, 292);
            panelIn_PDA.TabIndex = 2;
            // 
            // groupBoxIn_PDA
            // 
            groupBoxIn_PDA.Controls.Add(dataGridViewIn_PDA);
            groupBoxIn_PDA.Dock = DockStyle.Fill;
            groupBoxIn_PDA.Location = new Point(0, 0);
            groupBoxIn_PDA.Name = "groupBoxIn_PDA";
            groupBoxIn_PDA.Size = new Size(406, 292);
            groupBoxIn_PDA.TabIndex = 0;
            groupBoxIn_PDA.TabStop = false;
            groupBoxIn_PDA.Text = "Ввод";
            // 
            // dataGridViewIn_PDA
            // 
            dataGridViewIn_PDA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_PDA.ColumnHeadersVisible = false;
            dataGridViewIn_PDA.Dock = DockStyle.Fill;
            dataGridViewIn_PDA.Location = new Point(3, 23);
            dataGridViewIn_PDA.Name = "dataGridViewIn_PDA";
            dataGridViewIn_PDA.ReadOnly = true;
            dataGridViewIn_PDA.RowHeadersVisible = false;
            dataGridViewIn_PDA.RowHeadersWidth = 51;
            dataGridViewIn_PDA.Size = new Size(400, 266);
            dataGridViewIn_PDA.TabIndex = 0;
            // 
            // splitter_PDA
            // 
            splitter_PDA.Location = new Point(406, 158);
            splitter_PDA.Name = "splitter_PDA";
            splitter_PDA.Size = new Size(4, 292);
            splitter_PDA.TabIndex = 3;
            splitter_PDA.TabStop = false;
            // 
            // panelOut_PDA
            // 
            panelOut_PDA.Controls.Add(groupBoxOut_PDA);
            panelOut_PDA.Dock = DockStyle.Fill;
            panelOut_PDA.Location = new Point(410, 158);
            panelOut_PDA.Name = "panelOut_PDA";
            panelOut_PDA.Size = new Size(390, 292);
            panelOut_PDA.TabIndex = 4;
            // 
            // groupBoxOut_PDA
            // 
            groupBoxOut_PDA.Controls.Add(dataGridViewOut_PDA);
            groupBoxOut_PDA.Dock = DockStyle.Fill;
            groupBoxOut_PDA.Location = new Point(0, 0);
            groupBoxOut_PDA.Name = "groupBoxOut_PDA";
            groupBoxOut_PDA.Size = new Size(390, 292);
            groupBoxOut_PDA.TabIndex = 0;
            groupBoxOut_PDA.TabStop = false;
            groupBoxOut_PDA.Text = "Вывод";
            // 
            // dataGridViewOut_PDA
            // 
            dataGridViewOut_PDA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_PDA.ColumnHeadersVisible = false;
            dataGridViewOut_PDA.Dock = DockStyle.Fill;
            dataGridViewOut_PDA.Location = new Point(3, 23);
            dataGridViewOut_PDA.Name = "dataGridViewOut_PDA";
            dataGridViewOut_PDA.ReadOnly = true;
            dataGridViewOut_PDA.RowHeadersVisible = false;
            dataGridViewOut_PDA.RowHeadersWidth = 51;
            dataGridViewOut_PDA.Size = new Size(384, 266);
            dataGridViewOut_PDA.TabIndex = 0;
            // 
            // openFileDialog_PDA
            // 
            openFileDialog_PDA.FileName = "openFileDialog1";
            // 
            // toolTip_PDA
            // 
            toolTip_PDA.AutomaticDelay = 300;
            toolTip_PDA.ToolTipIcon = ToolTipIcon.Info;
            toolTip_PDA.ToolTipTitle = "Открыть файл";
            // 
            // toolTipDown_PDA
            // 
            toolTipDown_PDA.AutomaticDelay = 300;
            toolTipDown_PDA.ToolTipIcon = ToolTipIcon.Info;
            toolTipDown_PDA.ToolTipTitle = "Выполнить";
            // 
            // toolTipSave_PDA
            // 
            toolTipSave_PDA.AutomaticDelay = 300;
            toolTipSave_PDA.ToolTipIcon = ToolTipIcon.Info;
            toolTipSave_PDA.ToolTipTitle = "Сохранить";
            // 
            // toolTipQuestion_PDA
            // 
            toolTipQuestion_PDA.AutomaticDelay = 300;
            toolTipQuestion_PDA.ToolTipIcon = ToolTipIcon.Info;
            toolTipQuestion_PDA.ToolTipTitle = "Справка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelOut_PDA);
            Controls.Add(splitter_PDA);
            Controls.Add(panelIn_PDA);
            Controls.Add(panelCond_PDA);
            Controls.Add(panelButtons_PDA);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 25 | Пузина Д. А.";
            panelButtons_PDA.ResumeLayout(false);
            panelCond_PDA.ResumeLayout(false);
            groupBoxCond_PDA.ResumeLayout(false);
            groupBoxCond_PDA.PerformLayout();
            panelIn_PDA.ResumeLayout(false);
            groupBoxIn_PDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_PDA).EndInit();
            panelOut_PDA.ResumeLayout(false);
            groupBoxOut_PDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_PDA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons_PDA;
        private Panel panelCond_PDA;
        private GroupBox groupBoxCond_PDA;
        private Panel panelIn_PDA;
        private GroupBox groupBoxIn_PDA;
        private DataGridView dataGridViewIn_PDA;
        private Splitter splitter_PDA;
        private Panel panelOut_PDA;
        private GroupBox groupBoxOut_PDA;
        private DataGridView dataGridViewOut_PDA;
        private Button buttonQuestion_PDA;
        private Button buttonSave_PDA;
        private Button buttonDown_PDA;
        private Button buttonOpen_PDA;
        private TextBox textBoxCond_PDA;
        private OpenFileDialog openFileDialog_PDA;
        private ToolTip toolTip_PDA;
        private SaveFileDialog saveFileDialog_PDA;
        private ToolTip toolTipDown_PDA;
        private ToolTip toolTipSave_PDA;
        private ToolTip toolTipQuestion_PDA;
    }
}
