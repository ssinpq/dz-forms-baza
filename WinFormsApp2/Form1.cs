namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string filePath = txtMyInput.Text;

            try
            {
                string fileContent = File.ReadAllText(filePath);
                txtFileContent.Text = fileContent;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Ви не вказали шлях до файлу або шлях містить недопустимі символи.",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Файл не знайдено. Перевірте назву файлу.",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Невірний шлях до файлу: такої папки не існує.",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NotSupportedException)
            {
                MessageBox.Show("Невірний формат шляху до файлу.",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Немає доступу до цього файлу.",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Помилка читання файлу: " + ex.Message,
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
