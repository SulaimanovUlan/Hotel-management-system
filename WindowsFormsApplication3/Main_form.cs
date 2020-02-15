using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void manageToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ManageClientsForm manaCF = new ManageClientsForm();
            manaCF.ShowDialog();
        }

        private void manageRoomsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ManageRoomsForm manaRF = new ManageRoomsForm();
            manaRF.ShowDialog();
        }

        private void manageReservationToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ManageReservationForm manaRSVF = new ManageReservationForm();
            manaRSVF.ShowDialog();
        }



        private void Main_Form_Load(object sender, System.EventArgs e)
        {

        }
    }
}
