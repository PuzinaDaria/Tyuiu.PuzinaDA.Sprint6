using Tyuiu.PuzinaDA.Sprint6.Task5.V15.Lib;
namespace Tyuiu.PuzinaDA.Sprint6.Task5.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\daria\source\repos\Tyuiu.PuzinaDA.Sprint6\Tyuiu.PuzinaDA.Sprint6.Task5.V15\bin\Debug\net8.0-windows\InPutFileTask5V15.txt";
        private void buttonDown_PDA_Click(object sender, EventArgs e)
        {
            dataGridViewOutPut_PDA.ColumnCount = 2;
            dataGridViewOutPut_PDA.Columns[0].Width = 20;
            dataGridViewOutPut_PDA.Columns[1].Width = 50;

            double[] nums = new double[ds.len];

            nums = ds.LoadFromDataFile(path);

            for (int i = 0; i < nums.Length; i++)
            {
                dataGridViewOutPut_PDA.Rows.Add(Convert.ToString(i), Convert.ToString(nums[i]));
            }

        }

        private void buttonOpen_PDA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonQuestion_PDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт 6 Таск 5 Вариант 15 выполнил студент ИИПБ-24-1");
        }
    }
}
