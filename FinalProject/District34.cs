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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new Vacsites();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new Form4();
            Form.Closed += (s, args) => this.Close();
            Form.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new Form3();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new Form4();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new Form4();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new Form4();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
