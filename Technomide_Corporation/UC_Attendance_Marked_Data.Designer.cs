namespace Technomide_Corporation
{
    partial class UC_Attendance_Marked_Data
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
            this.btn_markout_attendance = new System.Windows.Forms.Button();
            this.label_Attendance_EmpName = new System.Windows.Forms.Label();
            this.label_Attendance_EmpID = new System.Windows.Forms.Label();
            this.label_emp_name = new System.Windows.Forms.Label();
            this.label_Attendance_Status = new System.Windows.Forms.Label();
            this.label_Attendance_Date = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_markout_attendance
            // 
            this.btn_markout_attendance.BackColor = System.Drawing.Color.White;
            this.btn_markout_attendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_markout_attendance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_markout_attendance.Location = new System.Drawing.Point(511, 2);
            this.btn_markout_attendance.Name = "btn_markout_attendance";
            this.btn_markout_attendance.Size = new System.Drawing.Size(75, 21);
            this.btn_markout_attendance.TabIndex = 128;
            this.btn_markout_attendance.Text = "Mark Out";
            this.btn_markout_attendance.UseVisualStyleBackColor = false;
            // 
            // label_Attendance_EmpName
            // 
            this.label_Attendance_EmpName.AutoSize = true;
            this.label_Attendance_EmpName.BackColor = System.Drawing.Color.White;
            this.label_Attendance_EmpName.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Attendance_EmpName.Location = new System.Drawing.Point(3, 3);
            this.label_Attendance_EmpName.Name = "label_Attendance_EmpName";
            this.label_Attendance_EmpName.Size = new System.Drawing.Size(100, 18);
            this.label_Attendance_EmpName.TabIndex = 126;
            this.label_Attendance_EmpName.Text = "Employee Name";
            // 
            // label_Attendance_EmpID
            // 
            this.label_Attendance_EmpID.AutoSize = true;
            this.label_Attendance_EmpID.BackColor = System.Drawing.Color.White;
            this.label_Attendance_EmpID.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Attendance_EmpID.Location = new System.Drawing.Point(193, 3);
            this.label_Attendance_EmpID.Name = "label_Attendance_EmpID";
            this.label_Attendance_EmpID.Size = new System.Drawing.Size(79, 18);
            this.label_Attendance_EmpID.TabIndex = 123;
            this.label_Attendance_EmpID.Text = "Employee ID";
            // 
            // label_emp_name
            // 
            this.label_emp_name.AutoSize = true;
            this.label_emp_name.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_emp_name.Location = new System.Drawing.Point(0, 10);
            this.label_emp_name.Name = "label_emp_name";
            this.label_emp_name.Size = new System.Drawing.Size(491, 18);
            this.label_emp_name.TabIndex = 125;
            this.label_emp_name.Text = "_____________________________________________________________________";
            // 
            // label_Attendance_Status
            // 
            this.label_Attendance_Status.AutoSize = true;
            this.label_Attendance_Status.BackColor = System.Drawing.Color.White;
            this.label_Attendance_Status.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Attendance_Status.Location = new System.Drawing.Point(431, 3);
            this.label_Attendance_Status.Name = "label_Attendance_Status";
            this.label_Attendance_Status.Size = new System.Drawing.Size(45, 18);
            this.label_Attendance_Status.TabIndex = 129;
            this.label_Attendance_Status.Text = "Status";
            // 
            // label_Attendance_Date
            // 
            this.label_Attendance_Date.AutoSize = true;
            this.label_Attendance_Date.BackColor = System.Drawing.Color.White;
            this.label_Attendance_Date.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Attendance_Date.Location = new System.Drawing.Point(311, 3);
            this.label_Attendance_Date.Name = "label_Attendance_Date";
            this.label_Attendance_Date.Size = new System.Drawing.Size(35, 18);
            this.label_Attendance_Date.TabIndex = 124;
            this.label_Attendance_Date.Text = "Date";
            // 
            // UC_Attendance_Marked_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_Attendance_Status);
            this.Controls.Add(this.btn_markout_attendance);
            this.Controls.Add(this.label_Attendance_EmpName);
            this.Controls.Add(this.label_Attendance_Date);
            this.Controls.Add(this.label_Attendance_EmpID);
            this.Controls.Add(this.label_emp_name);
            this.Name = "UC_Attendance_Marked_Data";
            this.Size = new System.Drawing.Size(598, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label_Attendance_EmpName;
        public System.Windows.Forms.Label label_Attendance_EmpID;
        private System.Windows.Forms.Label label_emp_name;
        public System.Windows.Forms.Label label_Attendance_Status;
        public System.Windows.Forms.Button btn_markout_attendance;
        public System.Windows.Forms.Label label_Attendance_Date;
    }
}
