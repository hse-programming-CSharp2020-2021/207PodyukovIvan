using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int number = 0;
        public static List<int> list = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            number++;
            if (number > 2)
            {
                list.Add(list[number - 3] + list[number - 2] * 2);
            }
            if (list[list.Count - 1] < 0)
            {
                number = 0;
                list.Clear();
                list.Add(1);
                list.Add(2);
                label1.Text = "Член ряда Пелла: ";
                MessageBox.Show("Переполнение! Ряд начнём с начала!");
            }
            else
            {
                label1.Text = "Член ряда Пелла: " + list[number - 1];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list.Add(1);
            list.Add(2);
        }
    }
}
