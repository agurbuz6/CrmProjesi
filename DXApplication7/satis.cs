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
    public partial class satis : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        public satis()
        {
            InitializeComponent();
        }
        public void clear()
        {
            textEdit1.Text = "";
            textEdit2.Text = "";
            textEdit3.Text = "";
            textEdit4.Text = "";
  

        }


        void griddoldur()
        {
            SqlConnection con = new SqlConnection("server=.; Initial Catalog=Crm; Integrated Security=SSPI");
            da = new SqlDataAdapter("Select *from Markalar ", con);
            con.Open();
            ds = new DataSet();
            da.Fill(ds, "Markalar");
            gridControl1.DataSource = ds.Tables["Markalar"];
            con.Close();



        }
        public void bilgigetir()
        {
            textEdit1.Text = gridView1.GetFocusedRowCellValue("Markaid").ToString().Trim();
            textEdit2.Text = gridView1.GetFocusedRowCellValue("Markaadi").ToString().Trim();
            textEdit3.Text = gridView1.GetFocusedRowCellValue("Modeladi").ToString().Trim();
            textEdit4.Text = gridView1.GetFocusedRowCellValue("Satismiktari").ToString().Trim();
          


        }


        private void satis_Load(object sender, EventArgs e)
        {
            griddoldur();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            con = new SqlConnection("server=.; Initial Catalog=Crm;Integrated Security=SSPI");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;


            cmd.CommandText = "INSERT INTO Markalar (Markaadi,Modeladi,Satismiktari) values ('" + textEdit2.Text + "','"+ textEdit3.Text+ "','"+textEdit4.Text  +  "')";

            cmd.ExecuteNonQuery();
            griddoldur();
            clear();
            con.Close();
            




        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {


            con = new SqlConnection("server=.; Initial Catalog=Crm;Integrated Security=SSPI");
            cmd = new SqlCommand("Delete from Markalar where Markaid=@id", con);
          string   kayitid = gridView1.GetFocusedRowCellValue("Markaid").ToString();
            cmd.Parameters.AddWithValue("@id", kayitid);

            con.Open();
            cmd.ExecuteNonQuery();
            griddoldur();
            clear();
            con.Close();



        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection("server=.; Initial Catalog=Crm; Integrated Security=SSPI");
            string sorgu = "Update Markalar Set   Markaadi=@ad,Modeladi=@mad,Satismiktari=@smiktar,Alismiktari=@amiktar Where markaid=@id";
            cmd = new SqlCommand(sorgu, con);

            cmd.Parameters.AddWithValue("@id", textEdit1.Text);
            cmd.Parameters.AddWithValue("@ad", textEdit2.Text);
            cmd.Parameters.AddWithValue("@mad", textEdit3.Text);
            cmd.Parameters.AddWithValue("@smiktar", textEdit4.Text);
   

            con.Open();
            cmd.ExecuteNonQuery();
            griddoldur();
            clear();
            con.Close();
            



        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            bilgigetir();
        }
    }
}