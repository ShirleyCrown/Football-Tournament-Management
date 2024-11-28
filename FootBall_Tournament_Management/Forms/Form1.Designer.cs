namespace FootBall_Tournament_Management
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new DevComponents.DotNetBar.ButtonX();
            this.lblError = new DevComponents.DotNetBar.LabelX();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(311, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "FootBall Tournament Management";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.HighlightText;
            // 
            // 
            // 
            this.txtUsername.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtUsername.Border.BorderBottomColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBarBackground2;
            this.txtUsername.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtUsername.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtUsername.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtUsername.Border.Class = "TextBoxBorder";
            this.txtUsername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUsername.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUsername.Location = new System.Drawing.Point(306, 104);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PreventEnterBeep = true;
            this.txtUsername.Size = new System.Drawing.Size(415, 47);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.WatermarkImage = ((System.Drawing.Image)(resources.GetObject("txtUsername.WatermarkImage")));
            this.txtUsername.WatermarkText = " Enter Users name: ";
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtPassword.Border.BorderBottomColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBarBackground2;
            this.txtPassword.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtPassword.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtPassword.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtPassword.Border.Class = "TextBoxBorder";
            this.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPassword.Location = new System.Drawing.Point(306, 200);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PreventEnterBeep = true;
            this.txtPassword.Size = new System.Drawing.Size(415, 47);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.WatermarkImage = ((System.Drawing.Image)(resources.GetObject("txtPassword.WatermarkImage")));
            this.txtPassword.WatermarkText = " Enter Password:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(406, 288);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 550);
            this.panel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLogin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLogin.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(306, 299);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(407, 48);
            this.btnLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextColor = System.Drawing.Color.Black;
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblError.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblError.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblError.Location = new System.Drawing.Point(392, 372);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(256, 23);
            this.lblError.TabIndex = 7;
            this.lblError.Text = "<b></b>Tên đăng nhập hoặc mật khẩu bị sai\r\n";
            this.lblError.TextAlignment = System.Drawing.StringAlignment.Center;
            this.lblError.Click += new System.EventHandler(this.labelX1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1848, 761);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Football Tournament Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUsername;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPassword;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX btnLogin;
        private DevComponents.DotNetBar.LabelX lblError;
    }
}

