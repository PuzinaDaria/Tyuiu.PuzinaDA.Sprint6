using Tyuiu.PuzinaDA.Sprint6.Task1.V13.Lib;
namespace Tyuiu.PuzinaDA.Sprint6.Task1.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDown_PDA_Click (object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartValue_PDA.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue_PDA.Text);

                string strLine;
                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] res = new double[len];
                res = ds.GetMassFunction(startValue, stopValue);
                textBoxResult_PDA.Text = "";
                textBoxResult_PDA.AppendText("+---------+----------+" + Environment.NewLine);
                textBoxResult_PDA.AppendText("|    X    |   f(x)   |" + Environment.NewLine);
                textBoxResult_PDA.AppendText("+---------+----------+" + Environment.NewLine);
                for (int i = 0; i < len; i++)
                {
                    strLine = String.Format("|{0,5:d}    | {1, 6:f2}   | ", startValue, res[i]);
                    textBoxResult_PDA.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxResult_PDA.AppendText("+---------+----------+");
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
        private void buttonQuestion_PDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 Вариант 13 выполнил студент ИИПБ-24-1 Пузина Дарья");
        }
    }
}
