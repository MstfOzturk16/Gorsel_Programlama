using Gorsel_Programlama;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace FAVNGİYİM
{
    public partial class UrunKarti : Control
    {
        public Urun BagliUrun { get; set; }
        private bool _hovered;
        private ContextMenuStrip _menu;

        private const int ShadowOfs = 4;
        private const int Radius    = 14;
        private const int TopH      = 148;

        public UrunKarti()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.DoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);
            Size    = new Size(220, 325);
            Margin  = new Padding(10);
            Cursor  = Cursors.Hand;
            BackColor = Color.FromArgb(245, 245, 245);
            ContextMenuOlustur();
        }

        private void ContextMenuOlustur()
        {
            _menu = new ContextMenuStrip();
            _menu.Font = new Font("Segoe UI", 9.5F);
            _menu.RenderMode = ToolStripRenderMode.System;

            var menuDuzenle = new ToolStripMenuItem("✏️   Düzenle");
            menuDuzenle.ForeColor = Color.FromArgb(30, 30, 30);
            menuDuzenle.Click += (s, e) =>
            {
                foreach (Form f in Application.OpenForms)
                    if (f is Form1 ana) { var uyf = new UrunYonetimiForm(ana); uyf.UrunSec(BagliUrun); uyf.ShowDialog(); return; }
            };

            var menuSil = new ToolStripMenuItem("🗑️   Sil");
            menuSil.ForeColor = Color.Crimson;
            menuSil.Click += (s, e) =>
            {
                if (BagliUrun == null) return;
                var onay = MessageBox.Show($"\"{BagliUrun.Ad}\" silinsin mi?", "Ürün Sil",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (onay == DialogResult.Yes)
                {
                    VeriTabani.UrunSil(BagliUrun.Id);
                    foreach (Form f in Application.OpenForms)
                        if (f is Form1 ana) { ana.UrunleriListele(); return; }
                }
            };

            _menu.Items.Add(menuDuzenle);
            _menu.Items.Add(new ToolStripSeparator());
            _menu.Items.Add(menuSil);
        }

        public void BilgileriYukle(Urun urun)
        {
            BagliUrun = urun;
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e) { _hovered = true;  Invalidate(); }
        protected override void OnMouseLeave(EventArgs e) { _hovered = false; Invalidate(); }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (BagliUrun == null) return;

            if (e.Button == MouseButtons.Right)
            {
                _menu?.Show(this, e.Location);
                return;
            }

            if (_hovered && BtnRect().Contains(e.Location)) SepeteEkle();
        }

        private Rectangle BtnRect()
        {
            int ox = ShadowOfs / 2;
            int w  = Width - ShadowOfs;
            int btnY = Height - ShadowOfs - 48;
            return new Rectangle(ox + 10, btnY, w - 20, 38);
        }

        private void SepeteEkle()
        {
            if (VeriTabani.StokDurumu.ContainsKey(BagliUrun.Id) && VeriTabani.StokDurumu[BagliUrun.Id] > 0)
            {
                VeriTabani.SiparisKuyrugu.Enqueue(BagliUrun);
                VeriTabani.IslemKaydet($"{BagliUrun.Ad} sepete eklendi.");
                MessageBox.Show($"{BagliUrun.Ad} sepete eklendi!", "Sepet",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (Form f in Application.OpenForms)
                    if (f is Form1 ana) { ana.SepetBadgeGuncelle(); break; }
            }
            else
            {
                MessageBox.Show($"{BagliUrun.Ad} stokta yok!", "Stok Yok",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (BagliUrun == null) return;

            var g = e.Graphics;
            g.SmoothingMode      = SmoothingMode.AntiAlias;
            g.TextRenderingHint  = TextRenderingHint.ClearTypeGridFit;
            g.InterpolationMode  = InterpolationMode.HighQualityBicubic;

            int ox = ShadowOfs / 2;
            int oy = ShadowOfs / 2;
            int w  = Width  - ShadowOfs;
            int h  = Height - ShadowOfs;

            // ── Gölge ───────────────────────────────────────────────
            for (int i = ShadowOfs; i >= 1; i--)
            {
                using (var sb = new SolidBrush(Color.FromArgb(10 * i, 0, 0, 0)))
                    FillRoundRect(g, sb, new Rectangle(ox + i, oy + i + 1, w, h), Radius);
            }

            // ── Kart gövdesi ─────────────────────────────────────────
            using (var wb = new SolidBrush(Color.White))
                FillRoundRect(g, wb, new Rectangle(ox, oy, w, h), Radius);

            // ── Renkli üst alan ──────────────────────────────────────
            var catColor = CategoryColor();
            var lightColor = Lighten(catColor, 40);
            using (var path = RoundPath(new Rectangle(ox, oy, w, TopH), Radius, topOnly: true))
            using (var grad = new LinearGradientBrush(
                new Point(ox, oy), new Point(ox + w, oy + TopH),
                lightColor, catColor))
                g.FillPath(grad, path);

            // ── Büyük baş harf (transparan arka plan ikonu) ──────────
            string initial = BagliUrun.Ad.Length > 0
                ? BagliUrun.Ad[0].ToString().ToUpper() : "?";

            using (var f = new Font("Segoe UI", 60F, FontStyle.Bold))
            using (var b = new SolidBrush(Color.FromArgb(40, 255, 255, 255)))
            using (var sf = Centered())
                g.DrawString(initial, f, b, new RectangleF(ox, oy, w, TopH), sf);

            // ── Beden etiketi (sağ üst) ──────────────────────────────
            DrawBadge(g, BagliUrun.Beden ?? "",
                new Rectangle(ox + w - 44, oy + 10, 34, 22),
                Color.FromArgb(200, 255, 255, 255),
                Color.FromArgb(60, 20, 20, 20), 6);

            // ── Kategori etiketi (alt sol) ───────────────────────────
            using (var bf = new Font("Segoe UI", 7.5F, FontStyle.Bold))
            {
                var sz  = g.MeasureString(BagliUrun.Kategori, bf);
                var br  = new Rectangle(ox + 10, oy + TopH - 29, (int)sz.Width + 16, 20);
                DrawBadge(g, BagliUrun.Kategori ?? "", br,
                    Color.FromArgb(180, 255, 255, 255),
                    Color.FromArgb(80, 20, 20, 20), 10);
            }

            // ── Hover overlay (resim üzeri koyulaşma) ────────────────
            if (_hovered)
                using (var path = RoundPath(new Rectangle(ox, oy, w, TopH), Radius, topOnly: true))
                using (var ov = new SolidBrush(Color.FromArgb(22, 0, 0, 0)))
                    g.FillPath(ov, path);

            // ── Bilgi alanı ──────────────────────────────────────────
            int iy = oy + TopH + 14;

            // Ürün adı
            using (var nf = new Font("Segoe UI", 10.5F, FontStyle.Bold))
            using (var nb = new SolidBrush(Color.FromArgb(22, 22, 22)))
            using (var sf = new StringFormat { Trimming = StringTrimming.EllipsisCharacter })
                g.DrawString(BagliUrun.Ad, nf, nb, new RectangleF(ox + 12, iy, w - 24, 24), sf);

            // Fiyat
            using (var pf = new Font("Segoe UI", 15F, FontStyle.Bold))
            using (var pb = new SolidBrush(Color.FromArgb(18, 18, 18)))
                g.DrawString(BagliUrun.Fiyat.ToString("C2"), pf, pb,
                    new PointF(ox + 12, iy + 28));

            // Stok durumu
            string stokTxt; Color stokClr;
            if      (BagliUrun.Stok == 0)    { stokTxt = "● Tükendi";              stokClr = Color.Crimson; }
            else if (BagliUrun.Stok <= 5)    { stokTxt = $"● Son {BagliUrun.Stok} ürün!"; stokClr = Color.OrangeRed; }
            else                              { stokTxt = "● Stokta var";            stokClr = Color.FromArgb(46,125,50); }

            using (var sf2 = new Font("Segoe UI", 8F))
            using (var sb2 = new SolidBrush(stokClr))
                g.DrawString(stokTxt, sf2, sb2, new PointF(ox + 12, iy + 68));

            // ── Sepete Ekle butonu (sadece hover'da) ──────────────────
            if (_hovered)
            {
                var btn = BtnRect();
                using (var bp = RoundPath(btn, 8))
                using (var bb = new SolidBrush(Color.FromArgb(22, 22, 22)))
                    g.FillPath(bb, bp);

                using (var btf = new Font("Segoe UI", 9.5F, FontStyle.Bold))
                using (var btb = new SolidBrush(Color.White))
                using (var sf  = Centered())
                    g.DrawString("+ Sepete Ekle", btf, btb, (RectangleF)btn, sf);
            }

            // ── Kart kenarlığı ───────────────────────────────────────
            using (var bp = RoundPath(new Rectangle(ox, oy, w, h), Radius))
            using (var pen = new Pen(Color.FromArgb(_hovered ? 50 : 15, 0, 0, 0), 1f))
                g.DrawPath(pen, bp);
        }

        // ── Yardımcı metotlar ────────────────────────────────────────

        private void DrawBadge(Graphics g, string text, Rectangle r,
            Color bgColor, Color textColor, int radius)
        {
            using (var bf = new Font("Segoe UI", 7.5F, FontStyle.Bold))
            using (var bb = new SolidBrush(bgColor))
            using (var tb = new SolidBrush(textColor))
            using (var sf = Centered())
            {
                FillRoundRect(g, bb, r, radius);
                g.DrawString(text, bf, tb, (RectangleF)r, sf);
            }
        }

        private Color CategoryColor()
        {
            switch (BagliUrun?.Kategori)
            {
                case "Üst Giyim": return Color.FromArgb(61,  90, 254);
                case "Alt Giyim": return Color.FromArgb(0,  150, 136);
                case "Aksesuar":  return Color.FromArgb(142, 36, 170);
                default:           return Color.FromArgb(69,  90, 100);
            }
        }

        private Color Lighten(Color c, int a) => Color.FromArgb(
            Math.Min(255, c.R + a),
            Math.Min(255, c.G + a),
            Math.Min(255, c.B + a));

        private void FillRoundRect(Graphics g, Brush b, Rectangle r, int radius)
        {
            using (var path = RoundPath(r, radius)) g.FillPath(b, path);
        }

        private GraphicsPath RoundPath(Rectangle r, int radius, bool topOnly = false)
        {
            var path = new GraphicsPath();
            int d = radius * 2;
            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            if (topOnly)
                path.AddLine(r.Right, r.Bottom, r.X, r.Bottom);
            else
            {
                path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
                path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            }
            path.CloseFigure();
            return path;
        }

        private StringFormat Centered() => new StringFormat
        {
            Alignment     = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        };
    }
}
