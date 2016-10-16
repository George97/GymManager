using System;
using System.Windows.Forms;
using GymManager.Entities;
using GymManager.Repositories;

namespace GymManager
{
    public partial class frmCustomer : Form
    {
        private readonly SqlCustomerRepository _customerRepository = new SqlCustomerRepository(frmGymManager.connectionString);
        private readonly Customer _customer = new Customer();
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = _customerRepository.SelectAllCustomers();
            dgvCustomer.Refresh();

            for (var i = 8; i < 12; i++)
            {
                dgvCustomer.Columns[i].Visible = false;
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            switch (clbOperations.SelectedIndex)
            {
                case 0:
                    var customerForm = new frmAddCustomer();
                    customerForm.ShowDialog();
                    dgvCustomer.DataSource = _customerRepository.SelectAllCustomers();
                    clbOperations.SetItemChecked(0, false);
                    clbOperations.SetSelected(0, false);
                    dgvCustomer.Refresh();
                    break;
                case 1:
                    _customer.PhoneNumber = dgvCustomer.CurrentRow.Cells[5].Value.ToString();
                    _customer.CardNumber = Convert.ToInt32(dgvCustomer.CurrentRow.Cells[7].Value);
                    if (_customerRepository.ChangePhoneNumber(_customer) > 0)
                        {
                            MessageBox.Show("Successfull operation", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Try Again", "Allert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    dgvCustomer.Refresh();
                    clbOperations.SetItemChecked(1, false);
                    clbOperations.SetSelected(1, false);

                    break;
                case 2:
                    _customer.Email= dgvCustomer.CurrentRow.Cells[6].Value.ToString();
                    _customer.CardNumber = Convert.ToInt32(dgvCustomer.CurrentRow.Cells[7].Value);
                    if(_customerRepository.ChangeEmail(_customer) > 0)
                    {
                        MessageBox.Show("Successfull operation", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Try Again", "Allert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    dgvCustomer.Refresh();
                    clbOperations.SetItemChecked(2, false);
                    clbOperations.SetSelected(2, false);

                    break;
                case 3:
                    _customer.HouseNumber = Convert.ToInt32(dgvCustomer.CurrentRow.Cells[4].Value);
                    _customer.Street = dgvCustomer.CurrentRow.Cells[3].Value.ToString();
                    _customer.CardNumber = Convert.ToInt32(dgvCustomer.CurrentRow.Cells[7].Value);

                    if (_customerRepository.ChangeAddress(_customer) > 0)
                    {
                        MessageBox.Show("Successfull operation", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Try Again", "Allert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    dgvCustomer.Refresh();
                    clbOperations.SetItemChecked(3, false);
                    clbOperations.SetSelected(3, false);
                    
                    break;
                default: break;
            }
        }

        private void CustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Activate();
        }

        private void clbOperations_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                for (int ix = 0; ix < clbOperations.Items.Count; ++ix)
                {
                    if (e.Index != ix)
                    {
                        clbOperations.SetItemChecked(ix, false);
                    }
                }
            }
        }
    }
}
