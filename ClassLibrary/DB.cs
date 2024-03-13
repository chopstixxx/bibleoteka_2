using Npgsql;
using NpgsqlTypes;
using System;
using System.Data;



namespace ClassLibrary
{
    public class DB
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=projects_db;User Id=postgres;Password=123;");

        public NpgsqlConnection Get_conn()
        { return conn; }
        public void Open_conn()
        { conn.Open(); }

        public DataTable Goods_load()
        {


            using (conn)
            {
                conn.Open();

                using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("SELECT * FROM project", conn))
                {

                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    return dt;


                }


            }

        }
        public DataTable Task_load(int project_id)
        {


            using (conn)
            {
                conn.Open();


                using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter($"SELECT * FROM task WHERE project_id = {project_id}", conn))
                {

                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    return dt;


                }


            }

        }

        public bool Task_remove(int id)
        {
            using (conn)
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM task WHERE id = @id", conn))
                {
                    cmd.Parameters.Add("@id", NpgsqlDbType.Integer).Value = id;
                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }



                }

            }
        }



        public void Project_remove(int id)
        {
            using (conn)
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM project WHERE id = @id", conn))
                {
                    cmd.Parameters.Add("@id", NpgsqlDbType.Integer).Value = id;
                        cmd.ExecuteNonQuery();
                                     
                }

            }
        }
        public bool Project_add(string name, string description)
        {
            using (conn)
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO project (name,description) VALUES (@name,@desc)", conn))
                {
                    cmd.Parameters.Add("@name", NpgsqlDbType.Varchar).Value = name;
                    cmd.Parameters.Add("@desc", NpgsqlDbType.Varchar).Value = description;
                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }

                }

            }
        }

        public bool Task_add(int project_id,string name, string description)
        {
            using (conn)
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO task (project_id,name,description,status) VALUES (@project_id,@name,@desc,@status)", conn))
                {
                    cmd.Parameters.Add("@project_id", NpgsqlDbType.Integer).Value = project_id;
                    cmd.Parameters.Add("@name", NpgsqlDbType.Varchar).Value = name;
                    cmd.Parameters.Add("@desc", NpgsqlDbType.Varchar).Value = description;
                    cmd.Parameters.Add("@status", NpgsqlDbType.Varchar).Value = "Не выполнена";
                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch(Exception ex)
                    {
                       return false;
                    }

                }

            }
        }
        public void Project_upd(int id, string name, string description)
        {
            using (conn)
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("UPDATE project SET name = @name, description = @description WHERE id = @id", conn))
                {
                    cmd.Parameters.Add("@id", NpgsqlDbType.Integer).Value = id;
                    cmd.Parameters.Add("@name", NpgsqlDbType.Text).Value = name;
                    cmd.Parameters.Add("@description", NpgsqlDbType.Text).Value = description;
                                                  
                        cmd.ExecuteNonQuery();

                   


                }

            }
        }
        public void Task_upd(int id, string name, string description, string status)
        {
            using (conn)
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("UPDATE task SET name = @name, description = @description, status = @status WHERE id = @id", conn))
                {
                    cmd.Parameters.Add("@id", NpgsqlDbType.Integer).Value = id;
                    cmd.Parameters.Add("@name", NpgsqlDbType.Text).Value = name;
                    cmd.Parameters.Add("@description", NpgsqlDbType.Text).Value = description;
                    cmd.Parameters.Add("@status", NpgsqlDbType.Text).Value = status;

                    cmd.ExecuteNonQuery();




                }

            }
        }
    }
    
}