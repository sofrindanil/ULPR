namespace _11._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trackBarN.Minimum = 0;   // ����������� �������� n
            trackBarN.Maximum = 100; // ������������ �������� n
            trackBarN.Value = 0;     // ��������� ��������
            lblNValue.Text = "n: 0"; // ����������� ���������� ��������
        }
        private void trackBarN_Scroll(object sender, EventArgs e)
        {
            lblNValue.Text = $"n: {trackBarN.Value}"; // ���������� �������� n ��� ���������
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int n = trackBarN.Value; // ��������� �������� n �� TrackBar
            int result;

            if (rbFormula.Checked)
            {
                // ������������� �������
                result = (n + 1) * (n + 1);
            }
            else if (rbLoop.Checked)
            {
                // ������������ � �����
                result = 0;
                for (int i = 0; i <= n; i++)
                {
                    result += (2 * i + 1);
                }
            }
            else
            {
                MessageBox.Show("����������, �������� ������ �������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // ����������� ����������
            lblResult.Text = $"����� �������� ����� �� 1 �� {2 * n + 1}: {result}";
        }
    }
}
