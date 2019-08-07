namespace Szakdolgozat1
{
    partial class Kereses_telefon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kereses_telefon));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Kereseseredmenydb4 = new System.Windows.Forms.TextBox();
            this.Keresesteltipus10 = new System.Windows.Forms.Label();
            this.Kereseseredmeny9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Kereses5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.Keresesteltipus12 = new System.Windows.Forms.ComboBox();
            this.Kereseseredmenylista5 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kereseseredmenylista5)).BeginInit();
            this.SuspendLayout();
            // 
            // Kereseseredmenydb4
            // 
            this.Kereseseredmenydb4.Location = new System.Drawing.Point(170, 168);
            this.Kereseseredmenydb4.Name = "Kereseseredmenydb4";
            this.Kereseseredmenydb4.Size = new System.Drawing.Size(121, 20);
            this.Kereseseredmenydb4.TabIndex = 5;
            // 
            // Keresesteltipus10
            // 
            this.Keresesteltipus10.AutoSize = true;
            this.Keresesteltipus10.Location = new System.Drawing.Point(37, 96);
            this.Keresesteltipus10.Name = "Keresesteltipus10";
            this.Keresesteltipus10.Size = new System.Drawing.Size(76, 13);
            this.Keresesteltipus10.TabIndex = 0;
            this.Keresesteltipus10.Text = "Telefon típusa";
            // 
            // Kereseseredmeny9
            // 
            this.Kereseseredmeny9.AutoSize = true;
            this.Kereseseredmeny9.Location = new System.Drawing.Point(37, 168);
            this.Kereseseredmeny9.Name = "Kereseseredmeny9";
            this.Kereseseredmeny9.Size = new System.Drawing.Size(100, 13);
            this.Kereseseredmeny9.TabIndex = 0;
            this.Kereseseredmeny9.Text = "Keresés eredménye";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 22;
            // 
            // Kereses5
            // 
            this.Kereses5.AutoSize = true;
            this.Kereses5.Location = new System.Drawing.Point(37, 51);
            this.Kereses5.Name = "Kereses5";
            this.Kereses5.Size = new System.Drawing.Size(133, 13);
            this.Kereses5.TabIndex = 0;
            this.Kereses5.Text = "Keresés a telefonok között";
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
            this.toolStrip1.TabIndex = 32;
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
            // Keresesteltipus12
            // 
            this.Keresesteltipus12.FormattingEnabled = true;
            this.Keresesteltipus12.Location = new System.Drawing.Point(170, 96);
            this.Keresesteltipus12.Name = "Keresesteltipus12";
            this.Keresesteltipus12.Size = new System.Drawing.Size(121, 21);
            this.Keresesteltipus12.TabIndex = 33;
            this.Keresesteltipus12.SelectedValueChanged += new System.EventHandler(this.Keresesteltipus12_SelectedValueChanged);
            // 
            // Kereseseredmenylista5
            // 
            this.Kereseseredmenylista5.BackgroundColor = System.Drawing.Color.White;
            this.Kereseseredmenylista5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Kereseseredmenylista5.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Kereseseredmenylista5.Location = new System.Drawing.Point(40, 256);
            this.Kereseseredmenylista5.Name = "Kereseseredmenylista5";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Kereseseredmenylista5.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Kereseseredmenylista5.Size = new System.Drawing.Size(727, 109);
            this.Kereseseredmenylista5.TabIndex = 35;
            // 
            // Kereses_telefon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(834, 412);
            this.Controls.Add(this.Kereseseredmenylista5);
            this.Controls.Add(this.Keresesteltipus12);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Kereseseredmenydb4);
            this.Controls.Add(this.Keresesteltipus10);
            this.Controls.Add(this.Kereseseredmeny9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Kereses5);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Kereses_telefon";
            this.Text = "Kereses_telefon";
            this.Load += new System.EventHandler(this.Kereses_telefon_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kereseseredmenylista5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Kereseseredmenydb4;
        private System.Windows.Forms.Label Keresesteltipus10;
        private System.Windows.Forms.Label Kereseseredmeny9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Kereses5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ComboBox Keresesteltipus12;
        private System.Windows.Forms.DataGridView Kereseseredmenylista5;
    }
}