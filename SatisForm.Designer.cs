namespace FAVNGİYİM
{
    partial class SatisForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl        = new System.Windows.Forms.TabControl();
            this.tabSepet          = new System.Windows.Forms.TabPage();
            this.lstSepet          = new System.Windows.Forms.ListBox();
            this.lblToplam         = new System.Windows.Forms.Label();
            this.tabSiparisler     = new System.Windows.Forms.TabPage();
            this.lstSiparisler     = new System.Windows.Forms.ListBox();
            this.btnSiparisOnayla  = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabSepet.SuspendLayout();
            this.tabSiparisler.SuspendLayout();
            this.SuspendLayout();

            // tabControl
            this.tabControl.Controls.Add(this.tabSepet);
            this.tabControl.Controls.Add(this.tabSiparisler);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);

            // tabSepet
            this.tabSepet.Controls.Add(this.lstSepet);
            this.tabSepet.Controls.Add(this.lblToplam);
            this.tabSepet.Name = "tabSepet";
            this.tabSepet.Text = "Sepet";
            this.tabSepet.Padding = new System.Windows.Forms.Padding(5);

            // lstSepet
            this.lstSepet.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstSepet.Height = 300;
            this.lstSepet.Name = "lstSepet";

            // lblToplam
            this.lblToplam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblToplam.Location = new System.Drawing.Point(5, 310);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(350, 30);
            this.lblToplam.Text = "Toplam: 0,00 TL";

            // tabSiparisler
            this.tabSiparisler.Controls.Add(this.lstSiparisler);
            this.tabSiparisler.Controls.Add(this.btnSiparisOnayla);
            this.tabSiparisler.Name = "tabSiparisler";
            this.tabSiparisler.Text = "Sipariş Kuyruğu";
            this.tabSiparisler.Padding = new System.Windows.Forms.Padding(5);

            // lstSiparisler
            this.lstSiparisler.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstSiparisler.Height = 300;
            this.lstSiparisler.Name = "lstSiparisler";

            // btnSiparisOnayla
            this.btnSiparisOnayla.Location = new System.Drawing.Point(5, 310);
            this.btnSiparisOnayla.Name = "btnSiparisOnayla";
            this.btnSiparisOnayla.Size = new System.Drawing.Size(200, 35);
            this.btnSiparisOnayla.Text = "Tüm Siparişleri İşle (Kasa)";
            this.btnSiparisOnayla.BackColor = System.Drawing.Color.Black;
            this.btnSiparisOnayla.ForeColor = System.Drawing.Color.White;
            this.btnSiparisOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparisOnayla.Click += new System.EventHandler(this.btnSiparisOnayla_Click);

            // SatisForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 420);
            this.Controls.Add(this.tabControl);
            this.Name = "SatisForm";
            this.Text = "Sepet & Siparişler — FAVN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.SatisForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabSepet.ResumeLayout(false);
            this.tabSiparisler.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSepet;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.TabPage tabSiparisler;
        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.Button btnSiparisOnayla;
    }
}
