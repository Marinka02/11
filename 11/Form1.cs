using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// подключили библиотечку
using System.Text.RegularExpressions;

namespace _11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // выполнить 1
        private void выполнитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = "aa aba abba abbba abca abea";
            Regex regex = new Regex("ab{1,3}a");
            // добавляем результаты в коллекцию
            MatchCollection matches = regex.Matches(str);
            // если удалось что-то найти
            if (matches.Count > 0)
            {
                // заполняем листбокс результатами
                for(int i = 0; i < matches.Count; i++)
                {
                    listBox1.Items.Add(matches[i]);
                }
            }
        }
        // выполнить 2
        private void выполнитьЗадание2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = "a1a a2a a3a a4a a5a aba aca";
            Regex regex = new Regex("a\\d{1}a");
            // добавляем результаты в коллекцию
            MatchCollection matches = regex.Matches(str);
            // если удалось что-то найти
            if (matches.Count > 0)
            {
                // заполняем листбокс результатами
                for (int i = 0; i < matches.Count; i++)
                {
                    listBox2.Items.Add(matches[i]);
                }
            }
        }
        // о программе
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание 1:\nДана строка 'aa aba abba abbba abca abea'. " +
                "Напишите регулярное выражение, которое найдет строки aa, aba, abba, abbba.\nЗадание 2:\n" +
                "Дана строка 'a1a a2a a3a a4a a5a aba aca'. Напишите регулярное выражение, которое найдет строки," +
                " в которых по краям стоят буквы 'a', а между ними одна цифра.");
        }
        // выход
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
