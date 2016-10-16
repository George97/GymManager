using System;
using System.Configuration;
using System.Windows.Forms;
using GymManager.Repositories;

namespace GymManager
{
    public partial class frmGymManager : Form
    {
        internal static string connectionString = ConfigurationManager.ConnectionStrings["GymManager"].ConnectionString;

        public frmGymManager()
        {
            InitializeComponent();
            lblInfo.Text = "Gym Manager customers info. Hello, " + ActiveAdmin.Name + " " + ActiveAdmin.Surname + "!";
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin adminForm = new frmAdmin();
            //this.vAllInfoTableAdapter.Fill(this.gymManagerDataSet.vAllInfo);
            adminForm.ShowDialog();
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
           frmCard cardForm = new frmCard();
            cardForm.ShowDialog();
        }

        private void btnVisits_Click(object sender, EventArgs e)
        {
            frmVisit visit = new frmVisit();
            visit.ShowDialog();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer customerForm = new frmCustomer();
            customerForm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {

            string mail = dgvGymManager.CurrentRow.Cells[2].Value.ToString();
            string nameSurname = dgvGymManager.CurrentRow.Cells[1].Value.ToString();
            var sendMail = new frmSendMail(mail, nameSurname);
            sendMail.ShowDialog();
        }

        private void frmGymManager_Activated(object sender, EventArgs e)
        {
           var viewRepository = new SqlViewRepository(connectionString);
           dgvGymManager.DataSource = viewRepository.SelectView();
           dgvGymManager.Refresh();
        }

        private void frmGymManager_Load(object sender, EventArgs e)
        {
            var viewRepository = new SqlViewRepository(connectionString);
            dgvGymManager.DataSource = viewRepository.SelectView();
            dgvGymManager.Refresh();
        }
    }
}
