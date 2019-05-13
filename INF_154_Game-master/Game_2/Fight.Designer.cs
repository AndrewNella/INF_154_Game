namespace Game_2
{
    partial class Fight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fight));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kickBTN = new System.Windows.Forms.Button();
            this.punchBTN = new System.Windows.Forms.Button();
            this.BlockBTN = new System.Windows.Forms.Button();
            this.bHL = new System.Windows.Forms.Label();
            this.bHealthPBX = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pHL = new System.Windows.Forms.Label();
            this.pHealthPBX = new System.Windows.Forms.PictureBox();
            this.bHBack = new System.Windows.Forms.PictureBox();
            this.pHBack = new System.Windows.Forms.PictureBox();
            this.music = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bHealthPBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHealthPBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bHBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.music)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.kickBTN);
            this.groupBox1.Controls.Add(this.punchBTN);
            this.groupBox1.Controls.Add(this.BlockBTN);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Script", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(983, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fight!!!";
            // 
            // kickBTN
            // 
            this.kickBTN.BackColor = System.Drawing.Color.Transparent;
            this.kickBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kickBTN.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kickBTN.Location = new System.Drawing.Point(12, 159);
            this.kickBTN.Name = "kickBTN";
            this.kickBTN.Size = new System.Drawing.Size(97, 44);
            this.kickBTN.TabIndex = 2;
            this.kickBTN.Text = "Kick";
            this.kickBTN.UseVisualStyleBackColor = false;
            this.kickBTN.Click += new System.EventHandler(this.KickBTN_Click);
            // 
            // punchBTN
            // 
            this.punchBTN.BackColor = System.Drawing.Color.Transparent;
            this.punchBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.punchBTN.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punchBTN.Location = new System.Drawing.Point(12, 109);
            this.punchBTN.Name = "punchBTN";
            this.punchBTN.Size = new System.Drawing.Size(97, 44);
            this.punchBTN.TabIndex = 1;
            this.punchBTN.Text = "Punch";
            this.punchBTN.UseVisualStyleBackColor = false;
            this.punchBTN.Click += new System.EventHandler(this.PunchBTN_Click);
            // 
            // BlockBTN
            // 
            this.BlockBTN.BackColor = System.Drawing.Color.Transparent;
            this.BlockBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BlockBTN.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlockBTN.Location = new System.Drawing.Point(12, 59);
            this.BlockBTN.Name = "BlockBTN";
            this.BlockBTN.Size = new System.Drawing.Size(97, 44);
            this.BlockBTN.TabIndex = 0;
            this.BlockBTN.Text = "Block";
            this.BlockBTN.UseVisualStyleBackColor = false;
            this.BlockBTN.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bHL
            // 
            this.bHL.AutoSize = true;
            this.bHL.BackColor = System.Drawing.Color.Transparent;
            this.bHL.Location = new System.Drawing.Point(-2, 0);
            this.bHL.Name = "bHL";
            this.bHL.Size = new System.Drawing.Size(88, 13);
            this.bHL.TabIndex = 4;
            this.bHL.Text = "Brewstor Health: ";
            // 
            // bHealthPBX
            // 
            this.bHealthPBX.Location = new System.Drawing.Point(1, 16);
            this.bHealthPBX.Name = "bHealthPBX";
            this.bHealthPBX.Size = new System.Drawing.Size(400, 30);
            this.bHealthPBX.TabIndex = 3;
            this.bHealthPBX.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Game_2.Properties.Resources.brewstor_fight;
            this.pictureBox1.Location = new System.Drawing.Point(1, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 221);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Game_2.Properties.Resources.pauline_fight;
            this.pictureBox2.Location = new System.Drawing.Point(728, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 273);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pHL
            // 
            this.pHL.AutoSize = true;
            this.pHL.BackColor = System.Drawing.Color.Transparent;
            this.pHL.Location = new System.Drawing.Point(878, 0);
            this.pHL.Name = "pHL";
            this.pHL.Size = new System.Drawing.Size(100, 13);
            this.pHL.TabIndex = 7;
            this.pHL.Text = "Pauline Health: 400";
            // 
            // pHealthPBX
            // 
            this.pHealthPBX.Location = new System.Drawing.Point(584, 16);
            this.pHealthPBX.Name = "pHealthPBX";
            this.pHealthPBX.Size = new System.Drawing.Size(400, 30);
            this.pHealthPBX.TabIndex = 6;
            this.pHealthPBX.TabStop = false;
            // 
            // bHBack
            // 
            this.bHBack.BackColor = System.Drawing.Color.Gray;
            this.bHBack.Location = new System.Drawing.Point(1, 16);
            this.bHBack.Name = "bHBack";
            this.bHBack.Size = new System.Drawing.Size(400, 30);
            this.bHBack.TabIndex = 8;
            this.bHBack.TabStop = false;
            // 
            // pHBack
            // 
            this.pHBack.BackColor = System.Drawing.Color.Gray;
            this.pHBack.Location = new System.Drawing.Point(584, 16);
            this.pHBack.Name = "pHBack";
            this.pHBack.Size = new System.Drawing.Size(400, 30);
            this.pHBack.TabIndex = 9;
            this.pHBack.TabStop = false;
            // 
            // music
            // 
            this.music.Enabled = true;
            this.music.Location = new System.Drawing.Point(354, 144);
            this.music.Name = "music";
            this.music.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("music.OcxState")));
            this.music.Size = new System.Drawing.Size(75, 23);
            this.music.TabIndex = 10;
            this.music.Visible = false;
            // 
            // Fight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.music);
            this.Controls.Add(this.pHL);
            this.Controls.Add(this.pHealthPBX);
            this.Controls.Add(this.bHL);
            this.Controls.Add(this.bHealthPBX);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bHBack);
            this.Controls.Add(this.pHBack);
            this.Name = "Fight";
            this.Text = "Fight";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fight_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bHealthPBX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHealthPBX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bHBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.music)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button kickBTN;
        private System.Windows.Forms.Button punchBTN;
        private System.Windows.Forms.Button BlockBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox bHealthPBX;
        private System.Windows.Forms.Label bHL;
        private System.Windows.Forms.Label pHL;
        private System.Windows.Forms.PictureBox pHealthPBX;
        private System.Windows.Forms.PictureBox bHBack;
        private System.Windows.Forms.PictureBox pHBack;
        private AxWMPLib.AxWindowsMediaPlayer music;
    }
}