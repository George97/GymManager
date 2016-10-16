using System;
using System.Windows.Forms;
using GymManager.Entities;
using GymManager.Repositories;

namespace GymManager
{
    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var customerRepository = new SqlCustomerRepository(frmGymManager.connectionString);
            var customer = new Customer();

            if (dgvAddCustomer.CurrentRow.Cells[0].Value != null && dgvAddCustomer.CurrentRow.Cells[1].Value != null &&
                dgvAddCustomer.CurrentRow.Cells[2].Value != null && dgvAddCustomer.CurrentRow.Cells[3].Value != null)
            {
                customer.Name = dgvAddCustomer.CurrentRow.Cells[0].Value.ToString();
                customer.Surname = dgvAddCustomer.CurrentRow.Cells[1].Value.ToString();
                customer.Street = dgvAddCustomer.CurrentRow.Cells[2].Value.ToString();
                customer.HouseNumber = Convert.ToInt32(dgvAddCustomer.CurrentRow.Cells[3].Value);
                customer.PhoneNumber = dgvAddCustomer.CurrentRow.Cells[4].Value.ToString();
                customer.Email = dgvAddCustomer.CurrentRow.Cells[5].Value.ToString();
                customer.Validaty = Convert.ToInt32(dgvAddCustomer.CurrentRow.Cells[7].Value);
                customer.Price = Convert.ToInt32(dgvAddCustomer.CurrentRow.Cells[8].Value);
                customer.CardType = dgvAddCustomer.CurrentRow.Cells[6].Value.ToString();
                customer.AdminId = ActiveAdmin.Id;

                if (customerRepository.AddNewCustomer(customer) > 0)
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
                MessageBox.Show("Enter data!");
            }
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            dgvAddCustomer.RowCount = 1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[1].Activate();
        }
    }
}
