using Tyuiu.PuzinaDA.Sprint6.Task6.V5.Lib;
namespace Tyuiu.PuzinaDA.Sprint6.Task6.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonDown_PDA_Click(object sender, EventArgs e)
        {
            string str = "l";
            textBoxOutPut_PDA.Text = ds.CollectTextFromFile(str, openFilePath);
        }
        private void buttonQuestion_PDA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void buttonOpen_PDA_Click(object sender, EventArgs e)
        {
            openFileDialog_PDA.ShowDialog();
            openFilePath = openFileDialog_PDA.FileName;
            textBoxInPut_PDA.Text = File.ReadAllText(openFilePath);
            groupBoxOP_PDA.Text = groupBoxOP_PDA.Text + " " + openFileDialog_PDA.FileName;
            buttonDown_PDA.Enabled = true;
        }

       
    }
}
