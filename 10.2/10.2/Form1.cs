namespace _10._2
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
                int n = Convert.ToInt32(txtN.Text); // Ввод значения n
                double result;

                if (rbFormula.Checked)
                {
                    // Использование формулы
                    result = Math.Pow(n, 2) * Math.Pow(n + 1, 2) / 4;
                }
                else if (rbLoop.Checked)
                {
                    // Суммирование в цикле
                    result = 0;
                    for (int i = 1; i <= n; i++)
                    {
                        result += Math.Pow(i, 3);
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите способ расчета.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Отображение результата
                lblResult.Text = $"Сумма кубов от 1 до {n}: {result}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректное значение для n.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

