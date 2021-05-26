using System;
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
    public partial class Vacsites : Form
    {
        public Vacsites()
        {
            InitializeComponent();
        }

       

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new Form7();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new Form7();
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

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new Form9();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new admin();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new Form2();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new admin();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }
    }
}
