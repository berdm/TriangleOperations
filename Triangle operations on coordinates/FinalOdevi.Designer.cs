namespace FinalOdevi
{
    partial class frmFinalOdevi
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEksenCiz = new System.Windows.Forms.Button();
            this.btnNesneCiz = new System.Windows.Forms.Button();
            this.btnNesneYansit = new System.Windows.Forms.Button();
            this.btnDondur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEksenCiz
            // 
            this.btnEksenCiz.Location = new System.Drawing.Point(52, 117);
            this.btnEksenCiz.Name = "btnEksenCiz";
            this.btnEksenCiz.Size = new System.Drawing.Size(75, 41);
            this.btnEksenCiz.TabIndex = 0;
            this.btnEksenCiz.Text = "Eksenleri Çiz";
            this.btnEksenCiz.UseVisualStyleBackColor = true;
            this.btnEksenCiz.Click += new System.EventHandler(this.btnEksenCiz_Click);
            // 
            // btnNesneCiz
            // 
            this.btnNesneCiz.Location = new System.Drawing.Point(52, 176);
            this.btnNesneCiz.Name = "btnNesneCiz";
            this.btnNesneCiz.Size = new System.Drawing.Size(75, 41);
            this.btnNesneCiz.TabIndex = 1;
            this.btnNesneCiz.Text = "Nesneyi Çiz (Üçgen)";
            this.btnNesneCiz.UseVisualStyleBackColor = true;
            this.btnNesneCiz.Click += new System.EventHandler(this.btnNesneCiz_Click);
            // 
            // btnNesneYansit
            // 
            this.btnNesneYansit.Location = new System.Drawing.Point(52, 232);
            this.btnNesneYansit.Name = "btnNesneYansit";
            this.btnNesneYansit.Size = new System.Drawing.Size(75, 36);
            this.btnNesneYansit.TabIndex = 2;
            this.btnNesneYansit.Text = "Yansıt(X)";
            this.btnNesneYansit.UseVisualStyleBackColor = true;
            // 
            // btnDondur
            // 
            this.btnDondur.Location = new System.Drawing.Point(52, 285);
            this.btnDondur.Name = "btnDondur";
            this.btnDondur.Size = new System.Drawing.Size(75, 39);
            this.btnDondur.TabIndex = 3;
            this.btnDondur.Text = "Döndür";
            this.btnDondur.UseVisualStyleBackColor = true;
            // 
            // frmFinalOdevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 478);
            this.Controls.Add(this.btnDondur);
            this.Controls.Add(this.btnNesneYansit);
            this.Controls.Add(this.btnNesneCiz);
            this.Controls.Add(this.btnEksenCiz);
            this.Name = "frmFinalOdevi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Final Ödevi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEksenCiz;
        private System.Windows.Forms.Button btnNesneCiz;
        private System.Windows.Forms.Button btnNesneYansit;
        private System.Windows.Forms.Button btnDondur;
    }
}

