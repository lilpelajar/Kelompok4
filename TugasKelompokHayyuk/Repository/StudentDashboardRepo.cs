    using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.SymbolStore;
    using System.Text;
    using TugasKelompokHayyuk.Config;
using TugasKelompokHayyuk.Models;

namespace TugasKelompokHayyuk.Repository
{
    public class StudentDashboardRepo : database
    {
        UserModels UserModels { get; set; }
        public DataTable ReadTableClasses(string username)
        {
            DataTable dataTable = new DataTable();
            using (var conn = MyConnection())
            {
                string query = @"SELECT subjects.subject_name, grades.score, users.full_name AS Teacher_Name
                                    FROM grades
                                    JOIN teacher_subject ON grades.teacher_subject_id = teacher_subject.id
                                    JOIN subjects ON teacher_subject.subject_id = subjects.id
                                    JOIN teachers ON teacher_subject.teacher_id = teachers.id
                                    JOIN users ON teachers.user_id = users.id
                                    JOIN students ON grades.student_id = students.id
                                    JOIN users AS student_user ON students.user_id = student_user.id
                                    WHERE student_user.username = @username;";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        public int GetGradesAggregate(string username)
        {
            int Courses = 0;
            using (var conn = MyConnection())
            {
                conn.Open();
                string query = @"SELECT COUNT(subjects.id) 
                                 FROM grades                        
                                 JOIN teacher_subject ON teacher_subject.id = grades.teacher_subject_id                        
                                 JOIN subjects ON subjects.id = teacher_subject.subject_id                        
                                 JOIN students ON students.id = grades.student_id                        
                                 JOIN users ON users.id = students.user_id                        
                                 WHERE users.username = @username;";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    object hasil = cmd.ExecuteScalar();
                    if (hasil != null && hasil != DBNull.Value)
                    {
                        Courses = Convert.ToInt32(hasil);
                    }
                }
            }
            return Courses;
        }
    } 
}
