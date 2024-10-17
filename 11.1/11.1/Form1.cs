namespace _11._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trackBarN.Minimum = 0;   // Минимальное значение n
            trackBarN.Maximum = 100; // Максимальное значение n
            trackBarN.Value = 0;     // Начальное значение
            lblNValue.Text = "n: 0"; // Отображение начального значения
        }
        private void trackBarN_Scroll(object sender, EventArgs e)
        {
            lblNValue.Text = $"n: {trackBarN.Value}"; // Обновление значения n при прокрутке
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int n = trackBarN.Value; // Получение значения n из TrackBar
            int result;

            if (rbFormula.Checked)
            {
                // Использование формулы
                result = (n + 1) * (n + 1);
            }
            else if (rbLoop.Checked)
            {
                // Суммирование в цикле
                result = 0;
                for (int i = 0; i <= n; i++)
                {
                    result += (2 * i + 1);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите способ расчета.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Отображение результата
            lblResult.Text = $"Сумма нечётных чисел от 1 до {2 * n + 1}: {result}";
        }
    }
}
