using System;
using System.Windows.Forms;
using GymManager.Entities;
using GymManager.Repositories;

namespace GymManager
{
    public partial class frmAddAdmin : Form
    {
        public frmAddAdmin()
        {
            InitializeComponent();
        }

        private void AddAdminForm_Load(object sender, EventArgs e)
        {
            dgvAddAdmin.RowCount = 1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var administratorRepository = new SqlAdministratorRepository(frmGymManager.connectionString);
            var admin = new Administrator();

            if (dgvAddAdmin.CurrentRow.Cells[0].Value != null && dgvAddAdmin.CurrentRow.Cells[1].Value != null &&
                dgvAddAdmin.CurrentRow.Cells[2].Value != null && dgvAddAdmin.CurrentRow.Cells[3].Value != null)
            {
                admin.Name = dgvAddAdmin.CurrentRow.Cells[0].Value.ToString();
                admin.Surname = dgvAddAdmin.CurrentRow.Cells[1].Value.ToString();
                admin.Login = dgvAddAdmin.CurrentRow.Cells[2].Value.ToString();
                admin.Password = Encrypt.GetHash(dgvAddAdmin.CurrentRow.Cells[3].Value.ToString());

                if (administratorRepository.AddNewAdministrator(admin) > 0)
                {
                    MessageBox.Show("Successfull operation", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Try Again", "Allert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Enter data!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void AddAdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[1].Activate();
        }
    }
}
