namespace Szakdolgozat1
{
    partial class Kereses_fodarab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kereses_fodarab));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Keresesteltipus4 = new System.Windows.Forms.Label();
            this.Kereseseredmeny5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Kereses3 = new System.Windows.Forms.Label();
            this.Kereseseredmenydb2 = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.Keresesteltipus5 = new System.Windows.Forms.ComboBox();
            this.Kereseseredmenylista4 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kereseseredmenylista4)).BeginInit();
            this.SuspendLayout();
            // 
            // Keresesteltipus4
            // 
            this.Keresesteltipus4.AutoSize = true;
            this.Keresesteltipus4.Location = new System.Drawing.Point(50, 103);
            this.Keresesteltipus4.Name = "Keresesteltipus4";
            this.Keresesteltipus4.Size = new System.Drawing.Size(76, 13);
            this.Keresesteltipus4.TabIndex = 0;
            this.Keresesteltipus4.Text = "Telefon típusa";
            // 
            // Kereseseredmeny5
            // 
            this.Kereseseredmeny5.AutoSize = true;
            this.Kereseseredmeny5.Location = new System.Drawing.Point(50, 174);
            this.Kereseseredmeny5.Name = "Kereseseredmeny5";
            this.Kereseseredmeny5.Size = new System.Drawing.Size(100, 13);
            this.Kereseseredmeny5.TabIndex = 0;
            this.Kereseseredmeny5.Text = "Keresés eredménye";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 20;
            // 
            // Kereses3
            // 
            this.Kereses3.AutoSize = true;
            this.Kereses3.Location = new System.Drawing.Point(50, 41);
            this.Kereses3.Name = "Kereses3";
            this.Kereses3.Size = new System.Drawing.Size(137, 13);
            this.Kereses3.TabIndex = 0;
            this.Kereses3.Text = "Keresés a fődarabok között";
            // 
            // Kereseseredmenydb2
            // 
            this.Kereseseredmenydb2.Location = new System.Drawing.Point(191, 174);
            this.Kereseseredmenydb2.Name = "Kereseseredmenydb2";
            this.Kereseseredmenydb2.Size = new System.Drawing.Size(120, 20);
            this.Kereseseredmenydb2.TabIndex = 5;
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
            this.toolStrip1.TabIndex = 30;
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
            // Keresesteltipus5
            // 
            this.Keresesteltipus5.FormattingEnabled = true;
            this.Keresesteltipus5.Location = new System.Drawing.Point(191, 103);
            this.Keresesteltipus5.Name = "Keresesteltipus5";
            this.Keresesteltipus5.Size = new System.Drawing.Size(121, 21);
            this.Keresesteltipus5.TabIndex = 31;
            this.Keresesteltipus5.SelectedValueChanged += new System.EventHandler(this.Keresesteltipus5_SelectedValueChanged);
            // 
            // Kereseseredmenylista4
            // 
            this.Kereseseredmenylista4.BackgroundColor = System.Drawing.Color.White;
            this.Kereseseredmenylista4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Kereseseredmenylista4.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Kereseseredmenylista4.Location = new System.Drawing.Point(53, 237);
            this.Kereseseredmenylista4.Name = "Kereseseredmenylista4";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Kereseseredmenylista4.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Kereseseredmenylista4.Size = new System.Drawing.Size(737, 137);
            this.Kereseseredmenylista4.TabIndex = 33;
            // 
            // Kereses_fodarab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(834, 412);
            this.Controls.Add(this.Kereseseredmenylista4);
            this.Controls.Add(this.Keresesteltipus5);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Kereseseredmenydb2);
            this.Controls.Add(this.Keresesteltipus4);
            this.Controls.Add(this.Kereseseredmeny5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Kereses3);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Kereses_fodarab";
            this.Text = "Kereses_fodarab";
            this.Load += new System.EventHandler(this.Kereses_fodarab_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kereseseredmenylista4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Keresesteltipus4;
        private System.Windows.Forms.Label Kereseseredmeny5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Kereses3;
        private System.Windows.Forms.TextBox Kereseseredmenydb2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ComboBox Keresesteltipus5;
        private System.Windows.Forms.DataGridView Kereseseredmenylista4;
    }
}