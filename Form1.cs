using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Gorsel_Programlama;

namespace FAVNGİYİM
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, string lParam);
        private const uint EM_SETCUEBANNER = 0x1501;

        private Panel  _pnlBosEkran;
        private Label  _lblUrunSayisi;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            typeof(Control).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(flpUrunler, true, null);

            InitBilgiBar();
            InitBosEkran();
            SendMessage(txtArama.Handle, EM_SETCUEBANNER, (IntPtr)1, "Ürün ara...");

            DosyaYonetici.Yukle();

            if (VeriTabani.TumUrunler.Count == 0)
            {
                VeriTabani.UrunEkle(new Urun { Id = 1,  Ad = "Mavi Tişört",       Fiyat = 250m,  Stok = 20, Kategori = "Üst Giyim", Beden = "M"  });
                VeriTabani.UrunEkle(new Urun { Id = 2,  Ad = "Keten Pantolon",    Fiyat = 450m,  Stok = 15, Kategori = "Alt Giyim", Beden = "L"  });
                VeriTabani.UrunEkle(new Urun { Id = 3,  Ad = "Deri Ceket",        Fiyat = 1200m, Stok = 5,  Kategori = "Üst Giyim", Beden = "XL" });
                VeriTabani.UrunEkle(new Urun { Id = 4,  Ad = "Spor Şort",         Fiyat = 180m,  Stok = 30, Kategori = "Alt Giyim", Beden = "S"  });
                VeriTabani.UrunEkle(new Urun { Id = 5,  Ad = "Deri Kemer",        Fiyat = 120m,  Stok = 25, Kategori = "Aksesuar",  Beden = "S"  });
                VeriTabani.UrunEkle(new Urun { Id = 6,  Ad = "Yazlık Elbise",     Fiyat = 550m,  Stok = 12, Kategori = "Üst Giyim", Beden = "M"  });
                VeriTabani.UrunEkle(new Urun { Id = 7,  Ad = "Slim Fit Jean",     Fiyat = 680m,  Stok = 18, Kategori = "Alt Giyim", Beden = "M"  });
                VeriTabani.UrunEkle(new Urun { Id = 8,  Ad = "Oversize Kapüşon",  Fiyat = 420m,  Stok = 22, Kategori = "Üst Giyim", Beden = "L"  });
                VeriTabani.UrunEkle(new Urun { Id = 9,  Ad = "Güneş Gözlüğü",    Fiyat = 350m,  Stok = 40, Kategori = "Aksesuar",  Beden = "S"  });
                VeriTabani.UrunEkle(new Urun { Id = 10, Ad = "Chino Pantolon",    Fiyat = 520m,  Stok = 3,  Kategori = "Alt Giyim", Beden = "XL" });
                VeriTabani.UrunEkle(new Urun { Id = 11, Ad = "Keten Gömlek",      Fiyat = 390m,  Stok = 0,  Kategori = "Üst Giyim", Beden = "S"  });
                VeriTabani.UrunEkle(new Urun { Id = 12, Ad = "Hasır Şapka",       Fiyat = 210m,  Stok = 35, Kategori = "Aksesuar",  Beden = "M"  });
            }

            UrunleriListele();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DosyaYonetici.Kaydet();
        }

        // ── Yardımcı başlatıcılar ────────────────────────────────────

        private void InitBilgiBar()
        {
            var pnlBar = new Panel
            {
                Dock      = DockStyle.Top,
                Height    = 36,
                BackColor = Color.White,
                Padding   = new Padding(12, 0, 12, 0)
            };

            _lblUrunSayisi = new Label
            {
                AutoSize  = true,
                Font      = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(100, 100, 110),
                Text      = "",
                Dock      = DockStyle.Left
            };
            _lblUrunSayisi.Top = (pnlBar.Height - _lblUrunSayisi.PreferredHeight) / 2;

            var sep = new Panel
            {
                Dock      = DockStyle.Bottom,
                Height    = 1,
                BackColor = Color.FromArgb(230, 230, 235)
            };

            pnlBar.Controls.Add(_lblUrunSayisi);
            pnlBar.Controls.Add(sep);
            this.Controls.Add(pnlBar);
            pnlBar.BringToFront();
        }

        private void cmbSiralama_SelectedIndexChanged(object sender, EventArgs e)
        {
            UrunleriListele();
        }

        private void InitBosEkran()
        {
            _pnlBosEkran = new Panel
            {
                Dock      = DockStyle.Fill,
                BackColor = Color.FromArgb(242, 242, 247),
                Visible   = false
            };

            var lblIkon = new Label
            {
                Text      = "🔍",
                Font      = new Font("Segoe UI", 40F),
                AutoSize  = false,
                Size      = new Size(500, 70),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(160, 160, 170)
            };

            var lblMesaj = new Label
            {
                Text      = "Ürün bulunamadı",
                Font      = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.FromArgb(60, 60, 70),
                AutoSize  = false,
                Size      = new Size(500, 36),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent
            };

            var lblAlt = new Label
            {
                Text      = "Farklı filtreler veya arama kriterleri deneyin.",
                Font      = new Font("Segoe UI", 10F),
                ForeColor = Color.FromArgb(140, 140, 150),
                AutoSize  = false,
                Size      = new Size(500, 24),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent
            };

            _pnlBosEkran.Controls.Add(lblAlt);
            _pnlBosEkran.Controls.Add(lblMesaj);
            _pnlBosEkran.Controls.Add(lblIkon);

            _pnlBosEkran.Resize += (s, e) =>
            {
                int cx = (_pnlBosEkran.Width - 500) / 2;
                int cy = (_pnlBosEkran.Height - 200) / 2;
                lblIkon.Location  = new Point(cx, cy);
                lblMesaj.Location = new Point(cx, cy + 78);
                lblAlt.Location   = new Point(cx, cy + 122);
            };

            this.Controls.Add(_pnlBosEkran);
            _pnlBosEkran.BringToFront();
        }

        // ── Ana listeleme metodu ──────────────────────────────────────

        public void UrunleriListele()
        {
            flpUrunler.Controls.Clear();

            string aranan = txtArama.Text.ToLower().Trim();

            var liste = new List<Urun>();

            foreach (var urun in VeriTabani.TumUrunler)
            {
                bool katEsles = (!chkUstGiyim.Checked && !chkAltGiyim.Checked && !chkAksesuar.Checked)
                    || (chkUstGiyim.Checked && urun.Kategori == "Üst Giyim")
                    || (chkAltGiyim.Checked && urun.Kategori == "Alt Giyim")
                    || (chkAksesuar.Checked && urun.Kategori == "Aksesuar");

                bool bedenEsles = (!chkS.Checked && !chkM.Checked && !chkL.Checked && !chkXL.Checked)
                    || (chkS.Checked  && urun.Beden == "S")
                    || (chkM.Checked  && urun.Beden == "M")
                    || (chkL.Checked  && urun.Beden == "L")
                    || (chkXL.Checked && urun.Beden == "XL");

                bool aramaEsles = string.IsNullOrEmpty(aranan) || urun.Ad.ToLower().Contains(aranan);

                if (katEsles && bedenEsles && aramaEsles)
                    liste.Add(urun);
            }

            // Sıralama
            switch (cmbSiralama.SelectedIndex)
            {
                case 1: liste = liste.OrderBy(u => u.Fiyat).ToList();           break;
                case 2: liste = liste.OrderByDescending(u => u.Fiyat).ToList(); break;
                case 3: liste = liste.OrderBy(u => u.Ad).ToList();              break;
            }

            foreach (var urun in liste)
            {
                var kart = new UrunKarti();
                kart.BilgileriYukle(urun);
                kart.Margin = new Padding(8);
                flpUrunler.Controls.Add(kart);
            }

            // Ürün sayısı etiketi
            lblSonucSayisi.Text = liste.Count == 0
                ? "Sonuç bulunamadı"
                : $"{liste.Count} ürün listeleniyor";

            // Boş ekran
            if (_pnlBosEkran != null)
                _pnlBosEkran.Visible = liste.Count == 0;
        }

        // ── Sepet badge ───────────────────────────────────────────────

        public void SepetBadgeGuncelle()
        {
            int sayi = VeriTabani.SiparisKuyrugu.Count;
            btnSepet.Text = sayi > 0 ? $"🛒  Sepet  ({sayi})" : "🛒  Sepet";
        }

        // ── Event handler'lar ─────────────────────────────────────────

        private void txtArama_TextChanged(object sender, EventArgs e)      => UrunleriListele();
        private void chkUstGiyim_CheckedChanged(object sender, EventArgs e) => UrunleriListele();
        private void chkAltGiyim_CheckedChanged(object sender, EventArgs e) => UrunleriListele();
        private void chkAksesuar_CheckedChanged(object sender, EventArgs e) => UrunleriListele();
        private void chkS_CheckedChanged(object sender, EventArgs e)        => UrunleriListele();
        private void chkM_CheckedChanged(object sender, EventArgs e)        => UrunleriListele();
        private void chkL_CheckedChanged(object sender, EventArgs e)        => UrunleriListele();
        private void chkXL_CheckedChanged(object sender, EventArgs e)       => UrunleriListele();

        private void btnFiltreTemizle_Click(object sender, EventArgs e)
        {
            chkUstGiyim.Checked = false;
            chkAltGiyim.Checked = false;
            chkAksesuar.Checked = false;
            chkS.Checked  = false;
            chkM.Checked  = false;
            chkL.Checked  = false;
            chkXL.Checked = false;
            txtArama.Clear();
            cmbSiralama.SelectedIndex = 0;
        }

        private void btnUrunYonetimi_Click(object sender, EventArgs e) => new UrunYonetimiForm(this).ShowDialog();
        private void btnSepet_Click(object sender, EventArgs e)
        {
            new SatisForm().ShowDialog();
            SepetBadgeGuncelle();
            UrunleriListele();
        }
        private void btnGecmis_Click(object sender, EventArgs e) => new IslemGecmisiForm().ShowDialog();
    }
}
