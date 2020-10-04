namespace Technomide_Corporation
{
    partial class UC_GroupBox
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
            this.label_function_name = new System.Windows.Forms.Label();
            this.label_count = new System.Windows.Forms.Label();
            this.picture_logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_function_name
            // 
            this.label_function_name.AutoSize = true;
            this.label_function_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_function_name.Location = new System.Drawing.Point(49, 3);
            this.label_function_name.Name = "label_function_name";
            this.label_function_name.Size = new System.Drawing.Size(92, 13);
            this.label_function_name.TabIndex = 1;
            this.label_function_name.Text = "Function Name";
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_count.Location = new System.Drawing.Point(94, 22);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(16, 16);
            this.label_count.TabIndex = 2;
            this.label_count.Text = "6";
            // 
            // picture_logo
            // 
            this.picture_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_logo.Image = global::Technomide_Corporation.Properties.Resources.Person;
            this.picture_logo.Location = new System.Drawing.Point(3, 3);
            this.picture_logo.Name = "picture_logo";
            this.picture_logo.Size = new System.Drawing.Size(35, 35);
            this.picture_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_logo.TabIndex = 0;
            this.picture_logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picture_logo);
            this.panel1.Controls.Add(this.label_count);
            this.panel1.Controls.Add(this.label_function_name);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 42);
            this.panel1.TabIndex = 3;
            // 
            // UC_GroupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Name = "UC_GroupBox";
            this.Size = new System.Drawing.Size(202, 46);
            this.Load += new System.EventHandler(this.UC_GroupBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox picture_logo;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label_function_name;
        public System.Windows.Forms.Label label_count;
    }
}
