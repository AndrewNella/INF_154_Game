namespace Game_2
{
    partial class Tutorial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Enemy_Preview = new System.Windows.Forms.Label();
            this.LBLEnemy = new System.Windows.Forms.Label();
            this.levelupPBX_Preview = new System.Windows.Forms.Label();
            this.LBLLevel = new System.Windows.Forms.Label();
            this.brewstor_Preview = new System.Windows.Forms.Label();
            this.LBLHero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tree_Preview = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Enemy_Preview
            // 
            this.Enemy_Preview.BackColor = System.Drawing.Color.Transparent;
            this.Enemy_Preview.Image = global::Game_2.Properties.Resources.Pauline_sprite1;
            this.Enemy_Preview.Location = new System.Drawing.Point(834, 237);
            this.Enemy_Preview.Name = "Enemy_Preview";
            this.Enemy_Preview.Size = new System.Drawing.Size(44, 76);
            this.Enemy_Preview.TabIndex = 8;
            this.Enemy_Preview.Click += new System.EventHandler(this.enemy_Click);
            // 
            // LBLEnemy
            // 
            this.LBLEnemy.AutoSize = true;
            this.LBLEnemy.BackColor = System.Drawing.Color.Transparent;
            this.LBLEnemy.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLEnemy.ForeColor = System.Drawing.Color.Black;
            this.LBLEnemy.Location = new System.Drawing.Point(207, 269);
            this.LBLEnemy.Name = "LBLEnemy";
            this.LBLEnemy.Size = new System.Drawing.Size(621, 22);
            this.LBLEnemy.TabIndex = 9;
            this.LBLEnemy.Text = "This is your enemy. You must defeat him to safe  the hostage and win the game.";
            // 
            // levelupPBX_Preview
            // 
            this.levelupPBX_Preview.BackColor = System.Drawing.Color.Transparent;
            this.levelupPBX_Preview.Image = global::Game_2.Properties.Resources.levelup;
            this.levelupPBX_Preview.Location = new System.Drawing.Point(808, 126);
            this.levelupPBX_Preview.Name = "levelupPBX_Preview";
            this.levelupPBX_Preview.Size = new System.Drawing.Size(93, 93);
            this.levelupPBX_Preview.TabIndex = 10;
            // 
            // LBLLevel
            // 
            this.LBLLevel.AutoSize = true;
            this.LBLLevel.BackColor = System.Drawing.Color.Transparent;
            this.LBLLevel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLLevel.ForeColor = System.Drawing.Color.Black;
            this.LBLLevel.Location = new System.Drawing.Point(207, 156);
            this.LBLLevel.Name = "LBLLevel";
            this.LBLLevel.Size = new System.Drawing.Size(469, 22);
            this.LBLLevel.TabIndex = 11;
            this.LBLLevel.Text = "Collect these magical items to level up and become stronger";
            // 
            // brewstor_Preview
            // 
            this.brewstor_Preview.BackColor = System.Drawing.Color.Transparent;
            this.brewstor_Preview.Image = global::Game_2.Properties.Resources.brewstor1;
            this.brewstor_Preview.Location = new System.Drawing.Point(834, 19);
            this.brewstor_Preview.Name = "brewstor_Preview";
            this.brewstor_Preview.Size = new System.Drawing.Size(60, 81);
            this.brewstor_Preview.TabIndex = 12;
            // 
            // LBLHero
            // 
            this.LBLHero.AutoSize = true;
            this.LBLHero.BackColor = System.Drawing.Color.Transparent;
            this.LBLHero.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLHero.ForeColor = System.Drawing.Color.Black;
            this.LBLHero.Location = new System.Drawing.Point(207, 57);
            this.LBLHero.Name = "LBLHero";
            this.LBLHero.Size = new System.Drawing.Size(552, 22);
            this.LBLHero.TabIndex = 13;
            this.LBLHero.Text = "This is you, the hero. You must defeat the villian and safe the hostage.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(207, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "This is a tree. You can not walk through trees.";
            // 
            // Tree_Preview
            // 
            this.Tree_Preview.BackColor = System.Drawing.Color.Transparent;
            this.Tree_Preview.Image = global::Game_2.Properties.Resources.tree_trans;
            this.Tree_Preview.Location = new System.Drawing.Point(830, 332);
            this.Tree_Preview.Name = "Tree_Preview";
            this.Tree_Preview.Size = new System.Drawing.Size(64, 97);
            this.Tree_Preview.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(232, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(331, 109);
            this.button1.TabIndex = 25;
            this.button1.Text = "Return to start?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game_2.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(944, 583);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tree_Preview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBLHero);
            this.Controls.Add(this.brewstor_Preview);
            this.Controls.Add(this.LBLLevel);
            this.Controls.Add(this.levelupPBX_Preview);
            this.Controls.Add(this.LBLEnemy);
            this.Controls.Add(this.Enemy_Preview);
            this.Name = "Tutorial";
            this.Text = "How To Play";
            this.Load += new System.EventHandler(this.Tutorial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Enemy_Preview;
        private System.Windows.Forms.Label LBLEnemy;
        private System.Windows.Forms.Label levelupPBX_Preview;
        private System.Windows.Forms.Label LBLLevel;
        private System.Windows.Forms.Label brewstor_Preview;
        private System.Windows.Forms.Label LBLHero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Tree_Preview;
        private System.Windows.Forms.Button button1;
    }
}