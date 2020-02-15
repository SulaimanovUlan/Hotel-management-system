using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    public partial class ManageReservationForm : Form
    {
        public ManageReservationForm()
        {
            InitializeComponent();
        }

        ROOM room = new ROOM();
        RESERVATION reservation = new RESERVATION();
        CONNECT conn = new CONNECT();

        //  displya room's type on combobox
        private void ManageReservationForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = reservation.getAllReserv();
            //  displya room's type
            roomType.DataSource = room.roomTypeList();
            roomType.DisplayMember = "label";
            roomType.ValueMember = "category_id";

            //  displya room's number depending on the selected type
            int type = Convert.ToInt32(roomType.SelectedValue.ToString());
            roomNumber.DataSource = room.roomByType(type);
            roomNumber.DisplayMember = "";
            roomNumber.ValueMember = "";
            roomNumber.DisplayMember = "room_id";
            roomNumber.ValueMember = "room_id";
        }


        //  Clear all fields
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxClientId.Text = "";
            //roomType.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }


        //  displya room's number depending on the selected type
        private void roomType_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                //  displya room's number depending on the selected type
                int type = Convert.ToInt32(roomType.SelectedValue.ToString());
                DataTable table = room.roomByType(type);
                roomNumber.DataSource = table;
                roomNumber.DisplayMember = "";
                roomNumber.ValueMember = "";
                roomNumber.DisplayMember = "room_id";
                roomNumber.ValueMember = "room_id";
            }
            catch (Exception)
            {
                // do nothing
            }
            
        }


        //  add new records
        private void addReserv_Click(object sender, EventArgs e)
        {
            try
            {
                int clientId = Convert.ToInt32(textBoxClientId.Text);
                // begin
                CONNECT conn = new CONNECT();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                string query = "SELECT * FROM client_table WHERE client_id = @pusser";
                SqlCommand command = new SqlCommand(query, conn.getConnection());
                command.Parameters.Add("@pusser", SqlDbType.Int).Value = textBoxClientId.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    int roomnumber = Convert.ToInt32(roomNumber.SelectedValue);
                    DateTime datein = dateTimePicker1.Value;
                    DateTime dateout = dateTimePicker2.Value;
                    if (datein < DateTime.Now || dateout <= datein)
                    {
                        MessageBox.Show("There is incorrect date", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (reservation.addReservation(roomnumber, clientId, datein, dateout))
                        {
                            string editQuery = "UPDATE room_table SET free = @yes WHERE room_id = @ides";

                            SqlCommand reservedYES = new SqlCommand(editQuery, conn.getConnection());
                            reservedYES.Parameters.Add("@yes", SqlDbType.VarChar).Value = "NO";
                            reservedYES.Parameters.Add("@ides", SqlDbType.Int).Value = roomnumber;
                            conn.openConnection();
                            reservedYES.ExecuteNonQuery();
                            conn.closeConnection();
                            MessageBox.Show("New Reservation Added", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridView1.DataSource = reservation.getAllReserv();
                        }
                        else
                        {
                            MessageBox.Show("New Reservation Not Added", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }




                }
                else
                {
                    MessageBox.Show("There is not such client id", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There is incorrect date", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            

            // end
            
        }

        //  display selected client data from datagridview to textboxes
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            reservides.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxClientId.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            roomNumber.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            int roomID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            roomType.SelectedValue = room.getRoomType(roomID);
            
        }

        //  delete selected record
        private void deleteReserv_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(reservides.Text);
            if (reservation.removeReservation(number))
            {
                dataGridView1.DataSource = reservation.getAllReserv();
                reservides.Text = "";
                textBoxClientId.Text = "";
                // -----------------

                string editQuery = "UPDATE room_table SET free = @yes WHERE room_id = @ides";

                SqlCommand reservedYES = new SqlCommand(editQuery, conn.getConnection());
                reservedYES.Parameters.Add("@yes", SqlDbType.VarChar).Value = "Yes";
                reservedYES.Parameters.Add("@ides", SqlDbType.Int).Value = room.getRoomNumber(number);
                conn.openConnection();
                reservedYES.ExecuteNonQuery();
                conn.closeConnection();

                // -----------------

                MessageBox.Show("Room Data Deleted", "Remove Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Room Data Not Deleted", "Remove Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
