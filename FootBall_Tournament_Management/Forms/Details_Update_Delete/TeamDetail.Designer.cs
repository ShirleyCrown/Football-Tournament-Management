﻿namespace FootBall_Tournament_Management.Forms.Details_Update_Delete
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dpkEDate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtTeamID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.ckb = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbCoachName = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMemebers = new System.Windows.Forms.DataGridView();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemebers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(178, 120);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(266, 37);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Team Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(483, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Coach:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(483, 126);
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
            this.dpkEDate.Location = new System.Drawing.Point(701, 121);
            this.dpkEDate.Name = "dpkEDate";
            this.dpkEDate.Size = new System.Drawing.Size(195, 37);
            this.dpkEDate.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(701, 206);
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
            this.txtTeamID.Location = new System.Drawing.Point(178, 41);
            this.txtTeamID.Name = "txtTeamID";
            this.txtTeamID.ReadOnly = true;
            this.txtTeamID.Size = new System.Drawing.Size(266, 37);
            this.txtTeamID.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Team ID:";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(926, 206);
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
            this.ckb.Location = new System.Drawing.Point(19, 211);
            this.ckb.Name = "ckb";
            this.ckb.Size = new System.Drawing.Size(215, 34);
            this.ckb.TabIndex = 4;
            this.ckb.Text = "Enable update";
            this.ckb.UseVisualStyleBackColor = true;
            this.ckb.CheckedChanged += new System.EventHandler(this.ckb_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.avatar);
            this.groupBox1.Controls.Add(this.cbbCoachName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.ckb);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtTeamID);
            this.groupBox1.Controls.Add(this.dpkEDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1396, 266);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // cbbCoachName
            // 
            this.cbbCoachName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCoachName.Enabled = false;
            this.cbbCoachName.FormattingEnabled = true;
            this.cbbCoachName.Location = new System.Drawing.Point(701, 41);
            this.cbbCoachName.Name = "cbbCoachName";
            this.cbbCoachName.Size = new System.Drawing.Size(340, 38);
            this.cbbCoachName.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMemebers);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(36, 347);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1396, 368);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Team members";
            // 
            // dgvMemebers
            // 
            this.dgvMemebers.AllowUserToAddRows = false;
            this.dgvMemebers.AllowUserToDeleteRows = false;
            this.dgvMemebers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMemebers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemebers.Location = new System.Drawing.Point(19, 36);
            this.dgvMemebers.Name = "dgvMemebers";
            this.dgvMemebers.ReadOnly = true;
            this.dgvMemebers.RowHeadersVisible = false;
            this.dgvMemebers.RowHeadersWidth = 62;
            this.dgvMemebers.RowTemplate.Height = 28;
            this.dgvMemebers.Size = new System.Drawing.Size(1360, 326);
            this.dgvMemebers.TabIndex = 0;
            // 
            // avatar
            // 
            this.avatar.BackColor = System.Drawing.SystemColors.Control;
            this.avatar.Enabled = false;
            this.avatar.Location = new System.Drawing.Point(1120, 41);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(226, 194);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatar.TabIndex = 6;
            this.avatar.TabStop = false;
            // 
            // TeamDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 727);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TeamDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Team Details";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemebers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dpkEDate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtTeamID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox ckb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMemebers;
        private System.Windows.Forms.ComboBox cbbCoachName;
        private System.Windows.Forms.PictureBox avatar;
    }
}