using System;
using System.Windows.Forms;
using Gorsel_Programlama;

namespace FAVNGİYİM
{
    public partial class IslemGecmisiForm : Form
    {
        public IslemGecmisiForm()
        {
            InitializeComponent();
        }

        private void IslemGecmisiForm_Load(object sender, EventArgs e)
        {
            GecmisiYukle();
        }

        private void GecmisiYukle()
        {
            lstGecmis.Items.Clear();
            foreach (string islem in VeriTabani.IslemGecmisi)
                lstGecmis.Items.Add(islem);

            lblSayac.Text = $"Toplam kayıt: {VeriTabani.IslemGecmisi.Count}";
        }

        private void btnGeriAl_Click(object sender, EventArgs e)
        {
            if (VeriTabani.IslemGecmisi.Count == 0)
            {
                MessageBox.Show("Geri alınacak işlem yok!", "Bilgi");
                return;
            }

            string silinen = VeriTabani.IslemGecmisi.Pop();
            GecmisiYukle();
            MessageBox.Show($"Geri alındı:\n{silinen}", "Geri Al (Undo)");
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            var onay = MessageBox.Show("Tüm geçmiş silinsin mi?", "Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                VeriTabani.IslemGecmisi.Clear();
                GecmisiYukle();
            }
        }
    }
}
