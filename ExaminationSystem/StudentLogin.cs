using Microsoft.Data.SqlClient;  
using System.Data; 

namespace ExaminationSystem
{
    public partial class StudentLogin : Form
    {
        public static string ID = "";
        public static string userName = "";
        public static string crsName = "";
        public static int crsID = 0;
        public static int examID = 0;
        public StudentLogin()
        {
            InitializeComponent();
        }
        SqlConnection SqlCN;
        SqlCommand sqlCmd;
        SqlCommand sqlCmd2;
        SqlCommand sqlCmdCrs;
        DataTable dt;
        DataTable DT;
        SqlDataAdapter adapter;
        SqlDataAdapter adapter2;
        student stForm;
        BindingSource b = new();
        private void StudentLogin_Load(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            label1.Visible = false;
            SqlCN = new SqlConnection();
            SqlCN.ConnectionString = "Data Source=.;Initial Catalog=Examination; " +
                "Integrated Security = true ; TrustServerCertificate=true";
            sqlCmd = new SqlCommand();
            sqlCmd.Connection = SqlCN;
            sqlCmd.CommandText = "Select * from Student";
            adapter = new SqlDataAdapter(sqlCmd);


        } 
        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            dt = new();
            adapter.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                if (textBox1.Text == item[0].ToString() && textBox2.Text == item[1].ToString() + " " + item[2].ToString() && btnLogin.Text=="Show Courses")
                {
                    ID = textBox1.Text;
                    userName = textBox2.Text;
                    
                    label1.Visible = true;
                    comboBox1.Visible = true;
                    btnLogin.Text = "Login"; 
                    sqlCmdCrs = new SqlCommand($"select * from courses where crsID in (select CrsID from student_courses where StudID = {ID})", SqlCN);

                    adapter2 = new SqlDataAdapter(sqlCmdCrs);
                    DT = new();
                    adapter2.Fill(DT);
                    b = new BindingSource(DT, "");
                    comboBox1.DataSource = b;
                    comboBox1.DisplayMember = "CrsName";
                    comboBox1.ValueMember = "CrsID";
                    comboBox1.DataBindings.Add("SelectedValue", b, "CrsID");
                }
                else if(textBox1.Text == item[0].ToString() && textBox2.Text == item[1].ToString() + " " + item[2].ToString() && btnLogin.Text == "Login")
                {
                    /*
                    crsName = 
                    sqlCmd = new SqlCommand();
                    sqlCmd.Connection = SqlCN;
                    sqlCmd.CommandText = $"Select CrsID from courses where crsName ='{crsName}'";
                   */
                    SqlCN.Open();
                    crsID = int.Parse(comboBox1.SelectedValue.ToString());
                    sqlCmd2 = new SqlCommand();
                    sqlCmd2.Connection = SqlCN;
                    sqlCmd2.CommandText = $"Select ExamID from Exam where CrsID ='{crsID}'";
                    examID = int.Parse(sqlCmd2.ExecuteScalar().ToString());
                    
                    stForm = new student();
                    this.Hide();
                    stForm.ShowDialog();
                    
                    SqlCN.Close();
                }  
            }
        }
    }
}
