using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Виселяк
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = button2;
            this.AcceptButton = button3;
        }
        public string text;
        public char[] word;
        public int hp;
        public int hptrue;
        private int wins = 0;
        private int losses = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            text = GetRandomWord();
            hp = 0;
            hptrue = 0;
            label1.Text = null;
            textBox1.Text = null;
            pictureBox1.Image = null;
            word = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                label1.Text += '.';
                word[i] = '.';
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Пустое поле", "Ошибка");
                return; // Выходим из метода, если текстовое поле пустое
            }
            bool words = false;

            if (textBox2.Text.Length == 1) // Для одной буквы
            {

                for (int i = 0; i < text.Length; i++)
                {
                    if (textBox2.Text[0] == text[i])
                    {
                        if (word[i] != text[i]) // Проверяем, не была ли эта буква уже угадана
                        {
                            words = true;
                            hptrue++;
                            word[i] = text[i];
                            label1.Text = null;
                        }
                    }
                }

                if (words == true)
                {
                    for (int i = 0; i < text.Length; i++)
                    {
                        label1.Text += word[i];
                    }

                    if (hptrue == text.Length)
                    {
                        MessageBox.Show("Ты победил!");
                        wins++;
                        UpdateWinsCounter();
                    }
                }
                else
                {
                    hp++;
                    string hpbuff = hp.ToString() + ".png";
                    pictureBox1.Image = new Bitmap(hpbuff);

                    if (hp == 10)
                    {
                        MessageBox.Show("Ты проиграл!");
                        label1.Text = null;
                        label1.Text = text;
                        losses++;
                        UpdateLossesCounter();
                    }
                }
            }
            else if (textBox2.Text.Length > 2)
            {
                if (textBox2.Text == text)
                {
                    label1.Text = null;
                    for (int i = 0; i < text.Length; i++)
                    {
                        label1.Text += text[i];
                    }
                    MessageBox.Show("Ты победил!");
                    wins++;
                    UpdateWinsCounter();
                    label1.Text = text;
                }
                else
                {
                    hp = 10;
                    string hpbuff = hp.ToString() + ".png";
                    pictureBox1.Image = new Bitmap(hpbuff);
                    MessageBox.Show("Ты проиграл!");
                    label1.Text = null;
                    label1.Text = text;
                    losses++;
                    UpdateLossesCounter();
                }
            }

            textBox2.Text = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        // Метод для обновления счетчика выигрышей
        private void UpdateWinsCounter()
        {
            labelWins.Text = $"Выигрыши: {wins}";
        }

        // Метод для обновления счетчика проигрышей
        private void UpdateLossesCounter()
        {
            labelLosses.Text = $"Проигрыши: {losses}";
        }
        private string GetRandomWord()
        {
            string[] words = System.IO.File.ReadAllLines("dictionary.txt");
            if (words.Length > 0)
            {
                Random random = new Random();
                int randomIndex = random.Next(0, words.Length);
                return words[randomIndex];
            }
            else
            {
                // Если файл со словарем пуст, верните пустую строку или обработайте эту ситуацию по своему усмотрению.
                return "";
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string word = textBox1.Text; // Получите новое слово из текстового поля textBoxWord

            // Добавьте новое слово в файл со словарем
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("dictionary.txt", true))
            {
                file.WriteLine(word);
            }

            textBox1.Text = ""; // Очистите текстовое поле textBoxWord после добавления слова
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка наличия файла dictionary.txt
                if (File.Exists("dictionary.txt"))
                {
                    // Чтение содержимого файла
                    string[] words = File.ReadAllLines("dictionary.txt");

                    // Проверка наличия доступных слов
                    if (words.Length > 0)
                    {
                        // Создание строки, содержащей все доступные слова
                        string wordsString = string.Join(Environment.NewLine, words);

                        // Отображение окна сообщения с доступными словами
                        MessageBox.Show(wordsString, "Доступные слова");
                    }
                    else
                    {
                        MessageBox.Show("Нет доступных слов", "Доступные слова");
                    }
                }
                else
                {
                    MessageBox.Show("Файл dictionary.txt не найден", "Ошибка");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при чтении файла: {ex.Message}", "Ошибка");
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
