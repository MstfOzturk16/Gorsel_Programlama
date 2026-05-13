namespace FAVNGİYİM
{
    partial class Form1
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
            this.flpUrunler = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSiparisleriIsle = new System.Windows.Forms.Button();
            this.lstGecmis = new System.Windows.Forms.ListBox();
            this.btnGecmis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpUrunler
            // 
            this.flpUrunler.Location = new System.Drawing.Point(0, 0);
            this.flpUrunler.Name = "flpUrunler";
            this.flpUrunler.Size = new System.Drawing.Size(692, 383);
            this.flpUrunler.TabIndex = 0;
            this.flpUrunler.Paint += new System.Windows.Forms.PaintEventHandler(this.flpUrunler_Paint);
            // 
            // btnSiparisleriIsle
            // 
            this.btnSiparisleriIsle.Location = new System.Drawing.Point(698, 237);
            this.btnSiparisleriIsle.Name = "btnSiparisleriIsle";
            this.btnSiparisleriIsle.Size = new System.Drawing.Size(75, 23);
            this.btnSiparisleriIsle.TabIndex = 1;
            this.btnSiparisleriIsle.Text = "Sipariş Kuyruğunu İşle (Kasa)";
            this.btnSiparisleriIsle.UseVisualStyleBackColor = true;
            this.btnSiparisleriIsle.Click += new System.EventHandler(this.btnSiparisleriIsle_Click);
            // 
            // lstGecmis
            // 
            this.lstGecmis.FormattingEnabled = true;
            this.lstGecmis.ItemHeight = 16;
            this.lstGecmis.Location = new System.Drawing.Point(683, 354);
            this.lstGecmis.Name = "lstGecmis";
            this.lstGecmis.Size = new System.Drawing.Size(120, 84);
            this.lstGecmis.TabIndex = 2;
            // 
            // btnGecmis
            // 
            this.btnGecmis.Location = new System.Drawing.Point(713, 399);
            this.btnGecmis.Name = "btnGecmis";
            this.btnGecmis.Size = new System.Drawing.Size(75, 23);
            this.btnGecmis.TabIndex = 3;
            this.btnGecmis.Text = "işlem geçmişi (stack)";
            this.btnGecmis.UseVisualStyleBackColor = true;
            this.btnGecmis.Click += new System.EventHandler(this.btnGecmis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGecmis);
            this.Controls.Add(this.lstGecmis);
            this.Controls.Add(this.btnSiparisleriIsle);
            this.Controls.Add(this.flpUrunler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpUrunler;
        private System.Windows.Forms.Button btnSiparisleriIsle;
        private System.Windows.Forms.ListBox lstGecmis;
        private System.Windows.Forms.Button btnGecmis;
    }
}

