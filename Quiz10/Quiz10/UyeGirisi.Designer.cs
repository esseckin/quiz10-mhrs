namespace Quiz10
{
    partial class UyeGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeGirisi));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_uyeGiris = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_kullanıcıAd = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(214)))), ((int)(((byte)(8)))));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_uyeGiris);
            this.groupBox1.Controls.Add(this.txt_pass);
            this.groupBox1.Controls.Add(this.txt_kullanıcıAd);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txt_uyeGiris
            // 
            this.txt_uyeGiris.BackColor = System.Drawing.Color.LightGreen;
            resources.ApplyResources(this.txt_uyeGiris, "txt_uyeGiris");
            this.txt_uyeGiris.Name = "txt_uyeGiris";
            this.txt_uyeGiris.UseVisualStyleBackColor = false;
            this.txt_uyeGiris.Click += new System.EventHandler(this.txt_uyeGiris_Click);
            // 
            // txt_pass
            // 
            resources.ApplyResources(this.txt_pass, "txt_pass");
            this.txt_pass.Name = "txt_pass";
            // 
            // txt_kullanıcıAd
            // 
            resources.ApplyResources(this.txt_kullanıcıAd, "txt_kullanıcıAd");
            this.txt_kullanıcıAd.Name = "txt_kullanıcıAd";
            // 
            // UyeGirisi
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quiz10.Properties.Resources.mhrs2;
            this.Controls.Add(this.groupBox1);
            this.Name = "UyeGirisi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UyeGirisi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txt_uyeGiris;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_kullanıcıAd;
    }
}