
namespace diaryApp
{
    partial class addDiary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addDiary));
            textBox1 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            label1 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.Color.BlanchedAlmond;
            textBox1.Location = new System.Drawing.Point(36, 103);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = " Buraya yazınız...";
            textBox1.Size = new System.Drawing.Size(359, 316);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.BlanchedAlmond;
            button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(483, 200);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(136, 69);
            button1.TabIndex = 1;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = System.Drawing.Color.Blue;
            dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(255, 128, 255);
            dateTimePicker1.Location = new System.Drawing.Point(502, 101);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
            label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(313, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(216, 45);
            label1.TabIndex = 3;
            label1.Text = "GÜNLÜK EKLE";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.BlanchedAlmond;
            button2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button2.Location = new System.Drawing.Point(638, 200);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(136, 69);
            button2.TabIndex = 4;
            button2.Text = "İptal";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // addDiary
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "addDiary";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "GÜNLÜĞÜM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}