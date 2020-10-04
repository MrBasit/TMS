namespace Technomide_Corporation
{
    partial class UC_Login_Info_Data
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
            this.label_login_id = new System.Windows.Forms.Label();
            this.label_login_password = new System.Windows.Forms.Label();
            this.label_login_userrole = new System.Windows.Forms.Label();
            this.label_login_username = new System.Windows.Forms.Label();
            this.label_emp_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_login_id
            // 
            this.label_login_id.AutoSize = true;
            this.label_login_id.BackColor = System.Drawing.Color.White;
            this.label_login_id.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login_id.Location = new System.Drawing.Point(10, 0);
            this.label_login_id.Name = "label_login_id";
            this.label_login_id.Size = new System.Drawing.Size(56, 18);
            this.label_login_id.TabIndex = 124;
            this.label_login_id.Text = "Login ID";
            // 
            // label_login_password
            // 
            this.label_login_password.AutoSize = true;
            this.label_login_password.BackColor = System.Drawing.Color.White;
            this.label_login_password.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login_password.Location = new System.Drawing.Point(352, 0);
            this.label_login_password.Name = "label_login_password";
            this.label_login_password.Size = new System.Drawing.Size(61, 18);
            this.label_login_password.TabIndex = 122;
            this.label_login_password.Text = "Password";
            // 
            // label_login_userrole
            // 
            this.label_login_userrole.AutoSize = true;
            this.label_login_userrole.BackColor = System.Drawing.Color.White;
            this.label_login_userrole.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login_userrole.Location = new System.Drawing.Point(539, 0);
            this.label_login_userrole.Name = "label_login_userrole";
            this.label_login_userrole.Size = new System.Drawing.Size(62, 18);
            this.label_login_userrole.TabIndex = 121;
            this.label_login_userrole.Text = "User Role";
            // 
            // label_login_username
            // 
            this.label_login_username.AutoSize = true;
            this.label_login_username.BackColor = System.Drawing.Color.White;
            this.label_login_username.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login_username.Location = new System.Drawing.Point(140, 0);
            this.label_login_username.Name = "label_login_username";
            this.label_login_username.Size = new System.Drawing.Size(66, 18);
            this.label_login_username.TabIndex = 120;
            this.label_login_username.Text = "Username";
            // 
            // label_emp_name
            // 
            this.label_emp_name.AutoSize = true;
            this.label_emp_name.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_emp_name.Location = new System.Drawing.Point(7, 8);
            this.label_emp_name.Name = "label_emp_name";
            this.label_emp_name.Size = new System.Drawing.Size(645, 18);
            this.label_emp_name.TabIndex = 123;
            this.label_emp_name.Text = "_________________________________________________________________________________" +
    "__________";
            // 
            // UC_Login_Info_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_login_id);
            this.Controls.Add(this.label_login_password);
            this.Controls.Add(this.label_login_userrole);
            this.Controls.Add(this.label_login_username);
            this.Controls.Add(this.label_emp_name);
            this.Name = "UC_Login_Info_Data";
            this.Size = new System.Drawing.Size(656, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_login_id;
        public System.Windows.Forms.Label label_login_password;
        public System.Windows.Forms.Label label_login_userrole;
        public System.Windows.Forms.Label label_login_username;
        private System.Windows.Forms.Label label_emp_name;
    }
}
