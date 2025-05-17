using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { }
        private void textBox1_TextChanged(object sender, EventArgs e)
            
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string fullName = textBox1.Text.Trim();
            string group = comboBox1.SelectedItem?.ToString();
            string subject = comboBox2.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(fullName) || group == null || subject == null)
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return;
            }

            try
            {
                var wordApp = new Word.Application();
                wordApp.Visible = false;
                var doc = wordApp.Documents.Add();
                string reportText = $"Отчёт о практической работе по {subject} студента {group}, {fullName}.";
                var para = doc.Content.Paragraphs.Add();
                para.Range.Text = reportText;
                string path = @"C:\Users\User\Desktop\отчеты\ОтчётПрактика.docx";
                doc.SaveAs2(path);
                doc.Close();
                wordApp.Quit();
                MessageBox.Show($"Отчёт успешно создан и сохранен в: {path}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
        
    

