namespace Szakdolgozat1
{
    partial class Kereses_alkatresz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kereses_alkatresz));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Keresesteltipus1 = new System.Windows.Forms.Label();
            this.Keresesalkkod1 = new System.Windows.Forms.Label();
            this.Kereseseredmeny3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Kereses2 = new System.Windows.Forms.Label();
            this.Kereseseredmenydb1 = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.Keresesteltipus2 = new System.Windows.Forms.ListBox();
            this.Keresesalkkod2 = new System.Windows.Forms.ComboBox();
            this.Kereseseredmenylista2 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kereseseredmenylista2)).BeginInit();
            this.SuspendLayout();
            // 
            // Keresesteltipus1
            // 
            this.Keresesteltipus1.AutoSize = true;
            this.Keresesteltipus1.Location = new System.Drawing.Point(58, 76);
            this.Keresesteltipus1.Name = "Keresesteltipus1";
            this.Keresesteltipus1.Size = new System.Drawing.Size(76, 13);
            this.Keresesteltipus1.TabIndex = 0;
            this.Keresesteltipus1.Text = "Telefon típusa";
            // 
            // Keresesalkkod1
            // 
            this.Keresesalkkod1.AutoSize = true;
            this.Keresesalkkod1.Location = new System.Drawing.Point(58, 159);
            this.Keresesalkkod1.Name = "Keresesalkkod1";
            this.Keresesalkkod1.Size = new System.Drawing.Size(71, 13);
            this.Keresesalkkod1.TabIndex = 0;
            this.Keresesalkkod1.Text = "Alkatrész kód";
            // 
            // Kereseseredmeny3
            // 
            this.Kereseseredmeny3.AutoSize = true;
            this.Kereseseredmeny3.Location = new System.Drawing.Point(58, 212);
            this.Kereseseredmeny3.Name = "Kereseseredmeny3";
            this.Kereseseredmeny3.Size = new System.Drawing.Size(100, 13);
            this.Kereseseredmeny3.TabIndex = 0;
            this.Kereseseredmeny3.Text = "Keresés eredménye";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 10;
            // 
            // Kereses2
            // 
            this.Kereses2.AutoSize = true;
            this.Kereses2.Location = new System.Drawing.Point(58, 51);
            this.Kereses2.Name = "Kereses2";
            this.Kereses2.Size = new System.Drawing.Size(148, 13);
            this.Kereses2.TabIndex = 0;
            this.Kereses2.Text = "Keresés az alkatrészek között";
            // 
            // Kereseseredmenydb1
            // 
            this.Kereseseredmenydb1.Location = new System.Drawing.Point(191, 209);
            this.Kereseseredmenydb1.Name = "Kereseseredmenydb1";
            this.Kereseseredmenydb1.Size = new System.Drawing.Size(100, 20);
            this.Kereseseredmenydb1.TabIndex = 5;
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
            this.toolStrip1.TabIndex = 20;
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
            // Keresesteltipus2
            // 
            this.Keresesteltipus2.FormattingEnabled = true;
            this.Keresesteltipus2.Location = new System.Drawing.Point(190, 76);
            this.Keresesteltipus2.Name = "Keresesteltipus2";
            this.Keresesteltipus2.Size = new System.Drawing.Size(120, 56);
            this.Keresesteltipus2.TabIndex = 21;
            this.Keresesteltipus2.SelectedIndexChanged += new System.EventHandler(this.Keresesteltipus2_SelectedIndexChanged);
            // 
            // Keresesalkkod2
            // 
            this.Keresesalkkod2.FormattingEnabled = true;
            this.Keresesalkkod2.Location = new System.Drawing.Point(190, 159);
            this.Keresesalkkod2.Name = "Keresesalkkod2";
            this.Keresesalkkod2.Size = new System.Drawing.Size(121, 21);
            this.Keresesalkkod2.TabIndex = 22;
            this.Keresesalkkod2.SelectedIndexChanged += new System.EventHandler(this.Keresesalkkod2_SelectedIndexChanged);
            // 
            // Kereseseredmenylista2
            // 
            this.Kereseseredmenylista2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Kereseseredmenylista2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Kereseseredmenylista2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Kereseseredmenylista2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Kereseseredmenylista2.Location = new System.Drawing.Point(61, 250);
            this.Kereseseredmenylista2.Name = "Kereseseredmenylista2";
            this.Kereseseredmenylista2.Size = new System.Drawing.Size(744, 127);
            this.Kereseseredmenylista2.TabIndex = 24;
            // 
            // Kereses_alkatresz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(834, 412);
            this.Controls.Add(this.Kereseseredmenylista2);
            this.Controls.Add(this.Keresesalkkod2);
            this.Controls.Add(this.Keresesteltipus2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Kereseseredmenydb1);
            this.Controls.Add(this.Keresesteltipus1);
            this.Controls.Add(this.Keresesalkkod1);
            this.Controls.Add(this.Kereseseredmeny3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Kereses2);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Kereses_alkatresz";
            this.Text = "Kereses_alkatresz";
            this.Load += new System.EventHandler(this.Kereses_alkatresz_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kereseseredmenylista2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Keresesteltipus1;
        private System.Windows.Forms.Label Keresesalkkod1;
        private System.Windows.Forms.Label Kereseseredmeny3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Kereses2;
        private System.Windows.Forms.TextBox Kereseseredmenydb1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ListBox Keresesteltipus2;
        private System.Windows.Forms.ComboBox Keresesalkkod2;
        private System.Windows.Forms.DataGridView Kereseseredmenylista2;
    }
}