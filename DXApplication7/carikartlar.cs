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
    public partial class carikartlar : DevExpress.XtraEditors.XtraForm
    {
        public carikartlar()
        {
            InitializeComponent();
            griddoldur();

        }
        public void griddoldur()
        {

            SqlConnection baglanti = new SqlConnection("server=.; Initial Catalog=Crm; Integrated Security=SSPI");

            SqlDataAdapter da = new SqlDataAdapter("select *from Cari ", baglanti);
            baglanti.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "Cari");
            gridControl1.DataSource = ds.Tables["Cari"];
            baglanti.Close();

        }

        public void bilgigetir()
        {
            id.Text = gridView1.GetFocusedRowCellValue("cariid").ToString().Trim();
           tarih.Text = gridView1.GetFocusedRowCellValue("tarih").ToString().Trim();
           firma.Text = gridView1.GetFocusedRowCellValue("firma").ToString().Trim();
           islem.Text = gridView1.GetFocusedRowCellValue("islem").ToString().Trim();
           alinan.Text = gridView1.GetFocusedRowCellValue("alinan").ToString().Trim();
           verilen.Text = gridView1.GetFocusedRowCellValue("verilen").ToString().Trim();
           aciklama.Text = gridView1.GetFocusedRowCellValue("aciklama").ToString().Trim();

          
        
        
        }
        public void temizle()
        {


            tarih.Text = "";
            firma.Text = "";
            islem.Text = "";
            alinan.Text = "";
            verilen.Text = "";
            aciklama.Text = "";


        
        }




        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("server=.; Initial Catalog=Crm; Integrated Security=SSPI");


            baglanti.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglanti;
            cmd.CommandText = "insert into Cari (tarih,firma ,islem ,alinan,verilen,aciklama) values ('" + tarih.Text + "','" + firma.SelectedItem + "','" + islem.Text + "','" + alinan.Text + "','" + verilen.Text + "','" + aciklama.Text + "')";

            cmd.ExecuteNonQuery();
            griddoldur();

        baglanti.Close();
}

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            bilgigetir();

            griddoldur();

        }

        private void carikartlar_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("server=.; Initial Catalog=Crm; Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select *from Firma";
            cmd.Connection = baglanti;

            cmd.CommandType = CommandType.Text;
            SqlDataReader dr;

            baglanti.Open();
            dr = cmd.ExecuteReader();


            while(dr.Read())
            {
                firma.Properties.Items.Add(dr["firmaadi"]);

            
            }

            baglanti.Close();
            temizle();


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("server=.; Initial Catalog=Crm; Integrated Security=SSPI");

            SqlCommand cmd = new SqlCommand("Delete  from Cari where cariid=@id ",connection);

            string kayitid;

            kayitid = gridView1.GetFocusedRowCellValue("cariid").ToString();

            cmd.Parameters.AddWithValue("@id", kayitid);
            connection.Open();
            cmd.ExecuteNonQuery();
            griddoldur();
            temizle();

            connection.Close();

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            bilgigetir();

            SqlConnection connection = new SqlConnection("server=.; Initial Catalog=Crm; Integrated Security=SSPI");
            string sorgu = "Update Cari set tarih=@tarih,firma=@firma,islem=@islem,alinan=@alinan,verilen=@verilen,aciklama=@aciklama where cariid=@id ";

            SqlCommand cmd = new SqlCommand(sorgu, connection);
            cmd.Parameters.AddWithValue("@id", id.Text);
            cmd.Parameters.AddWithValue("@tarih", tarih.Text);

            cmd.Parameters.AddWithValue("@firma", firma.Text);
            cmd.Parameters.AddWithValue("@islem", islem.Text);
            cmd.Parameters.AddWithValue("@alinan", alinan.Text);
            cmd.Parameters.AddWithValue("@verilen", verilen.Text);
            cmd.Parameters.AddWithValue("@aciklama", aciklama.Text);
            connection.Open();
            cmd.ExecuteNonQuery();
            griddoldur();
            temizle();
            connection.Close();
   





        }
    }
}