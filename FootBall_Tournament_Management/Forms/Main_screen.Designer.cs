namespace FootBall_Tournament_Management.Forms
{
    partial class Main_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_screen));
            this.heading = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCoach = new System.Windows.Forms.Button();
            this.btnPlayer = new System.Windows.Forms.Button();
            this.btnTeam = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnTournament = new System.Windows.Forms.Button();
            this.pnlComponent = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.componentList = new System.Windows.Forms.FlowLayoutPanel();
            this.heading.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.pnlComponent.SuspendLayout();
            this.SuspendLayout();
            // 
            // heading
            // 
            this.heading.BackColor = System.Drawing.Color.DodgerBlue;
            this.heading.Controls.Add(this.title);
            this.heading.Dock = System.Windows.Forms.DockStyle.Top;
            this.heading.Location = new System.Drawing.Point(0, 0);
            this.heading.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(1555, 188);
            this.heading.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(412, 66);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(688, 47);
            this.title.TabIndex = 0;
            this.title.Text = "FootBall Tournament Management";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 188);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 941);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnCoach, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnPlayer, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnTeam, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTournament, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 941);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCoach
            // 
            this.btnCoach.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCoach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCoach.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoach.ForeColor = System.Drawing.Color.White;
            this.btnCoach.Location = new System.Drawing.Point(3, 773);
            this.btnCoach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCoach.Name = "btnCoach";
            this.btnCoach.Size = new System.Drawing.Size(444, 164);
            this.btnCoach.TabIndex = 4;
            this.btnCoach.Text = "Coaches";
            this.btnCoach.UseVisualStyleBackColor = false;
            this.btnCoach.Click += new System.EventHandler(this.btnCoach_Click);
            this.btnCoach.MouseEnter += new System.EventHandler(this.btnCoach_MouseEnter);
            this.btnCoach.MouseLeave += new System.EventHandler(this.btnCoach_MouseLeave);
            // 
            // btnPlayer
            // 
            this.btnPlayer.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlayer.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayer.ForeColor = System.Drawing.Color.White;
            this.btnPlayer.Location = new System.Drawing.Point(3, 602);
            this.btnPlayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlayer.Name = "btnPlayer";
            this.btnPlayer.Size = new System.Drawing.Size(444, 163);
            this.btnPlayer.TabIndex = 3;
            this.btnPlayer.Text = "Players";
            this.btnPlayer.UseVisualStyleBackColor = false;
            this.btnPlayer.Click += new System.EventHandler(this.btnPlayer_Click);
            this.btnPlayer.MouseEnter += new System.EventHandler(this.btnPlayer_MouseEnter);
            this.btnPlayer.MouseLeave += new System.EventHandler(this.btnPlayer_MouseLeave);
            // 
            // btnTeam
            // 
            this.btnTeam.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeam.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeam.ForeColor = System.Drawing.Color.White;
            this.btnTeam.Location = new System.Drawing.Point(3, 431);
            this.btnTeam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTeam.Name = "btnTeam";
            this.btnTeam.Size = new System.Drawing.Size(444, 163);
            this.btnTeam.TabIndex = 2;
            this.btnTeam.Text = "Teams";
            this.btnTeam.UseVisualStyleBackColor = false;
            this.btnTeam.Click += new System.EventHandler(this.btnTeam_Click);
            this.btnTeam.MouseEnter += new System.EventHandler(this.btnTeam_MouseEnter);
            this.btnTeam.MouseLeave += new System.EventHandler(this.btnTeam_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.logo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(444, 248);
            this.panel4.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(121, 19);
            this.logo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(200, 211);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // btnTournament
            // 
            this.btnTournament.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTournament.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTournament.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTournament.ForeColor = System.Drawing.Color.White;
            this.btnTournament.Location = new System.Drawing.Point(3, 260);
            this.btnTournament.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTournament.Name = "btnTournament";
            this.btnTournament.Size = new System.Drawing.Size(444, 163);
            this.btnTournament.TabIndex = 1;
            this.btnTournament.Text = "Tournaments";
            this.btnTournament.UseVisualStyleBackColor = false;
            this.btnTournament.Click += new System.EventHandler(this.btnTournament_Click);
            this.btnTournament.MouseEnter += new System.EventHandler(this.btnTournament_MouseEnter);
            this.btnTournament.MouseLeave += new System.EventHandler(this.btnTournament_MouseLeave);
            // 
            // pnlComponent
            // 
            this.pnlComponent.Controls.Add(this.txtSearch);
            this.pnlComponent.Controls.Add(this.btnAdd);
            this.pnlComponent.Controls.Add(this.componentList);
            this.pnlComponent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlComponent.Location = new System.Drawing.Point(450, 188);
            this.pnlComponent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlComponent.Name = "pnlComponent";
            this.pnlComponent.Size = new System.Drawing.Size(1105, 941);
            this.pnlComponent.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(622, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 39);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(949, 7);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 55);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // componentList
            // 
            this.componentList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.componentList.AutoScroll = true;
            this.componentList.Location = new System.Drawing.Point(6, 68);
            this.componentList.Name = "componentList";
            this.componentList.Size = new System.Drawing.Size(1105, 870);
            this.componentList.TabIndex = 0;
            // 
            // Main_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 1129);
            this.Controls.Add(this.pnlComponent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.heading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Screen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_screen_FormClosing);
            this.Load += new System.EventHandler(this.Main_screen_Load);
            this.SizeChanged += new System.EventHandler(this.Main_screen_SizeChanged);
            this.heading.ResumeLayout(false);
            this.heading.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.pnlComponent.ResumeLayout(false);
            this.pnlComponent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel heading;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel pnlComponent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button btnCoach;
        private System.Windows.Forms.Button btnPlayer;
        private System.Windows.Forms.Button btnTeam;
        private System.Windows.Forms.Button btnTournament;
        private System.Windows.Forms.FlowLayoutPanel componentList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearch;
    }
}