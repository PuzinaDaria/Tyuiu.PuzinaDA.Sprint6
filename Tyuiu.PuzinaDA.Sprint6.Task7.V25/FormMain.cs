using System.Data.Common;
using System.IO;
using Tyuiu.PuzinaDA.Sprint6.Task7.V25.Lib;
namespace Tyuiu.PuzinaDA.Sprint6.Task7.V25
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        static string openFilePath;
        static int colums;
        static int rows;
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_PDA.Filter = "Значения, разделённые запятой(*.csv)|*.csv|(*.*)|*.*";
            saveFileDialog_PDA.Filter = "Значения, разделённые запятой(*.csv)|*.csv|(*.*)|*.*";
        }
        public static int[,] LoadFromFileData(string filePath)
        {


            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace("\n", "\r");
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            colums = lines[0].Split(";").Length;
            int[,] arrayValues = new int[rows, colums];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(";");
                for (int c = 0; c < colums; c++)
                {
                    arrayValues[i, c] = Convert.ToInt32(line_r[c]);
                }

            }
            return arrayValues;
        }

        private void buttonOpen_PDA_Click(object sender, EventArgs e)
        {
            openFileDialog_PDA.ShowDialog();
            openFilePath = openFileDialog_PDA.FileName;
            int[,] arrayValues = new int[rows, colums];
            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_PDA.ColumnCount = colums;
            dataGridViewIn_PDA.RowCount = rows;
            dataGridViewOut_PDA.ColumnCount = colums;
            dataGridViewOut_PDA.RowCount = rows;

            for (int i = 0; i < colums; i++)
            {
                dataGridViewIn_PDA.Columns[i].Width = 35;
                dataGridViewOut_PDA.Columns[i].Width = 35;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    dataGridViewIn_PDA.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonDown_PDA.Enabled = true;

        }

        private void buttonDown_PDA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = ds.GetMatrix(openFilePath);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    dataGridViewOut_PDA.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            buttonSave_PDA.Enabled = true;
        }

        private void buttonSave_PDA_Click(object sender, EventArgs e)
        {
            saveFileDialog_PDA.FileName = saveFileDialog_PDA.FileName;
            saveFileDialog_PDA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_PDA.ShowDialog();

            string path = saveFileDialog_PDA.FileName;

            FileInfo fl = new FileInfo(path);
            bool fileExists = fl.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOut_PDA.RowCount;
            int column = dataGridViewOut_PDA.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column-1; j++)
                {
                    if (j != column - 1)
                    {
                        str = str + dataGridViewOut_PDA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_PDA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }

        }

        private void buttonQuestion_PDA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
