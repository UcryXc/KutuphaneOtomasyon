namespace KutuphaneOtomasyon
{
    partial class MenuFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuFrm));
            this.yeniKullaniciBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cikisbtn = new System.Windows.Forms.Button();
            this.uyelerBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // yeniKullaniciBtn
            // 
            this.yeniKullaniciBtn.BackColor = System.Drawing.Color.Transparent;
            this.yeniKullaniciBtn.FlatAppearance.BorderSize = 0;
            this.yeniKullaniciBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yeniKullaniciBtn.Font = new System.Drawing.Font("Constantia", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniKullaniciBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.yeniKullaniciBtn.Location = new System.Drawing.Point(258, 12);
            this.yeniKullaniciBtn.Name = "yeniKullaniciBtn";
            this.yeniKullaniciBtn.Size = new System.Drawing.Size(491, 47);
            this.yeniKullaniciBtn.TabIndex = 2;
            this.yeniKullaniciBtn.Text = "YENİ KULLANICI OLUŞTUR";
            this.yeniKullaniciBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yeniKullaniciBtn.UseVisualStyleBackColor = false;
            this.yeniKullaniciBtn.Click += new System.EventHandler(this.yeniKullaniciBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // cikisbtn
            // 
            this.cikisbtn.BackColor = System.Drawing.Color.Transparent;
            this.cikisbtn.FlatAppearance.BorderSize = 0;
            this.cikisbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisbtn.Font = new System.Drawing.Font("Constantia", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cikisbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cikisbtn.Location = new System.Drawing.Point(777, 472);
            this.cikisbtn.Name = "cikisbtn";
            this.cikisbtn.Size = new System.Drawing.Size(122, 47);
            this.cikisbtn.TabIndex = 6;
            this.cikisbtn.Text = "ÇIKIŞ";
            this.cikisbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cikisbtn.UseVisualStyleBackColor = false;
            this.cikisbtn.Click += new System.EventHandler(this.cikisbtn_Click);
            // 
            // uyelerBtn
            // 
            this.uyelerBtn.BackColor = System.Drawing.Color.Transparent;
            this.uyelerBtn.FlatAppearance.BorderSize = 0;
            this.uyelerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uyelerBtn.Font = new System.Drawing.Font("Constantia", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyelerBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.uyelerBtn.Location = new System.Drawing.Point(258, 65);
            this.uyelerBtn.Name = "uyelerBtn";
            this.uyelerBtn.Size = new System.Drawing.Size(315, 49);
            this.uyelerBtn.TabIndex = 7;
            this.uyelerBtn.Text = "Kitap Ödünç Ver";
            this.uyelerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uyelerBtn.UseVisualStyleBackColor = false;
            this.uyelerBtn.Click += new System.EventHandler(this.uyelerBtn_Click);
            // 
            // MenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(924, 546);
            this.Controls.Add(this.uyelerBtn);
            this.Controls.Add(this.cikisbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.yeniKullaniciBtn);
            this.Name = "MenuFrm";
            this.Text = "MenuFrm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button yeniKullaniciBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cikisbtn;
        private System.Windows.Forms.Button uyelerBtn;
    }
}