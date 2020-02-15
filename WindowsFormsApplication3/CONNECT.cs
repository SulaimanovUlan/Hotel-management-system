using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace WindowsFormsApplication3
{
    class CONNECT
    {
        public SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog = job; Integrated Security = True");

        // create a function to return our connection
        public SqlConnection getConnection()
        {
            return connection;
        }

        // create a function to open the connection
        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                //MessageBox.Show("Connection opened to " + connection.Database);
            }

        }

        // create a function to close the connection
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                //MessageBox.Show("Connection closed with " + connection.Database);
            }
        }
    }
}
