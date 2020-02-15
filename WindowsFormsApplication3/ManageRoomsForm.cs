using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class ManageRoomsForm : Form
    {
        public ManageRoomsForm()
        {
            InitializeComponent();
        }
        ROOM room = new ROOM();

        //  displya combobox items
        private void ManageRoomsForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = room.roomTypeList();
            comboBox1.DisplayMember = "label";
            comboBox1.ValueMember = "category_id";
            dataGridView1.DataSource = room.getRooms();
        }

        //  add new room
        private void addRoom_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(textBoxNumber.Text);
                int type = Convert.ToInt32(comboBox1.SelectedValue.ToString());
                string phone = textBoxPhone.Text;
                if (room.addRoom(number, type, phone, "Yes"))
                {
                    dataGridView1.DataSource = room.getRooms();
                    textBoxNumber.Text = "";
                    textBoxPhone.Text = "";
                    comboBox1.SelectedIndex = 0;
                    MessageBox.Show("Room Added Successfully", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Room Not Added", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        // displya selected row from datagrid view to textboxes
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNumber.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox1.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value;
            textBoxPhone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string free = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (free.Equals("Yes"))
            {
                radioYes.Checked = true;
            }
            else if(free.Equals("NO"))
            {
                radioNo.Checked = true;
            }
        }

        //  update selected record
        private void button3_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBoxNumber.Text);
            int type = Convert.ToInt32(comboBox1.SelectedValue.ToString());
            string phone = textBoxPhone.Text;
            string free = "";
            if (radioYes.Checked)
            {
                free = "Yes";
            }
            else if (radioNo.Checked)
            {
                free = "NO";
            }
            try
            {
                if (room.editRoom(number, type, phone, free))
                {
                    dataGridView1.DataSource = room.getRooms();
                    textBoxNumber.Text = "";
                    textBoxPhone.Text = "";
                    comboBox1.SelectedIndex = 0;
                    MessageBox.Show("Room Data Updated", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Room Data Not Updated", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        //  delete selected record
        private void deleteButton_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBoxNumber.Text);
            if (room.removeRoom(number))
            {
                dataGridView1.DataSource = room.getRooms();
                textBoxNumber.Text = "";
                textBoxPhone.Text = "";
                comboBox1.SelectedIndex = 0;
                MessageBox.Show("Room Data Deleted", "Remove Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Room Data Not Deleted", "Remove Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //  clear all fields
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxNumber.Text = "";
            textBoxPhone.Text = "";
            comboBox1.SelectedIndex = 0;

        }

        private void radioNo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
