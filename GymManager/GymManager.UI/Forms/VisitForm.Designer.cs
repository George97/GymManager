namespace GymManager
{
    partial class frmVisit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisit));
            this.btnOk = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvVisits = new System.Windows.Forms.DataGridView();
            this.clbOperations = new System.Windows.Forms.CheckedListBox();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisits)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(13, 271);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(146, 271);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvVisits
            // 
            this.dgvVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisits.Location = new System.Drawing.Point(13, 13);
            this.dgvVisits.Name = "dgvVisits";
            this.dgvVisits.Size = new System.Drawing.Size(338, 179);
            this.dgvVisits.TabIndex = 2;
            // 
            // clbOperations
            // 
            this.clbOperations.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.clbOperations.CheckOnClick = true;
            this.clbOperations.ForeColor = System.Drawing.Color.White;
            this.clbOperations.FormattingEnabled = true;
            this.clbOperations.Items.AddRange(new object[] {
            "Enter new visit",
            "Search by date",
            "Search by key"});
            this.clbOperations.Location = new System.Drawing.Point(122, 198);
            this.clbOperations.Name = "clbOperations";
            this.clbOperations.Size = new System.Drawing.Size(120, 49);
            this.clbOperations.TabIndex = 4;
            this.clbOperations.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbOperations_ItemCheck);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(276, 271);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(371, 306);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.clbOperations);
            this.Controls.Add(this.dgvVisits);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVisit";
            this.Text = "Visits";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VisitForm_FormClosed);
            this.Load += new System.EventHandler(this.VisitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvVisits;
        private System.Windows.Forms.CheckedListBox clbOperations;
        private System.Windows.Forms.Button btnReset;
    }
}