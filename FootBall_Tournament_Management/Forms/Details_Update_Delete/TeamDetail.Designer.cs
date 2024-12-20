namespace FootBall_Tournament_Management.Forms.Details_Update_Delete
{
    partial class TeamDetail
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCoachID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dpkEDate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtTeamID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.ckb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(296, 133);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(405, 37);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Team Name:";
            // 
            // txtCoachID
            // 
            this.txtCoachID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCoachID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCoachID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoachID.Location = new System.Drawing.Point(296, 214);
            this.txtCoachID.Name = "txtCoachID";
            this.txtCoachID.ReadOnly = true;
            this.txtCoachID.Size = new System.Drawing.Size(405, 37);
            this.txtCoachID.TabIndex = 0;
            this.txtCoachID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCoachID_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Coach ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Established Date:";
            // 
            // dpkEDate
            // 
            this.dpkEDate.Enabled = false;
            this.dpkEDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkEDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkEDate.Location = new System.Drawing.Point(296, 291);
            this.dpkEDate.Name = "dpkEDate";
            this.dpkEDate.Size = new System.Drawing.Size(200, 37);
            this.dpkEDate.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(470, 434);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 45);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtTeamID
            // 
            this.txtTeamID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeamID.Location = new System.Drawing.Point(296, 54);
            this.txtTeamID.Name = "txtTeamID";
            this.txtTeamID.ReadOnly = true;
            this.txtTeamID.Size = new System.Drawing.Size(405, 37);
            this.txtTeamID.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Team ID:";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(621, 434);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 45);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ckb
            // 
            this.ckb.AutoSize = true;
            this.ckb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb.Location = new System.Drawing.Point(62, 439);
            this.ckb.Name = "ckb";
            this.ckb.Size = new System.Drawing.Size(215, 34);
            this.ckb.TabIndex = 4;
            this.ckb.Text = "Enable update";
            this.ckb.UseVisualStyleBackColor = true;
            this.ckb.CheckedChanged += new System.EventHandler(this.ckb_CheckedChanged);
            // 
            // TeamDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 508);
            this.Controls.Add(this.ckb);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dpkEDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCoachID);
            this.Controls.Add(this.txtTeamID);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TeamDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Team Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCoachID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dpkEDate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtTeamID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox ckb;
    }
}