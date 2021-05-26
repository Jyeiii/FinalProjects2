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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void managebutton1_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            var Form = new Vacsites();
            Form.Closed += (s, args) => this.Close();
            Form.Show();

        }

        private void registerbutton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new Citizenlist();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
