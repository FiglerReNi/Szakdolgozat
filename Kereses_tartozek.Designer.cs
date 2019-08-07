namespace Szakdolgozat1
{
    partial class Kereses_tartozek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kereses_tartozek));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Kereseseredmenydb3 = new System.Windows.Forms.TextBox();
            this.Keresesteltipus7 = new System.Windows.Forms.Label();
            this.Kereseseredmeny7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Kereses4 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.Keresestartkod2 = new System.Windows.Forms.ComboBox();
            this.Kereseseredmenylista3 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kereseseredmenylista3)).BeginInit();
            this.SuspendLayout();
            // 
            // Kereseseredmenydb3
            // 
            this.Kereseseredmenydb3.Location = new System.Drawing.Point(173, 173);
            this.Kereseseredmenydb3.Name = "Kereseseredmenydb3";
            this.Kereseseredmenydb3.Size = new System.Drawing.Size(121, 20);
            this.Kereseseredmenydb3.TabIndex = 5;
            // 
            // Keresesteltipus7
            // 
            this.Keresesteltipus7.AutoSize = true;
            this.Keresesteltipus7.Location = new System.Drawing.Point(37, 104);
            this.Keresesteltipus7.Name = "Keresesteltipus7";
            this.Keresesteltipus7.Size = new System.Drawing.Size(82, 13);
            this.Keresesteltipus7.TabIndex = 0;
            this.Keresesteltipus7.Text = "Tartozék típusa";
            // 
            // Kereseseredmeny7
            // 
            this.Kereseseredmeny7.AutoSize = true;
            this.Kereseseredmeny7.Location = new System.Drawing.Point(37, 173);
            this.Kereseseredmeny7.Name = "Kereseseredmeny7";
            this.Kereseseredmeny7.Size = new System.Drawing.Size(100, 13);
            this.Kereseseredmeny7.TabIndex = 0;
            this.Kereseseredmeny7.Text = "Keresés eredménye";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 22;
            // 
            // Kereses4
            // 
            this.Kereses4.AutoSize = true;
            this.Kereses4.Location = new System.Drawing.Point(37, 49);
            this.Kereses4.Name = "Kereses4";
            this.Kereses4.Size = new System.Drawing.Size(139, 13);
            this.Kereses4.TabIndex = 0;
            this.Kereses4.Text = "Keresés a tartozékok között";
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
            this.toolStrip1.Size = new System.Drawing.Size(834, 25);
            this.toolStrip1.TabIndex = 31;
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
            // Keresestartkod2
            // 
            this.Keresestartkod2.FormattingEnabled = true;
            this.Keresestartkod2.Location = new System.Drawing.Point(173, 104);
            this.Keresestartkod2.Name = "Keresestartkod2";
            this.Keresestartkod2.Size = new System.Drawing.Size(121, 21);
            this.Keresestartkod2.TabIndex = 32;
            this.Keresestartkod2.SelectedValueChanged += new System.EventHandler(this.Keresestartkod2_SelectedValueChanged);
            // 
            // Kereseseredmenylista3
            // 
            this.Kereseseredmenylista3.BackgroundColor = System.Drawing.Color.White;
            this.Kereseseredmenylista3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Kereseseredmenylista3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Kereseseredmenylista3.Location = new System.Drawing.Point(40, 237);
            this.Kereseseredmenylista3.Name = "Kereseseredmenylista3";
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Kereseseredmenylista3.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Kereseseredmenylista3.Size = new System.Drawing.Size(764, 119);
            this.Kereseseredmenylista3.TabIndex = 35;
            // 
            // Kereses_tartozek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(834, 412);
            this.Controls.Add(this.Kereseseredmenylista3);
            this.Controls.Add(this.Keresestartkod2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Kereseseredmenydb3);
            this.Controls.Add(this.Keresesteltipus7);
            this.Controls.Add(this.Kereseseredmeny7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Kereses4);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Kereses_tartozek";
            this.Text = "Kereses_tartozek";
            this.Load += new System.EventHandler(this.Kereses_tartozek_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kereseseredmenylista3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Kereseseredmenydb3;
        private System.Windows.Forms.Label Keresesteltipus7;
        private System.Windows.Forms.Label Kereseseredmeny7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Kereses4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ComboBox Keresestartkod2;
        private System.Windows.Forms.DataGridView Kereseseredmenylista3;
    }
}