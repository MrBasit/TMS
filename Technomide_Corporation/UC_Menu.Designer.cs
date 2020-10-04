namespace Technomide_Corporation
{
    partial class UC_Menu
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
            this.label_function = new System.Windows.Forms.Label();
            this.picture_logo_uc = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo_uc)).BeginInit();
            this.SuspendLayout();
            // 
            // label_function
            // 
            this.label_function.AutoSize = true;
            this.label_function.Location = new System.Drawing.Point(55, 9);
            this.label_function.Name = "label_function";
            this.label_function.Size = new System.Drawing.Size(48, 13);
            this.label_function.TabIndex = 1;
            this.label_function.Text = "Function";
            this.label_function.Click += new System.EventHandler(this.label_function_Click);
            // 
            // picture_logo_uc
            // 
            this.picture_logo_uc.BackColor = System.Drawing.Color.Transparent;
            this.picture_logo_uc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picture_logo_uc.ErrorImage = null;
            this.picture_logo_uc.Location = new System.Drawing.Point(14, 4);
            this.picture_logo_uc.Name = "picture_logo_uc";
            this.picture_logo_uc.Size = new System.Drawing.Size(27, 22);
            this.picture_logo_uc.TabIndex = 0;
            this.picture_logo_uc.TabStop = false;
            this.picture_logo_uc.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UC_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label_function);
            this.Controls.Add(this.picture_logo_uc);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UC_Menu";
            this.Size = new System.Drawing.Size(188, 30);
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo_uc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label_function;
        public System.Windows.Forms.PictureBox picture_logo_uc;
    }
}
