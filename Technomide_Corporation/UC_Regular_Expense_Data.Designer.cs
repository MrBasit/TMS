namespace Technomide_Corporation
{
    partial class UC_Regular_Expense_Data
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
            this.label_regular_amount = new System.Windows.Forms.Label();
            this.label_regular_date = new System.Windows.Forms.Label();
            this.label_regularexpense_id = new System.Windows.Forms.Label();
            this.label_emp_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_regular_amount
            // 
            this.label_regular_amount.AutoSize = true;
            this.label_regular_amount.BackColor = System.Drawing.Color.White;
            this.label_regular_amount.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_regular_amount.Location = new System.Drawing.Point(144, 0);
            this.label_regular_amount.Name = "label_regular_amount";
            this.label_regular_amount.Size = new System.Drawing.Size(53, 18);
            this.label_regular_amount.TabIndex = 118;
            this.label_regular_amount.Text = "Amount";
            // 
            // label_regular_date
            // 
            this.label_regular_date.AutoSize = true;
            this.label_regular_date.BackColor = System.Drawing.Color.White;
            this.label_regular_date.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_regular_date.Location = new System.Drawing.Point(252, 0);
            this.label_regular_date.Name = "label_regular_date";
            this.label_regular_date.Size = new System.Drawing.Size(35, 18);
            this.label_regular_date.TabIndex = 117;
            this.label_regular_date.Text = "Date";
            // 
            // label_regularexpense_id
            // 
            this.label_regularexpense_id.AutoSize = true;
            this.label_regularexpense_id.BackColor = System.Drawing.Color.White;
            this.label_regularexpense_id.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_regularexpense_id.Location = new System.Drawing.Point(12, 0);
            this.label_regularexpense_id.Name = "label_regularexpense_id";
            this.label_regularexpense_id.Size = new System.Drawing.Size(92, 18);
            this.label_regularexpense_id.TabIndex = 115;
            this.label_regularexpense_id.Text = "Regular Exp ID";
            // 
            // label_emp_name
            // 
            this.label_emp_name.AutoSize = true;
            this.label_emp_name.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_emp_name.Location = new System.Drawing.Point(3, 8);
            this.label_emp_name.Name = "label_emp_name";
            this.label_emp_name.Size = new System.Drawing.Size(344, 18);
            this.label_emp_name.TabIndex = 119;
            this.label_emp_name.Text = "________________________________________________";
            // 
            // UC_Regular_Expense_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_regular_amount);
            this.Controls.Add(this.label_regular_date);
            this.Controls.Add(this.label_regularexpense_id);
            this.Controls.Add(this.label_emp_name);
            this.Name = "UC_Regular_Expense_Data";
            this.Size = new System.Drawing.Size(350, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_regular_amount;
        public System.Windows.Forms.Label label_regular_date;
        public System.Windows.Forms.Label label_regularexpense_id;
        private System.Windows.Forms.Label label_emp_name;
    }
}
