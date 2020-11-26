using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = false;  // Остановлен таймер
            timer1.Interval = 100;     // Интервал тиков
            up = true;
            button2.Visible = false;
        }
        bool up;
        float xz, yz;                         // абсцисса и ордината центра земли
        float one;                            // единица масштаба
        float rz;                               // радиус земли
        float wz, hz;                        // левый верхний угол для земли  
        int k = 0;                              // счетчик тиков
        float teta0 = (float)(5 * Math.PI / 4); // начальный угол 
        float R0;                              // начальное расстояние от земли до спутника 
        float rs;                               // радиус спутника
        float ws, hs;                       // левый верхний угол для спутника
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureData();          // Подготовка и масштабирование данных для рисунка.            
            if (up == true)
            {
                k++;                    // счетчик тиков
            }
            else
            {
                if (k == 0)
                {
                    timer1.Enabled = false;
                    button2.Visible = false;
                    button1.Visible = true;
                }
                else
                {
                    k--;
                }
            }
            pictureBox1.Refresh();
        }
        // Подготовка и масштабирование данных для рисунка:
        private void pictureData()
        {
            xz = pictureBox1.Size.Width / 2;    // абсцисса центра земли
            yz = pictureBox1.Size.Height / 2;   // ордината центра земли
            one = Math.Min(xz, yz) / kOne;      // единица масштаба 
            rz = one * kz;                      // радиус земли
            wz = xz - rz; hz = yz - rz;         // левый верхний угол для земли   
            rs = one * ks;                      // радиус спутника
            ws = wz; hs = hz;                   // левый верхний угол для спутника
            float R;                            // расстояние от земли до спутника 
            R0 = (float)Math.Sqrt((ws - xz) * (ws - xz) + (hs - yz) * (hs - yz));
            float dR = one * kr;
            R = Math.Min(R0 + k * dR, one * 80);
            ws = (float)(R * Math.Cos(teta0 + k * dt)) + xz;
            hs = (float)(R * Math.Sin(teta0 + k * dt)) + yz;

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (!timer1.Enabled) 	// Таймер не включен
                pictureData();	// Пересчет масштабных соотношений
            pictureBox1.Refresh();	// Обновить изображение 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true; // Запустить таймер
            up = true;
            button1.Visible = false;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            up = false;
            button2.Visible = false;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics target = e.Graphics;
            Pen blackPen = new Pen(Color.Black);
            Pen greenPen = new Pen(Color.Green);
            target.FillEllipse(blackPen.Brush, ws, hs, 2 * rs, 2 * rs);
            target.FillEllipse(greenPen.Brush, wz, hz, 2 * rz, 2 * rz);
        }

        float dt = (float)(Math.PI / 100);      // приращение угла
        int kz = 15, ks = 4, kr = 1, kOne = 100;// коэффициенты 


    }
}
