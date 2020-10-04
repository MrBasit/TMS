namespace Technomide_Corporation
{
    partial class UC_Withdrawal_Data
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
            this.label_withdrawal_name = new System.Windows.Forms.Label();
            this.label_withdrawal_amount = new System.Windows.Forms.Label();
            this.label_withdrawal_date = new System.Windows.Forms.Label();
            this.label_emp_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_withdrawal_name
            // 
            this.label_withdrawal_name.AutoSize = true;
            this.label_withdrawal_name.BackColor = System.Drawing.Color.White;
            this.label_withdrawal_name.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_withdrawal_name.Location = new System.Drawing.Point(16, 0);
            this.label_withdrawal_name.Name = "label_withdrawal_name";
            this.label_withdrawal_name.Size = new System.Drawing.Size(41, 18);
            this.label_withdrawal_name.TabIndex = 124;
            this.label_withdrawal_name.Text = "Name";
            // 
            // label_withdrawal_amount
            // 
            this.label_withdrawal_amount.AutoSize = true;
            this.label_withdrawal_amount.BackColor = System.Drawing.Color.White;
            this.label_withdrawal_amount.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_withdrawal_amount.Location = new System.Drawing.Point(172, 0);
            this.label_withdrawal_amount.Name = "label_withdrawal_amount";
            this.label_withdrawal_amount.Size = new System.Drawing.Size(53, 18);
            this.label_withdrawal_amount.TabIndex = 122;
            this.label_withdrawal_amount.Text = "Amount";
            // 
            // label_withdrawal_date
            // 
            this.label_withdrawal_date.AutoSize = true;
            this.label_withdrawal_date.BackColor = System.Drawing.Color.White;
            this.label_withdrawal_date.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_withdrawal_date.Location = new System.Drawing.Point(303, 0);
            this.label_withdrawal_date.Name = "label_withdrawal_date";
            this.label_withdrawal_date.Size = new System.Drawing.Size(35, 18);
            this.label_withdrawal_date.TabIndex = 120;
            this.label_withdrawal_date.Text = "Date";
            // 
            // label_emp_name
            // 
            this.label_emp_name.AutoSize = true;
            this.label_emp_name.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_emp_name.Location = new System.Drawing.Point(7, 8);
            this.label_emp_name.Name = "label_emp_name";
            this.label_emp_name.Size = new System.Drawing.Size(400, 18);
            this.label_emp_name.TabIndex = 123;
            this.label_emp_name.Text = "________________________________________________________";
            // 
            // UC_Withdrawal_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_withdrawal_name);
            this.Controls.Add(this.label_withdrawal_amount);
            this.Controls.Add(this.label_withdrawal_date);
            this.Controls.Add(this.label_emp_name);
            this.Name = "UC_Withdrawal_Data";
            this.Size = new System.Drawing.Size(419, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_withdrawal_name;
        public System.Windows.Forms.Label label_withdrawal_amount;
        public System.Windows.Forms.Label label_withdrawal_date;
        private System.Windows.Forms.Label label_emp_name;
    }
}
