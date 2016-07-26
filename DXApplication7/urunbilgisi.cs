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
    public partial class urunbilgisi : DevExpress.XtraEditors.XtraForm
    {
        public urunbilgisi()
        {
            InitializeComponent();
            griddoldur();

        }
        public void griddoldur()
        {

            SqlConnection con = new SqlConnection("server=.; Initial Catalog=Crm; Integrated Security=SSPI");


            SqlDataAdapter da = new SqlDataAdapter("Select u.urunadi,m.Markaadi,m.Modeladi,u.satisfiyati,u.alisfiyati,u.miktar,m.Satismiktari from urun u inner join Markalar m on u.urunid =m.Markaid", con);
            con.Open();

            DataSet ds = new DataSet();
            da.Fill(ds, "urun");
            gridurunbilgisi.DataSource = ds.Tables["urun"];

            con.Close();

        
        
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=.; Initial Catalog=Crm; Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd.CommandText = "insert into urun (urunadi,satisfiyati,alisfiyati,miktar) values(@urunadi,@satisfiyati,@alisfiyati,@miktar) ;insert into Markalar (Markaadi,Modeladi,Satismiktari) values(@markaadi,@modeladi,@satismiktari)";

            cmd.Parameters.AddWithValue("@urunadi", urungeneladi.Text);
            cmd.Parameters.AddWithValue("@markaadi", markaadi.Text);
            cmd.Parameters.AddWithValue("@modeladi", modeladi.Text);

            cmd.Parameters.AddWithValue("@satisfiyati", satisfiyati.Text);
            cmd.Parameters.AddWithValue("@alisfiyati", alisfiyati.Text);
          

            cmd.Parameters.AddWithValue("@miktar", miktar.Text);
            cmd.Parameters.AddWithValue("@satismiktari", satismiktari.Text);
 


            cmd.ExecuteNonQuery();
            griddoldur();

            
            con.Close();



        }

        private void urunbilgisi_Load(object sender, EventArgs e)
        {
            griddoldur();

        }

        private void textEdit2_EditValueChanged_1(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("server=.; Initial Catalog=Crm; Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand("Delete u from urun as u inner join Markalar as m on u.urunid=m.Markaid where u.urunid=@id ");
            string ifade;


            ifade = gridView1.GetFocusedRowCellValue("u.urunid").ToString();

            cmd.Parameters.AddWithValue("@id", ifade);
            con.Open();

            cmd.ExecuteNonQuery();
            griddoldur();
            con.Close();




        }
    }
}