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
    public partial class Musteriarama : DevExpress.XtraEditors.XtraForm
    {
        public Musteriarama()
        {
            InitializeComponent();
        }

        private void searchControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
           



        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {



            if (searchControl1.Text == "         ")
            {
                SqlConnection baglanti = new SqlConnection("server=.; Initial Catalog=Crm; Integrated Security=SSPI");
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select *From musteri", baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds, "musteri");
                gridControl1.DataSource = ds.Tables["musteri"];

                baglanti.Close();


            }

            else if (radioButton1.Checked == true)
            {


                SqlConnection baglanti = new SqlConnection("server=.; Initial Catalog=Crm;Integrated Security=SSPI");
                baglanti.Open();

                SqlDataAdapter da = new SqlDataAdapter("Select *from musteri where musteriad  like  '" + searchControl1.Text + "%'", baglanti);
                DataSet ds = new DataSet();

                da.Fill(ds, "musteri");

                this.gridControl1.DataSource = ds.Tables[0];



                baglanti.Close();


            }
            else if (radioButton3.Checked == true)
            {
                SqlConnection baglanti = new SqlConnection("server=.;  Initial Catalog=Crm; Integrated Security=SSPI");
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select *from musteri where musterisoyad like '" + searchControl1.Text + "%'", baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds, "musteri");
                this.gridControl1.DataSource = ds.Tables[0];




            }
            else if (radioButton2.Checked == true)
            {


                SqlConnection baglanti = new SqlConnection("server=.;  Initial Catalog=Crm; Integrated Security=SSPI");
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select *from musteri where musteritcno like '" + searchControl1.Text + "%'", baglanti);
                DataSet ds = new DataSet();

                da.Fill(ds, "musteri");
                this.gridControl1.DataSource = ds.Tables[0];

            }
        }
    }
}