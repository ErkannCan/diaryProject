using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace diaryApp
{
    public partial class Form1 : Form
    {
        private const int TextBoxWidth = 600;
        private const int TextBoxHeight = 40;
        private string filePath;
        private Label noEntriesLabel; 

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadDiary()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            filePath = Path.Combine(baseDirectory, @"..\..\..\diaries.txt");

            
            ClearDynamicControls();

            
            if (File.Exists(filePath))
            {
                try
                {
                    
                    string[] lines = File.ReadAllLines(filePath);

                    if (lines.Length == 0)
                    {
                        
                        ShowNoEntriesMessage();
                    }
                    else
                    {
                        
                        DisplayDiaryEntries(lines);
                    }
                }
                catch (Exception ex)
                {
                   
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
            else
            {
                
                ShowNoEntriesMessage();
            }
        }

        private void ClearDynamicControls()
        {
            
            foreach (Control control in this.Controls.OfType<Label>().ToList())
            {
                if (control != label1) 
                {
                    this.Controls.Remove(control);
                    control.Dispose();
                }
            }

            foreach (Control control in this.Controls.OfType<TextBox>().ToList())
            {
                this.Controls.Remove(control);
                control.Dispose();
            }

            foreach (Control control in this.Controls.OfType<Button>().ToList())
            {
                if (control != button1) 
                {
                    this.Controls.Remove(control);
                    control.Dispose();
                }
            }
        }

        private void ShowNoEntriesMessage()
        {
            
            if (noEntriesLabel != null)
            {
                this.Controls.Remove(noEntriesLabel);
                noEntriesLabel.Dispose();
            }

           
            noEntriesLabel = new Label
            {
                Text = "Herhangi bir günlük mevcut değil." +
                " Yeni günlük eklemek için 'Yeni Günlük Ekle' butonunu kullanabilirsiniz!.",
                AutoSize = true,
                ForeColor = Color.Black
            };

            
            this.Controls.Add(noEntriesLabel);
            noEntriesLabel.AutoSize = true; 

            
            noEntriesLabel.Location = new Point((this.ClientSize.Width - noEntriesLabel.Width) / 2, (this.ClientSize.Height - noEntriesLabel.Height) / 2);
        }

        private void DisplayDiaryEntries(string[] lines)
        {
            int yPosition = label1.Bottom + 10; 

            foreach (string line in lines)
            {
               
                string[] parts = line.Split(new[] { '|' }, 3);
                if (parts.Length < 3) continue; 

                
                string id = parts[0].Trim(); 
                string date = parts[1].Trim();
                string diaryText = parts[2].Trim();

               
                Label dateLabel = new Label
                {
                    Text = date,
                    AutoSize = true,
                    Location = new Point(10, yPosition),
                    BackColor = Color.LightGray
                };

                
                TextBox diaryTextBox = new TextBox
                {
                    Multiline = true,
                    ScrollBars = ScrollBars.Vertical,
                    Location = new Point(10, dateLabel.Bottom + 5),
                    Size = new Size(600, 100),
                    BackColor = Color.LightYellow,
                    Text = diaryText
                };

               
                Button deleteButton = new Button
                {
                    Text = "Sil",
                    Size = new Size(75, 30),
                    BackColor = Color.Red,
                    ForeColor = Color.White
                };

                
                int buttonYPosition = diaryTextBox.Top + (diaryTextBox.Height - deleteButton.Height) / 2;
                deleteButton.Location = new Point(diaryTextBox.Right + 10, buttonYPosition);

                
                deleteButton.Click += (sender, e) =>
                {
                    DialogResult result = MessageBox.Show("Bu günlük silinecek. Emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        DeleteEntry(line);
                    }
                };

               
                this.Controls.Add(dateLabel);
                this.Controls.Add(diaryTextBox);
                this.Controls.Add(deleteButton);

               
                yPosition = diaryTextBox.Bottom + 15; 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDiary();
        }

        private void DeleteEntry(string lineToDelete)
        {
            try
            {
                
                var lines = File.ReadAllLines(filePath).ToList();

                
                var lineToDeleteIndex = lines.IndexOf(lineToDelete);
                if (lineToDeleteIndex != -1)
                {
                   
                    lines.RemoveAt(lineToDeleteIndex);

                    
                    File.WriteAllLines(filePath, lines);

                   
                    LoadDiary();
                }
                else
                {
                    MessageBox.Show("Günlük bulunamadı.");
                }
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addDiary addD = new addDiary();
            addD.DiaryAdded += (s, args) =>
            {
                LoadDiary(); 
            };
            addD.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
