namespace GymManager
{
    partial class frmCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCard));
            this.btnOk = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvCard = new System.Windows.Forms.DataGridView();
            this.tbxMonth = new System.Windows.Forms.TextBox();
            this.clbOperations = new System.Windows.Forms.CheckedListBox();
            this.lblMonth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCard)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(306, 243);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(407, 243);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvCard
            // 
            this.dgvCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCard.Location = new System.Drawing.Point(12, 8);
            this.dgvCard.Name = "dgvCard";
            this.dgvCard.Size = new System.Drawing.Size(717, 179);
            this.dgvCard.TabIndex = 3;
            // 
            // tbxMonth
            // 
            this.tbxMonth.Enabled = false;
            this.tbxMonth.Location = new System.Drawing.Point(407, 195);
            this.tbxMonth.Name = "tbxMonth";
            this.tbxMonth.Size = new System.Drawing.Size(75, 20);
            this.tbxMonth.TabIndex = 4;
            // 
            // clbOperations
            // 
            this.clbOperations.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.clbOperations.CheckOnClick = true;
            this.clbOperations.ForeColor = System.Drawing.Color.White;
            this.clbOperations.FormattingEnabled = true;
            this.clbOperations.Items.AddRange(new object[] {
            "Change Card Type",
            "Extend Card",
            "Set Card Active",
            "Show Balance",
            "Show Expiriacne Date"});
            this.clbOperations.Location = new System.Drawing.Point(166, 193);
            this.clbOperations.Name = "clbOperations";
            this.clbOperations.Size = new System.Drawing.Size(131, 79);
            this.clbOperations.TabIndex = 8;
            this.clbOperations.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbOpperations_ItemCheck);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMonth.Enabled = false;
            this.lblMonth.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMonth.Location = new System.Drawing.Point(303, 198);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(64, 13);
            this.lblMonth.TabIndex = 9;
            this.lblMonth.Text = "Enter month";
            // 
            // frmCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(741, 278);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.clbOperations);
            this.Controls.Add(this.tbxMonth);
            this.Controls.Add(this.dgvCard);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCard";
            this.Text = "Card";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CardForm_FormClosed);
            this.Load += new System.EventHandler(this.CardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvCard;
        private System.Windows.Forms.TextBox tbxMonth;
        private System.Windows.Forms.CheckedListBox clbOperations;
        private System.Windows.Forms.Label lblMonth;
    }
}