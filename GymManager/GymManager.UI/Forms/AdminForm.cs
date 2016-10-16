using System;
using System.Windows.Forms;
using GymManager.Entities;
using GymManager.Repositories;

namespace GymManager
{
    public partial class frmAdmin : Form
    {
       private readonly SqlAdministratorRepository _administratorRepositoryadmin = new SqlAdministratorRepository(frmGymManager.connectionString);

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            dgvAdmin.DataSource = _administratorRepositoryadmin.SelectAllAdministrators();
            dgvAdmin.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addAdmin = new frmAddAdmin();

            addAdmin.ShowDialog();
            dgvAdmin.DataSource = _administratorRepositoryadmin.SelectAllAdministrators();
            dgvAdmin.Refresh();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            var newAdmin = new Administrator();
            newAdmin.Id = Convert.ToInt32(dgvAdmin.CurrentRow.Cells[0].Value);
            newAdmin.IsActive = Convert.ToBoolean(dgvAdmin.CurrentRow.Cells[4].Value);

            if (_administratorRepositoryadmin.SetActivityAdministrator(newAdmin) > 0)
            {
                MessageBox.Show("Successfull operation","Done",MessageBoxButtons.OK,MessageBoxIcon.Information);
                dgvAdmin.DataSource = _administratorRepositoryadmin.SelectAllAdministrators();
                dgvAdmin.Refresh();
            }
            else
            {
                MessageBox.Show("Try Again","Allert",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            dgvAdmin.Update();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Activate();
        }
    }
}
