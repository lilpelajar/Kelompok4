using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TugasKelompokHayyuk.Config;

namespace TugasKelompokHayyuk.Repository
{
    public class TeacherDashboardRepo : database
    {
        public DataTable ReadTodaySchedule(string username)
        {
            DataTable dataTable = new DataTable();
            using (var conn = MyConnection())
            {
                conn.Open();
                string query = @"SELECT classes.class_name, classes.grade_level, subjects.subject_name
                                 FROM teacher_subject
                                 JOIN classes ON classes.id = teacher_subject.class_id
                                 JOIN subjects ON subjects.id = teacher_subject.subject_id
                                 JOIN teachers ON teachers.id = teacher_subject.teacher_id 
                                 JOIN users ON teachers.user_id = users.id
                                 WHERE users.username = @username;";
                using (MySqlCommand cmd = new MySqlCommand(query,conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    using(MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        public int GetTeachingScheduleAgg(string username) 
        {
            int schedule = 0;
            using (var conn = MyConnection())
            {
                conn.Open();
                string query = @"SELECT COUNT(classes.id)
                                 FROM teacher_subject
                                 JOIN classes ON classes.id = teacher_subject.class_id
                                 JOIN teachers ON teachers.id = teacher_subject.teacher_id
                                 JOIN users ON users.id = teachers.user_id
                                 WHERE users.username = @username";
                using(MySqlCommand cmd = new MySqlCommand(query,conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    schedule = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return schedule;
        }

        public int GetNotGradedAgg(string username)
        {
            int notgraded = 0;
            using (var conn = MyConnection())
            {
                conn.Open();
                string query = @"SELECT COUNT(grades.student_id) 
                                 FROM teacher_subject
                                 JOIN teachers ON teachers.id = teacher_subject.teacher_id
                                 JOIN grades ON grades.teacher_subject_id = teacher_subject.id
                                 JOIN users ON users.id = teachers.user_id
                                 WHERE users.username = @username
                                 AND grades.score = 0;";
                using( MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    notgraded = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }        
            return notgraded;
        }
    }
}
