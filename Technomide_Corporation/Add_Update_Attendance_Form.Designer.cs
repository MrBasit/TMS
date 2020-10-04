namespace Technomide_Corporation
{
    partial class Add_Update_Attendance_Form
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
            this.panel_modify_attendance = new System.Windows.Forms.Panel();
            this.txt_attendance_date = new System.Windows.Forms.DateTimePicker();
            this.txt_attendance_empid = new System.Windows.Forms.TextBox();
            this.txt_attendance_empname = new System.Windows.Forms.TextBox();
            this.txt_attendance_status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_attendance_outtime = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_attendance_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_attendance_intime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_update_attendance = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_modify_attendance.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_modify_attendance
            // 
            this.panel_modify_attendance.Controls.Add(this.txt_attendance_date);
            this.panel_modify_attendance.Controls.Add(this.txt_attendance_empid);
            this.panel_modify_attendance.Controls.Add(this.txt_attendance_empname);
            this.panel_modify_attendance.Controls.Add(this.txt_attendance_status);
            this.panel_modify_attendance.Controls.Add(this.label7);
            this.panel_modify_attendance.Controls.Add(this.label3);
            this.panel_modify_attendance.Controls.Add(this.txt_attendance_outtime);
            this.panel_modify_attendance.Controls.Add(this.label10);
            this.panel_modify_attendance.Controls.Add(this.txt_attendance_id);
            this.panel_modify_attendance.Controls.Add(this.label1);
            this.panel_modify_attendance.Controls.Add(this.label2);
            this.panel_modify_attendance.Controls.Add(this.txt_attendance_intime);
            this.panel_modify_attendance.Controls.Add(this.label4);
            this.panel_modify_attendance.Controls.Add(this.label5);
            this.panel_modify_attendance.Controls.Add(this.btn_update_attendance);
            this.panel_modify_attendance.Location = new System.Drawing.Point(66, 62);
            this.panel_modify_attendance.Name = "panel_modify_attendance";
            this.panel_modify_attendance.Size = new System.Drawing.Size(255, 277);
            this.panel_modify_attendance.TabIndex = 138;
            // 
            // txt_attendance_date
            // 
            this.txt_attendance_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_attendance_date.Location = new System.Drawing.Point(121, 109);
            this.txt_attendance_date.Name = "txt_attendance_date";
            this.txt_attendance_date.Size = new System.Drawing.Size(131, 20);
            this.txt_attendance_date.TabIndex = 149;
            // 
            // txt_attendance_empid
            // 
            this.txt_attendance_empid.BackColor = System.Drawing.Color.White;
            this.txt_attendance_empid.Location = new System.Drawing.Point(121, 81);
            this.txt_attendance_empid.Name = "txt_attendance_empid";
            this.txt_attendance_empid.Size = new System.Drawing.Size(131, 20);
            this.txt_attendance_empid.TabIndex = 148;
            // 
            // txt_attendance_empname
            // 
            this.txt_attendance_empname.BackColor = System.Drawing.Color.White;
            this.txt_attendance_empname.Location = new System.Drawing.Point(121, 54);
            this.txt_attendance_empname.Name = "txt_attendance_empname";
            this.txt_attendance_empname.Size = new System.Drawing.Size(131, 20);
            this.txt_attendance_empname.TabIndex = 147;
            // 
            // txt_attendance_status
            // 
            this.txt_attendance_status.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_attendance_status.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_attendance_status.DisplayMember = "Std_ID";
            this.txt_attendance_status.FormattingEnabled = true;
            this.txt_attendance_status.Location = new System.Drawing.Point(121, 187);
            this.txt_attendance_status.Name = "txt_attendance_status";
            this.txt_attendance_status.Size = new System.Drawing.Size(131, 21);
            this.txt_attendance_status.TabIndex = 146;
            this.txt_attendance_status.ValueMember = "Std_ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 18);
            this.label7.TabIndex = 144;
            this.label7.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 142;
            this.label3.Text = "Outtime";
            // 
            // txt_attendance_outtime
            // 
            this.txt_attendance_outtime.BackColor = System.Drawing.Color.White;
            this.txt_attendance_outtime.Location = new System.Drawing.Point(121, 161);
            this.txt_attendance_outtime.Name = "txt_attendance_outtime";
            this.txt_attendance_outtime.Size = new System.Drawing.Size(131, 20);
            this.txt_attendance_outtime.TabIndex = 141;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 18);
            this.label10.TabIndex = 140;
            this.label10.Text = "Attendance ID";
            // 
            // txt_attendance_id
            // 
            this.txt_attendance_id.BackColor = System.Drawing.Color.White;
            this.txt_attendance_id.Location = new System.Drawing.Point(121, 28);
            this.txt_attendance_id.Name = "txt_attendance_id";
            this.txt_attendance_id.Size = new System.Drawing.Size(131, 20);
            this.txt_attendance_id.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 129;
            this.label1.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 134;
            this.label2.Text = "Intime";
            // 
            // txt_attendance_intime
            // 
            this.txt_attendance_intime.BackColor = System.Drawing.Color.White;
            this.txt_attendance_intime.Location = new System.Drawing.Point(121, 135);
            this.txt_attendance_intime.Name = "txt_attendance_intime";
            this.txt_attendance_intime.Size = new System.Drawing.Size(131, 20);
            this.txt_attendance_intime.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 130;
            this.label4.Text = "Employee ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 18);
            this.label5.TabIndex = 131;
            this.label5.Text = "Date";
            // 
            // btn_update_attendance
            // 
            this.btn_update_attendance.BackColor = System.Drawing.Color.White;
            this.btn_update_attendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_attendance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_attendance.Location = new System.Drawing.Point(86, 239);
            this.btn_update_attendance.Name = "btn_update_attendance";
            this.btn_update_attendance.Size = new System.Drawing.Size(83, 35);
            this.btn_update_attendance.TabIndex = 5;
            this.btn_update_attendance.Text = "Update";
            this.btn_update_attendance.UseVisualStyleBackColor = false;
            this.btn_update_attendance.Click += new System.EventHandler(this.btn_update_attendance_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 27);
            this.label6.TabIndex = 139;
            this.label6.Text = "Update Attendance";
            // 
            // Add_Update_Attendance_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 351);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel_modify_attendance);
            this.Name = "Add_Update_Attendance_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Update_Attendance_Form";
            this.Load += new System.EventHandler(this.Add_Update_Attendance_Form_Load);
            this.panel_modify_attendance.ResumeLayout(false);
            this.panel_modify_attendance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_modify_attendance;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_attendance_id;
        public System.Windows.Forms.TextBox txt_attendance_intime;
        public System.Windows.Forms.Button btn_update_attendance;
        public System.Windows.Forms.ComboBox txt_attendance_status;
        public System.Windows.Forms.TextBox txt_attendance_outtime;
        public System.Windows.Forms.TextBox txt_attendance_empid;
        public System.Windows.Forms.TextBox txt_attendance_empname;
        public System.Windows.Forms.DateTimePicker txt_attendance_date;
    }
}