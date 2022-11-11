namespace SQLServer01
{
    partial class frmVIPMembers
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
            this.grdMemberList = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btlClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdMemberList)).BeginInit();
            this.SuspendLayout();
            // 
            // grdMemberList
            // 
            this.grdMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMemberList.Location = new System.Drawing.Point(181, 12);
            this.grdMemberList.Name = "grdMemberList";
            this.grdMemberList.Size = new System.Drawing.Size(607, 406);
            this.grdMemberList.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(31, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 27);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btlClose
            // 
            this.btlClose.Location = new System.Drawing.Point(31, 395);
            this.btlClose.Name = "btlClose";
            this.btlClose.Size = new System.Drawing.Size(75, 23);
            this.btlClose.TabIndex = 2;
            this.btlClose.Text = "Close";
            this.btlClose.UseVisualStyleBackColor = true;
            this.btlClose.Click += new System.EventHandler(this.btlClose_Click);
            // 
            // frmVIPMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btlClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grdMemberList);
            this.Name = "frmVIPMembers";
            this.Text = "VIP mangement";
            this.Load += new System.EventHandler(this.frmVIPMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMemberList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdMemberList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btlClose;
    }
}