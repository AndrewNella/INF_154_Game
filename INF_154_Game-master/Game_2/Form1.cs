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
    public partial class Form1 : Form
    {
        private System.Media.SoundPlayer music = new System.Media.SoundPlayer("Sounds\\music\\Our-Mountain_v003_Looping.wav");
        public Form1()
        {
            InitializeComponent();
            this.Text = "Main Menu";
            music.PlayLooping();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Game f = new Game();
            f.ms = this;
            this.Visible = false;
            music.Stop();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tutorial g = new Tutorial();
            g.TestMove = this;
            this.Visible = false;
            g.Show();
        }
         public Form BackToMain { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
