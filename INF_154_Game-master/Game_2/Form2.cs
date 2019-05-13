using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_2
{
    public partial class Tutorial : Form
    {
        public Tutorial()
        {
            InitializeComponent();
        }

        public Form TestMove { get; set; }
        private void Tutorial_Load(object sender, EventArgs e)
        {

        }

        private void enemy_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form1 h = new Form1();
            h.BackToMain = this;
            
            this.Visible = false;
            h.Show();
        }
    }
}
