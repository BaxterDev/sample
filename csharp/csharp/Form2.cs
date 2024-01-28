﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp
{
    public partial class Form2 : Form
    {
        private MyDB myDB = new MyDB();
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DisplayRecords();
        }

        private void btn_stud_add_Click(object sender, EventArgs e)
        {
            string studentName = txtb_sname.Text;
            string fields = "fullname";
            string fieldValues = $"'{studentName}'";

            int studentId = myDB.AddRecord("students", fields, fieldValues);

            if (studentId > 0)
            {
                string courseID = cmb_scourse.Text;
                fields = "stud_id, course_id";
                fieldValues = $"{studentId}, {courseID}";

                int result = myDB.AddRecord("student_course", fields, fieldValues);
                if (result > 0)
                {
                    MessageBox.Show("Student-course relationship added successfully.");
                    DisplayRecords();
                }
                else
                {
                    MessageBox.Show("Failed to add student-course relationship.");
                }
            }
            else
            {
                MessageBox.Show("Failed to add student.");
            }
        }





        private void DisplayRecords()
        {
            string sql = "SELECT sc.sc_id, s.fullname, c.course_name " +
                         "FROM student_course sc " +
                         "INNER JOIN course AS c ON sc.course_id = c.course_id " +
                         "INNER JOIN students AS s ON sc.stud_id = s.stud_id";

            DataTable dataTable = myDB.ViewRecords(sql);

            dataGridView1.DataSource = dataTable;

            dataGridView1.Columns["fullname"].HeaderText = "STUDENT NAME";
            dataGridView1.Columns["course_name"].HeaderText = "COURSE";

            dataGridView1.Columns["sc_id"].Visible = false;
        }



    }
}
