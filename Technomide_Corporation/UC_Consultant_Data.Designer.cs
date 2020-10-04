namespace Technomide_Corporation
{
    partial class UC_Consultant_Data
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
            this.label_cons_phone2 = new System.Windows.Forms.Label();
            this.label_cons_phone1 = new System.Windows.Forms.Label();
            this.label_cons_id = new System.Windows.Forms.Label();
            this.label_cons_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_cons_phone2
            // 
            this.label_cons_phone2.AutoSize = true;
            this.label_cons_phone2.BackColor = System.Drawing.Color.White;
            this.label_cons_phone2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cons_phone2.Location = new System.Drawing.Point(458, 0);
            this.label_cons_phone2.Name = "label_cons_phone2";
            this.label_cons_phone2.Size = new System.Drawing.Size(53, 18);
            this.label_cons_phone2.TabIndex = 101;
            this.label_cons_phone2.Text = "Phone 2";
            // 
            // label_cons_phone1
            // 
            this.label_cons_phone1.AutoSize = true;
            this.label_cons_phone1.BackColor = System.Drawing.Color.White;
            this.label_cons_phone1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cons_phone1.Location = new System.Drawing.Point(343, 0);
            this.label_cons_phone1.Name = "label_cons_phone1";
            this.label_cons_phone1.Size = new System.Drawing.Size(53, 18);
            this.label_cons_phone1.TabIndex = 100;
            this.label_cons_phone1.Text = "Phone 1";
            // 
            // label_cons_id
            // 
            this.label_cons_id.AutoSize = true;
            this.label_cons_id.BackColor = System.Drawing.Color.White;
            this.label_cons_id.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cons_id.Location = new System.Drawing.Point(200, 0);
            this.label_cons_id.Name = "label_cons_id";
            this.label_cons_id.Size = new System.Drawing.Size(86, 18);
            this.label_cons_id.TabIndex = 99;
            this.label_cons_id.Text = "Consultant ID";
            // 
            // label_cons_name
            // 
            this.label_cons_name.AutoSize = true;
            this.label_cons_name.BackColor = System.Drawing.Color.White;
            this.label_cons_name.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cons_name.Location = new System.Drawing.Point(3, 0);
            this.label_cons_name.Name = "label_cons_name";
            this.label_cons_name.Size = new System.Drawing.Size(107, 18);
            this.label_cons_name.TabIndex = 98;
            this.label_cons_name.Text = "Consultant Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(575, 18);
            this.label1.TabIndex = 102;
            this.label1.Text = "_________________________________________________________________________________" +
    "";
            // 
            // UC_Consultant_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_cons_phone2);
            this.Controls.Add(this.label_cons_phone1);
            this.Controls.Add(this.label_cons_id);
            this.Controls.Add(this.label_cons_name);
            this.Controls.Add(this.label1);
            this.Name = "UC_Consultant_Data";
            this.Size = new System.Drawing.Size(580, 26);
            this.Load += new System.EventHandler(this.UC_Consultant_Data_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_cons_phone2;
        public System.Windows.Forms.Label label_cons_phone1;
        public System.Windows.Forms.Label label_cons_id;
        public System.Windows.Forms.Label label_cons_name;
        private System.Windows.Forms.Label label1;
    }
}
