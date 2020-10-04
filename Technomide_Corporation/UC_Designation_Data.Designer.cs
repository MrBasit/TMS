namespace Technomide_Corporation
{
    partial class UC_Designation_Data
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
            this.label_designation_id = new System.Windows.Forms.Label();
            this.label_designation_name = new System.Windows.Forms.Label();
            this.label_emp_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_designation_id
            // 
            this.label_designation_id.AutoSize = true;
            this.label_designation_id.BackColor = System.Drawing.Color.White;
            this.label_designation_id.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_designation_id.Location = new System.Drawing.Point(3, 0);
            this.label_designation_id.Name = "label_designation_id";
            this.label_designation_id.Size = new System.Drawing.Size(93, 18);
            this.label_designation_id.TabIndex = 97;
            this.label_designation_id.Text = "Designation ID";
            // 
            // label_designation_name
            // 
            this.label_designation_name.AutoSize = true;
            this.label_designation_name.BackColor = System.Drawing.Color.White;
            this.label_designation_name.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_designation_name.Location = new System.Drawing.Point(108, 0);
            this.label_designation_name.Name = "label_designation_name";
            this.label_designation_name.Size = new System.Drawing.Size(114, 18);
            this.label_designation_name.TabIndex = 96;
            this.label_designation_name.Text = "Designation Name";
            // 
            // label_emp_name
            // 
            this.label_emp_name.AutoSize = true;
            this.label_emp_name.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_emp_name.Location = new System.Drawing.Point(3, 8);
            this.label_emp_name.Name = "label_emp_name";
            this.label_emp_name.Size = new System.Drawing.Size(365, 18);
            this.label_emp_name.TabIndex = 124;
            this.label_emp_name.Text = "___________________________________________________";
            // 
            // UC_Designation_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_designation_id);
            this.Controls.Add(this.label_designation_name);
            this.Controls.Add(this.label_emp_name);
            this.Name = "UC_Designation_Data";
            this.Size = new System.Drawing.Size(373, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_designation_id;
        public System.Windows.Forms.Label label_designation_name;
        private System.Windows.Forms.Label label_emp_name;
    }
}
