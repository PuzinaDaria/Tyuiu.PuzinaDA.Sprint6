using Tyuiu.PuzinaDA.Sprint6.Task0.V14.Lib;
namespace Tyuiu.PuzinaDA.Sprint6.Task0.V14
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonOutput_PDA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_PDA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxIntX_PDA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxIntX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47) || (e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
        private void buttonQuestion_PDA_Click (object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИИПБ-24-1 Пузина Дарья Алексеевна");
        }
    }
}
