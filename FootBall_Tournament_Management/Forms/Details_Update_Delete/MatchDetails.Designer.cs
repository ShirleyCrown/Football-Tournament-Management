namespace FootBall_Tournament_Management.Forms.Details_Update_Delete
{
    partial class MatchDetails
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTeam2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTeam1 = new System.Windows.Forms.Label();
            this.avatar2 = new System.Windows.Forms.PictureBox();
            this.avatar1 = new System.Windows.Forms.PictureBox();
            this.score1 = new System.Windows.Forms.NumericUpDown();
            this.score2 = new System.Windows.Forms.NumericUpDown();
            this.ckbScore = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dpkDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.ckbInfo = new System.Windows.Forms.CheckBox();
            this.btnUpdateScore = new System.Windows.Forms.Button();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.score1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.score2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTeam1);
            this.groupBox1.Controls.Add(this.btnUpdateScore);
            this.groupBox1.Controls.Add(this.ckbScore);
            this.groupBox1.Controls.Add(this.score2);
            this.groupBox1.Controls.Add(this.score1);
            this.groupBox1.Controls.Add(this.lblTeam2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.avatar2);
            this.groupBox1.Controls.Add(this.avatar1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1016, 372);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Score";
            // 
            // lblTeam2
            // 
            this.lblTeam2.AutoSize = true;
            this.lblTeam2.Location = new System.Drawing.Point(800, 256);
            this.lblTeam2.Name = "lblTeam2";
            this.lblTeam2.Size = new System.Drawing.Size(100, 30);
            this.lblTeam2.TabIndex = 1;
            this.lblTeam2.Text = "Team 2";
            this.lblTeam2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(467, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 115);
            this.label3.TabIndex = 1;
            this.label3.Text = "-";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTeam1
            // 
            this.lblTeam1.AutoSize = true;
            this.lblTeam1.Location = new System.Drawing.Point(102, 256);
            this.lblTeam1.Name = "lblTeam1";
            this.lblTeam1.Size = new System.Drawing.Size(100, 30);
            this.lblTeam1.TabIndex = 1;
            this.lblTeam1.Text = "Team 1";
            this.lblTeam1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // avatar2
            // 
            this.avatar2.Location = new System.Drawing.Point(754, 36);
            this.avatar2.Name = "avatar2";
            this.avatar2.Size = new System.Drawing.Size(200, 200);
            this.avatar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatar2.TabIndex = 0;
            this.avatar2.TabStop = false;
            // 
            // avatar1
            // 
            this.avatar1.Location = new System.Drawing.Point(56, 36);
            this.avatar1.Name = "avatar1";
            this.avatar1.Size = new System.Drawing.Size(200, 200);
            this.avatar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatar1.TabIndex = 0;
            this.avatar1.TabStop = false;
            // 
            // score1
            // 
            this.score1.Enabled = false;
            this.score1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score1.Location = new System.Drawing.Point(292, 80);
            this.score1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(154, 125);
            this.score1.TabIndex = 2;
            this.score1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // score2
            // 
            this.score2.Enabled = false;
            this.score2.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score2.Location = new System.Drawing.Point(563, 78);
            this.score2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(154, 125);
            this.score2.TabIndex = 2;
            this.score2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ckbScore
            // 
            this.ckbScore.AutoSize = true;
            this.ckbScore.Location = new System.Drawing.Point(16, 322);
            this.ckbScore.Name = "ckbScore";
            this.ckbScore.Size = new System.Drawing.Size(216, 34);
            this.ckbScore.TabIndex = 3;
            this.ckbScore.Text = "Enable Update";
            this.ckbScore.UseVisualStyleBackColor = true;
            this.ckbScore.CheckedChanged += new System.EventHandler(this.ckbUpdate_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdateInfo);
            this.groupBox2.Controls.Add(this.ckbInfo);
            this.groupBox2.Controls.Add(this.txtLocation);
            this.groupBox2.Controls.Add(this.dpkDate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 402);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1017, 254);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Infomation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Match date:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dpkDate
            // 
            this.dpkDate.Enabled = false;
            this.dpkDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkDate.Location = new System.Drawing.Point(355, 71);
            this.dpkDate.Name = "dpkDate";
            this.dpkDate.Size = new System.Drawing.Size(213, 37);
            this.dpkDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(355, 134);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(444, 37);
            this.txtLocation.TabIndex = 3;
            // 
            // ckbInfo
            // 
            this.ckbInfo.AutoSize = true;
            this.ckbInfo.Location = new System.Drawing.Point(17, 203);
            this.ckbInfo.Name = "ckbInfo";
            this.ckbInfo.Size = new System.Drawing.Size(216, 34);
            this.ckbInfo.TabIndex = 3;
            this.ckbInfo.Text = "Enable Update";
            this.ckbInfo.UseVisualStyleBackColor = true;
            this.ckbInfo.CheckedChanged += new System.EventHandler(this.ckbInfo_CheckedChanged);
            // 
            // btnUpdateScore
            // 
            this.btnUpdateScore.Enabled = false;
            this.btnUpdateScore.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateScore.Location = new System.Drawing.Point(889, 318);
            this.btnUpdateScore.Name = "btnUpdateScore";
            this.btnUpdateScore.Size = new System.Drawing.Size(121, 43);
            this.btnUpdateScore.TabIndex = 4;
            this.btnUpdateScore.Text = "Update";
            this.btnUpdateScore.UseVisualStyleBackColor = true;
            this.btnUpdateScore.Click += new System.EventHandler(this.btnUpdateScore_Click);
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.Enabled = false;
            this.btnUpdateInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInfo.Location = new System.Drawing.Point(890, 199);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(121, 43);
            this.btnUpdateInfo.TabIndex = 4;
            this.btnUpdateInfo.Text = "Update";
            this.btnUpdateInfo.UseVisualStyleBackColor = true;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // MatchDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 670);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MatchDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MatchDetails";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.score1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.score2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTeam2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTeam1;
        private System.Windows.Forms.PictureBox avatar2;
        private System.Windows.Forms.PictureBox avatar1;
        private System.Windows.Forms.NumericUpDown score2;
        private System.Windows.Forms.NumericUpDown score1;
        private System.Windows.Forms.CheckBox ckbScore;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dpkDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdateScore;
        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.CheckBox ckbInfo;
    }
}