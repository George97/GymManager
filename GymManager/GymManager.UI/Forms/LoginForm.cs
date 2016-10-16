using System;
using System.Configuration;
using System.Windows.Forms;
using GymManager.Entities;
using GymManager.Repositories;

namespace GymManager
{
    public partial class LoginForm : Form
    {
        private readonly SqlAdministratorRepository _administratorRepository;
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["GymManager"].ConnectionString;

        public LoginForm()
        {
            _administratorRepository = new SqlAdministratorRepository(_connectionString);
            InitializeComponent();
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            var login = tbxLogin.Text;
            var password = Encrypt.GetHash(tbxPassword.Text);
            Administrator admin = _administratorRepository.SelectAdministrator(login, password);

            if (admin == null)
            {
                MessageBox.Show("Invalid login and/or password!", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxPassword.Clear();
            }
            else
            {
                ActiveAdmin.Initialize(admin);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
