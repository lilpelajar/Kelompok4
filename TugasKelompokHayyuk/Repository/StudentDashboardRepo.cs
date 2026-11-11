    using MySql.Data.MySqlClient;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.SymbolStore;
    using System.Text;
    using TugasKelompokHayyuk.Config;

    namespace TugasKelompokHayyuk.Repository
    {
        public class StudentDashboardRepo : database
        {
            public DataTable ReadTableClasses()
            {
                DataTable dataTable = new DataTable();
                using (var conn = MyConnection())
                {
                    string query = @" select subjects.subject_code, subjects.subject_name, teachers.teacher_number
                                      from teacher_subject
                                      join teachers on teacher_subject.teacher_id = teachers.id
                                      join subjects on teacher_subject.subject_id = subjects.id;";
                    using(MySqlDataAdapter adapter = new MySqlDataAdapter(query,conn))
                    {
                        adapter.Fill(dataTable);
                    }
                }
                return dataTable;
            }

        }
    }
