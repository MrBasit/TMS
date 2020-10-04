namespace Technomide_Corporation
{
    partial class UC_Project_Income_Data
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
            this.label_project_amount = new System.Windows.Forms.Label();
            this.label_project_date = new System.Windows.Forms.Label();
            this.label_project_id = new System.Windows.Forms.Label();
            this.label_project_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_projectincome_id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_project_amount
            // 
            this.label_project_amount.AutoSize = true;
            this.label_project_amount.BackColor = System.Drawing.Color.White;
            this.label_project_amount.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_project_amount.Location = new System.Drawing.Point(489, 0);
            this.label_project_amount.Name = "label_project_amount";
            this.label_project_amount.Size = new System.Drawing.Size(53, 18);
            this.label_project_amount.TabIndex = 101;
            this.label_project_amount.Text = "Amount";
            this.label_project_amount.Click += new System.EventHandler(this.label_project_amount_Click);
            // 
            // label_project_date
            // 
            this.label_project_date.AutoSize = true;
            this.label_project_date.BackColor = System.Drawing.Color.White;
            this.label_project_date.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_project_date.Location = new System.Drawing.Point(607, 0);
            this.label_project_date.Name = "label_project_date";
            this.label_project_date.Size = new System.Drawing.Size(35, 18);
            this.label_project_date.TabIndex = 100;
            this.label_project_date.Text = "Date";
            // 
            // label_project_id
            // 
            this.label_project_id.AutoSize = true;
            this.label_project_id.BackColor = System.Drawing.Color.White;
            this.label_project_id.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_project_id.Location = new System.Drawing.Point(351, 0);
            this.label_project_id.Name = "label_project_id";
            this.label_project_id.Size = new System.Drawing.Size(65, 18);
            this.label_project_id.TabIndex = 99;
            this.label_project_id.Text = "Project ID";
            this.label_project_id.Click += new System.EventHandler(this.label_project_id_Click);
            // 
            // label_project_name
            // 
            this.label_project_name.AutoSize = true;
            this.label_project_name.BackColor = System.Drawing.Color.White;
            this.label_project_name.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_project_name.Location = new System.Drawing.Point(134, 0);
            this.label_project_name.Name = "label_project_name";
            this.label_project_name.Size = new System.Drawing.Size(86, 18);
            this.label_project_name.TabIndex = 98;
            this.label_project_name.Text = "Project Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(687, 18);
            this.label1.TabIndex = 102;
            this.label1.Text = "_________________________________________________________________________________" +
    "________________";
            // 
            // label_projectincome_id
            // 
            this.label_projectincome_id.AutoSize = true;
            this.label_projectincome_id.BackColor = System.Drawing.Color.White;
            this.label_projectincome_id.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_projectincome_id.Location = new System.Drawing.Point(6, 0);
            this.label_projectincome_id.Name = "label_projectincome_id";
            this.label_projectincome_id.Size = new System.Drawing.Size(111, 18);
            this.label_projectincome_id.TabIndex = 103;
            this.label_projectincome_id.Text = "Project Income ID";
            // 
            // UC_Project_Income_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_projectincome_id);
            this.Controls.Add(this.label_project_amount);
            this.Controls.Add(this.label_project_date);
            this.Controls.Add(this.label_project_id);
            this.Controls.Add(this.label_project_name);
            this.Controls.Add(this.label1);
            this.Name = "UC_Project_Income_Data";
            this.Size = new System.Drawing.Size(681, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_project_amount;
        public System.Windows.Forms.Label label_project_date;
        public System.Windows.Forms.Label label_project_id;
        public System.Windows.Forms.Label label_project_name;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label_projectincome_id;
    }
}
