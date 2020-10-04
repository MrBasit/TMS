namespace Technomide_Corporation
{
    partial class UC_Salary_Expense_Data
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
            this.label_salaryexpense_id = new System.Windows.Forms.Label();
            this.label_salary_amount = new System.Windows.Forms.Label();
            this.label_salary_date = new System.Windows.Forms.Label();
            this.label_salary_emp_name = new System.Windows.Forms.Label();
            this.label_emp_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_salaryexpense_id
            // 
            this.label_salaryexpense_id.AutoSize = true;
            this.label_salaryexpense_id.BackColor = System.Drawing.Color.White;
            this.label_salaryexpense_id.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_salaryexpense_id.Location = new System.Drawing.Point(16, 0);
            this.label_salaryexpense_id.Name = "label_salaryexpense_id";
            this.label_salaryexpense_id.Size = new System.Drawing.Size(84, 18);
            this.label_salaryexpense_id.TabIndex = 119;
            this.label_salaryexpense_id.Text = "Salary Exp ID";
            // 
            // label_salary_amount
            // 
            this.label_salary_amount.AutoSize = true;
            this.label_salary_amount.BackColor = System.Drawing.Color.White;
            this.label_salary_amount.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_salary_amount.Location = new System.Drawing.Point(352, 0);
            this.label_salary_amount.Name = "label_salary_amount";
            this.label_salary_amount.Size = new System.Drawing.Size(53, 18);
            this.label_salary_amount.TabIndex = 117;
            this.label_salary_amount.Text = "Amount";
            // 
            // label_salary_date
            // 
            this.label_salary_date.AutoSize = true;
            this.label_salary_date.BackColor = System.Drawing.Color.White;
            this.label_salary_date.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_salary_date.Location = new System.Drawing.Point(462, 0);
            this.label_salary_date.Name = "label_salary_date";
            this.label_salary_date.Size = new System.Drawing.Size(35, 18);
            this.label_salary_date.TabIndex = 116;
            this.label_salary_date.Text = "Date";
            // 
            // label_salary_emp_name
            // 
            this.label_salary_emp_name.AutoSize = true;
            this.label_salary_emp_name.BackColor = System.Drawing.Color.White;
            this.label_salary_emp_name.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_salary_emp_name.Location = new System.Drawing.Point(129, 0);
            this.label_salary_emp_name.Name = "label_salary_emp_name";
            this.label_salary_emp_name.Size = new System.Drawing.Size(100, 18);
            this.label_salary_emp_name.TabIndex = 115;
            this.label_salary_emp_name.Text = "Employee Name";
            // 
            // label_emp_name
            // 
            this.label_emp_name.AutoSize = true;
            this.label_emp_name.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_emp_name.Location = new System.Drawing.Point(7, 8);
            this.label_emp_name.Name = "label_emp_name";
            this.label_emp_name.Size = new System.Drawing.Size(547, 18);
            this.label_emp_name.TabIndex = 118;
            this.label_emp_name.Text = "_____________________________________________________________________________";
            // 
            // UC_Salary_Expense_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_salaryexpense_id);
            this.Controls.Add(this.label_salary_amount);
            this.Controls.Add(this.label_salary_date);
            this.Controls.Add(this.label_salary_emp_name);
            this.Controls.Add(this.label_emp_name);
            this.Name = "UC_Salary_Expense_Data";
            this.Size = new System.Drawing.Size(560, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_salaryexpense_id;
        public System.Windows.Forms.Label label_salary_amount;
        public System.Windows.Forms.Label label_salary_date;
        public System.Windows.Forms.Label label_salary_emp_name;
        private System.Windows.Forms.Label label_emp_name;
    }
}
