using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.Equals("")) || (textBox2.Text.Equals("")) || (textBox3.Text.Equals("")) || (textBox4.Text.Equals("")) || (textBox5.Text.Equals("")) || (textBox6.Text.Equals("")) || (comboBox1.Text.Equals("")) || (radioButton1.Text.Equals("")) || (radioButton2.Text.Equals("")))
                label8.Text = "Не все данные введены!";
            else
                MessageBox.Show(
                "Данные сохранены",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                
            using (StreamWriter sw = new StreamWriter(@"D:\Страхователи.txt"))
                {
                    sw.Write("Страхователь\n");
                    sw.Write("Фамилия:");
                    sw.Write(textBox2.Text);
                    sw.Write("\nИмя:");
                    sw.Write(textBox1.Text);
                    sw.Write("\nДата рождения:");
                    sw.Write(dateTimePicker1.Text);
                    sw.Write("\nПол:");
                    sw.Write(radioButton1.Text);
                    sw.Write("\nАдрес");
                    sw.Write("\nГород:");
                    sw.Write(textBox4.Text);
                    sw.Write("\nУлица:");
                    sw.Write(textBox3.Text);
                    sw.Write("\nДом:");
                    sw.Write(textBox5.Text);
                    sw.Write("\nКвартира:");
                    sw.Write(textBox6.Text);
                    sw.Write("\nСтрахование");
                    sw.Write("\nВид страхования:");
                    sw.Write(comboBox1.Text);
                    sw.Write("\nСрок страхования:");
                    sw.Write(numericUpDown1.Value);
                }
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear(); textBox6.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
