using System;
using System.Windows.Forms;
using GymManager.Entities;
using GymManager.Repositories;

namespace GymManager
{
    public partial class frmCard : Form
    {
        private readonly SqlCardRepository _cardRepository = new SqlCardRepository(frmGymManager.connectionString);
        private readonly Card _card = new Card();

        public frmCard()
        {
            InitializeComponent();
        }

        private void CardForm_Load(object sender, EventArgs e)
        {
            dgvCard.DataSource = _cardRepository.SelectAllCards();
            dgvCard.Update();
            dgvCard.Columns[dgvCard.ColumnCount - 1].Visible = false;
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
                    _card.TypeCard = dgvCard.CurrentRow.Cells[1].Value.ToString();
                    _card.CardNumber = Convert.ToInt32(dgvCard.CurrentRow.Cells[0].Value);
                    if (_cardRepository.ChangeCardType(_card) > 0)
                    {
                        MessageBox.Show("Successfull operation", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Try Again", "Allert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
          
                    clbOperations.SetItemChecked(0,false);
                    clbOperations.SetSelected(0, false);

                    break;
                case 1:
                    if (!string.IsNullOrEmpty(tbxMonth.Text))
                    {
                        _card.CardNumber = Convert.ToInt32(dgvCard.CurrentRow.Cells[0].Value);
                        _card.Month = Convert.ToInt32(tbxMonth.Text);

                        if (_cardRepository.ExtendCard(_card) > 0)
                        {
                            MessageBox.Show("Successfull operation", "Done", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Try Again", "Allert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        clbOperations.SetItemChecked(1, false);
                        clbOperations.SetSelected(1, false);
                    }
                    else
                    {
                        MessageBox.Show("Enter data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                    break;
                case 2:
                    _card.IsActive= Convert.ToBoolean(dgvCard.CurrentRow.Cells[4].Value);
                    _card.CardNumber = Convert.ToInt32(dgvCard.CurrentRow.Cells[0].Value);

                    if(_cardRepository.SetCardActive(_card) > 0)
                    {
                        MessageBox.Show("Successfull operation", "Done", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Try Again", "Allert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    clbOperations.SetItemChecked(2, false);
                    clbOperations.SetSelected(2, false);

                    break;
                case 3:
                    _card.CardNumber = Convert.ToInt32(dgvCard.CurrentRow.Cells[0].Value);
                    int balance = _cardRepository.GetBalance(_card);
                    if (balance > 0)
                    {
                        MessageBox.Show("For card №"+ dgvCard.CurrentRow.Cells[0].Value + " balance is " +balance, "Balance", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Try Again", "Allert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    clbOperations.SetItemChecked(3, false);
                    clbOperations.SetSelected(3, false);

                    break;
                case 4:
                    _card.CardNumber = Convert.ToInt32(dgvCard.CurrentRow.Cells[0].Value);
                    int term = _cardRepository.GetExpirationDate(_card);
                    if (term > 0)
                    {
                        MessageBox.Show("The card №" + dgvCard.CurrentRow.Cells[0].Value + " is valid " + term + " days", "Expiration Date", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Try Again", "Allert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                   
                    clbOperations.SetItemChecked(4, false);
                    clbOperations.SetSelected(4, false);

                    break;
                default: break;
            }
        }

        private void CardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Activate();
        }

        private void clbOpperations_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (clbOperations.SelectedIndex == 1)
            {
                lblMonth.Enabled = true;
                tbxMonth.Enabled = true;
            }

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
