using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication7
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Anaform a = new Anaform();
            if (textEdit1.Text == "Ahmet" && textEdit2.Text == "123")
            {

                a.Show();

            }
            else
            {


                MessageBox.Show("Hata");

            }

        }
    }
}
