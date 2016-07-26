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
using System.Data.SqlClient;





namespace DXApplication7
{
    public partial class cekbilgileri : DevExpress.XtraEditors.XtraForm
    {
        public cekbilgileri()
        {
            InitializeComponent();
            griddoldur();
        }

        private void textEdit7_EditValueChanged(object sender, EventArgs e)
        {

        }
        public void temizle()
        {
            verilistarihi.Text = "";
            vadetarihi.Text="";

                banka.Text="";

                ceknumarasi.Text="";

                cekturu.Text = "";
                aciklama.Text = "";
                durumu.Text = "";
          


            
        
        
        }
        public void griddoldur()
        {

            SqlConnection con = new SqlConnection("server=.; Initial Catalog=Crm;Integrated Security=SSPI");
            SqlDataAdapter da = new SqlDataAdapter("Select *from Cek ",con);
             con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "Cek");
            gridControl1.DataSource = ds.Tables["Cek"];

            con.Close();

        }
        public void bilgicek()
        {
            textEdit1.Text = gridView1.GetFocusedRowCellValue("cekid").ToString().Trim();
            verilistarihi.Text = gridView1.GetFocusedRowCellValue("verilistarihi").ToString().Trim();
      vadetarihi.Text=gridView1.GetFocusedRowCellValue("vadetarihi").ToString().Trim();
      banka.Text = gridView1.GetFocusedRowCellValue("banka").ToString().Trim();
      tutar.Text = gridView1.GetFocusedRowCellValue("tutar").ToString().Trim();
            
      aciklama.Text = gridView1.GetFocusedRowCellValue("aciklama").ToString().Trim();
      ceknumarasi.Text = gridView1.GetFocusedRowCellValue("ceknumarasi").ToString().Trim();

      cekturu.Text = gridView1.GetFocusedRowCellValue("cektur").ToString().Trim();
      durumu.Text = gridView1.GetFocusedRowCellValue("durumu").ToString().Trim();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("server=.;Initial Catalog=Crm;Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand();
            baglanti.Open();

            cmd.Connection = baglanti;

            cmd.CommandText = "insert into Cek (verilistarihi,vadetarihi,banka,ceknumarasi,tutar,aciklama,cektur,durumu) values ('" + verilistarihi.SelectedText+ "','" + vadetarihi.SelectedText+ "','" + banka.Text + "','" + ceknumarasi.Text + "','" + tutar.Text + "','" + aciklama.Text + "','" + cekturu.Text + "','" + durumu.Text + "')";


            
            cmd.ExecuteNonQuery();
            griddoldur();
            baglanti.Close();
          
            temizle();





            


        }

        private void cekbilgileri_Load(object sender, EventArgs e)
        {
            griddoldur();

        }

        private void sil_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=.; Initial Catalog=Crm; Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand("Delete from Cek where cekid=@id",con);
            string al;
            al = gridView1.GetFocusedRowCellValue("cekid").ToString();
            cmd.Parameters.AddWithValue("@id", al);
            con.Open();
            cmd.ExecuteNonQuery();
            griddoldur();
            temizle();


            con.Close();



        }

        private void guncelle_Click(object sender, EventArgs e)
        {



            SqlConnection con = new SqlConnection("server=.; Initial Catalog=Crm; Integrated Security=SSPI");
            string sorgu = "Update Cek Set verilistarihi=@tarih,vadetarihi=@vade,banka=@bnk,ceknumarasi=@numara,tutar=@tutar,aciklama=@aciklama,cektur=@cektur,durumu=@durumu where cekid=@id";

            SqlCommand cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@id", textEdit1.Text);
            cmd.Parameters.AddWithValue("@tarih", verilistarihi.Text);
            cmd.Parameters.AddWithValue("@vade", vadetarihi.Text);
            cmd.Parameters.AddWithValue("@bnk", banka.Text);
            cmd.Parameters.AddWithValue("@numara", ceknumarasi.Text);
            cmd.Parameters.AddWithValue("@tutar", tutar.Text);
            cmd.Parameters.AddWithValue("@aciklama", aciklama.Text);
            cmd.Parameters.AddWithValue("@cektur", cekturu.Text);
            cmd.Parameters.AddWithValue("@durumu", durumu.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            griddoldur();
        
            temizle();
            con.Close();

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            bilgicek();
        }
    }
}