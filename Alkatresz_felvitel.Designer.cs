namespace Szakdolgozat1
{
    partial class Alkatresz_felvitel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alkatresz_felvitel));
            this.Alkfeljavravar1 = new System.Windows.Forms.Label();
            this.Alkfeltipus1 = new System.Windows.Forms.Label();
            this.Alkfelfodarab1 = new System.Windows.Forms.Label();
            this.Alkfelalkatresz1 = new System.Windows.Forms.Label();
            this.Alkfelmentes = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Alkfelpdf2 = new System.Windows.Forms.Button();
            this.Alkfeljaveredmeny1 = new System.Windows.Forms.Label();
            this.Alkfelpdf3 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.Alkfeldatum1 = new System.Windows.Forms.Button();
            this.Alkfeldatum2 = new System.Windows.Forms.TextBox();
            this.Alkfeljavravar2 = new System.Windows.Forms.ComboBox();
            this.Alkfelfodarab2 = new System.Windows.Forms.ComboBox();
            this.Alkfelalkatresz2 = new System.Windows.Forms.ComboBox();
            this.Alkfelalkatresz4 = new System.Windows.Forms.ComboBox();
            this.Alkfeltipus2 = new System.Windows.Forms.ComboBox();
            this.Alkfeljav1 = new System.Windows.Forms.Label();
            this.Alkfeljav2 = new System.Windows.Forms.ComboBox();
            this.Alkfeljaveredmeny2 = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Alkfeljavravar1
            // 
            this.Alkfeljavravar1.AutoSize = true;
            this.Alkfeljavravar1.Location = new System.Drawing.Point(364, 58);
            this.Alkfeljavravar1.Name = "Alkfeljavravar1";
            this.Alkfeljavravar1.Size = new System.Drawing.Size(122, 13);
            this.Alkfeljavravar1.TabIndex = 0;
            this.Alkfeljavravar1.Text = "Javításra váró telefonok";
            // 
            // Alkfeltipus1
            // 
            this.Alkfeltipus1.AutoSize = true;
            this.Alkfeltipus1.Location = new System.Drawing.Point(376, 110);
            this.Alkfeltipus1.Name = "Alkfeltipus1";
            this.Alkfeltipus1.Size = new System.Drawing.Size(110, 13);
            this.Alkfeltipus1.TabIndex = 0;
            this.Alkfeltipus1.Text = "KIválsztott imei típusa";
            // 
            // Alkfelfodarab1
            // 
            this.Alkfelfodarab1.AutoSize = true;
            this.Alkfelfodarab1.Location = new System.Drawing.Point(384, 213);
            this.Alkfelfodarab1.Name = "Alkfelfodarab1";
            this.Alkfelfodarab1.Size = new System.Drawing.Size(102, 13);
            this.Alkfelfodarab1.TabIndex = 0;
            this.Alkfelfodarab1.Text = "Felhasznált Fődarab";
            // 
            // Alkfelalkatresz1
            // 
            this.Alkfelalkatresz1.AutoSize = true;
            this.Alkfelalkatresz1.Location = new System.Drawing.Point(380, 264);
            this.Alkfelalkatresz1.Name = "Alkfelalkatresz1";
            this.Alkfelalkatresz1.Size = new System.Drawing.Size(106, 13);
            this.Alkfelalkatresz1.TabIndex = 0;
            this.Alkfelalkatresz1.Text = "Felhasznált Alkatrész";
            this.Alkfelalkatresz1.Click += new System.EventHandler(this.Alkfelalkatresz1_Click);
            // 
            // Alkfelmentes
            // 
            this.Alkfelmentes.Location = new System.Drawing.Point(598, 627);
            this.Alkfelmentes.Name = "Alkfelmentes";
            this.Alkfelmentes.Size = new System.Drawing.Size(75, 23);
            this.Alkfelmentes.TabIndex = 10;
            this.Alkfelmentes.Text = "Mentés";
            this.Alkfelmentes.UseVisualStyleBackColor = true;
            this.Alkfelmentes.Click += new System.EventHandler(this.Alkfelmentes_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "csak szöveg (*.txt)|*.txt";
            // 
            // Alkfelpdf2
            // 
            this.Alkfelpdf2.Location = new System.Drawing.Point(414, 514);
            this.Alkfelpdf2.Name = "Alkfelpdf2";
            this.Alkfelpdf2.Size = new System.Drawing.Size(75, 23);
            this.Alkfelpdf2.TabIndex = 13;
            this.Alkfelpdf2.Text = "Feltöltés";
            this.Alkfelpdf2.UseVisualStyleBackColor = true;
            this.Alkfelpdf2.Click += new System.EventHandler(this.Alkfelpdf2_Click);
            // 
            // Alkfeljaveredmeny1
            // 
            this.Alkfeljaveredmeny1.AutoSize = true;
            this.Alkfeljaveredmeny1.Location = new System.Drawing.Point(393, 353);
            this.Alkfeljaveredmeny1.Name = "Alkfeljaveredmeny1";
            this.Alkfeljaveredmeny1.Size = new System.Drawing.Size(93, 13);
            this.Alkfeljaveredmeny1.TabIndex = 0;
            this.Alkfeljaveredmeny1.Text = "Javítási eredmény";
            // 
            // Alkfelpdf3
            // 
            this.Alkfelpdf3.BackColor = System.Drawing.Color.White;
            this.Alkfelpdf3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Alkfelpdf3.Location = new System.Drawing.Point(598, 514);
            this.Alkfelpdf3.Name = "Alkfelpdf3";
            this.Alkfelpdf3.Size = new System.Drawing.Size(231, 64);
            this.Alkfelpdf3.TabIndex = 9;
            this.Alkfelpdf3.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButton1,
            this.toolStripLabel2,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1334, 25);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "Űrlap";
            this.toolStripLabel1.Click += new System.EventHandler(this.Alkfelalkatresz1_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.Urlapokuj_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(40, 22);
            this.toolStripLabel2.Text = "Eladás";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Szakdolgozat1.Properties.Resources.kosar;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.Fooldaleladas_Click);
            // 
            // Alkfeldatum1
            // 
            this.Alkfeldatum1.Location = new System.Drawing.Point(414, 427);
            this.Alkfeldatum1.Name = "Alkfeldatum1";
            this.Alkfeldatum1.Size = new System.Drawing.Size(75, 23);
            this.Alkfeldatum1.TabIndex = 23;
            this.Alkfeldatum1.Text = "Dátum";
            this.Alkfeldatum1.UseVisualStyleBackColor = true;
            this.Alkfeldatum1.Click += new System.EventHandler(this.Alkfeldatum1_Click);
            // 
            // Alkfeldatum2
            // 
            this.Alkfeldatum2.Location = new System.Drawing.Point(598, 430);
            this.Alkfeldatum2.Name = "Alkfeldatum2";
            this.Alkfeldatum2.Size = new System.Drawing.Size(120, 20);
            this.Alkfeldatum2.TabIndex = 8;
            // 
            // Alkfeljavravar2
            // 
            this.Alkfeljavravar2.FormattingEnabled = true;
            this.Alkfeljavravar2.Location = new System.Drawing.Point(597, 58);
            this.Alkfeljavravar2.MaxDropDownItems = 100;
            this.Alkfeljavravar2.Name = "Alkfeljavravar2";
            this.Alkfeljavravar2.Size = new System.Drawing.Size(181, 21);
            this.Alkfeljavravar2.Sorted = true;
            this.Alkfeljavravar2.TabIndex = 1;
            this.Alkfeljavravar2.SelectedValueChanged += new System.EventHandler(this.Alkfeljavravar2_SelectedValueChanged);
            // 
            // Alkfelfodarab2
            // 
            this.Alkfelfodarab2.FormattingEnabled = true;
            this.Alkfelfodarab2.Location = new System.Drawing.Point(597, 213);
            this.Alkfelfodarab2.Name = "Alkfelfodarab2";
            this.Alkfelfodarab2.Size = new System.Drawing.Size(180, 21);
            this.Alkfelfodarab2.TabIndex = 4;
            // 
            // Alkfelalkatresz2
            // 
            this.Alkfelalkatresz2.FormattingEnabled = true;
            this.Alkfelalkatresz2.Location = new System.Drawing.Point(598, 256);
            this.Alkfelalkatresz2.Name = "Alkfelalkatresz2";
            this.Alkfelalkatresz2.Size = new System.Drawing.Size(180, 21);
            this.Alkfelalkatresz2.TabIndex = 5;
            this.Alkfelalkatresz2.SelectedValueChanged += new System.EventHandler(this.Alkfelalkatresz2_SelectedValueChanged);
            // 
            // Alkfelalkatresz4
            // 
            this.Alkfelalkatresz4.FormattingEnabled = true;
            this.Alkfelalkatresz4.Location = new System.Drawing.Point(597, 298);
            this.Alkfelalkatresz4.Name = "Alkfelalkatresz4";
            this.Alkfelalkatresz4.Size = new System.Drawing.Size(181, 21);
            this.Alkfelalkatresz4.TabIndex = 6;
            // 
            // Alkfeltipus2
            // 
            this.Alkfeltipus2.FormattingEnabled = true;
            this.Alkfeltipus2.Location = new System.Drawing.Point(597, 110);
            this.Alkfeltipus2.Name = "Alkfeltipus2";
            this.Alkfeltipus2.Size = new System.Drawing.Size(180, 21);
            this.Alkfeltipus2.TabIndex = 2;
            this.Alkfeltipus2.SelectedValueChanged += new System.EventHandler(this.Alkfeltipus2_SelectedValueChanged);
            // 
            // Alkfeljav1
            // 
            this.Alkfeljav1.AutoSize = true;
            this.Alkfeljav1.Location = new System.Drawing.Point(411, 162);
            this.Alkfeljav1.Name = "Alkfeljav1";
            this.Alkfeljav1.Size = new System.Drawing.Size(75, 13);
            this.Alkfeljav1.TabIndex = 36;
            this.Alkfeljav1.Text = "Javítás típusa";
            // 
            // Alkfeljav2
            // 
            this.Alkfeljav2.FormattingEnabled = true;
            this.Alkfeljav2.Location = new System.Drawing.Point(597, 162);
            this.Alkfeljav2.Name = "Alkfeljav2";
            this.Alkfeljav2.Size = new System.Drawing.Size(181, 21);
            this.Alkfeljav2.TabIndex = 3;
            // 
            // Alkfeljaveredmeny2
            // 
            this.Alkfeljaveredmeny2.FormattingEnabled = true;
            this.Alkfeljaveredmeny2.Items.AddRange(new object[] {
            "Javítva",
            "Nem történt javítás"});
            this.Alkfeljaveredmeny2.Location = new System.Drawing.Point(597, 345);
            this.Alkfeljaveredmeny2.Name = "Alkfeljaveredmeny2";
            this.Alkfeljaveredmeny2.Size = new System.Drawing.Size(181, 21);
            this.Alkfeljaveredmeny2.TabIndex = 7;
            // 
            // Alkatresz_felvitel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1334, 662);
            this.Controls.Add(this.Alkfeljaveredmeny2);
            this.Controls.Add(this.Alkfeljav2);
            this.Controls.Add(this.Alkfeljav1);
            this.Controls.Add(this.Alkfeltipus2);
            this.Controls.Add(this.Alkfelalkatresz4);
            this.Controls.Add(this.Alkfelalkatresz2);
            this.Controls.Add(this.Alkfelfodarab2);
            this.Controls.Add(this.Alkfeljavravar2);
            this.Controls.Add(this.Alkfeldatum2);
            this.Controls.Add(this.Alkfeldatum1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Alkfelpdf3);
            this.Controls.Add(this.Alkfeljaveredmeny1);
            this.Controls.Add(this.Alkfelpdf2);
            this.Controls.Add(this.Alkfelmentes);
            this.Controls.Add(this.Alkfelalkatresz1);
            this.Controls.Add(this.Alkfelfodarab1);
            this.Controls.Add(this.Alkfeltipus1);
            this.Controls.Add(this.Alkfeljavravar1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Alkatresz_felvitel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alkatrész felvitel";
            this.Load += new System.EventHandler(this.Alkatresz_felvitel_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Alkfeljavravar1;
        private System.Windows.Forms.Label Alkfeltipus1;
        private System.Windows.Forms.Label Alkfelfodarab1;
        private System.Windows.Forms.Label Alkfelalkatresz1;
        private System.Windows.Forms.Button Alkfelmentes;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Alkfelpdf2;
        private System.Windows.Forms.Label Alkfeljaveredmeny1;
        private System.Windows.Forms.RichTextBox Alkfelpdf3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Button Alkfeldatum1;
        private System.Windows.Forms.TextBox Alkfeldatum2;
        private System.Windows.Forms.ComboBox Alkfeljavravar2;
        private System.Windows.Forms.ComboBox Alkfelfodarab2;
        private System.Windows.Forms.ComboBox Alkfelalkatresz2;
        private System.Windows.Forms.ComboBox Alkfelalkatresz4;
        private System.Windows.Forms.ComboBox Alkfeltipus2;
        private System.Windows.Forms.Label Alkfeljav1;
        private System.Windows.Forms.ComboBox Alkfeljav2;
        private System.Windows.Forms.ComboBox Alkfeljaveredmeny2;
    }
}