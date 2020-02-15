using System;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication3
{
    class ROOM
    {
        CONNECT conn = new CONNECT();

        //  create a function to get a list of room's type
        public DataTable roomTypeList()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM room_category", conn.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        //  create a function to add a new room
        public bool addRoom(int number, int type, string phone, string free)
        {
            string insertQuery = "INSERT INTO room_table (room_id, room_type, phone, free) VALUES (@num, @tp, @phn, @fr)";
            SqlCommand command = new SqlCommand(insertQuery, conn.getConnection());

            //@num, @tp, @phn, @fr
            command.Parameters.Add("@num", SqlDbType.Int).Value = number;
            command.Parameters.Add("@tp", SqlDbType.Int).Value = type;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@fr", SqlDbType.VarChar).Value = free;
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

        //  create a function to get a list of all rooms
        public DataTable getRooms()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM room_table", conn.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        //  create a function to edit the selected room
        public bool editRoom(int number, int type, string phone, string free)
        {
            string editQuery = "UPDATE room_table SET room_type = @tp, phone = @phn, free = @fr WHERE room_id = @num";
            SqlCommand command = new SqlCommand(editQuery, conn.getConnection());


            //@num, @tp, @phn, @fr
            command.Parameters.Add("@num", SqlDbType.Int).Value = number;
            command.Parameters.Add("@tp", SqlDbType.Int).Value = type;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@fr", SqlDbType.VarChar).Value = free;
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
        //      we only need the id of room
        public bool removeRoom(int id)
        {
            string removeQuery = "DELETE FROM room_table WHERE room_id = @num";
            SqlCommand command = new SqlCommand(removeQuery, conn.getConnection());


            command.Parameters.Add("@num", SqlDbType.Int).Value = id;
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

        // create a function to get a list of rooms by type

        public DataTable roomByType(int type)
        {
            SqlCommand command = new SqlCommand("SELECT room_id FROM room_table WHERE room_type = @typ AND free = @yes", conn.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            //  @typ
            command.Parameters.Add("@yes", SqlDbType.VarChar).Value = "Yes";
            command.Parameters.Add("@typ", SqlDbType.Int).Value = type;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public int getRoomType(int number)
        {
            SqlCommand command = new SqlCommand("SELECT room_type FROM room_table WHERE room_id = @rid", conn.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            //  @typ
            
            command.Parameters.Add("@rid", SqlDbType.Int).Value = number;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return Convert.ToInt32(table.Rows[0][0].ToString());
        }

        public int getRoomNumber(int number)
        {
            SqlCommand command = new SqlCommand("SELECT room_number FROM reservation_table WHERE reserv_id = @rid", conn.getConnection());
         
            //  @typ

            command.Parameters.Add("@rid", SqlDbType.Int).Value = number;
            conn.openConnection();
            string cmd = (string)command.ExecuteScalar();

            return Convert.ToInt32(cmd);
        }


    }
}
