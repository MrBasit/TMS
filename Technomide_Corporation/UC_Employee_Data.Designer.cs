namespace Technomide_Corporation
{
    partial class UC_Employee_Data
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
            this.label_employee_salary = new System.Windows.Forms.Label();
            this.label_employee_type = new System.Windows.Forms.Label();
            this.label_employee_id = new System.Windows.Forms.Label();
            this.label_employee_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_employee_salary
            // 
            this.label_employee_salary.AutoSize = true;
            this.label_employee_salary.BackColor = System.Drawing.Color.White;
            this.label_employee_salary.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_employee_salary.Location = new System.Drawing.Point(465, 0);
            this.label_employee_salary.Name = "label_employee_salary";
            this.label_employee_salary.Size = new System.Drawing.Size(43, 18);
            this.label_employee_salary.TabIndex = 91;
            this.label_employee_salary.Text = "Salary";
            // 
            // label_employee_type
            // 
            this.label_employee_type.AutoSize = true;
            this.label_employee_type.BackColor = System.Drawing.Color.White;
            this.label_employee_type.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_employee_type.Location = new System.Drawing.Point(330, 0);
            this.label_employee_type.Name = "label_employee_type";
            this.label_employee_type.Size = new System.Drawing.Size(94, 18);
            this.label_employee_type.TabIndex = 90;
            this.label_employee_type.Text = "Employee Type";
            // 
            // label_employee_id
            // 
            this.label_employee_id.AutoSize = true;
            this.label_employee_id.BackColor = System.Drawing.Color.White;
            this.label_employee_id.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_employee_id.Location = new System.Drawing.Point(175, 0);
            this.label_employee_id.Name = "label_employee_id";
            this.label_employee_id.Size = new System.Drawing.Size(79, 18);
            this.label_employee_id.TabIndex = 89;
            this.label_employee_id.Text = "Employee ID";
            // 
            // label_employee_name
            // 
            this.label_employee_name.AutoSize = true;
            this.label_employee_name.BackColor = System.Drawing.Color.White;
            this.label_employee_name.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_employee_name.Location = new System.Drawing.Point(5, 0);
            this.label_employee_name.Name = "label_employee_name";
            this.label_employee_name.Size = new System.Drawing.Size(100, 18);
            this.label_employee_name.TabIndex = 88;
            this.label_employee_name.Text = "Employee Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 18);
            this.label1.TabIndex = 92;
            this.label1.Text = "_____________________________________________________________________________";
            // 
            // UC_Employee_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_employee_salary);
            this.Controls.Add(this.label_employee_type);
            this.Controls.Add(this.label_employee_id);
            this.Controls.Add(this.label_employee_name);
            this.Controls.Add(this.label1);
            this.Name = "UC_Employee_Data";
            this.Size = new System.Drawing.Size(555, 26);
            this.Load += new System.EventHandler(this.UC_Employee_Data_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_employee_salary;
        public System.Windows.Forms.Label label_employee_type;
        public System.Windows.Forms.Label label_employee_id;
        public System.Windows.Forms.Label label_employee_name;
        private System.Windows.Forms.Label label1;
    }
}
