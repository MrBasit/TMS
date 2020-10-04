namespace Technomide_Corporation
{
    partial class Manage_Designation_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel_data = new System.Windows.Forms.Panel();
            this.label_employee_id = new System.Windows.Forms.Label();
            this.label_employee_name = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_designation_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Designation";
            // 
            // panel_data
            // 
            this.panel_data.AutoScroll = true;
            this.panel_data.Location = new System.Drawing.Point(15, 100);
            this.panel_data.Name = "panel_data";
            this.panel_data.Size = new System.Drawing.Size(357, 206);
            this.panel_data.TabIndex = 8;
            // 
            // label_employee_id
            // 
            this.label_employee_id.AutoSize = true;
            this.label_employee_id.BackColor = System.Drawing.Color.White;
            this.label_employee_id.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_employee_id.Location = new System.Drawing.Point(12, 79);
            this.label_employee_id.Name = "label_employee_id";
            this.label_employee_id.Size = new System.Drawing.Size(95, 18);
            this.label_employee_id.TabIndex = 95;
            this.label_employee_id.Text = "Designation ID";
            // 
            // label_employee_name
            // 
            this.label_employee_name.AutoSize = true;
            this.label_employee_name.BackColor = System.Drawing.Color.White;
            this.label_employee_name.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_employee_name.Location = new System.Drawing.Point(117, 79);
            this.label_employee_name.Name = "label_employee_name";
            this.label_employee_name.Size = new System.Drawing.Size(117, 18);
            this.label_employee_name.TabIndex = 94;
            this.label_employee_name.Text = "Designation Name";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(297, 326);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 96;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_designation_name
            // 
            this.txt_designation_name.BackColor = System.Drawing.Color.White;
            this.txt_designation_name.Location = new System.Drawing.Point(15, 326);
            this.txt_designation_name.Multiline = true;
            this.txt_designation_name.Name = "txt_designation_name";
            this.txt_designation_name.Size = new System.Drawing.Size(276, 23);
            this.txt_designation_name.TabIndex = 97;
            // 
            // Manage_Designation_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.txt_designation_name);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label_employee_id);
            this.Controls.Add(this.label_employee_name);
            this.Controls.Add(this.panel_data);
            this.Controls.Add(this.label1);
            this.Name = "Manage_Designation_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage_Designation_Form";
            this.Load += new System.EventHandler(this.Manage_Designation_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_data;
        public System.Windows.Forms.Label label_employee_id;
        public System.Windows.Forms.Label label_employee_name;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_designation_name;
    }
}