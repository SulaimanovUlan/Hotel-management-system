using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication3
{
    class RESERVATION
    {
        CONNECT conn = new CONNECT();

        //  creata a function to get all reserv list
        public DataTable getAllReserv()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM reservation_table", conn.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        //  creata a function to add a new reservation
        public bool addReservation(int number, int clientId, DateTime dateIn, DateTime dateOut)
        {
            string insertQuery = "INSERT INTO reservation_table (room_number, client_id, date_in, date_out) VALUES (@rnm, @cid, @din, @dout)";
            SqlCommand command = new SqlCommand(insertQuery, conn.getConnection());

            //@rnm, @cid, @din, @dout
            command.Parameters.Add("@rnm", SqlDbType.Int).Value = number;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = clientId;
            command.Parameters.Add("@din", SqlDbType.Date).Value = dateIn;
            command.Parameters.Add("@dout", SqlDbType.Date).Value = dateOut;
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


        //      create a function to edite a reservation data
        public bool editReservation(int reservId, int number, int clientId, DateTime dateIn, DateTime dateOut)
        {
            string editQuery = "UPDATE reservation_table SET room_number = @rnm, client_id = @cid, date_in = @din, date_out = @dout WHERE reserv_id = @rvid";
            SqlCommand command = new SqlCommand(editQuery, conn.getConnection());

            //@rnm, @cid, @din, @dout, @rvid
            command.Parameters.Add("@rvid", SqlDbType.Int).Value = reservId;
            command.Parameters.Add("@rnm", SqlDbType.Int).Value = number;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = clientId;
            command.Parameters.Add("@din", SqlDbType.Date).Value = dateIn;
            command.Parameters.Add("@dout", SqlDbType.Date).Value = dateOut;
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

        
        //      create a function to delete the selected reservation
        //      we only need the id of reservation
        public bool removeReservation(int rsv_id)
        {
            string removeQuery = "DELETE FROM reservation_table WHERE reserv_id = @rvid";
            SqlCommand command = new SqlCommand(removeQuery, conn.getConnection());

            // @rvid
            command.Parameters.Add("@rvid", SqlDbType.Int).Value = rsv_id;
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
        
       
    }
}
