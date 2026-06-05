namespace FAVNGİYİM
{
    partial class IslemGecmisiForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstGecmis   = new System.Windows.Forms.ListBox();
            this.lblBaslik   = new System.Windows.Forms.Label();
            this.lblSayac    = new System.Windows.Forms.Label();
            this.btnGeriAl   = new System.Windows.Forms.Button();
            this.btnTemizle  = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblBaslik
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.Location = new System.Drawing.Point(10, 10);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(460, 28);
            this.lblBaslik.Text = "İşlem Geçmişi (Stack — LIFO)";

            // lstGecmis
            this.lstGecmis.Location = new System.Drawing.Point(10, 45);
            this.lstGecmis.Name = "lstGecmis";
            this.lstGecmis.Size = new System.Drawing.Size(460, 320);

            // lblSayac
            this.lblSayac.Location = new System.Drawing.Point(10, 372);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(200, 20);
            this.lblSayac.Text = "Toplam kayıt: 0";

            // btnGeriAl
            this.btnGeriAl.Location = new System.Drawing.Point(10, 400);
            this.btnGeriAl.Name = "btnGeriAl";
            this.btnGeriAl.Size = new System.Drawing.Size(200, 35);
            this.btnGeriAl.Text = "Son İşlemi Geri Al (Undo)";
            this.btnGeriAl.BackColor = System.Drawing.Color.Black;
            this.btnGeriAl.ForeColor = System.Drawing.Color.White;
            this.btnGeriAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriAl.Click += new System.EventHandler(this.btnGeriAl_Click);

            // btnTemizle
            this.btnTemizle.Location = new System.Drawing.Point(225, 400);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(150, 35);
            this.btnTemizle.Text = "Tümünü Temizle";
            this.btnTemizle.BackColor = System.Drawing.Color.DarkRed;
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);

            // IslemGecmisiForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.lstGecmis);
            this.Controls.Add(this.lblSayac);
            this.Controls.Add(this.btnGeriAl);
            this.Controls.Add(this.btnTemizle);
            this.Name = "IslemGecmisiForm";
            this.Text = "İşlem Geçmişi — FAVN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.IslemGecmisiForm_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox lstGecmis;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblSayac;
        private System.Windows.Forms.Button btnGeriAl;
        private System.Windows.Forms.Button btnTemizle;
    }
}
