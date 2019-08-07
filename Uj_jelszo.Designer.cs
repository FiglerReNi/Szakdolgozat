namespace Szakdolgozat1
{
    partial class Uj_jelszo
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
            this.ujfelh1 = new System.Windows.Forms.Label();
            this.ujjelsz1 = new System.Windows.Forms.Label();
            this.ujfelh2 = new System.Windows.Forms.TextBox();
            this.ujjelsz2 = new System.Windows.Forms.TextBox();
            this.ujjelsz3 = new System.Windows.Forms.Button();
            this.ujregi1 = new System.Windows.Forms.Label();
            this.ujregi2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ujfelh1
            // 
            this.ujfelh1.AutoSize = true;
            this.ujfelh1.Location = new System.Drawing.Point(26, 56);
            this.ujfelh1.Name = "ujfelh1";
            this.ujfelh1.Size = new System.Drawing.Size(81, 13);
            this.ujfelh1.TabIndex = 0;
            this.ujfelh1.Text = "Felhasználónév";
            // 
            // ujjelsz1
            // 
            this.ujjelsz1.AutoSize = true;
            this.ujjelsz1.Location = new System.Drawing.Point(26, 124);
            this.ujjelsz1.Name = "ujjelsz1";
            this.ujjelsz1.Size = new System.Drawing.Size(46, 13);
            this.ujjelsz1.TabIndex = 1;
            this.ujjelsz1.Text = "Új jelszó";
            // 
            // ujfelh2
            // 
            this.ujfelh2.Location = new System.Drawing.Point(117, 49);
            this.ujfelh2.Name = "ujfelh2";
            this.ujfelh2.Size = new System.Drawing.Size(100, 20);
            this.ujfelh2.TabIndex = 1;
            // 
            // ujjelsz2
            // 
            this.ujjelsz2.Location = new System.Drawing.Point(117, 117);
            this.ujjelsz2.Name = "ujjelsz2";
            this.ujjelsz2.Size = new System.Drawing.Size(100, 20);
            this.ujjelsz2.TabIndex = 3;
            // 
            // ujjelsz3
            // 
            this.ujjelsz3.Location = new System.Drawing.Point(117, 176);
            this.ujjelsz3.Name = "ujjelsz3";
            this.ujjelsz3.Size = new System.Drawing.Size(100, 23);
            this.ujjelsz3.TabIndex = 4;
            this.ujjelsz3.Text = "Új jelszó";
            this.ujjelsz3.UseVisualStyleBackColor = true;
            this.ujjelsz3.Click += new System.EventHandler(this.ujjelsz3_Click);
            // 
            // ujregi1
            // 
            this.ujregi1.AutoSize = true;
            this.ujregi1.Location = new System.Drawing.Point(26, 90);
            this.ujregi1.Name = "ujregi1";
            this.ujregi1.Size = new System.Drawing.Size(58, 13);
            this.ujregi1.TabIndex = 5;
            this.ujregi1.Text = "Régi jelszó";
            // 
            // ujregi2
            // 
            this.ujregi2.Location = new System.Drawing.Point(117, 83);
            this.ujregi2.Name = "ujregi2";
            this.ujregi2.Size = new System.Drawing.Size(100, 20);
            this.ujregi2.TabIndex = 2;
            // 
            // Uj_jelszo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(254, 237);
            this.Controls.Add(this.ujregi2);
            this.Controls.Add(this.ujregi1);
            this.Controls.Add(this.ujjelsz3);
            this.Controls.Add(this.ujjelsz2);
            this.Controls.Add(this.ujfelh2);
            this.Controls.Add(this.ujjelsz1);
            this.Controls.Add(this.ujfelh1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Uj_jelszo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elfelejtett jelszó";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ujfelh1;
        private System.Windows.Forms.Label ujjelsz1;
        private System.Windows.Forms.TextBox ujfelh2;
        private System.Windows.Forms.TextBox ujjelsz2;
        private System.Windows.Forms.Button ujjelsz3;
        private System.Windows.Forms.Label ujregi1;
        private System.Windows.Forms.TextBox ujregi2;
    }
}