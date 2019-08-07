namespace Szakdolgozat1
{
    partial class Kereses_urlapok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kereses_urlapok));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Kereses1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Kereseseredmeny1 = new System.Windows.Forms.Label();
            this.Keresesimei1 = new System.Windows.Forms.Label();
            this.Keresesimei3 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.Keresesazonosito1 = new System.Windows.Forms.Label();
            this.Kereseseredmenylista1 = new System.Windows.Forms.DataGridView();
            this.Keresesazonosito2 = new System.Windows.Forms.ComboBox();
            this.Keresesimei2 = new System.Windows.Forms.MaskedTextBox();
            this.Keresesimei4 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kereseseredmenylista1)).BeginInit();
            this.SuspendLayout();
            // 
            // Kereses1
            // 
            this.Kereses1.AutoSize = true;
            this.Kereses1.Location = new System.Drawing.Point(37, 45);
            this.Kereses1.Name = "Kereses1";
            this.Kereses1.Size = new System.Drawing.Size(115, 13);
            this.Kereses1.TabIndex = 0;
            this.Kereses1.Text = "Keresés az űrlapokban";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // Kereseseredmeny1
            // 
            this.Kereseseredmeny1.AutoSize = true;
            this.Kereseseredmeny1.Location = new System.Drawing.Point(40, 221);
            this.Kereseseredmeny1.Name = "Kereseseredmeny1";
            this.Kereseseredmeny1.Size = new System.Drawing.Size(100, 13);
            this.Kereseseredmeny1.TabIndex = 0;
            this.Kereseseredmeny1.Text = "Keresés eredménye";
            // 
            // Keresesimei1
            // 
            this.Keresesimei1.AutoSize = true;
            this.Keresesimei1.Location = new System.Drawing.Point(40, 86);
            this.Keresesimei1.Name = "Keresesimei1";
            this.Keresesimei1.Size = new System.Drawing.Size(26, 13);
            this.Keresesimei1.TabIndex = 0;
            this.Keresesimei1.Text = "Imei";
            // 
            // Keresesimei3
            // 
            this.Keresesimei3.Location = new System.Drawing.Point(385, 86);
            this.Keresesimei3.Name = "Keresesimei3";
            this.Keresesimei3.Size = new System.Drawing.Size(75, 23);
            this.Keresesimei3.TabIndex = 2;
            this.Keresesimei3.Text = "Keresés";
            this.Keresesimei3.UseVisualStyleBackColor = true;
            this.Keresesimei3.Click += new System.EventHandler(this.Keresesimei3_Click);
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
            // Keresesazonosito1
            // 
            this.Keresesazonosito1.AutoSize = true;
            this.Keresesazonosito1.Location = new System.Drawing.Point(43, 150);
            this.Keresesazonosito1.Name = "Keresesazonosito1";
            this.Keresesazonosito1.Size = new System.Drawing.Size(90, 13);
            this.Keresesazonosito1.TabIndex = 9;
            this.Keresesazonosito1.Text = "Adatlapazonosító";
            // 
            // Kereseseredmenylista1
            // 
            this.Kereseseredmenylista1.AllowUserToAddRows = false;
            this.Kereseseredmenylista1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Kereseseredmenylista1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Kereseseredmenylista1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Kereseseredmenylista1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Kereseseredmenylista1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Kereseseredmenylista1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Kereseseredmenylista1.Location = new System.Drawing.Point(40, 265);
            this.Kereseseredmenylista1.Name = "Kereseseredmenylista1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Kereseseredmenylista1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Kereseseredmenylista1.ShowCellToolTips = false;
            this.Kereseseredmenylista1.ShowEditingIcon = false;
            this.Kereseseredmenylista1.Size = new System.Drawing.Size(756, 108);
            this.Kereseseredmenylista1.TabIndex = 12;
            // 
            // Keresesazonosito2
            // 
            this.Keresesazonosito2.FormattingEnabled = true;
            this.Keresesazonosito2.Location = new System.Drawing.Point(216, 142);
            this.Keresesazonosito2.MaxDropDownItems = 4;
            this.Keresesazonosito2.Name = "Keresesazonosito2";
            this.Keresesazonosito2.Size = new System.Drawing.Size(121, 21);
            this.Keresesazonosito2.TabIndex = 3;
            this.Keresesazonosito2.SelectedValueChanged += new System.EventHandler(this.Keresesazonosito3_SelectedValueChanged);
            // 
            // Keresesimei2
            // 
            this.Keresesimei2.Location = new System.Drawing.Point(216, 86);
            this.Keresesimei2.Mask = "000000000";
            this.Keresesimei2.Name = "Keresesimei2";
            this.Keresesimei2.Size = new System.Drawing.Size(121, 20);
            this.Keresesimei2.TabIndex = 1;
            // 
            // Keresesimei4
            // 
            this.Keresesimei4.Location = new System.Drawing.Point(490, 86);
            this.Keresesimei4.Name = "Keresesimei4";
            this.Keresesimei4.Size = new System.Drawing.Size(75, 23);
            this.Keresesimei4.TabIndex = 4;
            this.Keresesimei4.Text = "Új keresés";
            this.Keresesimei4.UseVisualStyleBackColor = true;
            this.Keresesimei4.Click += new System.EventHandler(this.Keresesimei4_Click);
            // 
            // Kereses_urlapok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(834, 412);
            this.Controls.Add(this.Keresesimei4);
            this.Controls.Add(this.Keresesimei2);
            this.Controls.Add(this.Keresesazonosito2);
            this.Controls.Add(this.Kereseseredmenylista1);
            this.Controls.Add(this.Keresesazonosito1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Keresesimei3);
            this.Controls.Add(this.Keresesimei1);
            this.Controls.Add(this.Kereseseredmeny1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Kereses1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Kereses_urlapok";
            this.Text = "Kereses_urlapok";
            this.Load += new System.EventHandler(this.Kereses_urlapok_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kereseseredmenylista1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Kereses1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Kereseseredmeny1;
        private System.Windows.Forms.Label Keresesimei1;
        private System.Windows.Forms.Button Keresesimei3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Label Keresesazonosito1;
        private System.Windows.Forms.DataGridView Kereseseredmenylista1;
        private System.Windows.Forms.ComboBox Keresesazonosito2;
        private System.Windows.Forms.MaskedTextBox Keresesimei2;
        private System.Windows.Forms.Button Keresesimei4;
    }
}