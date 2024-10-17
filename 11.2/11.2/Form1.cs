namespace _11._2
{
    public partial class Form1 : Form
    {
        private const string FileName = "zodiacData.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var znaki = GenerateZodiacRecords(8);
            SaveToFile(znaki);
            MessageBox.Show("Данные сгенерированы и сохранены в файл.");
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            var records = ReadFromFile();
            DisplayRecords(listBoxAll, records);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMonth.Text, out int month) && month >= 1 && month <= 12)
            {
                var records = ReadFromFile();
                var filteredRecords = records.Where(r => r.DateOfBirth.Month == month).ToList();

                if (filteredRecords.Any())
                {
                    DisplayRecords(listBoxFiltered, filteredRecords);
                    lblMessage.Text = ""; // Убираем сообщение об ошибке
                }
                else
                {
                    lblMessage.Text = "Нет людей, родившихся в этом месяце.";
                    listBoxFiltered.Items.Clear();
                }
            }
            else
            {
                lblMessage.Text = "Введите корректный номер месяца (1-12).";
                listBoxFiltered.Items.Clear();
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            listBoxAll.Items.Clear();
            listBoxFiltered.Items.Clear();
            txtMonth.Clear();
            lblMessage.Text = "";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var filteredRecords = listBoxFiltered.Items.Cast<string>().ToList();

            if (!filteredRecords.Any())
            {
                MessageBox.Show("Нет данных для сохранения.");
                return;
            }

            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (var record in filteredRecords)
                        {
                            writer.WriteLine(record);
                        }
                    }
                    MessageBox.Show("Данные сохранены.");
                }
            }
        }

        private List<ZNAK> GenerateZodiacRecords(int count)
        {
            var firstNames = new List<string>
    {
        "Иван", "Петр", "Сидор", "Алекс", "Борис", "Кузьма",
        "Сергей", "Павел"
    };

            var lastNames = new List<string>
    {
        "Иванов", "Петров", "Сидоров", "Александров",
        "Борисов", "Кузнецов", "Смирнов", "Попов"
    };

            var znaki = new List<ZNAK>();
            var rnd = new Random();

            for (int i = 0; i < count; i++)
            {
                var firstName = firstNames[rnd.Next(firstNames.Count)];
                var lastName = lastNames[rnd.Next(lastNames.Count)];
                var day = rnd.Next(1, 29); // Генерация случайного дня
                var month = rnd.Next(1, 13); // Генерация случайного месяца
                var year = rnd.Next(1950, 2005); // Генерация года

                var fullName = $"{firstName} {lastName}";
                var dateOfBirth = new DateTime(year, month, day);
                var zodiac = GetZodiacSign(day, month);

                znaki.Add(new ZNAK(fullName, zodiac, dateOfBirth));
            }

            return znaki;
        }

        private string GetZodiacSign(int day, int month)
        {
            if ((month == 1 && day >= 20) || (month == 2 && day <= 18)) return "Водолей";
            if ((month == 2 && day >= 19) || (month == 3 && day <= 20)) return "Рыбы";
            if ((month == 3 && day >= 21) || (month == 4 && day <= 19)) return "Овен";
            if ((month == 4 && day >= 20) || (month == 5 && day <= 20)) return "Телец";
            if ((month == 5 && day >= 21) || (month == 6 && day <= 20)) return "Близнецы";
            if ((month == 6 && day >= 21) || (month == 7 && day <= 22)) return "Рак";
            if ((month == 7 && day >= 23) || (month == 8 && day <= 22)) return "Лев";
            if ((month == 8 && day >= 23) || (month == 9 && day <= 22)) return "Дева";
            if ((month == 9 && day >= 23) || (month == 10 && day <= 22)) return "Весы";
            if ((month == 10 && day >= 23) || (month == 11 && day <= 21)) return "Скорпион";
            if ((month == 11 && day >= 22) || (month == 12 && day <= 21)) return "Стрелец";
            return "Козерог";
        }

        private void SaveToFile(List<ZNAK> znaki)
        {
            using (var writer = new StreamWriter(FileName))
            {
                foreach (var znak in znaki)
                {
                    writer.WriteLine($"{znak.FullName};{znak.ZodiacSign};{znak.DateOfBirth.ToString("yyyy-MM-dd")}");
                }
            }
        }

        private List<ZNAK> ReadFromFile()
        {
            var records = new List<ZNAK>();

            if (File.Exists(FileName))
            {
                using (var reader = new StreamReader(FileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split(';');
                        if (parts.Length == 3 && DateTime.TryParse(parts[2], out var dateOfBirth))
                        {
                            records.Add(new ZNAK(parts[0], parts[1], dateOfBirth));
                        }
                    }
                }
            }

            return records.OrderBy(z => z.ZodiacSign).ToList(); // Сортировка по знакам Зодиака
        }

        private void DisplayRecords(ListBox listBox, List<ZNAK> records)
        {
            listBox.Items.Clear();
            foreach (var record in records)
            {
                listBox.Items.Add(record.ToString());
            }
        }

        private void txtMonth_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class ZNAK
    {
        public string FullName { get; set; }
        public string ZodiacSign { get; set; }
        public DateTime DateOfBirth { get; set; }

        public ZNAK(string fullName, string zodiacSign, DateTime dateOfBirth)
        {
            FullName = fullName;
            ZodiacSign = zodiacSign;
            DateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            return $"{FullName}, {ZodiacSign}, {DateOfBirth.ToShortDateString()}";
        }
    }
}
