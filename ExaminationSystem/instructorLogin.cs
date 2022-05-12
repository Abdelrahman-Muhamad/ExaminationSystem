using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem
{
    public partial class instructor : Form
    {
        public static string ID = "";
        public static string userName = "";
        //public string ID
        //{
        //    get => textBox1.Text;
        //     set => textBox1.Text = value;
        //}
        //public string userName
        //{
        //    get => textBox2.Text;
        //     set => textBox2.Text = value;
        //}
        public instructor()
        {
            InitializeComponent();
        }
        SqlConnection SqlCN; 
        SqlCommand sqlCmd; 
        private void instructor_Load(object sender, EventArgs e)
        {
            this.Text = "Enter your user name and ID";
            SqlCN = new SqlConnection(); 
            SqlCN.ConnectionString = "Data Source=.;Initial Catalog=Examination; " +
                "Integrated Security = true ; TrustServerCertificate=true"; 
            sqlCmd = new SqlCommand(); 
            sqlCmd.Connection = SqlCN; 
            sqlCmd.CommandText = "Select * from Instructor";
            adapter = new SqlDataAdapter(sqlCmd);
            
        }
        DataTable dt;
        SqlDataAdapter adapter;
        InsMainPage newForm;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            dt = new ();
            adapter.Fill(dt);
            foreach(DataRow item in dt.Rows)
            {
                if (textBox1.Text == item[0].ToString() && textBox2.Text == item[1].ToString() + " " + item[2].ToString())
                {
                    ID = textBox1.Text;
                    userName = textBox2.Text;
                    newForm = new InsMainPage();
                    this.Hide();
                    newForm.ShowDialog();
                    newForm.Text = $"hello{instructor.userName}";
                    //this.Text = $"ID {ID}";

                }
                else
                    
                    this.Show();
                Errorlbl.Text = "Enter correct ID and username";
                    
            }

        }
        instructorCreate insCreate;
        private void btnCreate_Click(object sender, EventArgs e)
        {
            insCreate = new instructorCreate();
            this.Hide();
            insCreate.ShowDialog();
        }
    }
}
