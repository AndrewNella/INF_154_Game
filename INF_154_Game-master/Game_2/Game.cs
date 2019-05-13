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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            mediaPlayer.URL = "Sounds\\music\\Game.wav";
            mediaPlayer.settings.setMode("loop", true);
            mediaPlayer.Ctlcontrols.play();
            this.Text = "Game";
            step.Load();
            bump.Load();
            music.LoadAsync();
            music.Play();
            brewstor.Size = new Size(bXSize, bYSize);
            enemy.Size = new Size(eXSize, eYSize);
            levelupPBX.Size = new Size(lXSize, lYSize);
            labels[0] = tree;
            labels[1] = tree1;
            labels[2] = tree2;
            labels[3] = tree3;
            labels[4] = tree4;
            labels[5] = tree5;
            labels[6] = tree6;
            labels[7] = tree7;
            labels[8] = tree8;
            labels[9] = tree9;
            labels[10] = tree10;
            labels[11] = tree11;
            labels[12] = tree12;
            labels[13] = tree13;
            labels[14] = tree14;
            labels[15] = tree15;
            labels[16] = tree16;
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void moveB(KeyEventArgs e)
        {
            step.Load();
            bump.Load();
            moveE();
            int bX = brewstor.Location.X, bY = brewstor.Location.Y;
            switch (e.KeyCode.ToString())
            {
                case "W":
                    bY -= bVel;
                    break;
                case "S":
                    bY += bVel;
                    break;
                case "A":
                    bX -= bVel;
                    break;
                case "D":
                    bX += bVel;
                    break;
                case "F3":
                    break;
            }
                
            
            brewstor.Location = new Point(clamp(bX, minX, maxX), clamp(bY, minY, maxY));
            bool tree = false;
            foreach (Label l in labels) if (hit(brewstor, l)) tree = true;
            if (!tree)
            {
                step.Play();
                pBX = bX;
                pBY = bY;
            }
            else
            {
                bump.Play();
                brewstor.Location = new Point(clamp(pBX, minX, maxX), clamp(pBY, minY, maxY));
            }
            if (hit(brewstor, enemy)) fight();
            levelUp();
            if (levelupspawned && hit(brewstor, levelupPBX)) gotLevel();
            this.Refresh();
        }

        private void fight()
        {
            mediaPlayer.Ctlcontrols.stop();
            liv--;
            lives.Text = "Lives: " + liv;
            if(liv <= 0)
            {
                MessageBox.Show("Game Over");
                ms.Show();
                this.Hide();
            }
            Fight f = new Fight(level);
            f.game = this;
            this.Visible = false;
            f.Show();
            enemy.Location = new Point(brewstor.Location.X, (brewstor.Location.Y + bYSize + 40));
        }

        private void gotLevel()
        {
            level = clamp(level + 1, 0, 4);
            lives.Text = "Level: " + level;
            levelupPBX.Visible = false;
            levelupspawned = false;
            liv++;
            lives.Text = "Lives: " + liv;
            MessageBox.Show("Leveled up!!");
            if (level == 4) MessageBox.Show("Max level!");
        }

        private void moveE()
        {
            int eX = enemy.Location.X, eY = enemy.Location.Y;
            int bX = brewstor.Location.X, bY = brewstor.Location.Y;
            if (eX < bX) eX += eVel;
            else if (eX > bX) eX -= eVel;
            if (eY < bY) eY += eVel;
            else if (eY > bY) eY -= eVel;
            enemy.Location = new Point(clamp(eX, minX, maxX), clamp(eY, minY, maxY));
        }

        private void levelUp()
        {
            Random r = new Random();
            int ran = r.Next(1, (level * 10));
            if (ran == levelval && !levelupspawned && level < 4)
            {
                levelupPBX.Location = new Point(r.Next(minX, maxX), r.Next(minY, maxY));
                if (!hit(brewstor, levelupPBX))
                {
                    levelupPBX.Visible = true;
                    levelupspawned = true;
                }
            }
        }

        private bool hit(Label a, Label b)
        {
            return !((b.Location.Y > (a.Location.Y + a.Size.Height) || a.Location.Y > (b.Location.Y + b.Size.Height)) || 
                (b.Location.X > (a.Location.X + a.Size.Width) || a.Location.X > (b.Location.X + b.Size.Width)));
        }

        private int clamp(int Var, int min, int max)
        {
            if (Var > max) return max;
            else if (Var < min) return min;
            return Var;
        }


        private void Game_Load(object sender, EventArgs e)
        {
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            moveB(e);
        }

        public Form ms { get; set; }

        private const int minY = 0,
            maxY = 650,
            minX = 0, //1220, 650
            maxX = 1220,
            bXSize = 58,
            bYSize = 70,
            eXSize = 40,
            eYSize = 64,
            lXSize = 90,
            lYSize = 90,
            bVel = 10,
            eVel = 5;

        private void levelupPBX_Click(object sender, EventArgs e)
        {

        }

        private void Game_Activated(object sender, EventArgs e)
        {
            mediaPlayer.URL = "Sounds\\music\\Game.wav";
            mediaPlayer.settings.setMode("loop", true);
            mediaPlayer.Ctlcontrols.play();
        }

        public int level = 4,
            liv = 3,
            pBX = 0,
            pBY = 0;

        private int levelval = new Random().Next(0, 10);
        private bool levelupspawned = false;
        private Label[] labels = new Label[17];
        private System.Media.SoundPlayer step = new System.Media.SoundPlayer("Sounds\\effects\\Footstep.wav");
        private System.Media.SoundPlayer bump = new System.Media.SoundPlayer("Sounds\\effects\\hit.wav");
        private System.Media.SoundPlayer music = new System.Media.SoundPlayer("Sounds\\music\\Game.wav");
    }
}
