using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DXApplication7
{
    public partial class Anaform : DevExpress.XtraEditors.XtraForm
    {
        public Anaform()
        {
            InitializeComponent();
        }

        private void musteriKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriKayit m = new MusteriKayit();
            m.Show();

        }

        private void musteriAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Musteriarama m = new Musteriarama();
            m.Show();
        }

        private void urunSatisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            satis s = new satis();
            s.Show();

        }

        private void odemeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void firmaBilgiGirisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Firma f = new Firma();
            f.Show();

        }

        private void cekBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cekbilgileri cek = new cekbilgileri();
            cek.Show();

        }

        private void cariBilgilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carikartlar cari = new carikartlar();
            cari.Show();

        }

        private void urunAnalizToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ciroKartlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void personelİslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void personelAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void musteriAnaliziToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}