namespace Technomide_Corporation
{
    partial class Manage_Skills_Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_skill_name = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label_employee_id = new System.Windows.Forms.Label();
            this.label_employee_name = new System.Windows.Forms.Label();
            this.panel_data = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_skill_name
            // 
            this.txt_skill_name.BackColor = System.Drawing.Color.White;
            this.txt_skill_name.Location = new System.Drawing.Point(15, 327);
            this.txt_skill_name.Multiline = true;
            this.txt_skill_name.Name = "txt_skill_name";
            this.txt_skill_name.Size = new System.Drawing.Size(276, 23);
            this.txt_skill_name.TabIndex = 103;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(297, 327);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 102;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label_employee_id
            // 
            this.label_employee_id.AutoSize = true;
            this.label_employee_id.BackColor = System.Drawing.Color.White;
            this.label_employee_id.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_employee_id.Location = new System.Drawing.Point(12, 80);
            this.label_employee_id.Name = "label_employee_id";
            this.label_employee_id.Size = new System.Drawing.Size(50, 18);
            this.label_employee_id.TabIndex = 101;
            this.label_employee_id.Text = "Skill ID";
            // 
            // label_employee_name
            // 
            this.label_employee_name.AutoSize = true;
            this.label_employee_name.BackColor = System.Drawing.Color.White;
            this.label_employee_name.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_employee_name.Location = new System.Drawing.Point(117, 80);
            this.label_employee_name.Name = "label_employee_name";
            this.label_employee_name.Size = new System.Drawing.Size(72, 18);
            this.label_employee_name.TabIndex = 100;
            this.label_employee_name.Text = "Skill Name";
            // 
            // panel_data
            // 
            this.panel_data.AutoScroll = true;
            this.panel_data.Location = new System.Drawing.Point(15, 101);
            this.panel_data.Name = "panel_data";
            this.panel_data.Size = new System.Drawing.Size(357, 206);
            this.panel_data.TabIndex = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 30);
            this.label1.TabIndex = 98;
            this.label1.Text = "Skills";
            // 
            // Manage_Skills_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.txt_skill_name);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label_employee_id);
            this.Controls.Add(this.label_employee_name);
            this.Controls.Add(this.panel_data);
            this.Controls.Add(this.label1);
            this.Name = "Manage_Skills_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage_Skills_Form";
            this.Load += new System.EventHandler(this.Manage_Skills_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_skill_name;
        private System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.Label label_employee_id;
        public System.Windows.Forms.Label label_employee_name;
        private System.Windows.Forms.Panel panel_data;
        private System.Windows.Forms.Label label1;
    }
}