namespace Szakdolgozat1
{
    partial class Fooldal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fooldal));
            this.Fooldaludvozlo = new System.Windows.Forms.TextBox();
            this.Fooldaludvozlo5 = new System.Windows.Forms.Button();
            this.Fooldaludvozlo1 = new System.Windows.Forms.Label();
            this.Fooldaludvozlo2 = new System.Windows.Forms.Label();
            this.Fooldaludvozlo3 = new System.Windows.Forms.TextBox();
            this.Fooldaludvozlo4 = new System.Windows.Forms.TextBox();
            this.Fooldaludvozlo9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Fooldaludvozlo
            // 
            resources.ApplyResources(this.Fooldaludvozlo, "Fooldaludvozlo");
            this.Fooldaludvozlo.Name = "Fooldaludvozlo";
            this.Fooldaludvozlo.ReadOnly = true;
            this.Fooldaludvozlo.TextChanged += new System.EventHandler(this.Fooldaludvozlo_TextChanged);
            // 
            // Fooldaludvozlo5
            // 
            resources.ApplyResources(this.Fooldaludvozlo5, "Fooldaludvozlo5");
            this.Fooldaludvozlo5.Name = "Fooldaludvozlo5";
            this.Fooldaludvozlo5.UseVisualStyleBackColor = true;
            this.Fooldaludvozlo5.Click += new System.EventHandler(this.Fooldaludvozlo1_Click);
            // 
            // Fooldaludvozlo1
            // 
            resources.ApplyResources(this.Fooldaludvozlo1, "Fooldaludvozlo1");
            this.Fooldaludvozlo1.Name = "Fooldaludvozlo1";
            // 
            // Fooldaludvozlo2
            // 
            resources.ApplyResources(this.Fooldaludvozlo2, "Fooldaludvozlo2");
            this.Fooldaludvozlo2.Name = "Fooldaludvozlo2";
            // 
            // Fooldaludvozlo3
            // 
            resources.ApplyResources(this.Fooldaludvozlo3, "Fooldaludvozlo3");
            this.Fooldaludvozlo3.Name = "Fooldaludvozlo3";
            // 
            // Fooldaludvozlo4
            // 
            resources.ApplyResources(this.Fooldaludvozlo4, "Fooldaludvozlo4");
            this.Fooldaludvozlo4.Name = "Fooldaludvozlo4";
            // 
            // Fooldaludvozlo9
            // 
            resources.ApplyResources(this.Fooldaludvozlo9, "Fooldaludvozlo9");
            this.Fooldaludvozlo9.Name = "Fooldaludvozlo9";
            this.Fooldaludvozlo9.UseVisualStyleBackColor = true;
            this.Fooldaludvozlo9.Click += new System.EventHandler(this.Fooldaludvozlo9_Click);
            // 
            // Fooldal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CausesValidation = false;
            this.Controls.Add(this.Fooldaludvozlo9);
            this.Controls.Add(this.Fooldaludvozlo4);
            this.Controls.Add(this.Fooldaludvozlo3);
            this.Controls.Add(this.Fooldaludvozlo2);
            this.Controls.Add(this.Fooldaludvozlo1);
            this.Controls.Add(this.Fooldaludvozlo5);
            this.Controls.Add(this.Fooldaludvozlo);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Fooldal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TransparencyKey = System.Drawing.Color.Cornsilk;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Fooldaludvozlo;
        private System.Windows.Forms.Button Fooldaludvozlo5;
        private System.Windows.Forms.Label Fooldaludvozlo1;
        private System.Windows.Forms.Label Fooldaludvozlo2;
        private System.Windows.Forms.TextBox Fooldaludvozlo3;
        private System.Windows.Forms.TextBox Fooldaludvozlo4;
        private System.Windows.Forms.Button Fooldaludvozlo9;
    }
}

