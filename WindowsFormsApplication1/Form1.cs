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
using ClosedXML.Excel;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-44D92EG\SQLEXPRESS;Initial Catalog=data1;Integrated Security=True");

        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;


        public Form1()
        {
            InitializeComponent();
           

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtcharges.Text==""&&txtcontactnumber.Text==""&&txtname.Text=="" && txttypework.Text=="")
            {
                MessageBox.Show("Please Fill All Fields");
            }


            else
            {
                try
                {

                    sqlcon.Open();
                    cmd = new SqlCommand
        ("insert into bag(Customer_Name,Cell,Work_Type,Charges) values('" + txtname.Text + "','" + txtcontactnumber.Text + "','" + txttypework.Text + "','" + Int32.Parse(txtcharges.Text) + "')", sqlcon);
                    cmd.ExecuteNonQuery();

          
                    sqlcon.Close();
                    MessageBox.Show("Record Saved Successfully");
                    
                }
                     
                catch(Exception)
                {
                    MessageBox.Show("Contact 03207677525", "Error In code", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                 
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtcharges.Text = "";
            txtcontactnumber.Text = "";
            txtname.Text = "";
            txttypework.Text = "";
            MessageBox.Show("Cleared !");
        }

        private void DataBaseView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnloaddata_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            cmd = new SqlCommand("select * from bag", sqlcon);
            da = new SqlDataAdapter(cmd.CommandText, sqlcon);
            ds = new DataSet();
            da.Fill(ds, "bag");
            DataBaseView.DataSource = ds.Tables["bag"].DefaultView;
            sqlcon.Close();
        }

        private void btndeluser_Click(object sender, EventArgs e)
        {
            
            pageDel f2 = new pageDel();
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sqlcon.Open();

            cmd = new SqlCommand("select * from bag where Cell='" + txtsearch.Text + "'", sqlcon);

            da = new SqlDataAdapter(cmd.CommandText, sqlcon);
            ds = new DataSet();
            da.Fill(ds, "bag");
            DataBaseView.DataSource = ds.Tables["bag"].DefaultView;

            sqlcon.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel workbook|*.xlsx" })
 {
     if(sfd.ShowDialog()==DialogResult.OK)
     {
         try
         {
             using(XLWorkbook workbook=new XLWorkbook())
             {
                // workbook.Worksheets.Add(this.bagBindingSource2.Bag.CopyToDataTable(),"Bag");

                 workbook.Worksheets.Add(this.myData.bag.CopyToDataTable(), "bag");

                 workbook.SaveAs(sfd.FileName);
             }
             MessageBox.Show("Exported");
         }
         catch(Exception)
         {
             MessageBox.Show("Contact 03207677525", "Error In code", MessageBoxButtons.OK, MessageBoxIcon.Warning);
         }
     }
 }
        
 }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myData.bag' table. You can move, or remove it, as needed.
            this.bagTableAdapter3.Fill(this.myData.bag);
            // TODO: This line of code loads data into the 'dgv.bag' table. You can move, or remove it, as needed.
           

        } 
    }
}
