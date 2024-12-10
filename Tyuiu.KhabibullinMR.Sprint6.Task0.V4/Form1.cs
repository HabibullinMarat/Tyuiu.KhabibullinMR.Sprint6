using Tyuiu.KhabibullinMR.Sprint6.Task0.V4.Lib;

namespace Tyuiu.KhabibullinMR.Sprint6.Task0.V4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void TextBoxVarX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != ',' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task 0 выполнил студент группы ИИПб-24-2 Хабибуллин Марат Рамильевич", "Сообщение", MessageBoxButtons.OK);
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxX.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
