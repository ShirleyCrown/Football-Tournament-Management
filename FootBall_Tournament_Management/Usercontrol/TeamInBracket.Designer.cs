﻿namespace FootBall_Tournament_Management
{
    partial class TeamInBracket
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ckbTeamName = new System.Windows.Forms.CheckBox();
            this.detail = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.detail.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckbTeamName
            // 
            this.ckbTeamName.AutoSize = true;
            this.ckbTeamName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTeamName.Location = new System.Drawing.Point(28, 14);
            this.ckbTeamName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckbTeamName.Name = "ckbTeamName";
            this.ckbTeamName.Size = new System.Drawing.Size(104, 34);
            this.ckbTeamName.TabIndex = 0;
            this.ckbTeamName.Text = "None";
            this.ckbTeamName.UseVisualStyleBackColor = true;
            // 
            // detail
            // 
            this.detail.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.detail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetail});
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(185, 36);
            // 
            // showDetail
            // 
            this.showDetail.Name = "showDetail";
            this.showDetail.Size = new System.Drawing.Size(184, 32);
            this.showDetail.Text = "Show details";
            this.showDetail.Click += new System.EventHandler(this.showDetail_Click);
            // 
            // TeamInBracket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ckbTeamName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TeamInBracket";
            this.Size = new System.Drawing.Size(302, 71);
            this.Load += new System.EventHandler(this.TeamInBracket_Load);
            this.detail.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox ckbTeamName;
        private System.Windows.Forms.ContextMenuStrip detail;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showDetail;
    }
}
