namespace Game_2
{
    partial class Wincs
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
            this.winBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // winBTN
            // 
            this.winBTN.Location = new System.Drawing.Point(355, 199);
            this.winBTN.Name = "winBTN";
            this.winBTN.Size = new System.Drawing.Size(75, 23);
            this.winBTN.TabIndex = 0;
            this.winBTN.Text = "Done";
            this.winBTN.UseVisualStyleBackColor = true;
            this.winBTN.Click += new System.EventHandler(this.WinBTN_Click);
            // 
            // Wincs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.winBTN);
            this.Name = "Wincs";
            this.Text = "Wincs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button winBTN;
    }
}