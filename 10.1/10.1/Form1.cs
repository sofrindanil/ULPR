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
                // ������ ������� ������
                double Ct = Convert.ToDouble(txtNotebookPrice.Text); // ���� �������
                double Cb = Convert.ToDouble(txtCoverPrice.Text);    // ���� �������
                int Kt = Convert.ToInt32(txtNotebookCount.Text);      // ���������� ��������

                // ������ ����� ���������
                double totalCost = (Ct + Cb) * Kt;

                // ����������� ����������
                lblResult.Text = $"����� ���������: {totalCost:C}";
            }
            catch (FormatException)
            {
                MessageBox.Show("����������, ������� ���������� ��������.", "������ �����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
