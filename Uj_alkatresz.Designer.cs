namespace Szakdolgozat1
{
    partial class Uj_Alkatresz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uj_Alkatresz));
            this.Keszletektipus1 = new System.Windows.Forms.Label();
            this.Keszletekalkkod1 = new System.Windows.Forms.Label();
            this.Keszletekar1 = new System.Windows.Forms.Label();
            this.Keszletektipus2 = new System.Windows.Forms.ListBox();
            this.Keszletekar2 = new System.Windows.Forms.TextBox();
            this.Keszletekfelvitel1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.Keszletekdatum1 = new System.Windows.Forms.Button();
            this.Keszletekdatum2 = new System.Windows.Forms.TextBox();
            this.Keszletekalkkod2 = new System.Windows.Forms.ComboBox();
            this.Keszletekalkkod3 = new System.Windows.Forms.Label();
            this.Keszletekalkkod4 = new System.Windows.Forms.MaskedTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Keszletektipus1
            // 
            this.Keszletektipus1.AutoSize = true;
            this.Keszletektipus1.Location = new System.Drawing.Point(12, 76);
            this.Keszletektipus1.Name = "Keszletektipus1";
            this.Keszletektipus1.Size = new System.Drawing.Size(35, 13);
            this.Keszletektipus1.TabIndex = 0;
            this.Keszletektipus1.Text = "Típus";
            // 
            // Keszletekalkkod1
            // 
            this.Keszletekalkkod1.AutoSize = true;
            this.Keszletekalkkod1.Location = new System.Drawing.Point(12, 170);
            this.Keszletekalkkod1.Name = "Keszletekalkkod1";
            this.Keszletekalkkod1.Size = new System.Drawing.Size(71, 13);
            this.Keszletekalkkod1.TabIndex = 0;
            this.Keszletekalkkod1.Text = "Alkatrész kód";
            // 
            // Keszletekar1
            // 
            this.Keszletekar1.AutoSize = true;
            this.Keszletekar1.Location = new System.Drawing.Point(12, 258);
            this.Keszletekar1.Name = "Keszletekar1";
            this.Keszletekar1.Size = new System.Drawing.Size(69, 13);
            this.Keszletekar1.TabIndex = 0;
            this.Keszletekar1.Text = "Beszerzési ár";
            // 
            // Keszletektipus2
            // 
            this.Keszletektipus2.FormattingEnabled = true;
            this.Keszletektipus2.Location = new System.Drawing.Point(116, 76);
            this.Keszletektipus2.Name = "Keszletektipus2";
            this.Keszletektipus2.Size = new System.Drawing.Size(120, 56);
            this.Keszletektipus2.TabIndex = 1;
            this.Keszletektipus2.SelectedValueChanged += new System.EventHandler(this.Keszletektipus2_SelectedValueChanged);
            // 
            // Keszletekar2
            // 
            this.Keszletekar2.Location = new System.Drawing.Point(116, 255);
            this.Keszletekar2.Name = "Keszletekar2";
            this.Keszletekar2.Size = new System.Drawing.Size(120, 20);
            this.Keszletekar2.TabIndex = 4;
            // 
            // Keszletekfelvitel1
            // 
            this.Keszletekfelvitel1.Location = new System.Drawing.Point(116, 359);
            this.Keszletekfelvitel1.Name = "Keszletekfelvitel1";
            this.Keszletekfelvitel1.Size = new System.Drawing.Size(75, 23);
            this.Keszletekfelvitel1.TabIndex = 6;
            this.Keszletekfelvitel1.Text = "Felvitel";
            this.Keszletekfelvitel1.UseVisualStyleBackColor = true;
            this.Keszletekfelvitel1.Click += new System.EventHandler(this.Keszletekfelvitel1_Click);
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
            this.toolStrip1.Size = new System.Drawing.Size(334, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "Űrlap";
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
            // Keszletekdatum1
            // 
            this.Keszletekdatum1.Location = new System.Drawing.Point(15, 300);
            this.Keszletekdatum1.Name = "Keszletekdatum1";
            this.Keszletekdatum1.Size = new System.Drawing.Size(75, 23);
            this.Keszletekdatum1.TabIndex = 5;
            this.Keszletekdatum1.Text = "Dátum";
            this.Keszletekdatum1.UseVisualStyleBackColor = true;
            this.Keszletekdatum1.Click += new System.EventHandler(this.Keszletekdatum1_Click);
            // 
            // Keszletekdatum2
            // 
            this.Keszletekdatum2.Location = new System.Drawing.Point(116, 300);
            this.Keszletekdatum2.Name = "Keszletekdatum2";
            this.Keszletekdatum2.Size = new System.Drawing.Size(120, 20);
            this.Keszletekdatum2.TabIndex = 7;
            // 
            // Keszletekalkkod2
            // 
            this.Keszletekalkkod2.FormattingEnabled = true;
            this.Keszletekalkkod2.ItemHeight = 13;
            this.Keszletekalkkod2.Location = new System.Drawing.Point(116, 170);
            this.Keszletekalkkod2.Name = "Keszletekalkkod2";
            this.Keszletekalkkod2.Size = new System.Drawing.Size(121, 21);
            this.Keszletekalkkod2.TabIndex = 2;
            // 
            // Keszletekalkkod3
            // 
            this.Keszletekalkkod3.AutoSize = true;
            this.Keszletekalkkod3.Location = new System.Drawing.Point(12, 210);
            this.Keszletekalkkod3.Name = "Keszletekalkkod3";
            this.Keszletekalkkod3.Size = new System.Drawing.Size(55, 13);
            this.Keszletekalkkod3.TabIndex = 11;
            this.Keszletekalkkod3.Text = "Azonosító";
            // 
            // Keszletekalkkod4
            // 
            this.Keszletekalkkod4.Location = new System.Drawing.Point(116, 210);
            this.Keszletekalkkod4.Mask = "000000000";
            this.Keszletekalkkod4.Name = "Keszletekalkkod4";
            this.Keszletekalkkod4.Size = new System.Drawing.Size(120, 20);
            this.Keszletekalkkod4.TabIndex = 3;
            // 
            // Uj_Alkatresz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(334, 412);
            this.Controls.Add(this.Keszletekalkkod4);
            this.Controls.Add(this.Keszletekalkkod3);
            this.Controls.Add(this.Keszletekalkkod2);
            this.Controls.Add(this.Keszletekdatum2);
            this.Controls.Add(this.Keszletekdatum1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Keszletekfelvitel1);
            this.Controls.Add(this.Keszletekar2);
            this.Controls.Add(this.Keszletektipus2);
            this.Controls.Add(this.Keszletekar1);
            this.Controls.Add(this.Keszletekalkkod1);
            this.Controls.Add(this.Keszletektipus1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Uj_Alkatresz";
            this.Text = "Készletek - Új Alkatrész";
            this.Load += new System.EventHandler(this.Uj_Alkatresz_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Keszletektipus1;
        private System.Windows.Forms.Label Keszletekalkkod1;
        private System.Windows.Forms.Label Keszletekar1;
        private System.Windows.Forms.ListBox Keszletektipus2;
        private System.Windows.Forms.TextBox Keszletekar2;
        private System.Windows.Forms.Button Keszletekfelvitel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Button Keszletekdatum1;
        private System.Windows.Forms.TextBox Keszletekdatum2;
        private System.Windows.Forms.ComboBox Keszletekalkkod2;
        private System.Windows.Forms.Label Keszletekalkkod3;
        private System.Windows.Forms.MaskedTextBox Keszletekalkkod4;
    }
}