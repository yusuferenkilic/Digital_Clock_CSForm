﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm");
            label2.Text = DateTime.Now.ToString("ss");
            label3.Text = DateTime.Now.ToString("dd.MM.yyyy");
            label4.Text = DateTime.Now.ToString("dddd");

            label2.Location = new Point(label1.Location.X + label1.Width , label2.Location.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        bool formTasiniyor = false;
        Point baslangicnoktasi = new Point(0, 0);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            formTasiniyor = true;
            baslangicnoktasi = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            formTasiniyor = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (formTasiniyor)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.baslangicnoktasi.X, p.Y - this.baslangicnoktasi.Y);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox3.Enabled = true;
            pictureBox2.Enabled = false;
            timer2.Start();
        }

        int a = 0;
        int b = 0;
        int c = 0;

        private void timer2_Tick(object sender, EventArgs e)
        {
            a++;
            b++;
            c++;
            label1.BackColor = Color.FromArgb(192 - a , 192 - b , 192 - c);
            label1.ForeColor = Color.FromArgb(37 + a , 37 + b , 37 + c);

            label2.BackColor = Color.FromArgb(192 - a, 192 - b, 192 - c);
            label2.ForeColor = Color.FromArgb(37 + a, 37 + b, 37 + c);

            label3.BackColor = Color.FromArgb(192 - a, 192 - b, 192 - c);
            label3.ForeColor = Color.FromArgb(37 + a, 37 + b, 37 + c);

            label4.BackColor = Color.FromArgb(192 - a, 192 - b, 192 - c);
            label4.ForeColor = Color.FromArgb(37 + a, 37 + b, 37 + c);

            label5.BackColor = Color.FromArgb(192 - a, 192 - b, 192 - c);
            label5.ForeColor = Color.FromArgb(37 + a, 37 + b, 37 + c);

            label6.BackColor = Color.FromArgb(192 - a, 192 - b, 192 - c);
            label6.ForeColor = Color.FromArgb(37 + a, 37 + b, 37 + c);

            this.BackColor = Color.FromArgb(192 - a, 192 - b, 192 - c);
            panel1.BackColor = Color.FromArgb(192 - a, 192 - b, 192 - c);
            pictureBox4.BackColor = Color.FromArgb(192 - a, 192 - b, 192 - c);

            if (label1.BackColor == Color.FromArgb(37,37,37))
            {
                timer2.Stop();
                a = 0;
                b = 0;
                c = 0;
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Enabled = false;
            pictureBox2.Enabled = true;
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            a++;
            b++;
            c++;
            label1.BackColor = Color.FromArgb(37 + a, 37 + b, 37 + c);
            label1.ForeColor = Color.FromArgb(192 - a, 192 - b, 192 - c);

            label2.BackColor = Color.FromArgb(37 + a, 37 + b, 37 + c);
            label2.ForeColor = Color.FromArgb(192 - a, 192 - b, 192 - c);

            label3.BackColor = Color.FromArgb(37 + a, 37 + b, 37 + c);
            label3.ForeColor = Color.FromArgb(192 - a, 192 - b, 192 - c);

            label4.BackColor = Color.FromArgb(37 + a, 37 + b, 37 + c);
            label4.ForeColor = Color.FromArgb(192 - a, 192 - b, 192 - c);

            label5.BackColor = Color.FromArgb(37 + a, 37 + b, 37 + c);
            label5.ForeColor = Color.FromArgb(192 - a, 192 - b, 192 - c);

            label6.BackColor = Color.FromArgb(37 + a, 37 + b, 37 + c);
            label6.ForeColor = Color.FromArgb(192 - a, 192 - b, 192 - c);

            this.BackColor = Color.FromArgb(37 + a, 37 + b, 37 + c);
            panel1.BackColor = Color.FromArgb(37 + a, 37 + b, 37 + c);
            pictureBox4.BackColor = Color.FromArgb(37 + a, 37 + b, 37 + c);

            if (label1.BackColor == Color.FromArgb(192,192,192))
            {
                timer3.Stop();
                a = 0;
                b = 0;
                c = 0;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
