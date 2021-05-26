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
    public partial class Form28 : Form
    {
        public Form28()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new Form27();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new Form29();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new Form29();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new Form29();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new Form29();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new Form29();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new Form29();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new Form29();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }
    }
}
