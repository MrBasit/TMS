namespace Technomide_Corporation
{
    partial class Dashboard_form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Attendance = new System.Windows.Forms.Button();
            this.UC_Show_Unmarked_Attendance = new Technomide_Corporation.UC_GroupBox();
            this.UC_Show_Marked_Attendance = new Technomide_Corporation.UC_GroupBox();
            this.UC_Show_Total_Employees = new Technomide_Corporation.UC_GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Projects = new System.Windows.Forms.Button();
            this.UC_Show_Ongoing_Projects = new Technomide_Corporation.UC_GroupBox();
            this.UC_Show_Completed_Projects = new Technomide_Corporation.UC_GroupBox();
            this.UC_Show_Total_Projects = new Technomide_Corporation.UC_GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Employees = new System.Windows.Forms.Button();
            this.UC_Show_Remotely_Employees = new Technomide_Corporation.UC_GroupBox();
            this.UC_Show_Physical_Employees = new Technomide_Corporation.UC_GroupBox();
            this.UC_Show_Total_Employees_1 = new Technomide_Corporation.UC_GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Consultant = new System.Windows.Forms.Button();
            this.UC_Show_Inactive_Consultant = new Technomide_Corporation.UC_GroupBox();
            this.UC_Show_Active_Consultant = new Technomide_Corporation.UC_GroupBox();
            this.UC_Show_Total_Consultant = new Technomide_Corporation.UC_GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.UC_Show_Monthly_Expense = new Technomide_Corporation.UC_GroupBox();
            this.btn_Expense = new System.Windows.Forms.Button();
            this.UC_Show_Today_Expense = new Technomide_Corporation.UC_GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_Income = new System.Windows.Forms.Button();
            this.UC_Show_Project_Income = new Technomide_Corporation.UC_GroupBox();
            this.UC_Show_Academy_Income = new Technomide_Corporation.UC_GroupBox();
            this.UC_Show_Month_Income = new Technomide_Corporation.UC_GroupBox();
            this.UC_Show_Today_Income = new Technomide_Corporation.UC_GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btn_Accounts = new System.Windows.Forms.Button();
            this.UC_Show_Student_Account = new Technomide_Corporation.UC_GroupBox();
            this.UC_Show_Admin_Account = new Technomide_Corporation.UC_GroupBox();
            this.UC_Show_Owner_Account = new Technomide_Corporation.UC_GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(519, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dashboard";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Attendance);
            this.groupBox1.Controls.Add(this.UC_Show_Unmarked_Attendance);
            this.groupBox1.Controls.Add(this.UC_Show_Marked_Attendance);
            this.groupBox1.Controls.Add(this.UC_Show_Total_Employees);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1161, 65);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attendance";
            // 
            // btn_Attendance
            // 
            this.btn_Attendance.BackColor = System.Drawing.Color.White;
            this.btn_Attendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Attendance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Attendance.Location = new System.Drawing.Point(1005, 15);
            this.btn_Attendance.Name = "btn_Attendance";
            this.btn_Attendance.Size = new System.Drawing.Size(121, 44);
            this.btn_Attendance.TabIndex = 4;
            this.btn_Attendance.Text = "Visit Attendance Section";
            this.btn_Attendance.UseVisualStyleBackColor = false;
            // 
            // UC_Show_Unmarked_Attendance
            // 
            this.UC_Show_Unmarked_Attendance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC_Show_Unmarked_Attendance.Location = new System.Drawing.Point(480, 15);
            this.UC_Show_Unmarked_Attendance.Name = "UC_Show_Unmarked_Attendance";
            this.UC_Show_Unmarked_Attendance.Size = new System.Drawing.Size(193, 46);
            this.UC_Show_Unmarked_Attendance.TabIndex = 3;
            // 
            // UC_Show_Marked_Attendance
            // 
            this.UC_Show_Marked_Attendance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC_Show_Marked_Attendance.Location = new System.Drawing.Point(240, 15);
            this.UC_Show_Marked_Attendance.Name = "UC_Show_Marked_Attendance";
            this.UC_Show_Marked_Attendance.Size = new System.Drawing.Size(193, 46);
            this.UC_Show_Marked_Attendance.TabIndex = 2;
            // 
            // UC_Show_Total_Employees
            // 
            this.UC_Show_Total_Employees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC_Show_Total_Employees.Location = new System.Drawing.Point(6, 15);
            this.UC_Show_Total_Employees.Name = "UC_Show_Total_Employees";
            this.UC_Show_Total_Employees.Size = new System.Drawing.Size(193, 46);
            this.UC_Show_Total_Employees.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Projects);
            this.groupBox2.Controls.Add(this.UC_Show_Ongoing_Projects);
            this.groupBox2.Controls.Add(this.UC_Show_Completed_Projects);
            this.groupBox2.Controls.Add(this.UC_Show_Total_Projects);
            this.groupBox2.Location = new System.Drawing.Point(12, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1161, 68);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Projects";
            // 
            // btn_Projects
            // 
            this.btn_Projects.BackColor = System.Drawing.Color.White;
            this.btn_Projects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Projects.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Projects.Location = new System.Drawing.Point(1005, 16);
            this.btn_Projects.Name = "btn_Projects";
            this.btn_Projects.Size = new System.Drawing.Size(121, 44);
            this.btn_Projects.TabIndex = 5;
            this.btn_Projects.Text = "Visit Project Section";
            this.btn_Projects.UseVisualStyleBackColor = false;
            // 
            // UC_Show_Ongoing_Projects
            // 
            this.UC_Show_Ongoing_Projects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC_Show_Ongoing_Projects.Location = new System.Drawing.Point(480, 16);
            this.UC_Show_Ongoing_Projects.Name = "UC_Show_Ongoing_Projects";
            this.UC_Show_Ongoing_Projects.Size = new System.Drawing.Size(193, 46);
            this.UC_Show_Ongoing_Projects.TabIndex = 3;
            // 
            // UC_Show_Completed_Projects
            // 
            this.UC_Show_Completed_Projects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC_Show_Completed_Projects.Location = new System.Drawing.Point(240, 16);
            this.UC_Show_Completed_Projects.Name = "UC_Show_Completed_Projects";
            this.UC_Show_Completed_Projects.Size = new System.Drawing.Size(193, 46);
            this.UC_Show_Completed_Projects.TabIndex = 2;
            // 
            // UC_Show_Total_Projects
            // 
            this.UC_Show_Total_Projects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC_Show_Total_Projects.Location = new System.Drawing.Point(6, 16);
            this.UC_Show_Total_Projects.Name = "UC_Show_Total_Projects";
            this.UC_Show_Total_Projects.Size = new System.Drawing.Size(193, 46);
            this.UC_Show_Total_Projects.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Employees);
            this.groupBox3.Controls.Add(this.UC_Show_Remotely_Employees);
            this.groupBox3.Controls.Add(this.UC_Show_Physical_Employees);
            this.groupBox3.Controls.Add(this.UC_Show_Total_Employees_1);
            this.groupBox3.Location = new System.Drawing.Point(12, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1161, 68);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Employees";
            // 
            // btn_Employees
            // 
            this.btn_Employees.BackColor = System.Drawing.Color.White;
            this.btn_Employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Employees.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Employees.Location = new System.Drawing.Point(1005, 16);
            this.btn_Employees.Name = "btn_Employees";
            this.btn_Employees.Size = new System.Drawing.Size(121, 44);
            this.btn_Employees.TabIndex = 6;
            this.btn_Employees.Text = "Visit Employee Section";
            this.btn_Employees.UseVisualStyleBackColor = false;
            // 
            // UC_Show_Remotely_Employees
            // 
            this.UC_Show_Remotely_Employees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC_Show_Remotely_Employees.Location = new System.Drawing.Point(480, 16);
            this.UC_Show_Remotely_Employees.Name = "UC_Show_Remotely_Employees";
            this.UC_Show_Remotely_Employees.Size = new System.Drawing.Size(193, 46);
            this.UC_Show_Remotely_Employees.TabIndex = 3;
            // 
            // UC_Show_Physical_Employees
            // 
            this.UC_Show_Physical_Employees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC_Show_Physical_Employees.Location = new System.Drawing.Point(240, 16);
            this.UC_Show_Physical_Employees.Name = "UC_Show_Physical_Employees";
            this.UC_Show_Physical_Employees.Size = new System.Drawing.Size(193, 46);
            this.UC_Show_Physical_Employees.TabIndex = 2;
            // 
            // UC_Show_Total_Employees_1
            // 
            this.UC_Show_Total_Employees_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC_Show_Total_Employees_1.Location = new System.Drawing.Point(6, 16);
            this.UC_Show_Total_Employees_1.Name = "UC_Show_Total_Employees_1";
            this.UC_Show_Total_Employees_1.Size = new System.Drawing.Size(193, 46);
            this.UC_Show_Total_Employees_1.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Consultant);
            this.groupBox4.Controls.Add(this.UC_Show_Inactive_Consultant);
            this.groupBox4.Controls.Add(this.UC_Show_Active_Consultant);
            this.groupBox4.Controls.Add(this.UC_Show_Total_Consultant);
            this.groupBox4.Location = new System.Drawing.Point(12, 257);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1161, 68);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Consultant";
            // 
            // btn_Consultant
            // 
            this.btn_Consultant.BackColor = System.Drawing.Color.White;
            this.btn_Consultant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Consultant.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Consultant.Location = new System.Drawing.Point(1005, 16);
            this.btn_Consultant.Name = "btn_Consultant";
            this.btn_Consultant.Size = new System.Drawing.Size(121, 44);
            this.btn_Consultant.TabIndex = 7;
            this.btn_Consultant.Text = "Visit Consultant Section";
            this.btn_Consultant.UseVisualStyleBackColor = false;
            // 
            // UC_Show_Inactive_Consultant
            // 
            this.UC_Show_Inactive_Consultant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC_Show_Inactive_Consultant.Location = new System.Drawing.Point(480, 16);
            this.UC_Show_Inactive_Consultant.Name = "UC_Show_Inactive_Consultant";
            this.UC_Show_Inactive_Consultant.Size = new System.Drawing.Size(193, 46);
            this.UC_Show_Inactive_Consultant.TabIndex = 3;
            // 
            // UC_Show_Active_Consultant
            // 
            this.UC_Show_Active_Consultant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC_Show_Active_Consultant.Location = new System.Drawing.Point(240, 16);
            this.UC_Show_Active_Consultant.Name = "UC_Show_Active_Consultant";
            this.UC_Show_Active_Consultant.Size = new System.Drawing.Size(193, 46);
            this.UC_Show_Active_Consultant.TabIndex = 2;
            // 
            // UC_Show_Total_Consultant
            // 
            this.UC_Show_Total_Consultant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC_Show_Total_Consultant.Location = new System.Drawing.Point(6, 16);
            this.UC_Show_Total_Consultant.Name = "UC_Show_Total_Consultant";
            this.UC_Show_Total_Consultant.Size = new System.Drawing.Size(193, 46);
            this.UC_Show_Total_Consultant.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.UC_Show_Monthly_Expense);
            this.groupBox5.Controls.Add(this.btn_Expense);
            this.groupBox5.Controls.Add(this.UC_Show_Today_Expense);
            this.groupBox5.Location = new System.Drawing.Point(12, 325);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1161, 68);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Expenses";
            // 
            // UC_Show_Monthly_Expense
            // 
            this.UC_Show_Monthly_Expense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC_Show_Monthly_Expense.Location = new System.Drawing.Point(240, 16);
            this.UC_Show_Monthly_Expense.Name = "UC_Show_Monthly_Expense";
            this.UC_Show_Monthly_Expense.Size = new System.Drawing.Size(193, 46);
            this.UC_Show_Monthly_Expense.TabIndex = 2;
            // 
            // btn_Expense
            // 
            this.btn_Expense.BackColor = System.Drawing.Color.White;
            this.btn_Expense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Expense.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Expense.Location = new System.Drawing.Point(1005, 16);
            this.btn_Expense.Name = "btn_Expense";
            this.btn_Expense.Size = new System.Drawing.Size(121, 46);
            this.btn_Expense.TabIndex = 8;
            this.btn_Expense.Text = "Visit Expense Section";
            this.btn_Expense.UseVisualStyleBackColor = false;
            // 
            // UC_Show_Today_Expense
            // 
            this.UC_Show_Today_Expense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC_Show_Today_Expense.Location = new System.Drawing.Point(6, 16);
            this.UC_Show_Today_Expense.Name = "UC_Show_Today_Expense";
            this.UC_Show_Today_Expense.Size = new System.Drawing.Size(193, 46);
            this.UC_Show_Today_Expense.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_Income);
            this.groupBox6.Controls.Add(this.UC_Show_Project_Income);
            this.groupBox6.Controls.Add(this.UC_Show_Academy_Income);
            this.groupBox6.Controls.Add(this.UC_Show_Month_Income);
            this.groupBox6.Controls.Add(this.UC_Show_Today_Income);
            this.groupBox6.Location = new System.Drawing.Point(12, 393);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1161, 71);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Income";
            // 
            // btn_Income
            // 
            this.btn_Income.BackColor = System.Drawing.Color.White;
            this.btn_Income.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Income.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Income.Location = new System.Drawing.Point(1005, 18);
            this.btn_Income.Name = "btn_Income";
            this.btn_Income.Size = new System.Drawing.Size(121, 47);
            this.btn_Income.TabIndex = 9;
            this.btn_Income.Text = "Visit Income Section";
            this.btn_Income.UseVisualStyleBackColor = false;
            // 
            // UC_Show_Project_Income
            // 
            this.UC_Show_Project_Income.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC_Show_Project_Income.Location = new System.Drawing.Point(708, 18);
            this.UC_Show_Project_Income.Name = "UC_Show_Project_Income";
            this.UC_Show_Project_Income.Size = new System.Drawing.Size(193, 47);
            this.UC_Show_Project_Income.TabIndex = 4;
            // 
            // UC_Show_Academy_Income
            // 
            this.UC_Show_Academy_Income.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC_Show_Academy_Income.Location = new System.Drawing.Point(480, 18);
            this.UC_Show_Academy_Income.Name = "UC_Show_Academy_Income";
            this.UC_Show_Academy_Income.Size = new System.Drawing.Size(193, 47);
            this.UC_Show_Academy_Income.TabIndex = 3;
            // 
            // UC_Show_Month_Income
            // 
            this.UC_Show_Month_Income.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC_Show_Month_Income.Location = new System.Drawing.Point(240, 18);
            this.UC_Show_Month_Income.Name = "UC_Show_Month_Income";
            this.UC_Show_Month_Income.Size = new System.Drawing.Size(193, 47);
            this.UC_Show_Month_Income.TabIndex = 2;
            // 
            // UC_Show_Today_Income
            // 
            this.UC_Show_Today_Income.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC_Show_Today_Income.Location = new System.Drawing.Point(6, 18);
            this.UC_Show_Today_Income.Name = "UC_Show_Today_Income";
            this.UC_Show_Today_Income.Size = new System.Drawing.Size(193, 47);
            this.UC_Show_Today_Income.TabIndex = 1;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btn_Accounts);
            this.groupBox7.Controls.Add(this.UC_Show_Student_Account);
            this.groupBox7.Controls.Add(this.UC_Show_Admin_Account);
            this.groupBox7.Controls.Add(this.UC_Show_Owner_Account);
            this.groupBox7.Location = new System.Drawing.Point(12, 467);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1161, 77);
            this.groupBox7.TabIndex = 14;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Account";
            // 
            // btn_Accounts
            // 
            this.btn_Accounts.BackColor = System.Drawing.Color.White;
            this.btn_Accounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Accounts.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Accounts.Location = new System.Drawing.Point(1005, 19);
            this.btn_Accounts.Name = "btn_Accounts";
            this.btn_Accounts.Size = new System.Drawing.Size(121, 50);
            this.btn_Accounts.TabIndex = 8;
            this.btn_Accounts.Text = "Visit Account Section";
            this.btn_Accounts.UseVisualStyleBackColor = false;
            // 
            // UC_Show_Student_Account
            // 
            this.UC_Show_Student_Account.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC_Show_Student_Account.Location = new System.Drawing.Point(480, 19);
            this.UC_Show_Student_Account.Name = "UC_Show_Student_Account";
            this.UC_Show_Student_Account.Size = new System.Drawing.Size(193, 50);
            this.UC_Show_Student_Account.TabIndex = 3;
            // 
            // UC_Show_Admin_Account
            // 
            this.UC_Show_Admin_Account.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC_Show_Admin_Account.Location = new System.Drawing.Point(240, 19);
            this.UC_Show_Admin_Account.Name = "UC_Show_Admin_Account";
            this.UC_Show_Admin_Account.Size = new System.Drawing.Size(193, 50);
            this.UC_Show_Admin_Account.TabIndex = 2;
            // 
            // UC_Show_Owner_Account
            // 
            this.UC_Show_Owner_Account.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC_Show_Owner_Account.Location = new System.Drawing.Point(6, 19);
            this.UC_Show_Owner_Account.Name = "UC_Show_Owner_Account";
            this.UC_Show_Owner_Account.Size = new System.Drawing.Size(193, 50);
            this.UC_Show_Owner_Account.TabIndex = 1;
            // 
            // Dashboard_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1185, 642);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard_form";
            this.Text = "Dashboard_form";
            this.Load += new System.EventHandler(this.Dashboard_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private UC_GroupBox UC_Show_Unmarked_Attendance;
        private UC_GroupBox UC_Show_Marked_Attendance;
        private UC_GroupBox UC_Show_Total_Employees;
        private System.Windows.Forms.GroupBox groupBox2;
        private UC_GroupBox UC_Show_Ongoing_Projects;
        private UC_GroupBox UC_Show_Completed_Projects;
        private UC_GroupBox UC_Show_Total_Projects;
        private System.Windows.Forms.GroupBox groupBox3;
        private UC_GroupBox UC_Show_Remotely_Employees;
        private UC_GroupBox UC_Show_Physical_Employees;
        private UC_GroupBox UC_Show_Total_Employees_1;
        private System.Windows.Forms.GroupBox groupBox4;
        private UC_GroupBox UC_Show_Inactive_Consultant;
        private UC_GroupBox UC_Show_Active_Consultant;
        private UC_GroupBox UC_Show_Total_Consultant;
        private System.Windows.Forms.GroupBox groupBox5;
        private UC_GroupBox UC_Show_Monthly_Expense;
        private UC_GroupBox UC_Show_Today_Expense;
        private System.Windows.Forms.GroupBox groupBox6;
        private UC_GroupBox UC_Show_Academy_Income;
        private UC_GroupBox UC_Show_Month_Income;
        private UC_GroupBox UC_Show_Today_Income;
        private System.Windows.Forms.GroupBox groupBox7;
        private UC_GroupBox UC_Show_Student_Account;
        private UC_GroupBox UC_Show_Admin_Account;
        private UC_GroupBox UC_Show_Owner_Account;
        private UC_GroupBox UC_Show_Project_Income;
        public System.Windows.Forms.Button btn_Attendance;
        public System.Windows.Forms.Button btn_Projects;
        public System.Windows.Forms.Button btn_Employees;
        public System.Windows.Forms.Button btn_Consultant;
        public System.Windows.Forms.Button btn_Expense;
        public System.Windows.Forms.Button btn_Income;
        public System.Windows.Forms.Button btn_Accounts;
    }
}