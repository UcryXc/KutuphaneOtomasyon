namespace KutuphaneOtomasyon
{
    partial class YeniKullaniciFrm
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
            this.sifreTxtBox = new System.Windows.Forms.TextBox();
            this.kullaniciTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.silBtn = new System.Windows.Forms.Button();
            this.kaydetBtn = new System.Windows.Forms.Button();
            this.verileriGosterBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sifreTxtBox
            // 
            this.sifreTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreTxtBox.Location = new System.Drawing.Point(505, 153);
            this.sifreTxtBox.Name = "sifreTxtBox";
            this.sifreTxtBox.Size = new System.Drawing.Size(155, 29);
            this.sifreTxtBox.TabIndex = 9;
            // 
            // kullaniciTxtBox
            // 
            this.kullaniciTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciTxtBox.Location = new System.Drawing.Point(505, 77);
            this.kullaniciTxtBox.Name = "kullaniciTxtBox";
            this.kullaniciTxtBox.Size = new System.Drawing.Size(155, 29);
            this.kullaniciTxtBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(332, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(273, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // silBtn
            // 
            this.silBtn.BackColor = System.Drawing.Color.Transparent;
            this.silBtn.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.silBtn.FlatAppearance.BorderSize = 2;
            this.silBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.silBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silBtn.Location = new System.Drawing.Point(329, 282);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(148, 45);
            this.silBtn.TabIndex = 13;
            this.silBtn.Text = "Sil";
            this.silBtn.UseVisualStyleBackColor = false;
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.BackColor = System.Drawing.Color.Transparent;
            this.kaydetBtn.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.kaydetBtn.FlatAppearance.BorderSize = 2;
            this.kaydetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kaydetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydetBtn.Location = new System.Drawing.Point(175, 282);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(148, 45);
            this.kaydetBtn.TabIndex = 12;
            this.kaydetBtn.Text = "Kaydet";
            this.kaydetBtn.UseVisualStyleBackColor = false;
            // 
            // verileriGosterBtn
            // 
            this.verileriGosterBtn.BackColor = System.Drawing.Color.Transparent;
            this.verileriGosterBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.verileriGosterBtn.FlatAppearance.BorderSize = 2;
            this.verileriGosterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verileriGosterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.verileriGosterBtn.Location = new System.Drawing.Point(12, 282);
            this.verileriGosterBtn.Name = "verileriGosterBtn";
            this.verileriGosterBtn.Size = new System.Drawing.Size(148, 45);
            this.verileriGosterBtn.TabIndex = 11;
            this.verileriGosterBtn.Text = "Verileri Göster";
            this.verileriGosterBtn.UseVisualStyleBackColor = false;
            this.verileriGosterBtn.Click += new System.EventHandler(this.verileriGosterBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 333);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1032, 241);
            this.dataGridView1.TabIndex = 10;
            // 
            // YeniKullaniciFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1056, 597);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.kaydetBtn);
            this.Controls.Add(this.verileriGosterBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sifreTxtBox);
            this.Controls.Add(this.kullaniciTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "YeniKullaniciFrm";
            this.Text = "YeniKullaniciFrm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sifreTxtBox;
        private System.Windows.Forms.TextBox kullaniciTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.Button kaydetBtn;
        private System.Windows.Forms.Button verileriGosterBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}