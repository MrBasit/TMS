namespace Technomide_Corporation
{
    partial class UC_Project_Expense_Data
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
            this.label_projectexpense_id = new System.Windows.Forms.Label();
            this.label_project_amount = new System.Windows.Forms.Label();
            this.label_project_date = new System.Windows.Forms.Label();
            this.label_project_emp_name = new System.Windows.Forms.Label();
            this.label_project_name = new System.Windows.Forms.Label();
            this.label_emp_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_projectexpense_id
            // 
            this.label_projectexpense_id.AutoSize = true;
            this.label_projectexpense_id.BackColor = System.Drawing.Color.White;
            this.label_projectexpense_id.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_projectexpense_id.Location = new System.Drawing.Point(16, 0);
            this.label_projectexpense_id.Name = "label_projectexpense_id";
            this.label_projectexpense_id.Size = new System.Drawing.Size(90, 18);
            this.label_projectexpense_id.TabIndex = 114;
            this.label_projectexpense_id.Text = "Project Exp ID";
            // 
            // label_project_amount
            // 
            this.label_project_amount.AutoSize = true;
            this.label_project_amount.BackColor = System.Drawing.Color.White;
            this.label_project_amount.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_project_amount.Location = new System.Drawing.Point(546, 0);
            this.label_project_amount.Name = "label_project_amount";
            this.label_project_amount.Size = new System.Drawing.Size(53, 18);
            this.label_project_amount.TabIndex = 112;
            this.label_project_amount.Text = "Amount";
            // 
            // label_project_date
            // 
            this.label_project_date.AutoSize = true;
            this.label_project_date.BackColor = System.Drawing.Color.White;
            this.label_project_date.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_project_date.Location = new System.Drawing.Point(640, 0);
            this.label_project_date.Name = "label_project_date";
            this.label_project_date.Size = new System.Drawing.Size(35, 18);
            this.label_project_date.TabIndex = 111;
            this.label_project_date.Text = "Date";
            // 
            // label_project_emp_name
            // 
            this.label_project_emp_name.AutoSize = true;
            this.label_project_emp_name.BackColor = System.Drawing.Color.White;
            this.label_project_emp_name.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_project_emp_name.Location = new System.Drawing.Point(350, 0);
            this.label_project_emp_name.Name = "label_project_emp_name";
            this.label_project_emp_name.Size = new System.Drawing.Size(100, 18);
            this.label_project_emp_name.TabIndex = 110;
            this.label_project_emp_name.Text = "Employee Name";
            // 
            // label_project_name
            // 
            this.label_project_name.AutoSize = true;
            this.label_project_name.BackColor = System.Drawing.Color.White;
            this.label_project_name.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_project_name.Location = new System.Drawing.Point(112, 0);
            this.label_project_name.Name = "label_project_name";
            this.label_project_name.Size = new System.Drawing.Size(86, 18);
            this.label_project_name.TabIndex = 109;
            this.label_project_name.Text = "Project Name";
            // 
            // label_emp_name
            // 
            this.label_emp_name.AutoSize = true;
            this.label_emp_name.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_emp_name.Location = new System.Drawing.Point(3, 8);
            this.label_emp_name.Name = "label_emp_name";
            this.label_emp_name.Size = new System.Drawing.Size(729, 18);
            this.label_emp_name.TabIndex = 113;
            this.label_emp_name.Text = "_________________________________________________________________________________" +
    "______________________";
            // 
            // UC_Project_Expense_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_projectexpense_id);
            this.Controls.Add(this.label_project_amount);
            this.Controls.Add(this.label_project_date);
            this.Controls.Add(this.label_project_emp_name);
            this.Controls.Add(this.label_project_name);
            this.Controls.Add(this.label_emp_name);
            this.Name = "UC_Project_Expense_Data";
            this.Size = new System.Drawing.Size(728, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_projectexpense_id;
        public System.Windows.Forms.Label label_project_amount;
        public System.Windows.Forms.Label label_project_date;
        public System.Windows.Forms.Label label_project_emp_name;
        public System.Windows.Forms.Label label_project_name;
        private System.Windows.Forms.Label label_emp_name;
    }
}
