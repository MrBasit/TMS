namespace Technomide_Corporation
{
    partial class UC_Attendance_Unmarked_Data
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
            this.label_Attendance_EmpName = new System.Windows.Forms.Label();
            this.label_Attendance_Date = new System.Windows.Forms.Label();
            this.label_Attendance_EmpID = new System.Windows.Forms.Label();
            this.label_emp_name = new System.Windows.Forms.Label();
            this.txt_status_attendance = new System.Windows.Forms.ComboBox();
            this.btn_markin_attendance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Attendance_EmpName
            // 
            this.label_Attendance_EmpName.AutoSize = true;
            this.label_Attendance_EmpName.BackColor = System.Drawing.Color.White;
            this.label_Attendance_EmpName.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Attendance_EmpName.Location = new System.Drawing.Point(3, 5);
            this.label_Attendance_EmpName.Name = "label_Attendance_EmpName";
            this.label_Attendance_EmpName.Size = new System.Drawing.Size(100, 18);
            this.label_Attendance_EmpName.TabIndex = 120;
            this.label_Attendance_EmpName.Text = "Employee Name";
            // 
            // label_Attendance_Date
            // 
            this.label_Attendance_Date.AutoSize = true;
            this.label_Attendance_Date.BackColor = System.Drawing.Color.White;
            this.label_Attendance_Date.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Attendance_Date.Location = new System.Drawing.Point(313, 5);
            this.label_Attendance_Date.Name = "label_Attendance_Date";
            this.label_Attendance_Date.Size = new System.Drawing.Size(35, 18);
            this.label_Attendance_Date.TabIndex = 116;
            this.label_Attendance_Date.Text = "Date";
            // 
            // label_Attendance_EmpID
            // 
            this.label_Attendance_EmpID.AutoSize = true;
            this.label_Attendance_EmpID.BackColor = System.Drawing.Color.White;
            this.label_Attendance_EmpID.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Attendance_EmpID.Location = new System.Drawing.Point(189, 5);
            this.label_Attendance_EmpID.Name = "label_Attendance_EmpID";
            this.label_Attendance_EmpID.Size = new System.Drawing.Size(79, 18);
            this.label_Attendance_EmpID.TabIndex = 115;
            this.label_Attendance_EmpID.Text = "Employee ID";
            // 
            // label_emp_name
            // 
            this.label_emp_name.AutoSize = true;
            this.label_emp_name.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_emp_name.Location = new System.Drawing.Point(-1, 12);
            this.label_emp_name.Name = "label_emp_name";
            this.label_emp_name.Size = new System.Drawing.Size(407, 18);
            this.label_emp_name.TabIndex = 119;
            this.label_emp_name.Text = "_________________________________________________________";
            // 
            // txt_status_attendance
            // 
            this.txt_status_attendance.FormattingEnabled = true;
            this.txt_status_attendance.Items.AddRange(new object[] {
            "Absent",
            "Present",
            "Leave"});
            this.txt_status_attendance.Location = new System.Drawing.Point(412, 5);
            this.txt_status_attendance.Name = "txt_status_attendance";
            this.txt_status_attendance.Size = new System.Drawing.Size(95, 21);
            this.txt_status_attendance.TabIndex = 121;
            // 
            // btn_markin_attendance
            // 
            this.btn_markin_attendance.BackColor = System.Drawing.Color.White;
            this.btn_markin_attendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_markin_attendance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_markin_attendance.Location = new System.Drawing.Point(523, 5);
            this.btn_markin_attendance.Name = "btn_markin_attendance";
            this.btn_markin_attendance.Size = new System.Drawing.Size(75, 21);
            this.btn_markin_attendance.TabIndex = 122;
            this.btn_markin_attendance.Text = "Mark In";
            this.btn_markin_attendance.UseVisualStyleBackColor = false;
            // 
            // UC_Attendance_Unmarked_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_markin_attendance);
            this.Controls.Add(this.txt_status_attendance);
            this.Controls.Add(this.label_Attendance_EmpName);
            this.Controls.Add(this.label_Attendance_Date);
            this.Controls.Add(this.label_Attendance_EmpID);
            this.Controls.Add(this.label_emp_name);
            this.Name = "UC_Attendance_Unmarked_Data";
            this.Size = new System.Drawing.Size(609, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_Attendance_EmpName;
        public System.Windows.Forms.Label label_Attendance_Date;
        public System.Windows.Forms.Label label_Attendance_EmpID;
        private System.Windows.Forms.Label label_emp_name;
        public System.Windows.Forms.ComboBox txt_status_attendance;
        public System.Windows.Forms.Button btn_markin_attendance;
    }
}
