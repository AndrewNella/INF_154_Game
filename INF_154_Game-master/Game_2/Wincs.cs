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
    public partial class Wincs : Form
    {
        public Wincs()
        {
            InitializeComponent();
            this.Text = "You Won!!!";
            MessageBox.Show("You Saved...");
        }

        private void WinBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
