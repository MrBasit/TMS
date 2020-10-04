namespace Technomide_Corporation
{
    partial class Login_form
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
            this.label_rollofuser = new System.Windows.Forms.Label();
            this.label_employee_type = new System.Windows.Forms.Label();
            this.label_employee_id = new System.Windows.Forms.Label();
            this.label_employee_name = new System.Windows.Forms.Label();
            this.panel_data = new System.Windows.Forms.Panel();
            this.label_add_login_account = new System.Windows.Forms.Label();
            this.picture_add_login_account = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_add_login_account)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login Info";
            // 
            // label_rollofuser
            // 
            this.label_rollofuser.AutoSize = true;
            this.label_rollofuser.BackColor = System.Drawing.Color.White;
            this.label_rollofuser.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rollofuser.Location = new System.Drawing.Point(547, 145);
            this.label_rollofuser.Name = "label_rollofuser";
            this.label_rollofuser.Size = new System.Drawing.Size(66, 18);
            this.label_rollofuser.TabIndex = 100;
            this.label_rollofuser.Text = "User Role";
            // 
            // label_employee_type
            // 
            this.label_employee_type.AutoSize = true;
            this.label_employee_type.BackColor = System.Drawing.Color.White;
            this.label_employee_type.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_employee_type.Location = new System.Drawing.Point(353, 145);
            this.label_employee_type.Name = "label_employee_type";
            this.label_employee_type.Size = new System.Drawing.Size(65, 18);
            this.label_employee_type.TabIndex = 99;
            this.label_employee_type.Text = "Password";
            // 
            // label_employee_id
            // 
            this.label_employee_id.AutoSize = true;
            this.label_employee_id.BackColor = System.Drawing.Color.White;
            this.label_employee_id.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_employee_id.Location = new System.Drawing.Point(149, 145);
            this.label_employee_id.Name = "label_employee_id";
            this.label_employee_id.Size = new System.Drawing.Size(69, 18);
            this.label_employee_id.TabIndex = 98;
            this.label_employee_id.Text = "Username";
            // 
            // label_employee_name
            // 
            this.label_employee_name.AutoSize = true;
            this.label_employee_name.BackColor = System.Drawing.Color.White;
            this.label_employee_name.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_employee_name.Location = new System.Drawing.Point(12, 145);
            this.label_employee_name.Name = "label_employee_name";
            this.label_employee_name.Size = new System.Drawing.Size(57, 18);
            this.label_employee_name.TabIndex = 97;
            this.label_employee_name.Text = "Login ID";
            // 
            // panel_data
            // 
            this.panel_data.AutoScroll = true;
            this.panel_data.BackColor = System.Drawing.Color.White;
            this.panel_data.Location = new System.Drawing.Point(9, 166);
            this.panel_data.Name = "panel_data";
            this.panel_data.Size = new System.Drawing.Size(796, 391);
            this.panel_data.TabIndex = 96;
            // 
            // label_add_login_account
            // 
            this.label_add_login_account.AutoSize = true;
            this.label_add_login_account.BackColor = System.Drawing.Color.White;
            this.label_add_login_account.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_add_login_account.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_add_login_account.Location = new System.Drawing.Point(41, 95);
            this.label_add_login_account.Name = "label_add_login_account";
            this.label_add_login_account.Size = new System.Drawing.Size(122, 18);
            this.label_add_login_account.TabIndex = 101;
            this.label_add_login_account.Text = "Add Login Account";
            this.label_add_login_account.Click += new System.EventHandler(this.label_add_login_account_Click);
            // 
            // picture_add_login_account
            // 
            this.picture_add_login_account.BackColor = System.Drawing.Color.White;
            this.picture_add_login_account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_add_login_account.Image = global::Technomide_Corporation.Properties.Resources.Add;
            this.picture_add_login_account.Location = new System.Drawing.Point(15, 95);
            this.picture_add_login_account.Name = "picture_add_login_account";
            this.picture_add_login_account.Size = new System.Drawing.Size(20, 18);
            this.picture_add_login_account.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_add_login_account.TabIndex = 102;
            this.picture_add_login_account.TabStop = false;
            this.picture_add_login_account.Click += new System.EventHandler(this.picture_add_login_account_Click);
            // 
            // Login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(817, 570);
            this.Controls.Add(this.picture_add_login_account);
            this.Controls.Add(this.label_add_login_account);
            this.Controls.Add(this.label_rollofuser);
            this.Controls.Add(this.label_employee_type);
            this.Controls.Add(this.label_employee_id);
            this.Controls.Add(this.label_employee_name);
            this.Controls.Add(this.panel_data);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_form";
            this.Text = "Login_form";
            this.Load += new System.EventHandler(this.Login_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_add_login_account)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label_rollofuser;
        public System.Windows.Forms.Label label_employee_type;
        public System.Windows.Forms.Label label_employee_id;
        public System.Windows.Forms.Label label_employee_name;
        private System.Windows.Forms.Panel panel_data;
        public System.Windows.Forms.PictureBox picture_add_login_account;
        public System.Windows.Forms.Label label_add_login_account;
    }
}