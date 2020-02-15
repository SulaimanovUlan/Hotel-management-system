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
    public partial class ManageClientsForm : Form
    {

        CLIENT client = new CLIENT();
        public ManageClientsForm()
        {
            InitializeComponent();
        }


        //  method to clear all field
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPhone.Text = "";
            textBoxCountry.Text = "";
        }

        //  method to insert new record
        private void button2_Click(object sender, EventArgs e)
        {
            string fname = textBoxFirstName.Text;
            string lname = textBoxLastName.Text;
            string phone = textBoxPhone.Text;
            string country = textBoxCountry.Text;
            if (fname.Trim().Equals("") || lname.Trim().Equals("") || phone.Trim().Equals("") || country.Trim().Equals(""))
            {
                MessageBox.Show("ERROR - Required Fields are empty", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 
                bool insertClient = client.insertClient(fname, lname, phone, country);
                if (insertClient)
                {
                    MessageBox.Show("New Client Inserted Successfuly", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = client.getClients();
                }
                else
                {
                    MessageBox.Show("ERROR - Client Not Inserted", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //  method to show datagrid onLoad
        private void ManageClientsForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = client.getClients();
        }

        //  method to update a data from database
        private void button3_Click(object sender, EventArgs e)
        {
            int id;
            string fname = textBoxFirstName.Text;
            string lname = textBoxLastName.Text;
            string phone = textBoxPhone.Text;
            string country = textBoxCountry.Text;

            try
            {
                id = Convert.ToInt32(textBoxID.Text);
                if (fname.Trim().Equals("") || lname.Trim().Equals("") || phone.Trim().Equals("") || country.Trim().Equals(""))
                {
                    MessageBox.Show("ERROR - Required Fields are empty", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool insertClient = client.editClient(id, fname, lname, phone, country);
                    if (insertClient)
                    {
                        MessageBox.Show("New Client Updated Successfuly", "Edit Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = client.getClients();
                    }
                    else
                    {
                        MessageBox.Show("ERROR - Client Not Updated", "Edit Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
 
        }

        //  display selected client data from datagridview to textboxes
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxFirstName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxLastName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxPhone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxCountry.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                if (client.removeClient(id))
                {
                    dataGridView1.DataSource = client.getClients();
                    MessageBox.Show("Client Deleted Successfuly", "Delted Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxID.Text = "";
                    textBoxFirstName.Text = "";
                    textBoxLastName.Text = "";
                    textBoxPhone.Text = "";
                    textBoxCountry.Text = "";
                }
                else
                {
                    MessageBox.Show("ERROR - Client Not Deleted", "Delete Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
