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
    public partial class Firma : DevExpress.XtraEditors.XtraForm
    {   
        public Firma()
        {
            InitializeComponent();
        }
        public void temizle()
        {

            firmaadi.Text = "";
            adres.Text = "";
            yetkili.Text = "";
            tel.Text = "";


        }
        public void bilgigetir()
        {
            gridControlfirma.Text = gridView1.GetFocusedRowCellValue("firmaid").ToString().Trim();
            firmaadi.Text = gridView1.GetFocusedRowCellValue("firmaadi").ToString().Trim();
            yetkili.Text = gridView1.GetFocusedRowCellValue("yetkili").ToString().Trim();
            tel.Text = gridView1.GetFocusedRowCellValue("tel").ToString().Trim();
            adres.Text = gridView1.GetFocusedRowCellValue("adresi").ToString().Trim();


        }

        public void griddoldur()
        {
            SqlConnection baglanti = new SqlConnection("server=.; Initial Catalog=Crm; Integrated Security=SSPI");
            SqlDataAdapter da = new SqlDataAdapter("Select * from Firma",baglanti);
            baglanti.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "Firma");
            gridControlfirma.DataSource = ds.Tables["Firma"];



        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {

            SqlConnection baglanti = new SqlConnection("server=.; Initial Catalog=Crm; Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand();

            baglanti.Open();
            cmd.Connection = baglanti;


            cmd.CommandText = "insert into Firma (firmaadi,adresi,yetkili,tel ) values ('" + firmaadi.Text + "','" + adres.Text + "','" + yetkili.Text + "','" + tel.Text + "')";

            cmd.ExecuteNonQuery();
            griddoldur();

            temizle();

            baglanti.Close();



          
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void Firma_Load(object sender, EventArgs e)
        {
            griddoldur();

        }

        private void firmasil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("server=.; Initial Catalog=Crm; Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand("Delete from Firma where firmaid=@id", baglanti);
            string kayit = gridView1.GetFocusedRowCellValue("firmaid").ToString();
            cmd.Parameters.AddWithValue("@id",kayit);
            baglanti.Open();



            cmd.ExecuteNonQuery();

            griddoldur();
            temizle();


            baglanti.Close();

            






        }

        private void firmaguncelle_Click(object sender, EventArgs e)
        {



            SqlConnection con = new SqlConnection("server=.; Initial Catalog=Crm; Integrated Security=SSPI");
            String sorgucumlesi = "Update Firma set firmaadi=@ad ,adresi=@adres,yetkili=@yetki where firmaid=@id";
         

            SqlCommand cmd = new SqlCommand(sorgucumlesi, con);
            
            cmd.Parameters.AddWithValue("@id",gridControlfirma.Text);
            cmd.Parameters.AddWithValue("@ad", firmaadi.Text);
            cmd.Parameters.AddWithValue("@adres", adres.Text);

            cmd.Parameters.AddWithValue("@yetki", yetkili.Text);

            con.Open();
            cmd.ExecuteNonQuery();




            griddoldur();
            temizle();
            con.Close();


    

        }

        private void id_Click(object sender, EventArgs e)
        {
            bilgigetir();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

            if (searchControl1.Text == "         ")
            {
                SqlConnection baglanti = new SqlConnection("server=.; Initial Catalog=Crm; Integrated Security=SSPI");
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select *From Firma", baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds, "Firma");
                gridControlfirma.DataSource = ds.Tables["Firma"];

                baglanti.Close();


            }

            else if (radioButton1.Checked == true)
            {


                SqlConnection baglanti = new SqlConnection("server=.; Initial Catalog=Crm;Integrated Security=SSPI");
                baglanti.Open();

                SqlDataAdapter da = new SqlDataAdapter("Select *from Firma where firmaadi  like  '" + searchControl1.Text + "%'", baglanti);
                DataSet ds = new DataSet();

                da.Fill(ds, "Firma");

               this.gridControlfirma .DataSource = ds.Tables[0];



                baglanti.Close();


            }
        
            else if (radioButton2.Checked == true)
            {


                SqlConnection baglanti = new SqlConnection("server=.;  Initial Catalog=Crm; Integrated Security=SSPI");
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select *from Firma where yetkili like '" + searchControl1.Text + "%'", baglanti);
                DataSet ds = new DataSet();

                da.Fill(ds, "Firma");
               this.gridControlfirma.DataSource = ds.Tables[0];

            }





        }
    }
}