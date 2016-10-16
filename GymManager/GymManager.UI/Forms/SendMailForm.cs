using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GymManager
{
    public partial class frmSendMail : Form
    {
        private readonly string _mail;
        private readonly string _nameSurname;
        public frmSendMail(string email, string naseSurname)
        {
            this._mail = email;
            this._nameSurname = naseSurname;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SendMailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Activate();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("gym.manager.net.2016@gmail.com", "11111111gym"),
                EnableSsl = true
            };

            var message = new MailMessage();
            message.From = new MailAddress("gym.manager.net.2016@gmail.com");
            message.To.Add(new MailAddress(_mail,_nameSurname));
            message.Subject = tbxTopic.Text;
            message.Body = rtbxMessage.Text;

            try
            {
                client.Send(message);
                MessageBox.Show("Successfull operation", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Try Again", "Allert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
