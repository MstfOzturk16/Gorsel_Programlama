namespace FAVNGİYİM
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader       = new System.Windows.Forms.Panel();
            this.lblBaslik       = new System.Windows.Forms.Label();
            this.lblSlogan       = new System.Windows.Forms.Label();
            this.pnlArama        = new System.Windows.Forms.Panel();
            this.lblAramaIkon    = new System.Windows.Forms.Label();
            this.txtArama        = new System.Windows.Forms.TextBox();
            this.pnlNavButonlar  = new System.Windows.Forms.Panel();
            this.btnUrunYonetimi = new System.Windows.Forms.Button();
            this.btnSepet        = new System.Windows.Forms.Button();
            this.btnGecmis       = new System.Windows.Forms.Button();
            this.pnlFiltre       = new System.Windows.Forms.Panel();
            this.lblFiltreBas    = new System.Windows.Forms.Label();
            this.pnlSep1         = new System.Windows.Forms.Panel();
            this.lblKatBaslik    = new System.Windows.Forms.Label();
            this.chkUstGiyim     = new System.Windows.Forms.CheckBox();
            this.chkAltGiyim     = new System.Windows.Forms.CheckBox();
            this.chkAksesuar     = new System.Windows.Forms.CheckBox();
            this.pnlSep2         = new System.Windows.Forms.Panel();
            this.lblBedenBaslik  = new System.Windows.Forms.Label();
            this.pnlBedenGrid    = new System.Windows.Forms.Panel();
            this.chkS            = new System.Windows.Forms.CheckBox();
            this.chkM            = new System.Windows.Forms.CheckBox();
            this.chkL            = new System.Windows.Forms.CheckBox();
            this.chkXL           = new System.Windows.Forms.CheckBox();
            this.pnlSep3         = new System.Windows.Forms.Panel();
            this.btnFiltreTemizle = new System.Windows.Forms.Button();
            this.pnlSep4          = new System.Windows.Forms.Panel();
            this.lblSiralamaBaslik = new System.Windows.Forms.Label();
            this.cmbSiralama      = new System.Windows.Forms.ComboBox();
            this.pnlSep5          = new System.Windows.Forms.Panel();
            this.lblSonucSayisi   = new System.Windows.Forms.Label();
            this.pnlBrand         = new System.Windows.Forms.Panel();
            this.flpUrunler       = new System.Windows.Forms.FlowLayoutPanel();

            this.pnlHeader.SuspendLayout();
            this.pnlNavButonlar.SuspendLayout();
            this.pnlArama.SuspendLayout();
            this.pnlFiltre.SuspendLayout();
            this.pnlBedenGrid.SuspendLayout();
            this.SuspendLayout();

            // ════════════════════════════════════════════
            // HEADER
            // ════════════════════════════════════════════
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(10, 10, 10);
            this.pnlHeader.Controls.Add(this.lblBaslik);
            this.pnlHeader.Controls.Add(this.lblSlogan);
            this.pnlHeader.Controls.Add(this.pnlArama);
            this.pnlHeader.Controls.Add(this.pnlNavButonlar);
            this.pnlHeader.Dock   = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 95;
            this.pnlHeader.Name   = "pnlHeader";

            this.lblBaslik.AutoSize  = false;
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Font      = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.Location  = new System.Drawing.Point(18, 14);
            this.lblBaslik.Name      = "lblBaslik";
            this.lblBaslik.Size      = new System.Drawing.Size(185, 40);
            this.lblBaslik.Text      = "FAVN";

            this.lblSlogan.ForeColor = System.Drawing.Color.FromArgb(110, 110, 110);
            this.lblSlogan.Font      = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Italic);
            this.lblSlogan.Location  = new System.Drawing.Point(21, 58);
            this.lblSlogan.Name      = "lblSlogan";
            this.lblSlogan.Size      = new System.Drawing.Size(160, 16);
            this.lblSlogan.Text      = "modern giyim mağazası";

            this.pnlArama.BackColor   = System.Drawing.Color.FromArgb(30, 30, 30);
            this.pnlArama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlArama.Controls.Add(this.lblAramaIkon);
            this.pnlArama.Controls.Add(this.txtArama);
            this.pnlArama.Location    = new System.Drawing.Point(215, 32);
            this.pnlArama.Name        = "pnlArama";
            this.pnlArama.Size        = new System.Drawing.Size(340, 32);

            this.lblAramaIkon.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblAramaIkon.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAramaIkon.Location  = new System.Drawing.Point(6, 4);
            this.lblAramaIkon.Name      = "lblAramaIkon";
            this.lblAramaIkon.Size      = new System.Drawing.Size(22, 20);
            this.lblAramaIkon.Text      = "🔍";

            this.txtArama.BackColor   = System.Drawing.Color.FromArgb(30, 30, 30);
            this.txtArama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArama.ForeColor   = System.Drawing.Color.White;
            this.txtArama.Font        = new System.Drawing.Font("Segoe UI", 10F);
            this.txtArama.Location    = new System.Drawing.Point(32, 6);
            this.txtArama.Name        = "txtArama";
            this.txtArama.Size        = new System.Drawing.Size(300, 20);
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);

            this.pnlNavButonlar.BackColor = System.Drawing.Color.Transparent;
            this.pnlNavButonlar.Controls.Add(this.btnUrunYonetimi);
            this.pnlNavButonlar.Controls.Add(this.btnSepet);
            this.pnlNavButonlar.Controls.Add(this.btnGecmis);
            this.pnlNavButonlar.Dock  = System.Windows.Forms.DockStyle.Right;
            this.pnlNavButonlar.Width = 390;
            this.pnlNavButonlar.Name  = "pnlNavButonlar";

            this.btnUrunYonetimi.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.btnUrunYonetimi.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            this.btnUrunYonetimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunYonetimi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.btnUrunYonetimi.FlatAppearance.BorderSize  = 1;
            this.btnUrunYonetimi.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUrunYonetimi.Location = new System.Drawing.Point(8, 30);
            this.btnUrunYonetimi.Name     = "btnUrunYonetimi";
            this.btnUrunYonetimi.Size     = new System.Drawing.Size(125, 34);
            this.btnUrunYonetimi.Text     = "Ürün Yönetimi";
            this.btnUrunYonetimi.Cursor   = System.Windows.Forms.Cursors.Hand;
            this.btnUrunYonetimi.Click   += new System.EventHandler(this.btnUrunYonetimi_Click);

            this.btnSepet.ForeColor = System.Drawing.Color.White;
            this.btnSepet.BackColor = System.Drawing.Color.FromArgb(61, 90, 254);
            this.btnSepet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSepet.FlatAppearance.BorderSize = 0;
            this.btnSepet.Font      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSepet.Location  = new System.Drawing.Point(143, 30);
            this.btnSepet.Name      = "btnSepet";
            this.btnSepet.Size      = new System.Drawing.Size(110, 34);
            this.btnSepet.Text      = "🛒  Sepet";
            this.btnSepet.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnSepet.Click    += new System.EventHandler(this.btnSepet_Click);

            this.btnGecmis.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.btnGecmis.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            this.btnGecmis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGecmis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.btnGecmis.FlatAppearance.BorderSize  = 1;
            this.btnGecmis.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGecmis.Location = new System.Drawing.Point(263, 30);
            this.btnGecmis.Name     = "btnGecmis";
            this.btnGecmis.Size     = new System.Drawing.Size(118, 34);
            this.btnGecmis.Text     = "📋  Geçmiş";
            this.btnGecmis.Cursor   = System.Windows.Forms.Cursors.Hand;
            this.btnGecmis.Click   += new System.EventHandler(this.btnGecmis_Click);

            // ════════════════════════════════════════════
            // FİLTRE PANELİ
            // ════════════════════════════════════════════
            this.pnlFiltre.BackColor = System.Drawing.Color.FromArgb(250, 250, 253);
            this.pnlFiltre.Controls.Add(this.lblFiltreBas);
            this.pnlFiltre.Controls.Add(this.pnlSep1);
            this.pnlFiltre.Controls.Add(this.lblKatBaslik);
            this.pnlFiltre.Controls.Add(this.chkUstGiyim);
            this.pnlFiltre.Controls.Add(this.chkAltGiyim);
            this.pnlFiltre.Controls.Add(this.chkAksesuar);
            this.pnlFiltre.Controls.Add(this.pnlSep2);
            this.pnlFiltre.Controls.Add(this.lblBedenBaslik);
            this.pnlFiltre.Controls.Add(this.pnlBedenGrid);
            this.pnlFiltre.Controls.Add(this.pnlSep3);
            this.pnlFiltre.Controls.Add(this.btnFiltreTemizle);
            this.pnlFiltre.Controls.Add(this.pnlSep4);
            this.pnlFiltre.Controls.Add(this.lblSiralamaBaslik);
            this.pnlFiltre.Controls.Add(this.cmbSiralama);
            this.pnlFiltre.Controls.Add(this.pnlSep5);
            this.pnlFiltre.Controls.Add(this.lblSonucSayisi);
            this.pnlFiltre.Controls.Add(this.pnlBrand);
            this.pnlFiltre.Dock  = System.Windows.Forms.DockStyle.Left;
            this.pnlFiltre.Width = 205;
            this.pnlFiltre.Name  = "pnlFiltre";

            // FİLTRELE başlık
            this.lblFiltreBas.ForeColor = System.Drawing.Color.FromArgb(15, 15, 15);
            this.lblFiltreBas.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFiltreBas.Location  = new System.Drawing.Point(16, 20);
            this.lblFiltreBas.Name      = "lblFiltreBas";
            this.lblFiltreBas.Size      = new System.Drawing.Size(173, 26);
            this.lblFiltreBas.Text      = "FİLTRELE";

            Sep(this.pnlSep1, 55);

            // KATEGORİLER
            this.lblKatBaslik.ForeColor = System.Drawing.Color.FromArgb(130, 130, 140);
            this.lblKatBaslik.Font      = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblKatBaslik.Location  = new System.Drawing.Point(16, 65);
            this.lblKatBaslik.Name      = "lblKatBaslik";
            this.lblKatBaslik.Size      = new System.Drawing.Size(173, 16);
            this.lblKatBaslik.Text      = "KATEGORİLER";

            KatChk(this.chkUstGiyim, "Üst Giyim", 86,
                System.Drawing.Color.FromArgb(61, 90, 254));
            this.chkUstGiyim.CheckedChanged += new System.EventHandler(this.chkUstGiyim_CheckedChanged);

            KatChk(this.chkAltGiyim, "Alt Giyim", 114,
                System.Drawing.Color.FromArgb(0, 150, 136));
            this.chkAltGiyim.CheckedChanged += new System.EventHandler(this.chkAltGiyim_CheckedChanged);

            KatChk(this.chkAksesuar, "Aksesuar", 142,
                System.Drawing.Color.FromArgb(142, 36, 170));
            this.chkAksesuar.CheckedChanged += new System.EventHandler(this.chkAksesuar_CheckedChanged);

            Sep(this.pnlSep2, 176);

            // BEDEN
            this.lblBedenBaslik.ForeColor = System.Drawing.Color.FromArgb(130, 130, 140);
            this.lblBedenBaslik.Font      = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblBedenBaslik.Location  = new System.Drawing.Point(16, 186);
            this.lblBedenBaslik.Name      = "lblBedenBaslik";
            this.lblBedenBaslik.Size      = new System.Drawing.Size(173, 16);
            this.lblBedenBaslik.Text      = "BEDEN";

            this.pnlBedenGrid.BackColor = System.Drawing.Color.Transparent;
            this.pnlBedenGrid.Controls.Add(this.chkS);
            this.pnlBedenGrid.Controls.Add(this.chkM);
            this.pnlBedenGrid.Controls.Add(this.chkL);
            this.pnlBedenGrid.Controls.Add(this.chkXL);
            this.pnlBedenGrid.Location = new System.Drawing.Point(14, 207);
            this.pnlBedenGrid.Name     = "pnlBedenGrid";
            this.pnlBedenGrid.Size     = new System.Drawing.Size(174, 68);

            BedenChk(this.chkS,  "S",   0,  0);
            BedenChk(this.chkM,  "M",  88,  0);
            BedenChk(this.chkL,  "L",   0, 34);
            BedenChk(this.chkXL, "XL", 88, 34);

            this.chkS.CheckedChanged  += new System.EventHandler(this.chkS_CheckedChanged);
            this.chkM.CheckedChanged  += new System.EventHandler(this.chkM_CheckedChanged);
            this.chkL.CheckedChanged  += new System.EventHandler(this.chkL_CheckedChanged);
            this.chkXL.CheckedChanged += new System.EventHandler(this.chkXL_CheckedChanged);

            Sep(this.pnlSep3, 284);

            // Filtreleri Temizle
            this.btnFiltreTemizle.ForeColor = System.Drawing.Color.FromArgb(90, 90, 100);
            this.btnFiltreTemizle.BackColor = System.Drawing.Color.FromArgb(240, 240, 246);
            this.btnFiltreTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltreTemizle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(210, 210, 220);
            this.btnFiltreTemizle.FlatAppearance.BorderSize  = 1;
            this.btnFiltreTemizle.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFiltreTemizle.Location = new System.Drawing.Point(16, 294);
            this.btnFiltreTemizle.Name     = "btnFiltreTemizle";
            this.btnFiltreTemizle.Size     = new System.Drawing.Size(173, 32);
            this.btnFiltreTemizle.Text     = "✕   Filtreleri Temizle";
            this.btnFiltreTemizle.Cursor   = System.Windows.Forms.Cursors.Hand;
            this.btnFiltreTemizle.Click   += new System.EventHandler(this.btnFiltreTemizle_Click);

            Sep(this.pnlSep4, 338);

            // SIRALAMA
            this.lblSiralamaBaslik.ForeColor = System.Drawing.Color.FromArgb(130, 130, 140);
            this.lblSiralamaBaslik.Font      = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblSiralamaBaslik.Location  = new System.Drawing.Point(16, 348);
            this.lblSiralamaBaslik.Name      = "lblSiralamaBaslik";
            this.lblSiralamaBaslik.Size      = new System.Drawing.Size(173, 16);
            this.lblSiralamaBaslik.Text      = "SIRALAMA";

            this.cmbSiralama.DropDownStyle   = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSiralama.Font            = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbSiralama.FlatStyle       = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSiralama.BackColor       = System.Drawing.Color.White;
            this.cmbSiralama.ForeColor       = System.Drawing.Color.FromArgb(30, 30, 30);
            this.cmbSiralama.Location        = new System.Drawing.Point(16, 370);
            this.cmbSiralama.Name            = "cmbSiralama";
            this.cmbSiralama.Size            = new System.Drawing.Size(173, 26);
            this.cmbSiralama.Items.AddRange(new object[] {
                "⇅  Varsayılan",
                "↑  Fiyat: Düşükten Yükseğe",
                "↓  Fiyat: Yüksekten Düşüğe",
                "A  İsim: A → Z"
            });
            this.cmbSiralama.SelectedIndex = 0;
            this.cmbSiralama.SelectedIndexChanged += new System.EventHandler(this.cmbSiralama_SelectedIndexChanged);

            Sep(this.pnlSep5, 408);

            // Sonuç sayacı
            this.lblSonucSayisi.ForeColor = System.Drawing.Color.FromArgb(100, 100, 115);
            this.lblSonucSayisi.Font      = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSonucSayisi.Location  = new System.Drawing.Point(16, 418);
            this.lblSonucSayisi.Name      = "lblSonucSayisi";
            this.lblSonucSayisi.Size      = new System.Drawing.Size(173, 18);
            this.lblSonucSayisi.Text      = "12 ürün listeleniyor";

            // Marka footer (DockStyle.Bottom)
            this.pnlBrand.BackColor  = System.Drawing.Color.FromArgb(240, 240, 248);
            this.pnlBrand.Dock       = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBrand.Height     = 80;
            this.pnlBrand.Name       = "pnlBrand";

            var lblBrandLogo = new System.Windows.Forms.Label
            {
                Text      = "FAVN",
                Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.FromArgb(61, 90, 254),
                AutoSize  = false,
                Size      = new System.Drawing.Size(173, 28),
                Location  = new System.Drawing.Point(16, 12),
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            };
            var lblBrandSlogan = new System.Windows.Forms.Label
            {
                Text      = "modern giyim mağazası",
                Font      = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Italic),
                ForeColor = System.Drawing.Color.FromArgb(150, 150, 160),
                AutoSize  = false,
                Size      = new System.Drawing.Size(173, 16),
                Location  = new System.Drawing.Point(16, 40)
            };
            var lblBrandYear = new System.Windows.Forms.Label
            {
                Text      = "© 2025–2026 Görsel Programlama",
                Font      = new System.Drawing.Font("Segoe UI", 7F),
                ForeColor = System.Drawing.Color.FromArgb(170, 170, 180),
                AutoSize  = false,
                Size      = new System.Drawing.Size(173, 14),
                Location  = new System.Drawing.Point(16, 58)
            };
            this.pnlBrand.Controls.Add(lblBrandLogo);
            this.pnlBrand.Controls.Add(lblBrandSlogan);
            this.pnlBrand.Controls.Add(lblBrandYear);

            // ════════════════════════════════════════════
            // ÜRÜN LİSTESİ
            // ════════════════════════════════════════════
            this.flpUrunler.AutoScroll = true;
            this.flpUrunler.BackColor  = System.Drawing.Color.FromArgb(242, 242, 247);
            this.flpUrunler.Dock       = System.Windows.Forms.DockStyle.Fill;
            this.flpUrunler.Name       = "flpUrunler";
            this.flpUrunler.Padding    = new System.Windows.Forms.Padding(16, 22, 16, 16);

            // ════════════════════════════════════════════
            // FORM
            // ════════════════════════════════════════════
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(242, 242, 247);
            this.ClientSize          = new System.Drawing.Size(1200, 750);
            this.MinimumSize         = new System.Drawing.Size(960, 640);
            this.Controls.Add(this.flpUrunler);
            this.Controls.Add(this.pnlFiltre);
            this.Controls.Add(this.pnlHeader);
            this.Name        = "Form1";
            this.Text        = "FAVN — Modern Giyim Mağazası";
            this.Load       += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);

            this.pnlHeader.ResumeLayout(false);
            this.pnlNavButonlar.ResumeLayout(false);
            this.pnlArama.ResumeLayout(false);
            this.pnlFiltre.ResumeLayout(false);
            this.pnlBedenGrid.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        // ── Yardımcı stil metotları ──────────────────────────────────

        private void Sep(System.Windows.Forms.Panel p, int y)
        {
            p.BackColor = System.Drawing.Color.FromArgb(220, 220, 228);
            p.Location  = new System.Drawing.Point(16, y);
            p.Size      = new System.Drawing.Size(173, 1);
        }

        private void KatChk(System.Windows.Forms.CheckBox chk, string text, int y,
            System.Drawing.Color accent)
        {
            chk.FlatStyle  = System.Windows.Forms.FlatStyle.Flat;
            chk.FlatAppearance.CheckedBackColor  = accent;
            chk.FlatAppearance.BorderColor       = System.Drawing.Color.FromArgb(200, 200, 210);
            chk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(245, 245, 250);
            chk.BackColor  = System.Drawing.Color.Transparent;
            chk.ForeColor  = System.Drawing.Color.FromArgb(30, 30, 35);
            chk.Font       = new System.Drawing.Font("Segoe UI", 9.5F);
            chk.Location   = new System.Drawing.Point(14, y);
            chk.Name       = "chk" + text.Replace(" ", "");
            chk.Size       = new System.Drawing.Size(175, 24);
            chk.Text       = text;
            chk.Cursor     = System.Windows.Forms.Cursors.Hand;
        }

        private void BedenChk(System.Windows.Forms.CheckBox chk, string text, int x, int y)
        {
            chk.Appearance = System.Windows.Forms.Appearance.Button;
            chk.FlatStyle  = System.Windows.Forms.FlatStyle.Flat;
            chk.FlatAppearance.BorderColor       = System.Drawing.Color.FromArgb(210, 210, 220);
            chk.FlatAppearance.BorderSize        = 1;
            chk.FlatAppearance.CheckedBackColor  = System.Drawing.Color.FromArgb(61, 90, 254);
            chk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(230, 232, 255);
            chk.BackColor  = System.Drawing.Color.FromArgb(238, 238, 246);
            chk.ForeColor  = System.Drawing.Color.FromArgb(30, 30, 30);
            chk.Font       = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            chk.Location   = new System.Drawing.Point(x, y);
            chk.Name       = "chk" + text;
            chk.Size       = new System.Drawing.Size(80, 30);
            chk.Text       = text;
            chk.TextAlign  = System.Drawing.ContentAlignment.MiddleCenter;
            chk.Cursor     = System.Windows.Forms.Cursors.Hand;
        }

        // ── Alanlar ──────────────────────────────────────────────────
        private System.Windows.Forms.Panel    pnlHeader;
        private System.Windows.Forms.Label    lblBaslik;
        private System.Windows.Forms.Label    lblSlogan;
        private System.Windows.Forms.Panel    pnlArama;
        private System.Windows.Forms.Label    lblAramaIkon;
        private System.Windows.Forms.TextBox  txtArama;
        private System.Windows.Forms.Panel    pnlNavButonlar;
        private System.Windows.Forms.Button   btnUrunYonetimi;
        private System.Windows.Forms.Button   btnSepet;
        private System.Windows.Forms.Button   btnGecmis;
        private System.Windows.Forms.Panel    pnlFiltre;
        private System.Windows.Forms.Label    lblFiltreBas;
        private System.Windows.Forms.Panel    pnlSep1;
        private System.Windows.Forms.Label    lblKatBaslik;
        private System.Windows.Forms.CheckBox chkUstGiyim;
        private System.Windows.Forms.CheckBox chkAltGiyim;
        private System.Windows.Forms.CheckBox chkAksesuar;
        private System.Windows.Forms.Panel    pnlSep2;
        private System.Windows.Forms.Label    lblBedenBaslik;
        private System.Windows.Forms.Panel    pnlBedenGrid;
        private System.Windows.Forms.CheckBox chkS;
        private System.Windows.Forms.CheckBox chkM;
        private System.Windows.Forms.CheckBox chkL;
        private System.Windows.Forms.CheckBox chkXL;
        private System.Windows.Forms.Panel    pnlSep3;
        private System.Windows.Forms.Button   btnFiltreTemizle;
        private System.Windows.Forms.Panel    pnlSep4;
        private System.Windows.Forms.Label    lblSiralamaBaslik;
        private System.Windows.Forms.ComboBox cmbSiralama;
        private System.Windows.Forms.Panel    pnlSep5;
        private System.Windows.Forms.Label    lblSonucSayisi;
        private System.Windows.Forms.Panel    pnlBrand;
        private System.Windows.Forms.FlowLayoutPanel flpUrunler;
    }
}
