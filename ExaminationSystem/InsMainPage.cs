using Microsoft.Data.SqlClient;
using System.Data;

namespace ExaminationSystem
{ 
    public partial class InsMainPage : Form
    {
        public static string crsName = "";
        public InsMainPage()
        {
            InitializeComponent();
        }
        SqlConnection SqlCN;
        SqlCommand sqlCmdGenerate;
        SqlCommand sqlCmdCrs;
        private void InsMainPage_Load(object sender, EventArgs e)
        {
            SqlCN = new SqlConnection();

            SqlCN.ConnectionString = "Data Source=.;Initial Catalog=Examination; " +
                "Integrated Security = true ; TrustServerCertificate=true";

            sqlCmdGenerate = new SqlCommand("generateExam", SqlCN);
            sqlCmdGenerate.CommandType = CommandType.StoredProcedure;

            mcqCount = new SqlParameter();
            mcqCount.ParameterName = "@countTf";
            mcqCount.SqlDbType = SqlDbType.Int;
            mcqCount.Direction = ParameterDirection.Input; 

            TFCount = new SqlParameter();
            TFCount.ParameterName = "@countMCQ";
            TFCount.SqlDbType = SqlDbType.Int;
            TFCount.Direction = ParameterDirection.Input; 

            instructorId = new SqlParameter();
            instructorId.ParameterName = "@instructorId";
            instructorId.SqlDbType = SqlDbType.Int;
            instructorId.Direction = ParameterDirection.Input; 

            duration = new SqlParameter();
            duration.ParameterName = "@duration";
            duration.SqlDbType = SqlDbType.Decimal;
            duration.Direction = ParameterDirection.Input;
            
            CrsID = new SqlParameter();
            CrsID.ParameterName = "@CrsID";
            CrsID.SqlDbType = SqlDbType.Int;
            CrsID.Direction = ParameterDirection.Input;  
            adapter = new SqlDataAdapter(sqlCmdGenerate); 
            sqlCmdCrs = new SqlCommand($"select * from courses where crsID in (select CrsID from Instructor_Course where InsID = {instructor.ID})", SqlCN);

            adapter2 = new SqlDataAdapter(sqlCmdCrs);
            DT = new();
            adapter2.Fill(DT);
            b = new BindingSource(DT, "");
            comboBox1.DataSource = b;
            comboBox1.DisplayMember = "CrsName";
            comboBox1.ValueMember = "CrsID";
            comboBox1.DataBindings.Add("SelectedValue", b, "CrsID");
        }
        BindingSource b ;
        DataTable DT;
        SqlParameter mcqCount;
        SqlParameter TFCount;
        SqlParameter instructorId;
        SqlParameter duration; 
        SqlParameter CrsID; 
        SqlDataAdapter adapter;
        SqlDataAdapter adapter2; 
        private void btnGenerate_Click(object sender, EventArgs e)
        { 
            if (int.Parse(MCQnum.Text) + int.Parse(TFnum.Text) == 10)
            {
                SqlCN.Open();
                mcqCount.Value = Convert.ToInt32(MCQnum.Text);
                sqlCmdGenerate.Parameters.Add(mcqCount);

                TFCount.Value = Convert.ToInt32(TFnum.Text);
                sqlCmdGenerate.Parameters.Add(TFCount);

                CrsID.Value = Convert.ToInt32(comboBox1.SelectedValue);
                sqlCmdGenerate.Parameters.Add(CrsID); 

                instructorId.Value = Convert.ToInt32(instructor.ID);
                sqlCmdGenerate.Parameters.Add(instructorId);

                duration.Value = Convert.ToDecimal(lblDuration.Text);
                sqlCmdGenerate.Parameters.Add(duration);
                SqlDataReader reader = sqlCmdGenerate.ExecuteReader();
                Examheaderlbl.Text = "Exam has been generated";
                SqlCN.Close();
            }
            else
                Examheaderlbl.Text = "Total number of questions MUST be 10";
             
        }
    }
}
