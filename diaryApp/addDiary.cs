using System;
using System.IO;
using System.Windows.Forms;

namespace diaryApp
{
    public partial class addDiary : Form
    {
       
        public event EventHandler DiaryAdded;

        public addDiary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(baseDirectory, @"..\..\..\diaries.txt");

         
            string date = dateTimePicker1.Value.ToString("dd MMMM yyyy dddd");

           
            string diaryText = textBox1.Text;

            
            if (string.IsNullOrWhiteSpace(diaryText))
            {
                MessageBox.Show("Lütfen bir şeyler yazın!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            string uniqueID = Guid.NewGuid().ToString();

            
            string newEntry = $"{uniqueID} | {date} | {diaryText}";

            
            try
            {
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    sw.WriteLine(newEntry);
                }
                MessageBox.Show("Günlük başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                DiaryAdded?.Invoke(this, EventArgs.Empty);

               
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
