namespace GymManager
{
    partial class frmSendMail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSendMail));
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbxTopic = new System.Windows.Forms.TextBox();
            this.rtbxMessage = new System.Windows.Forms.RichTextBox();
            this.lblTopic = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(110, 183);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(87, 31);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(225, 183);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 31);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbxTopic
            // 
            this.tbxTopic.Location = new System.Drawing.Point(79, 12);
            this.tbxTopic.Name = "tbxTopic";
            this.tbxTopic.Size = new System.Drawing.Size(274, 20);
            this.tbxTopic.TabIndex = 2;
            // 
            // rtbxMessage
            // 
            this.rtbxMessage.Location = new System.Drawing.Point(79, 56);
            this.rtbxMessage.Name = "rtbxMessage";
            this.rtbxMessage.Size = new System.Drawing.Size(272, 108);
            this.rtbxMessage.TabIndex = 3;
            this.rtbxMessage.Text = "";
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTopic.Location = new System.Drawing.Point(12, 12);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(34, 13);
            this.lblTopic.TabIndex = 4;
            this.lblTopic.Text = "Topic";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMessage.Location = new System.Drawing.Point(12, 56);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "Message";
            // 
            // frmSendMail
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(379, 226);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblTopic);
            this.Controls.Add(this.rtbxMessage);
            this.Controls.Add(this.tbxTopic);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSend);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSendMail";
            this.Text = "Send Mail";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SendMailForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbxTopic;
        private System.Windows.Forms.RichTextBox rtbxMessage;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.Label lblMessage;
    }
}