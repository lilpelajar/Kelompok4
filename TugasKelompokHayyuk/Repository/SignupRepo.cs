using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using TugasKelompokHayyuk.Config;
using TugasKelompokHayyuk.Models;

namespace TugasKelompokHayyuk.Repository
{
    public class SignupRepo : database
    {
        public bool AddUser(UserModels userModels)
        {
            using (var conn = MyConnection())
            {
                conn.Open();
                try
                {
                    string query = @"insert into users (username, email, password_hash, full_name, role_enum)
                                 values (@username, @email, @password_hash, @full_name, @role_enum)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", userModels.Username);
                        cmd.Parameters.AddWithValue("@email", userModels.Email);
                        cmd.Parameters.AddWithValue("@password_hash", userModels.Password);
                        cmd.Parameters.AddWithValue("@full_name", userModels.FullName);
                        cmd.Parameters.AddWithValue("@role_enum", userModels.RoleUser);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("gagal memasukkan user: " + ex, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public bool RegistStudent(UserModels userModels) 
        {
            using (var conn = MyConnection())
            {
                conn.Open();
                using (MySqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        long lastuserid = 0;
                        string query = @"insert into users (username, email, password_hash, full_name, role_enum)
                                 values (@username, @email, @password_hash, @full_name, @role_enum);
                                 select last_insert_id()";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@username", userModels.Username);
                            cmd.Parameters.AddWithValue("@email", userModels.Email);
                            cmd.Parameters.AddWithValue("@password_hash", userModels.Password);
                            cmd.Parameters.AddWithValue("@full_name", userModels.FullName);
                            cmd.Parameters.AddWithValue("@role_enum", userModels.RoleUser);

                            lastuserid = Convert.ToInt64(cmd.ExecuteScalar());
                        }

                        string studentnumber = "";
                        string query2 = @"select student_number from students order by student_number desc limit 1";
                        using (MySqlCommand cmd2 = new MySqlCommand(query2, conn, transaction))
                        {
                            object apakek = cmd2.ExecuteScalar();
                            if (apakek != null && apakek != DBNull.Value)
                            {
                                string convert = apakek.ToString();
                                if (long.TryParse(convert, out long itulah))
                                {
                                    long bagogo = itulah + 1;
                                    studentnumber = bagogo.ToString();
                                }
                            }
                        }

                        string query3 = @"insert into students (user_id, student_number) values
                                      (@user_id,@student_number)";
                        using (MySqlCommand cmd3 = new MySqlCommand(query3, conn, transaction))
                        {
                            cmd3.Parameters.AddWithValue("@user_id", lastuserid);
                            cmd3.Parameters.AddWithValue("@student_number", studentnumber);

                            cmd3.ExecuteNonQuery();

                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("error occurred: " + ex);
                        return false;
                    }
                    
                }
            }
        }

        public bool RegistTeachers(UserModels userModels)
        {
            using(var conn = MyConnection())
            {
                conn.Open();
                using(MySqlTransaction transaction = conn.BeginTransaction())
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Transaction = transaction;
                        try
                        {
                            cmd.CommandText = @"insert into users (username, email, password_hash, full_name, role_enum)
                                 values (@username, @email, @password_hash, @full_name, @role_enum);
                                 select last_insert_id()";
                            cmd.Parameters.AddWithValue("@username",userModels.Username);
                            cmd.Parameters.AddWithValue("@email", userModels.Email);
                            cmd.Parameters.AddWithValue("@password_hash", userModels.Password);
                            cmd.Parameters.AddWithValue("@full_name", userModels.FullName);
                            cmd.Parameters.AddWithValue("@role_enum", userModels.RoleUser);
                            
                            long userid = Convert.ToInt64(cmd.ExecuteScalar());
                            string teachernumb = "";

                            cmd.CommandText = @"select teacher_number from teachers order by teacher_number desc limit 1";
                            object anu = cmd.ExecuteScalar();
                            if (anu != null && anu != DBNull.Value)
                            {
                                string convert = anu.ToString();
                                if (long.TryParse(convert, out long itulah))
                                {
                                    long bagogo = itulah + 1;
                                    teachernumb = bagogo.ToString();
                                }
                            }

                            cmd.CommandText = @"insert into teachers (user_id, teacher_number) values (@user_id, @teacher_number)";
                            cmd.Parameters.AddWithValue("@user_id", userid);
                            cmd.Parameters.AddWithValue("@teacher_number", teachernumb);
                            cmd.ExecuteNonQuery();

                            transaction.Commit();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("error occurred: " + ex);
                            return false;
                        }
                    }
                }
            }
        }

    }
}
