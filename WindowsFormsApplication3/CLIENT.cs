using System;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication3
{
    class CLIENT
    {
        CONNECT conn = new CONNECT();

        //      create a function to insert a new client 
        public bool insertClient(String fname, String lname, String phone, String country)
        {
            string insertQuery = "INSERT INTO client_table (first_name, last_name, phone, country) VALUES (@fnm, @lnm, @phn, @cnt)";
            SqlCommand command = new SqlCommand(insertQuery, conn.getConnection());

            //@fnm, @lnm, @phn, @cnt
            command.Parameters.Add("@fnm", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lnm", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@cnt", SqlDbType.VarChar).Value = country;
            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
           
        }

        //      create a function to get the clients list
        public DataTable getClients()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM client_table", conn.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        //      create a function to edite a client data
        public bool editClient(int id, String fname, String lname, String phone, String country)
        {
            string editQuery = "UPDATE client_table SET first_name = @fnm, last_name = @lnm, phone = @phn, country = @cnt WHERE client_id = @cid";
            SqlCommand command = new SqlCommand(editQuery, conn.getConnection());

            //@fnm, @lnm, @phn, @cnt
            command.Parameters.Add("@cid", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fnm", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lnm", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@cnt", SqlDbType.VarChar).Value = country;
            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }

        //      create a function to delete the selected client
        //      we only need the id of client
        public bool removeClient(int id)
        {
            string removeQuery = "DELETE FROM client_table WHERE client_id = @cid";
            SqlCommand command = new SqlCommand(removeQuery, conn.getConnection());


            command.Parameters.Add("@cid", SqlDbType.Int).Value = id;
            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }


    }   // ----> CLASS CLIENT
}   // ----> NAMESPACE
