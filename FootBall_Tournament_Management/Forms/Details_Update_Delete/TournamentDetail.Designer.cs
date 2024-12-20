namespace FootBall_Tournament_Management.Forms.Details_Update_Delete
{
    partial class TournamentDetail
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
            this.ckbUpdateDetails = new System.Windows.Forms.CheckBox();
            this.dpkEnd = new System.Windows.Forms.DateTimePicker();
            this.dpkStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnUpdateDetails = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckbUpdatePrize = new System.Windows.Forms.CheckBox();
            this.txt2ndRunnerup = new System.Windows.Forms.TextBox();
            this.txtChampionPrize = new System.Windows.Forms.TextBox();
            this.txtRunnerup = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUpdatePrize = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lstTeamInDB = new System.Windows.Forms.ListView();
            this.lstTeamInTournament = new System.Windows.Forms.ListView();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnMoveAllRight = new System.Windows.Forms.Button();
            this.btnUpdateTeams = new System.Windows.Forms.Button();
            this.btnMoveAllLeft = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ckbUpdateTeams = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbUpdateDetails);
            this.groupBox1.Controls.Add(this.dpkEnd);
            this.groupBox1.Controls.Add(this.dpkStart);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtLocation);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.btnUpdateDetails);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(64, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 369);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tournament Details";
            // 
            // ckbUpdateDetails
            // 
            this.ckbUpdateDetails.AutoSize = true;
            this.ckbUpdateDetails.BackColor = System.Drawing.SystemColors.Control;
            this.ckbUpdateDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbUpdateDetails.Location = new System.Drawing.Point(15, 317);
            this.ckbUpdateDetails.Name = "ckbUpdateDetails";
            this.ckbUpdateDetails.Size = new System.Drawing.Size(215, 34);
            this.ckbUpdateDetails.TabIndex = 4;
            this.ckbUpdateDetails.Text = "Enable update";
            this.ckbUpdateDetails.UseVisualStyleBackColor = false;
            this.ckbUpdateDetails.CheckedChanged += new System.EventHandler(this.ckbUpdateDetails_CheckedChanged);
            // 
            // dpkEnd
            // 
            this.dpkEnd.Enabled = false;
            this.dpkEnd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkEnd.Location = new System.Drawing.Point(342, 212);
            this.dpkEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dpkEnd.Name = "dpkEnd";
            this.dpkEnd.Size = new System.Drawing.Size(188, 37);
            this.dpkEnd.TabIndex = 10;
            // 
            // dpkStart
            // 
            this.dpkStart.Enabled = false;
            this.dpkStart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkStart.Location = new System.Drawing.Point(342, 160);
            this.dpkStart.Margin = new System.Windows.Forms.Padding(2);
            this.dpkStart.Name = "dpkStart";
            this.dpkStart.Size = new System.Drawing.Size(188, 37);
            this.dpkStart.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "End date:";
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(342, 265);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(254, 37);
            this.txtLocation.TabIndex = 8;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(342, 54);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(248, 37);
            this.txtID.TabIndex = 9;
            // 
            // btnUpdateDetails
            // 
            this.btnUpdateDetails.Enabled = false;
            this.btnUpdateDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDetails.Location = new System.Drawing.Point(495, 317);
            this.btnUpdateDetails.Name = "btnUpdateDetails";
            this.btnUpdateDetails.Size = new System.Drawing.Size(118, 45);
            this.btnUpdateDetails.TabIndex = 2;
            this.btnUpdateDetails.Text = "Update";
            this.btnUpdateDetails.UseVisualStyleBackColor = true;
            this.btnUpdateDetails.Click += new System.EventHandler(this.btnUpdateDetails_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(342, 109);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(248, 37);
            this.txtName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 268);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Location:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 30);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tournament ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Start date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tournament name:";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1279, 907);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 45);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(631, 907);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(228, 45);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start Tournament";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckbUpdatePrize);
            this.groupBox2.Controls.Add(this.txt2ndRunnerup);
            this.groupBox2.Controls.Add(this.txtChampionPrize);
            this.groupBox2.Controls.Add(this.txtRunnerup);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnUpdatePrize);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(766, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(648, 365);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prize Information";
            // 
            // ckbUpdatePrize
            // 
            this.ckbUpdatePrize.AutoSize = true;
            this.ckbUpdatePrize.BackColor = System.Drawing.SystemColors.Control;
            this.ckbUpdatePrize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbUpdatePrize.Location = new System.Drawing.Point(20, 312);
            this.ckbUpdatePrize.Name = "ckbUpdatePrize";
            this.ckbUpdatePrize.Size = new System.Drawing.Size(215, 34);
            this.ckbUpdatePrize.TabIndex = 4;
            this.ckbUpdatePrize.Text = "Enable update";
            this.ckbUpdatePrize.UseVisualStyleBackColor = false;
            this.ckbUpdatePrize.CheckedChanged += new System.EventHandler(this.ckbUpdatePrize_CheckedChanged);
            // 
            // txt2ndRunnerup
            // 
            this.txt2ndRunnerup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2ndRunnerup.Location = new System.Drawing.Point(342, 160);
            this.txt2ndRunnerup.Margin = new System.Windows.Forms.Padding(2);
            this.txt2ndRunnerup.Name = "txt2ndRunnerup";
            this.txt2ndRunnerup.ReadOnly = true;
            this.txt2ndRunnerup.Size = new System.Drawing.Size(222, 37);
            this.txt2ndRunnerup.TabIndex = 8;
            this.txt2ndRunnerup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt2ndRunnerup_KeyPress);
            // 
            // txtChampionPrize
            // 
            this.txtChampionPrize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChampionPrize.Location = new System.Drawing.Point(342, 54);
            this.txtChampionPrize.Margin = new System.Windows.Forms.Padding(2);
            this.txtChampionPrize.Name = "txtChampionPrize";
            this.txtChampionPrize.ReadOnly = true;
            this.txtChampionPrize.Size = new System.Drawing.Size(222, 37);
            this.txtChampionPrize.TabIndex = 9;
            this.txtChampionPrize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt2ndRunnerup_KeyPress);
            // 
            // txtRunnerup
            // 
            this.txtRunnerup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRunnerup.Location = new System.Drawing.Point(342, 109);
            this.txtRunnerup.Margin = new System.Windows.Forms.Padding(2);
            this.txtRunnerup.Name = "txtRunnerup";
            this.txtRunnerup.ReadOnly = true;
            this.txtRunnerup.Size = new System.Drawing.Size(222, 37);
            this.txtRunnerup.TabIndex = 9;
            this.txtRunnerup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt2ndRunnerup_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(51, 163);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(240, 30);
            this.label9.TabIndex = 5;
            this.label9.Text = "Second Runner-up:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(51, 54);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 30);
            this.label10.TabIndex = 7;
            this.label10.Text = "Champion:";
            // 
            // btnUpdatePrize
            // 
            this.btnUpdatePrize.Enabled = false;
            this.btnUpdatePrize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePrize.Location = new System.Drawing.Point(500, 312);
            this.btnUpdatePrize.Name = "btnUpdatePrize";
            this.btnUpdatePrize.Size = new System.Drawing.Size(118, 45);
            this.btnUpdatePrize.TabIndex = 2;
            this.btnUpdatePrize.Text = "Update";
            this.btnUpdatePrize.UseVisualStyleBackColor = true;
            this.btnUpdatePrize.Click += new System.EventHandler(this.btnUpdatePrize_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(51, 109);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 30);
            this.label12.TabIndex = 7;
            this.label12.Text = "Runner-up:";
            // 
            // lstTeamInDB
            // 
            this.lstTeamInDB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTeamInDB.HideSelection = false;
            this.lstTeamInDB.Location = new System.Drawing.Point(186, 83);
            this.lstTeamInDB.Name = "lstTeamInDB";
            this.lstTeamInDB.Size = new System.Drawing.Size(408, 322);
            this.lstTeamInDB.TabIndex = 1;
            this.lstTeamInDB.TileSize = new System.Drawing.Size(488, 25);
            this.lstTeamInDB.UseCompatibleStateImageBehavior = false;
            this.lstTeamInDB.View = System.Windows.Forms.View.Tile;
            // 
            // lstTeamInTournament
            // 
            this.lstTeamInTournament.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTeamInTournament.HideSelection = false;
            this.lstTeamInTournament.Location = new System.Drawing.Point(774, 83);
            this.lstTeamInTournament.Name = "lstTeamInTournament";
            this.lstTeamInTournament.Size = new System.Drawing.Size(414, 322);
            this.lstTeamInTournament.TabIndex = 1;
            this.lstTeamInTournament.TileSize = new System.Drawing.Size(488, 25);
            this.lstTeamInTournament.UseCompatibleStateImageBehavior = false;
            this.lstTeamInTournament.View = System.Windows.Forms.View.Tile;
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveRight.Location = new System.Drawing.Point(645, 105);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(72, 45);
            this.btnMoveRight.TabIndex = 2;
            this.btnMoveRight.Text = ">";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveLeft.Location = new System.Drawing.Point(645, 171);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(72, 45);
            this.btnMoveLeft.TabIndex = 2;
            this.btnMoveLeft.Text = "<";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // btnMoveAllRight
            // 
            this.btnMoveAllRight.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveAllRight.Location = new System.Drawing.Point(645, 288);
            this.btnMoveAllRight.Name = "btnMoveAllRight";
            this.btnMoveAllRight.Size = new System.Drawing.Size(72, 45);
            this.btnMoveAllRight.TabIndex = 2;
            this.btnMoveAllRight.Text = ">>";
            this.btnMoveAllRight.UseVisualStyleBackColor = true;
            this.btnMoveAllRight.Click += new System.EventHandler(this.btnMoveAllRight_Click);
            // 
            // btnUpdateTeams
            // 
            this.btnUpdateTeams.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTeams.Location = new System.Drawing.Point(1202, 423);
            this.btnUpdateTeams.Name = "btnUpdateTeams";
            this.btnUpdateTeams.Size = new System.Drawing.Size(118, 45);
            this.btnUpdateTeams.TabIndex = 2;
            this.btnUpdateTeams.Text = "Update";
            this.btnUpdateTeams.UseVisualStyleBackColor = true;
            this.btnUpdateTeams.Click += new System.EventHandler(this.btnUpdateTeams_Click);
            // 
            // btnMoveAllLeft
            // 
            this.btnMoveAllLeft.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveAllLeft.Location = new System.Drawing.Point(645, 352);
            this.btnMoveAllLeft.Name = "btnMoveAllLeft";
            this.btnMoveAllLeft.Size = new System.Drawing.Size(72, 45);
            this.btnMoveAllLeft.TabIndex = 2;
            this.btnMoveAllLeft.Text = "<<";
            this.btnMoveAllLeft.UseVisualStyleBackColor = true;
            this.btnMoveAllLeft.Click += new System.EventHandler(this.btnMoveAllLeft_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(182, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(262, 28);
            this.label6.TabIndex = 3;
            this.label6.Text = "Already saved teams";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(768, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(254, 28);
            this.label7.TabIndex = 3;
            this.label7.Text = "Teams in tournament";
            // 
            // ckbUpdateTeams
            // 
            this.ckbUpdateTeams.AutoSize = true;
            this.ckbUpdateTeams.BackColor = System.Drawing.SystemColors.Control;
            this.ckbUpdateTeams.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbUpdateTeams.Location = new System.Drawing.Point(15, 418);
            this.ckbUpdateTeams.Name = "ckbUpdateTeams";
            this.ckbUpdateTeams.Size = new System.Drawing.Size(215, 34);
            this.ckbUpdateTeams.TabIndex = 4;
            this.ckbUpdateTeams.Text = "Enable update";
            this.ckbUpdateTeams.UseVisualStyleBackColor = false;
            this.ckbUpdateTeams.CheckedChanged += new System.EventHandler(this.ckbUpdateTeams_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstTeamInTournament);
            this.groupBox3.Controls.Add(this.ckbUpdateTeams);
            this.groupBox3.Controls.Add(this.lstTeamInDB);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnMoveRight);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnMoveLeft);
            this.groupBox3.Controls.Add(this.btnMoveAllLeft);
            this.groupBox3.Controls.Add(this.btnMoveAllRight);
            this.groupBox3.Controls.Add(this.btnUpdateTeams);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(64, 402);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(1350, 477);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Teams in tournament";
            // 
            // TournamentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1472, 977);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TournamentDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TournamentDetail";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dpkEnd;
        private System.Windows.Forms.DateTimePicker dpkStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt2ndRunnerup;
        private System.Windows.Forms.TextBox txtChampionPrize;
        private System.Windows.Forms.TextBox txtRunnerup;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox ckbUpdateDetails;
        private System.Windows.Forms.CheckBox ckbUpdatePrize;
        private System.Windows.Forms.Button btnUpdateDetails;
        private System.Windows.Forms.Button btnUpdatePrize;
        private System.Windows.Forms.ListView lstTeamInDB;
        private System.Windows.Forms.ListView lstTeamInTournament;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnMoveAllRight;
        private System.Windows.Forms.Button btnUpdateTeams;
        private System.Windows.Forms.Button btnMoveAllLeft;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ckbUpdateTeams;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}