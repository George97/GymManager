using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymManager.Entities;
using GymManager.Repositories;

namespace GymManager
{
    public partial class frmAddVisit : Form
    {
        public frmAddVisit()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var visitingRepository = new SqlVisitingRepository(frmGymManager.connectionString);
            var visit = new Visiting();

            if (dgvAddVisit.CurrentRow.Cells[0].Value != null && dgvAddVisit.CurrentRow.Cells[1].Value != null)
            {
                visit.CardNumber = Convert.ToInt32(dgvAddVisit.CurrentRow.Cells[0].Value);
                visit.KeyNumber = Convert.ToInt32(dgvAddVisit.CurrentRow.Cells[1].Value);
                
                if (visitingRepository.InsertNewVisit(visit) > 0)
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
                MessageBox.Show("Enter data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddVisitForm_Load(object sender, EventArgs e)
        {
            dgvAddVisit.RowCount = 1;
        }

        private void AddVisitForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.OpenForms[1].Activate();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
