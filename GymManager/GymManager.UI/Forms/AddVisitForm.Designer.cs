namespace GymManager
{
    partial class frmAddVisit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddVisit));
            this.dgvAddVisit = new System.Windows.Forms.DataGridView();
            this.clmCardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKeyNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddVisit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAddVisit
            // 
            this.dgvAddVisit.AllowUserToAddRows = false;
            this.dgvAddVisit.AllowUserToDeleteRows = false;
            this.dgvAddVisit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddVisit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCardNumber,
            this.clmKeyNumber});
            this.dgvAddVisit.Location = new System.Drawing.Point(4, 3);
            this.dgvAddVisit.Name = "dgvAddVisit";
            this.dgvAddVisit.Size = new System.Drawing.Size(245, 47);
            this.dgvAddVisit.TabIndex = 3;
            // 
            // clmCardNumber
            // 
            this.clmCardNumber.HeaderText = "CardNumber";
            this.clmCardNumber.Name = "clmCardNumber";
            // 
            // clmKeyNumber
            // 
            this.clmKeyNumber.HeaderText = "KeyNumber";
            this.clmKeyNumber.Name = "clmKeyNumber";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(40, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(145, 51);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAddVisit
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(255, 80);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvAddVisit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddVisit";
            this.Text = "Add Visit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddVisitForm_FormClosed);
            this.Load += new System.EventHandler(this.AddVisitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddVisit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAddVisit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCardNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKeyNumber;
    }
}