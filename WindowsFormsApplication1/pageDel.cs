using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class pageDel : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-44D92EG\SQLEXPRESS;Initial Catalog=data1;Integrated Security=True");

        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        public pageDel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndel_Click(object sender, EventArgs e)
        {

            if(txtdel.Text!="")
            {
                sqlcon.Open();

                cmd = new SqlCommand
                    ("delete from bag where Cell='" + txtdel.Text + "'", sqlcon);
                cmd.ExecuteNonQuery();

                sqlcon.Close();
                MessageBox.Show("Delete Account ");

             

                Hide();

            }
            else
            {
                MessageBox.Show("Field Empty ");
            }
            
        }
    }
}
