namespace FootBall_Tournament_Management.Forms.Details_Update_Delete
{
    partial class PlayerDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTeamID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dpkDob = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudJerseyNum = new System.Windows.Forms.NumericUpDown();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbbPos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPlayerID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.ckbUpdate = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudJerseyNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team ID:";
            // 
            // txtTeamID
            // 
            this.txtTeamID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeamID.Location = new System.Drawing.Point(292, 111);
            this.txtTeamID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTeamID.Name = "txtTeamID";
            this.txtTeamID.ReadOnly = true;
            this.txtTeamID.Size = new System.Drawing.Size(385, 37);
            this.txtTeamID.TabIndex = 1;
            this.txtTeamID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTeamID_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Player name:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(292, 177);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(385, 37);
            this.txtName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Position:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 319);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Day of birth:";
            // 
            // dpkDob
            // 
            this.dpkDob.Enabled = false;
            this.dpkDob.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkDob.Location = new System.Drawing.Point(292, 318);
            this.dpkDob.Margin = new System.Windows.Forms.Padding(2);
            this.dpkDob.Name = "dpkDob";
            this.dpkDob.Size = new System.Drawing.Size(185, 37);
            this.dpkDob.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 391);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phone number:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(292, 388);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(385, 37);
            this.txtPhoneNumber.TabIndex = 1;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTeamID_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 461);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "Jersey number:";
            // 
            // nudJerseyNum
            // 
            this.nudJerseyNum.Enabled = false;
            this.nudJerseyNum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudJerseyNum.Location = new System.Drawing.Point(292, 460);
            this.nudJerseyNum.Margin = new System.Windows.Forms.Padding(2);
            this.nudJerseyNum.Name = "nudJerseyNum";
            this.nudJerseyNum.ReadOnly = true;
            this.nudJerseyNum.Size = new System.Drawing.Size(115, 37);
            this.nudJerseyNum.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(438, 565);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 53);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbbPos
            // 
            this.cbbPos.Enabled = false;
            this.cbbPos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPos.FormattingEnabled = true;
            this.cbbPos.Items.AddRange(new object[] {
            "Goal Keeper",
            "Center-Back",
            "Full-Back",
            "Left-Back",
            "Right-back",
            "Wing-Back",
            "Sweeper",
            "Central-Midfielder",
            "Defensive Midfielder",
            "Attacking Midfielder",
            "Wide Midfielder",
            "Striker",
            "Center-Forward",
            "Second-Striker",
            "Left-Winger",
            "Right-Winger"});
            this.cbbPos.Location = new System.Drawing.Point(292, 247);
            this.cbbPos.Name = "cbbPos";
            this.cbbPos.Size = new System.Drawing.Size(385, 38);
            this.cbbPos.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "Player ID:";
            // 
            // txtPlayerID
            // 
            this.txtPlayerID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerID.Location = new System.Drawing.Point(292, 39);
            this.txtPlayerID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPlayerID.Name = "txtPlayerID";
            this.txtPlayerID.ReadOnly = true;
            this.txtPlayerID.Size = new System.Drawing.Size(385, 37);
            this.txtPlayerID.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(585, 565);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 53);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ckbUpdate
            // 
            this.ckbUpdate.AutoSize = true;
            this.ckbUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbUpdate.Location = new System.Drawing.Point(54, 574);
            this.ckbUpdate.Name = "ckbUpdate";
            this.ckbUpdate.Size = new System.Drawing.Size(215, 34);
            this.ckbUpdate.TabIndex = 6;
            this.ckbUpdate.Text = "Enable update";
            this.ckbUpdate.UseVisualStyleBackColor = true;
            this.ckbUpdate.CheckedChanged += new System.EventHandler(this.ckbUpdate_CheckedChanged);
            // 
            // PlayerDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 652);
            this.Controls.Add(this.ckbUpdate);
            this.Controls.Add(this.cbbPos);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.nudJerseyNum);
            this.Controls.Add(this.dpkDob);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlayerID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTeamID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "PlayerDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Player Details";
            ((System.ComponentModel.ISupportInitialize)(this.nudJerseyNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTeamID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dpkDob;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudJerseyNum;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbbPos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPlayerID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox ckbUpdate;
    }
}