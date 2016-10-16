namespace GymManager
{
    partial class frmGymManager
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGymManager));
            this.dgvGymManager = new System.Windows.Forms.DataGridView();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnVisits = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSendMail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGymManager)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGymManager
            // 
            this.dgvGymManager.AllowUserToAddRows = false;
            this.dgvGymManager.AllowUserToDeleteRows = false;
            this.dgvGymManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGymManager.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvGymManager.Location = new System.Drawing.Point(16, 27);
            this.dgvGymManager.Name = "dgvGymManager";
            this.dgvGymManager.ReadOnly = true;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dgvGymManager.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvGymManager.Size = new System.Drawing.Size(1134, 215);
            this.dgvGymManager.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInfo.Location = new System.Drawing.Point(10, 8);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 16);
            this.lblInfo.TabIndex = 1;
            // 
            // btnAdmin
            // 
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(16, 259);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(121, 28);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "Administrator";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(194, 259);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(116, 28);
            this.btnCustomer.TabIndex = 3;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnVisits
            // 
            this.btnVisits.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnVisits.Image = ((System.Drawing.Image)(resources.GetObject("btnVisits.Image")));
            this.btnVisits.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisits.Location = new System.Drawing.Point(398, 259);
            this.btnVisits.Name = "btnVisits";
            this.btnVisits.Size = new System.Drawing.Size(116, 28);
            this.btnVisits.TabIndex = 4;
            this.btnVisits.Text = "Visits";
            this.btnVisits.UseVisualStyleBackColor = true;
            this.btnVisits.Click += new System.EventHandler(this.btnVisits_Click);
            // 
            // btnCard
            // 
            this.btnCard.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCard.Image = ((System.Drawing.Image)(resources.GetObject("btnCard.Image")));
            this.btnCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCard.Location = new System.Drawing.Point(604, 259);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(110, 28);
            this.btnCard.TabIndex = 5;
            this.btnCard.Text = "Card";
            this.btnCard.UseVisualStyleBackColor = true;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // btnClose
            // 
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1040, 259);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 28);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSendMail
            // 
            this.btnSendMail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSendMail.Image = ((System.Drawing.Image)(resources.GetObject("btnSendMail.Image")));
            this.btnSendMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendMail.Location = new System.Drawing.Point(834, 259);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(113, 28);
            this.btnSendMail.TabIndex = 7;
            this.btnSendMail.Text = "Send Mail";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // frmGymManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1175, 308);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCard);
            this.Controls.Add(this.btnVisits);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.dgvGymManager);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGymManager";
            this.Text = "GymManager";
            this.Activated += new System.EventHandler(this.frmGymManager_Activated);
            this.Load += new System.EventHandler(this.frmGymManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGymManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnVisits;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.DataGridView dgvGymManager;
    }
}

