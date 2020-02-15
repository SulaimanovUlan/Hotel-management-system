using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication3
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CONNECT conn = new CONNECT();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            string query = "SELECT * FROM user_table WHERE user_name = @musn AND user_password = @pusser";
            SqlCommand command = new SqlCommand(query, conn.getConnection());

            command.Parameters.Add("@musn", SqlDbType.VarChar).Value = textBoxUsername.Text;
            command.Parameters.Add("@pusser", SqlDbType.VarChar).Value = textBoxPassword.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            // check if the username and the password exist

            if (table.Rows.Count > 0)
            {
                this.Hide();
                Main_Form mform = new Main_Form();
                mform.Show();
            }
            else
            {
                if (textBoxUsername.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your UserName to login", "Empty UserName", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBoxPassword.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your PassWord to login", "Empty PassWord", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("This UserName or PassWord Doesn't Exist", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
