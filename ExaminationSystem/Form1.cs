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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Are you student or instructor?";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            instructor newForm = new instructor();
            this.Hide();
            newForm.ShowDialog(); 
        } 
        private void btnStudent_Click(object sender, EventArgs e)
        {
            StudentLogin newForm2 = new StudentLogin();
            this.Hide();
            newForm2.ShowDialog(); 
        }
    }
}