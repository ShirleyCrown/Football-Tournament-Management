namespace FootBall_Tournament_Management
{
    partial class Component
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
            this.name = new System.Windows.Forms.Label();
            this.avatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(20, 230);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(257, 32);
            this.name.TabIndex = 1;
            this.name.Text = "Component Name";
            // 
            // avatar
            // 
            this.avatar.BackColor = System.Drawing.Color.White;
            this.avatar.Location = new System.Drawing.Point(40, 25);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(208, 178);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatar.TabIndex = 0;
            this.avatar.TabStop = false;
            this.avatar.SizeChanged += new System.EventHandler(this.avatar_SizeChanged);
            // 
            // Component
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.name);
            this.Controls.Add(this.avatar);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "Component";
            this.Size = new System.Drawing.Size(295, 295);
            this.Load += new System.EventHandler(this.Component_Load);
            this.Click += new System.EventHandler(this.Component_Click);
            this.MouseLeave += new System.EventHandler(this.Component_MouseLeave);
            this.MouseHover += new System.EventHandler(this.Component_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Label name;
    }
}
