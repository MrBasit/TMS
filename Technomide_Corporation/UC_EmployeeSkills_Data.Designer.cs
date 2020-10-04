namespace Technomide_Corporation
{
    partial class UC_EmployeeSkills_Data
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
            this.label_employee_name = new System.Windows.Forms.Label();
            this.label_skill_name = new System.Windows.Forms.Label();
            this.label_emp_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_employee_name
            // 
            this.label_employee_name.AutoSize = true;
            this.label_employee_name.BackColor = System.Drawing.Color.White;
            this.label_employee_name.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_employee_name.Location = new System.Drawing.Point(4, 0);
            this.label_employee_name.Name = "label_employee_name";
            this.label_employee_name.Size = new System.Drawing.Size(100, 18);
            this.label_employee_name.TabIndex = 126;
            this.label_employee_name.Text = "Employee Name";
            // 
            // label_skill_name
            // 
            this.label_skill_name.AutoSize = true;
            this.label_skill_name.BackColor = System.Drawing.Color.White;
            this.label_skill_name.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_skill_name.Location = new System.Drawing.Point(171, 0);
            this.label_skill_name.Name = "label_skill_name";
            this.label_skill_name.Size = new System.Drawing.Size(69, 18);
            this.label_skill_name.TabIndex = 125;
            this.label_skill_name.Text = "Skill Name";
            // 
            // label_emp_name
            // 
            this.label_emp_name.AutoSize = true;
            this.label_emp_name.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_emp_name.Location = new System.Drawing.Point(4, 8);
            this.label_emp_name.Name = "label_emp_name";
            this.label_emp_name.Size = new System.Drawing.Size(365, 18);
            this.label_emp_name.TabIndex = 127;
            this.label_emp_name.Text = "___________________________________________________";
            // 
            // UC_EmployeeSkills_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_employee_name);
            this.Controls.Add(this.label_skill_name);
            this.Controls.Add(this.label_emp_name);
            this.Name = "UC_EmployeeSkills_Data";
            this.Size = new System.Drawing.Size(373, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_employee_name;
        public System.Windows.Forms.Label label_skill_name;
        private System.Windows.Forms.Label label_emp_name;
    }
}
