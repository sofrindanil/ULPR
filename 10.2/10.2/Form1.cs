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
                int n = Convert.ToInt32(txtN.Text); // ���� �������� n
                double result;

                if (rbFormula.Checked)
                {
                    // ������������� �������
                    result = Math.Pow(n, 2) * Math.Pow(n + 1, 2) / 4;
                }
                else if (rbLoop.Checked)
                {
                    // ������������ � �����
                    result = 0;
                    for (int i = 1; i <= n; i++)
                    {
                        result += Math.Pow(i, 3);
                    }
                }
                else
                {
                    MessageBox.Show("����������, �������� ������ �������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ����������� ����������
                lblResult.Text = $"����� ����� �� 1 �� {n}: {result}";
            }
            catch (FormatException)
            {
                MessageBox.Show("����������, ������� ���������� �������� ��� n.", "������ �����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

