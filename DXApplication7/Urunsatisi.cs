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
    public partial class   Urunsatisi : DevExpress.XtraEditors.XtraForm 
    {
        
        public Urunsatisi()
        {
            InitializeComponent();
           griddoldur();
        }

        MusteriKayit mu = new MusteriKayit();
        public void bilgigetir()
        {
     

        }
        public void griddoldur()
        {
            SqlConnection baglanti = new SqlConnection("server=.; Initial Catalog=Crm; Integrated Security=SSPI");
            SqlDataAdapter da=new SqlDataAdapter("Select *from Satis ",baglanti);
            


            baglanti.Open();
            DataSet ds=new DataSet();

           da.Fill(ds,"Satis");

            gridurunsatisi.DataSource=ds.Tables["Satis"];
            baglanti.Close();
        }

        public void temizle()
        {

            urunadi.SelectedItem = "";
            satilmabecerisi.SelectedItem = "";

            satifiyati.Text = "";
            karyuzdesi.Text = "";



        }


        private void comboBoxEdit2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textEdit7_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Urunsatisi_Load(object sender, EventArgs e)
        {
            griddoldur();

            textad.Text = MusteriKayit.gonderilecekveriad;
            texttc.Text = MusteriKayit.gonderilecekveritc;
            textsoyad.Text = MusteriKayit.gonderilecekverisoyad;
           Adres.Text = MusteriKayit.gonderilecekveriadres;
           texttelno.Text = MusteriKayit.gonderilecekveritel;
           SqlConnection baglanti = new SqlConnection("server=.; Initial Catalog=Crm; Integrated Security=SSPI");

     
     SqlCommand cmd = new SqlCommand();
     cmd.CommandText = "Select *from urun";

     cmd.Connection = baglanti;
     cmd.CommandType = CommandType.Text;
     SqlDataReader dr;
     baglanti.Open();
     dr = cmd.ExecuteReader();


            while(dr.Read())
            {

                urunadi.Properties.Items.Add(dr["urunadi"]);

            
            
            }
         
            baglanti.Close();






        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=.; Initial Catalog=Crm; Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;

            cmd.CommandText="insert into Satis (satilanurunadi,satilmabecerisi,satisfiyati,karyuzdesi) values ('"+urunadi.SelectedItem+"','"+satilmabecerisi.SelectedItem+"','"+satifiyati.Text+"','"+karyuzdesi.Text+"')";
        

            
            cmd.ExecuteNonQuery();
            griddoldur();
            temizle();
            con.Close();
           

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}