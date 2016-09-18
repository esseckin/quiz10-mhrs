namespace Quiz10
{
    partial class RandevuGecmisi
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_randevu = new System.Windows.Forms.ComboBox();
            this.btn_goster = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgw_randevu = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_randevu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Randevu Seçiniz :";
            // 
            // cmb_randevu
            // 
            this.cmb_randevu.BackColor = System.Drawing.Color.White;
            this.cmb_randevu.FormattingEnabled = true;
            this.cmb_randevu.Location = new System.Drawing.Point(242, 61);
            this.cmb_randevu.Name = "cmb_randevu";
            this.cmb_randevu.Size = new System.Drawing.Size(121, 21);
            this.cmb_randevu.TabIndex = 1;
            // 
            // btn_goster
            // 
            this.btn_goster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(214)))), ((int)(((byte)(8)))));
            this.btn_goster.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_goster.Location = new System.Drawing.Point(251, 105);
            this.btn_goster.Name = "btn_goster";
            this.btn_goster.Size = new System.Drawing.Size(99, 48);
            this.btn_goster.TabIndex = 2;
            this.btn_goster.Text = "Göster";
            this.btn_goster.UseVisualStyleBackColor = false;
            this.btn_goster.Click += new System.EventHandler(this.btn_goster_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGreen;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.dgw_randevu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_goster);
            this.groupBox1.Controls.Add(this.cmb_randevu);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 397);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevu Geçmişi";
            // 
            // dgw_randevu
            // 
            this.dgw_randevu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(214)))), ((int)(((byte)(8)))));
            this.dgw_randevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_randevu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgw_randevu.Location = new System.Drawing.Point(3, 209);
            this.dgw_randevu.Name = "dgw_randevu";
            this.dgw_randevu.Size = new System.Drawing.Size(629, 185);
            this.dgw_randevu.TabIndex = 3;
            // 
            // RandevuGecmisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quiz10.Properties.Resources.mhrs2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(664, 429);
            this.Controls.Add(this.groupBox1);
            this.Name = "RandevuGecmisi";
            this.Text = "RandevuGecmisi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RandevuGecmisi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_randevu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_randevu;
        private System.Windows.Forms.Button btn_goster;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgw_randevu;
    }
}