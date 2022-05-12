using Microsoft.Data.SqlClient; 
using System.Data; 

namespace ExaminationSystem
{
    public partial class student : Form
    {
        //public static string Answer = "";
        public student()
        {
            InitializeComponent();
        }
        SqlConnection SqlCN;
        SqlCommand sqlCmd;
        SqlCommand sqlCmd2; 

        DataTable dt;
        SqlDataAdapter adapter;
        
        int counter = 0;
        string[] Qtype = new string[10];

        private void student_Load(object sender, EventArgs e)
        {
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            this.Text = $"hello {StudentLogin.userName}";
            SqlCN = new SqlConnection();
            SqlCN.ConnectionString = "Data Source=.;Initial Catalog=Examination; " +
                "Integrated Security = true ; TrustServerCertificate=true";

            sqlCmd = new SqlCommand();
            sqlCmd.Connection = SqlCN;
            sqlCmd.CommandText = "showExam";
            sqlCmd.CommandType = CommandType.StoredProcedure;

            CRS = new SqlParameter();
            CRS.ParameterName = "@CrsID";
            CRS.Direction = ParameterDirection.Input;
            CRS.SqlDbType = SqlDbType.Int;
            CRS.Value = int.Parse(StudentLogin.crsID.ToString());
            sqlCmd.Parameters.Add(CRS);

            adapter = new SqlDataAdapter(sqlCmd);
            dt = new DataTable();
            adapter.Fill(dt);
            newBindingSource = new BindingSource(dt, "");
            lblQuest.DataBindings.Add("Text", newBindingSource, "QustBody");
            Qtype = dt.AsEnumerable().Select(r => r.Field<string>("QuestType")).ToArray();
            QuestID = dt.AsEnumerable().Select(r => r.Field<int>("q")).ToArray();
            if (Qtype[counter ] == "true")
            {
                radioButton2.Visible = false;
                radioButton3.Visible = false;

                lblType.Text = "True OR False";
                radioButton1.Visible = true;
                radioButton4.Visible = true;
                radioButton1.Text = "True";
                radioButton4.Text = "False";
            }

            else
            {
                radioButton1.Visible = true;
                radioButton4.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton1.Text = "A";
                radioButton4.Text = "B";
                radioButton3.Text = "C";
                radioButton2.Text = "D"; 
                lblType.Text = "Choose the correct answer";
                lblID.DataBindings.Add("Text", newBindingSource, "q");
            }  
        }
        BindingSource newBindingSource;
        SqlParameter st_ID;
        SqlParameter ExamId;
        SqlParameter questionId1;
        SqlParameter questionId2;
        SqlParameter questionId3;
        SqlParameter questionId4;
        SqlParameter questionId5;
        SqlParameter questionId6;
        SqlParameter questionId7;
        SqlParameter questionId8;
        SqlParameter questionId9;
        SqlParameter questionId10;
        SqlParameter CRS;
        string[] answers = new string[10];
        int[] QuestID = new int[10];
        SqlParameter ans1;
        SqlParameter ans2;
        SqlParameter ans3;
        SqlParameter ans4;
        SqlParameter ans5;
        SqlParameter ans6;
        SqlParameter ans7;
        SqlParameter ans8;
        SqlParameter ans9;
        SqlParameter ans10;
        SqlCommand sqlCmdGrade;
        SqlCommand sqlCmdGrade2;
        SqlParameter studentID;
        SqlParameter examID;
        int stu_id = int.Parse(StudentLogin.ID);
        private void btnNext_Click(object sender, EventArgs e)
        {
            
            
            if (counter < 10)
            {
                if (radioButton1.Checked == true)
                {
                    answers[counter] = radioButton1.Text;
                }

                else if (radioButton2.Checked == true)
                {
                    answers[counter] = radioButton2.Text;
                }

                else if (radioButton3.Checked == true)
                {
                    answers[counter] = radioButton3.Text;
                }

                else
                {
                    answers[counter] = radioButton4.Text; 
                } 

            }
            SqlCN.Open(); 
            sqlCmd2 =new SqlCommand("ExamAnswers", SqlCN);
            sqlCmd2.CommandType = CommandType.StoredProcedure; 
            st_ID = new SqlParameter();
            st_ID.ParameterName = "@st_ID";
            st_ID.Direction = ParameterDirection.Input;
            st_ID.SqlDbType = SqlDbType.Int;
            st_ID.Value = stu_id ;
            sqlCmd2.Parameters.Add(st_ID);

            ExamId = new SqlParameter();
            ExamId.ParameterName = "@ExamId";
            ExamId.Direction = ParameterDirection.Input;
            ExamId.SqlDbType = SqlDbType.Int;
            ExamId.Value = int.Parse(StudentLogin.examID.ToString());
            sqlCmd2.Parameters.Add(ExamId);  
            
            dt.AsEnumerable().Select(r => r.Field<string>("QuestType")).ToArray();
            newBindingSource.MoveNext();
            counter++;
            if (counter < 9)
            {
                if (Qtype[counter ] == "true")
                {

                    radioButton2.Visible = false;
                    radioButton3.Visible = false;
                    lblType.Text = "True OR False";
                    radioButton1.Visible = true;
                    radioButton4.Visible = true;
                    radioButton1.Text = "True";
                    radioButton4.Text = "False";
                }
                else
                {
                    radioButton1.Visible = true;
                    radioButton4.Visible = true;
                    radioButton2.Visible = true;
                    radioButton3.Visible = true;
                    radioButton1.Text = "A";
                    radioButton4.Text = "B";
                    radioButton3.Text = "C";
                    radioButton2.Text = "D";

                    lblType.Text = "Choose the correct answer";
                    lblID.Text = (counter + 1).ToString();
                }
            }
            if (counter == 10)
            {
                questionId1 = new SqlParameter();
                questionId1.ParameterName = "@questionId1";
                questionId1.Direction = ParameterDirection.Input;
                questionId1.SqlDbType = SqlDbType.Int;
                questionId1.Value = QuestID[0];
                sqlCmd2.Parameters.Add(questionId1);

                ans1 = new SqlParameter();
                ans1.ParameterName = "@ans1";
                ans1.Direction = ParameterDirection.Input;
                ans1.SqlDbType = SqlDbType.NVarChar;
                ans1.Value = answers[0];
                sqlCmd2.Parameters.Add(ans1);

                questionId2 = new SqlParameter();
                questionId2.ParameterName = "@questionId2";
                questionId2.Direction = ParameterDirection.Input;
                questionId2.SqlDbType = SqlDbType.Int;
                questionId2.Value = QuestID[1];
                sqlCmd2.Parameters.Add(questionId2);

                ans2 = new SqlParameter();
                ans2.ParameterName = "@ans2";
                ans2.Direction = ParameterDirection.Input;
                ans2.SqlDbType = SqlDbType.NVarChar;
                ans2.Value = answers[1];
                sqlCmd2.Parameters.Add(ans2);


                questionId3 = new SqlParameter();
                questionId3.ParameterName = "@questionId3";
                questionId3.Direction = ParameterDirection.Input;
                questionId3.SqlDbType = SqlDbType.Int;
                questionId3.Value = QuestID[2];
                sqlCmd2.Parameters.Add(questionId3);

                ans3 = new SqlParameter();
                ans3.ParameterName = "@ans3";
                ans3.Direction = ParameterDirection.Input;
                ans3.SqlDbType = SqlDbType.NVarChar;
                ans3.Value = answers[2];
                sqlCmd2.Parameters.Add(ans3);

                questionId4 = new SqlParameter();
                questionId4.ParameterName = "@questionId4";
                questionId4.Direction = ParameterDirection.Input;
                questionId4.SqlDbType = SqlDbType.Int;
                questionId4.Value = QuestID[3];
                sqlCmd2.Parameters.Add(questionId4);

                ans4 = new SqlParameter();
                ans4.ParameterName = "@ans4";
                ans4.Direction = ParameterDirection.Input;
                ans4.SqlDbType = SqlDbType.NVarChar;
                ans4.Value = answers[3];
                sqlCmd2.Parameters.Add(ans4);

                questionId5 = new SqlParameter();
                questionId5.ParameterName = "@questionId5";
                questionId5.Direction = ParameterDirection.Input;
                questionId5.SqlDbType = SqlDbType.Int;
                questionId5.Value = QuestID[4];
                sqlCmd2.Parameters.Add(questionId5);

                ans5 = new SqlParameter();
                ans5.ParameterName = "@ans5";
                ans5.Direction = ParameterDirection.Input;
                ans5.SqlDbType = SqlDbType.NVarChar;
                ans5.Value = answers[4];
                sqlCmd2.Parameters.Add(ans5);


                questionId6 = new SqlParameter();
                questionId6.ParameterName = "@questionId6";
                questionId6.Direction = ParameterDirection.Input;
                questionId6.SqlDbType = SqlDbType.Int;
                questionId6.Value = QuestID[5];
                sqlCmd2.Parameters.Add(questionId6);

                ans6 = new SqlParameter();
                ans6.ParameterName = "@ans6";
                ans6.Direction = ParameterDirection.Input;
                ans6.SqlDbType = SqlDbType.NVarChar;
                ans6.Value = answers[5];
                sqlCmd2.Parameters.Add(ans6);


                questionId7 = new SqlParameter();
                questionId7.ParameterName = "@questionId7";
                questionId7.Direction = ParameterDirection.Input;
                questionId7.SqlDbType = SqlDbType.Int;
                questionId7.Value = QuestID[6];
                sqlCmd2.Parameters.Add(questionId7);

                ans7 = new SqlParameter();
                ans7.ParameterName = "@ans7";
                ans7.Direction = ParameterDirection.Input;
                ans7.SqlDbType = SqlDbType.NVarChar;
                ans7.Value = answers[6];
                sqlCmd2.Parameters.Add(ans7);

                questionId8 = new SqlParameter();
                questionId8.ParameterName = "@questionId8";
                questionId8.Direction = ParameterDirection.Input;
                questionId8.SqlDbType = SqlDbType.Int;
                questionId8.Value = QuestID[7];
                sqlCmd2.Parameters.Add(questionId8);

                ans8 = new SqlParameter();
                ans8.ParameterName = "@ans8";
                ans8.Direction = ParameterDirection.Input;
                ans8.SqlDbType = SqlDbType.NVarChar;
                ans8.Value = answers[7];
                sqlCmd2.Parameters.Add(ans8);


                questionId9 = new SqlParameter();
                questionId9.ParameterName = "@questionId9";
                questionId9.Direction = ParameterDirection.Input;
                questionId9.SqlDbType = SqlDbType.Int;
                questionId9.Value = QuestID[8];
                sqlCmd2.Parameters.Add(questionId9);

                ans9 = new SqlParameter();
                ans9.ParameterName = "@ans9";
                ans9.Direction = ParameterDirection.Input;
                ans9.SqlDbType = SqlDbType.NVarChar;
                ans9.Value = answers[8];
                sqlCmd2.Parameters.Add(ans9);

                questionId10 = new SqlParameter();
                questionId10.ParameterName = "@questionId10";
                questionId10.Direction = ParameterDirection.Input;
                questionId10.SqlDbType = SqlDbType.Int;
                questionId10.Value = QuestID[9];
                sqlCmd2.Parameters.Add(questionId10);

                ans10 = new SqlParameter();
                ans10.ParameterName = "@ans10";
                ans10.Direction = ParameterDirection.Input;
                ans10.SqlDbType = SqlDbType.NVarChar;
                ans10.Value = answers[9];
                sqlCmd2.Parameters.Add(ans10);  
                SqlDataReader reader = sqlCmd2.ExecuteReader();
                btnNext.Text = "Finish";
            } 
                
            if(btnNext.Text == "Finish")
            {
              
                sqlCmdGrade = new SqlCommand("CorrectExam", SqlCN);
                sqlCmdGrade.CommandType = CommandType.StoredProcedure;
                studentID = new SqlParameter();
                studentID.ParameterName = "@studID";
                studentID.Direction = ParameterDirection.Input;
                studentID.SqlDbType = SqlDbType.Int;
                studentID.Value = int.Parse(StudentLogin.ID);
                sqlCmdGrade.Parameters.Add(studentID);

                examID = new SqlParameter();
                examID.ParameterName = "@examID";
                examID.Direction = ParameterDirection.Input;
                examID.SqlDbType = SqlDbType.Int;
                examID.Value = StudentLogin.examID;
                sqlCmdGrade.Parameters.Add(examID);

            }
               
            SqlCN.Close();
        }
        StudentGrade newGradeForm;
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
