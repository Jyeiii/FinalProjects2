﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new Form13();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new Form9();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new Form14();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new Form18();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new Form18();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new Form8();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new Form8();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new Form9();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }
    }
}
