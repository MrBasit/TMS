namespace Technomide_Corporation
{
    partial class Owner_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Owner_Form));
            this.panel_top_bar = new System.Windows.Forms.Panel();
            this.LogOut_Button = new System.Windows.Forms.Button();
            this.pic_burger_menu = new System.Windows.Forms.PictureBox();
            this.label_UserName = new System.Windows.Forms.Label();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.UC_About_Menu = new Technomide_Corporation.UC_Menu();
            this.UC_withdrawl_Menu = new Technomide_Corporation.UC_Menu();
            this.UC_login_Meun = new Technomide_Corporation.UC_Menu();
            this.UC_Income_Menu = new Technomide_Corporation.UC_Menu();
            this.UC_Expense_Menu = new Technomide_Corporation.UC_Menu();
            this.UC_PROJECTS_MENU = new Technomide_Corporation.UC_Menu();
            this.UC_CONSULTANT_MENU = new Technomide_Corporation.UC_Menu();
            this.UC_Employee_Menu = new Technomide_Corporation.UC_Menu();
            this.UC_Attendance_Menu = new Technomide_Corporation.UC_Menu();
            this.UC_Dashboard_Menu = new Technomide_Corporation.UC_Menu();
            this.panel_top_bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_burger_menu)).BeginInit();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top_bar
            // 
            this.panel_top_bar.BackColor = System.Drawing.Color.Transparent;
            this.panel_top_bar.Controls.Add(this.LogOut_Button);
            this.panel_top_bar.Controls.Add(this.pic_burger_menu);
            this.panel_top_bar.Controls.Add(this.label_UserName);
            this.panel_top_bar.Location = new System.Drawing.Point(12, 12);
            this.panel_top_bar.Name = "panel_top_bar";
            this.panel_top_bar.Size = new System.Drawing.Size(1192, 37);
            this.panel_top_bar.TabIndex = 0;
            // 
            // LogOut_Button
            // 
            this.LogOut_Button.BackColor = System.Drawing.Color.White;
            this.LogOut_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut_Button.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut_Button.Location = new System.Drawing.Point(1074, 7);
            this.LogOut_Button.Name = "LogOut_Button";
            this.LogOut_Button.Size = new System.Drawing.Size(75, 23);
            this.LogOut_Button.TabIndex = 3;
            this.LogOut_Button.Text = "Logout";
            this.LogOut_Button.UseVisualStyleBackColor = false;
            this.LogOut_Button.Click += new System.EventHandler(this.LogOut_Button_Click_1);
            // 
            // pic_burger_menu
            // 
            this.pic_burger_menu.BackColor = System.Drawing.Color.White;
            this.pic_burger_menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_burger_menu.BackgroundImage")));
            this.pic_burger_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_burger_menu.Location = new System.Drawing.Point(3, 3);
            this.pic_burger_menu.Name = "pic_burger_menu";
            this.pic_burger_menu.Size = new System.Drawing.Size(36, 30);
            this.pic_burger_menu.TabIndex = 2;
            this.pic_burger_menu.TabStop = false;
            this.pic_burger_menu.Click += new System.EventHandler(this.pic_burger_menu_Click);
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.BackColor = System.Drawing.Color.Transparent;
            this.label_UserName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserName.Location = new System.Drawing.Point(906, 8);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(98, 19);
            this.label_UserName.TabIndex = 0;
            this.label_UserName.Text = "Shaikhoo1999";
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.Transparent;
            this.panel_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_menu.Controls.Add(this.UC_About_Menu);
            this.panel_menu.Controls.Add(this.UC_withdrawl_Menu);
            this.panel_menu.Controls.Add(this.UC_login_Meun);
            this.panel_menu.Controls.Add(this.UC_Income_Menu);
            this.panel_menu.Controls.Add(this.UC_Expense_Menu);
            this.panel_menu.Controls.Add(this.UC_PROJECTS_MENU);
            this.panel_menu.Controls.Add(this.UC_CONSULTANT_MENU);
            this.panel_menu.Controls.Add(this.UC_Employee_Menu);
            this.panel_menu.Controls.Add(this.UC_Attendance_Menu);
            this.panel_menu.Controls.Add(this.UC_Dashboard_Menu);
            this.panel_menu.Controls.Add(this.pictureBox2);
            this.panel_menu.Location = new System.Drawing.Point(12, 55);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(200, 592);
            this.panel_menu.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 75);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel_main
            // 
            this.panel_main.AutoScroll = true;
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_main.Location = new System.Drawing.Point(12, 55);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1192, 609);
            this.panel_main.TabIndex = 2;
            // 
            // UC_About_Menu
            // 
            this.UC_About_Menu.BackColor = System.Drawing.Color.White;
            this.UC_About_Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC_About_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UC_About_Menu.Location = new System.Drawing.Point(0, 345);
            this.UC_About_Menu.Name = "UC_About_Menu";
            this.UC_About_Menu.Size = new System.Drawing.Size(200, 31);
            this.UC_About_Menu.TabIndex = 10;
            this.UC_About_Menu.Load += new System.EventHandler(this.UC_About_Menu_Load);
            this.UC_About_Menu.Click += new System.EventHandler(this.UC_About_Menu_Click);
            // 
            // UC_withdrawl_Menu
            // 
            this.UC_withdrawl_Menu.BackColor = System.Drawing.Color.White;
            this.UC_withdrawl_Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC_withdrawl_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UC_withdrawl_Menu.Location = new System.Drawing.Point(0, 315);
            this.UC_withdrawl_Menu.Name = "UC_withdrawl_Menu";
            this.UC_withdrawl_Menu.Size = new System.Drawing.Size(200, 31);
            this.UC_withdrawl_Menu.TabIndex = 9;
            this.UC_withdrawl_Menu.Click += new System.EventHandler(this.UC_withdrawl_Menu_Click);
            // 
            // UC_login_Meun
            // 
            this.UC_login_Meun.BackColor = System.Drawing.Color.White;
            this.UC_login_Meun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC_login_Meun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UC_login_Meun.Location = new System.Drawing.Point(0, 285);
            this.UC_login_Meun.Name = "UC_login_Meun";
            this.UC_login_Meun.Size = new System.Drawing.Size(200, 31);
            this.UC_login_Meun.TabIndex = 8;
            this.UC_login_Meun.Click += new System.EventHandler(this.UC_login_Meun_Click);
            // 
            // UC_Income_Menu
            // 
            this.UC_Income_Menu.BackColor = System.Drawing.Color.White;
            this.UC_Income_Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC_Income_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UC_Income_Menu.Location = new System.Drawing.Point(0, 255);
            this.UC_Income_Menu.Name = "UC_Income_Menu";
            this.UC_Income_Menu.Size = new System.Drawing.Size(200, 31);
            this.UC_Income_Menu.TabIndex = 7;
            this.UC_Income_Menu.Click += new System.EventHandler(this.UC_Income_Menu_Click);
            // 
            // UC_Expense_Menu
            // 
            this.UC_Expense_Menu.BackColor = System.Drawing.Color.White;
            this.UC_Expense_Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC_Expense_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UC_Expense_Menu.Location = new System.Drawing.Point(0, 225);
            this.UC_Expense_Menu.Name = "UC_Expense_Menu";
            this.UC_Expense_Menu.Size = new System.Drawing.Size(200, 31);
            this.UC_Expense_Menu.TabIndex = 6;
            this.UC_Expense_Menu.Click += new System.EventHandler(this.UC_Expense_Menu_Click);
            // 
            // UC_PROJECTS_MENU
            // 
            this.UC_PROJECTS_MENU.BackColor = System.Drawing.Color.White;
            this.UC_PROJECTS_MENU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC_PROJECTS_MENU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UC_PROJECTS_MENU.Location = new System.Drawing.Point(0, 195);
            this.UC_PROJECTS_MENU.Name = "UC_PROJECTS_MENU";
            this.UC_PROJECTS_MENU.Size = new System.Drawing.Size(200, 31);
            this.UC_PROJECTS_MENU.TabIndex = 5;
            this.UC_PROJECTS_MENU.Click += new System.EventHandler(this.UC_PROJECTS_MENU_Click);
            // 
            // UC_CONSULTANT_MENU
            // 
            this.UC_CONSULTANT_MENU.BackColor = System.Drawing.Color.White;
            this.UC_CONSULTANT_MENU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC_CONSULTANT_MENU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UC_CONSULTANT_MENU.Location = new System.Drawing.Point(0, 165);
            this.UC_CONSULTANT_MENU.Name = "UC_CONSULTANT_MENU";
            this.UC_CONSULTANT_MENU.Size = new System.Drawing.Size(200, 31);
            this.UC_CONSULTANT_MENU.TabIndex = 4;
            this.UC_CONSULTANT_MENU.Click += new System.EventHandler(this.UC_CONSULTANT_MENU_Click);
            // 
            // UC_Employee_Menu
            // 
            this.UC_Employee_Menu.BackColor = System.Drawing.Color.White;
            this.UC_Employee_Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC_Employee_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UC_Employee_Menu.Location = new System.Drawing.Point(0, 135);
            this.UC_Employee_Menu.Name = "UC_Employee_Menu";
            this.UC_Employee_Menu.Size = new System.Drawing.Size(200, 31);
            this.UC_Employee_Menu.TabIndex = 3;
            this.UC_Employee_Menu.Click += new System.EventHandler(this.UC_Employee_Menu_Click);
            // 
            // UC_Attendance_Menu
            // 
            this.UC_Attendance_Menu.BackColor = System.Drawing.Color.White;
            this.UC_Attendance_Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC_Attendance_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UC_Attendance_Menu.Location = new System.Drawing.Point(0, 105);
            this.UC_Attendance_Menu.Name = "UC_Attendance_Menu";
            this.UC_Attendance_Menu.Size = new System.Drawing.Size(200, 31);
            this.UC_Attendance_Menu.TabIndex = 2;
            this.UC_Attendance_Menu.Click += new System.EventHandler(this.UC_Attendance_Menu_Click);
            // 
            // UC_Dashboard_Menu
            // 
            this.UC_Dashboard_Menu.BackColor = System.Drawing.Color.White;
            this.UC_Dashboard_Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC_Dashboard_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UC_Dashboard_Menu.Location = new System.Drawing.Point(0, 75);
            this.UC_Dashboard_Menu.Name = "UC_Dashboard_Menu";
            this.UC_Dashboard_Menu.Size = new System.Drawing.Size(200, 30);
            this.UC_Dashboard_Menu.TabIndex = 1;
            this.UC_Dashboard_Menu.Click += new System.EventHandler(this.UC_Dashboard_Menu_Click);
            // 
            // Owner_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1216, 673);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel_top_bar);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Owner_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Owner";
            this.Load += new System.EventHandler(this.Owner_Load);
            this.panel_top_bar.ResumeLayout(false);
            this.panel_top_bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_burger_menu)).EndInit();
            this.panel_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top_bar;
        private System.Windows.Forms.PictureBox pic_burger_menu;
        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.PictureBox pictureBox2;
        private UC_Menu UC_PROJECTS_MENU;
        private UC_Menu UC_CONSULTANT_MENU;
        private UC_Menu UC_Employee_Menu;
        private UC_Menu UC_Attendance_Menu;
        private UC_Menu UC_Dashboard_Menu;
        private System.Windows.Forms.Button LogOut_Button;
        private UC_Menu UC_About_Menu;
        private UC_Menu UC_withdrawl_Menu;
        private UC_Menu UC_login_Meun;
        private UC_Menu UC_Income_Menu;
        private UC_Menu UC_Expense_Menu;
    }
}