namespace Technomide_Corporation
{
    partial class UC_Academy_Income_Data
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
            this.label_std_amount = new System.Windows.Forms.Label();
            this.label_std_date = new System.Windows.Forms.Label();
            this.label_std_name = new System.Windows.Forms.Label();
            this.label_std_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_academyincome_id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_std_amount
            // 
            this.label_std_amount.AutoSize = true;
            this.label_std_amount.BackColor = System.Drawing.Color.White;
            this.label_std_amount.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_std_amount.Location = new System.Drawing.Point(403, 0);
            this.label_std_amount.Name = "label_std_amount";
            this.label_std_amount.Size = new System.Drawing.Size(53, 18);
            this.label_std_amount.TabIndex = 106;
            this.label_std_amount.Text = "Amount";
            // 
            // label_std_date
            // 
            this.label_std_date.AutoSize = true;
            this.label_std_date.BackColor = System.Drawing.Color.White;
            this.label_std_date.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_std_date.Location = new System.Drawing.Point(516, 0);
            this.label_std_date.Name = "label_std_date";
            this.label_std_date.Size = new System.Drawing.Size(35, 18);
            this.label_std_date.TabIndex = 105;
            this.label_std_date.Text = "Date";
            // 
            // label_std_name
            // 
            this.label_std_name.AutoSize = true;
            this.label_std_name.BackColor = System.Drawing.Color.White;
            this.label_std_name.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_std_name.Location = new System.Drawing.Point(240, 0);
            this.label_std_name.Name = "label_std_name";
            this.label_std_name.Size = new System.Drawing.Size(90, 18);
            this.label_std_name.TabIndex = 104;
            this.label_std_name.Text = "Student Name";
            this.label_std_name.Click += new System.EventHandler(this.label_project_id_Click);
            // 
            // label_std_id
            // 
            this.label_std_id.AutoSize = true;
            this.label_std_id.BackColor = System.Drawing.Color.White;
            this.label_std_id.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_std_id.Location = new System.Drawing.Point(145, 0);
            this.label_std_id.Name = "label_std_id";
            this.label_std_id.Size = new System.Drawing.Size(69, 18);
            this.label_std_id.TabIndex = 103;
            this.label_std_id.Text = "Student ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 18);
            this.label1.TabIndex = 107;
            this.label1.Text = "_________________________________________________________________________________" +
    "_____";
            // 
            // label_academyincome_id
            // 
            this.label_academyincome_id.AutoSize = true;
            this.label_academyincome_id.BackColor = System.Drawing.Color.White;
            this.label_academyincome_id.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_academyincome_id.Location = new System.Drawing.Point(6, 0);
            this.label_academyincome_id.Name = "label_academyincome_id";
            this.label_academyincome_id.Size = new System.Drawing.Size(122, 18);
            this.label_academyincome_id.TabIndex = 108;
            this.label_academyincome_id.Text = "Academy Income ID";
            // 
            // UC_Academy_Income_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_academyincome_id);
            this.Controls.Add(this.label_std_amount);
            this.Controls.Add(this.label_std_date);
            this.Controls.Add(this.label_std_name);
            this.Controls.Add(this.label_std_id);
            this.Controls.Add(this.label1);
            this.Name = "UC_Academy_Income_Data";
            this.Size = new System.Drawing.Size(681, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_std_amount;
        public System.Windows.Forms.Label label_std_date;
        public System.Windows.Forms.Label label_std_name;
        public System.Windows.Forms.Label label_std_id;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label_academyincome_id;
    }
}
