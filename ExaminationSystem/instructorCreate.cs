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
    public partial class instructorCreate : Form
    {
        public instructorCreate()
        {
            InitializeComponent();
        }
        SqlConnection SqlCN;
        SqlCommand sqlCmdCreateAcc;
        SqlCommand sqlCmdCheck;
        SqlParameter fristName;
        SqlParameter lastname;
        SqlParameter deptID;
        SqlParameter salary; 
        SqlDataAdapter adapter; 
        DataTable dt;
        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            SqlCN = new SqlConnection();

            SqlCN.ConnectionString = "Data Source=.;Initial Catalog=Examination; " +
                "Integrated Security = true ; TrustServerCertificate=true";
            SqlCN.Open();
            sqlCmdCreateAcc = new SqlCommand("InsertIns", SqlCN);
            sqlCmdCreateAcc.CommandType = CommandType.StoredProcedure; 

            fristName = new SqlParameter();
            fristName.ParameterName = "@fname";
            fristName.Direction = ParameterDirection.Input;
            fristName.Value = fname.Text;
            
            fristName.SqlDbType = SqlDbType.VarChar;

            lastname = new SqlParameter();
            lastname.ParameterName = "@lname";
            lastname.Direction = ParameterDirection.Input;
            lastname.SqlDbType = SqlDbType.VarChar;
            lastname.Value = lname.Text;
            
            deptID = new SqlParameter();
            deptID.ParameterName = "@deptid";
            deptID.Direction = ParameterDirection.Input;
            deptID.SqlDbType = SqlDbType.Int;  
            deptID.Value =int.Parse( deptid.Text);  

            salary = new SqlParameter();
            salary.ParameterName = "@sal";
            salary.Direction = ParameterDirection.Input;
            salary.SqlDbType = SqlDbType.Decimal;
            salary.Value =Convert.ToDecimal( sal.Text);

            sqlCmdCheck = new SqlCommand("select DeptID from department",SqlCN);
          
            sqlCmdCheck.CommandType = CommandType.Text;
            dt = new();
            adapter = new SqlDataAdapter(sqlCmdCheck);
            adapter.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                if (deptid.Text == item[0].ToString())
                {
                    sqlCmdCreateAcc.Parameters.Add(lastname);
                    sqlCmdCreateAcc.Parameters.Add(fristName);
                    sqlCmdCreateAcc.Parameters.Add(deptID);
                    sqlCmdCreateAcc.Parameters.Add(salary);
                    SqlDataReader reader = sqlCmdCreateAcc.ExecuteReader();
                    headerlbl.Text = "Account has been created";
                }
                
                else 
                    headerlbl.Text = "Enter correct department ID";

            }  
            SqlCN.Close(); 
            
        }

        private void instructorCreate_Load(object sender, EventArgs e)
        {

        }
    }
}
