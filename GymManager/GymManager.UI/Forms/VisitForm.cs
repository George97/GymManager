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
    public partial class frmVisit : Form
    {
        private readonly SqlVisitingRepository _visitingRepository = new SqlVisitingRepository(frmGymManager.connectionString);
        private readonly Visiting _visit = new Visiting();
      
        public frmVisit()
        {
            InitializeComponent();
        }

        private void VisitForm_Load(object sender, EventArgs e)
        {
            dgvVisits.DataSource = _visitingRepository.SelectAllVisits();
            dgvVisits.Refresh();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            switch (clbOperations.SelectedIndex)
            {
                case 0:
                    var addVisit = new frmAddVisit();
                    addVisit.ShowDialog();
                    dgvVisits.DataSource = _visitingRepository.SelectAllVisits();
                    clbOperations.SetItemChecked(0, false);
                    clbOperations.SetSelected(0, false);
                    break;
                case 1:
                    _visit.DateVisit = dgvVisits.CurrentCell.Value.ToString();
                    dgvVisits.DataSource = _visitingRepository.GetVisitsByDateVisit(_visit);
                    dgvVisits.Refresh();
                    clbOperations.SetItemChecked(1, false);
                    clbOperations.SetSelected(1, false);
                    break;
                case 2:
                    _visit.KeyNumber = Convert.ToInt32(dgvVisits.CurrentCell.Value);
                    dgvVisits.DataSource = _visitingRepository.GetVisitsByKeyNumber(_visit);
                    dgvVisits.Refresh();
                    clbOperations.SetItemChecked(2, false);
                    clbOperations.SetSelected(2, false);
                    break;
                default: break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VisitForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Activate();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvVisits.DataSource = _visitingRepository.SelectAllVisits();
            dgvVisits.Refresh();
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
