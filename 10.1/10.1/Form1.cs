namespace _10._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Чтение входных данных
                double Ct = Convert.ToDouble(txtNotebookPrice.Text); // цена тетради
                double Cb = Convert.ToDouble(txtCoverPrice.Text);    // цена обложки
                int Kt = Convert.ToInt32(txtNotebookCount.Text);      // количество тетрадей

                // Расчет общей стоимости
                double totalCost = (Ct + Cb) * Kt;

                // Отображение результата
                lblResult.Text = $"Общая стоимость: {totalCost:C}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректные значения.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
