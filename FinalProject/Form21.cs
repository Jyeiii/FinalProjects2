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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.Hide();
            var Form = new Form7();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Hide();
            var Form = new Form22();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }
    }
}
