namespace Technomide_Corporation
{
    partial class Income_form
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
            this.panel_project_data = new System.Windows.Forms.Panel();
            this.label_project_date = new System.Windows.Forms.Label();
            this.label_project_amount = new System.Windows.Forms.Label();
            this.label_project_id = new System.Windows.Forms.Label();
            this.label_project_name = new System.Windows.Forms.Label();
            this.label_add_projectincome = new System.Windows.Forms.Label();
            this.groupBox_View = new System.Windows.Forms.GroupBox();
            this.btn_view_project_income = new System.Windows.Forms.RadioButton();
            this.btn_view_academy_income = new System.Windows.Forms.RadioButton();
            this.groupBox_Total_Income = new System.Windows.Forms.GroupBox();
            this.label_overall_income = new System.Windows.Forms.Label();
            this.label_academy_income = new System.Windows.Forms.Label();
            this.label_project_income = new System.Windows.Forms.Label();
            this.txt_select_income = new System.Windows.Forms.ComboBox();
            this.groupBox_Search_By = new System.Windows.Forms.GroupBox();
            this.txt_search_pro_id = new System.Windows.Forms.ComboBox();
            this.txt_search_pro_name = new System.Windows.Forms.ComboBox();
            this.groupBox_Sort_By = new System.Windows.Forms.GroupBox();
            this.btn_sort_pro_amount_desc = new System.Windows.Forms.RadioButton();
            this.btn_sort_pro_name = new System.Windows.Forms.RadioButton();
            this.btn_sort_pro_amount_asc = new System.Windows.Forms.RadioButton();
            this.groupBox_Search_By_Date = new System.Windows.Forms.GroupBox();
            this.txt_search_project_specific_year = new System.Windows.Forms.ComboBox();
            this.txt_search_project_specific_date = new System.Windows.Forms.ComboBox();
            this.txt_search_project_specific_month = new System.Windows.Forms.ComboBox();
            this.picture_add_projectincome = new System.Windows.Forms.PictureBox();
            this.panel_Project_Income = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_Academy_Income = new System.Windows.Forms.Panel();
            this.panel_add_student = new System.Windows.Forms.Panel();
            this.btn_add_student = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_student_name = new System.Windows.Forms.TextBox();
            this.picture_add_student = new System.Windows.Forms.PictureBox();
            this.label_add_student = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_search_std_name = new System.Windows.Forms.ComboBox();
            this.txt_search_std_id = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_search_academy_specific_year = new System.Windows.Forms.ComboBox();
            this.txt_search_academy_specific_date = new System.Windows.Forms.ComboBox();
            this.txt_search_academy_specific_month = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_sort_by_std_name = new System.Windows.Forms.RadioButton();
            this.btn_sort_by_date = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_academy_data = new System.Windows.Forms.Panel();
            this.picture_add_academyincome = new System.Windows.Forms.PictureBox();
            this.label_add_academyincome = new System.Windows.Forms.Label();
            this.groupBox_View.SuspendLayout();
            this.groupBox_Total_Income.SuspendLayout();
            this.groupBox_Search_By.SuspendLayout();
            this.groupBox_Sort_By.SuspendLayout();
            this.groupBox_Search_By_Date.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_add_projectincome)).BeginInit();
            this.panel_Project_Income.SuspendLayout();
            this.panel_Academy_Income.SuspendLayout();
            this.panel_add_student.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_add_student)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_add_academyincome)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Income";
            // 
            // panel_project_data
            // 
            this.panel_project_data.AutoScroll = true;
            this.panel_project_data.BackColor = System.Drawing.Color.White;
            this.panel_project_data.Location = new System.Drawing.Point(73, 109);
            this.panel_project_data.Name = "panel_project_data";
            this.panel_project_data.Size = new System.Drawing.Size(999, 360);
            this.panel_project_data.TabIndex = 101;
            this.panel_project_data.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_data_Paint);
            // 
            // label_project_date
            // 
            this.label_project_date.AutoSize = true;
            this.label_project_date.BackColor = System.Drawing.Color.White;
            this.label_project_date.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_project_date.Location = new System.Drawing.Point(714, 88);
            this.label_project_date.Name = "label_project_date";
            this.label_project_date.Size = new System.Drawing.Size(35, 18);
            this.label_project_date.TabIndex = 105;
            this.label_project_date.Text = "Date";
            this.label_project_date.Click += new System.EventHandler(this.label_project_date_Click);
            // 
            // label_project_amount
            // 
            this.label_project_amount.AutoSize = true;
            this.label_project_amount.BackColor = System.Drawing.Color.White;
            this.label_project_amount.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_project_amount.Location = new System.Drawing.Point(564, 88);
            this.label_project_amount.Name = "label_project_amount";
            this.label_project_amount.Size = new System.Drawing.Size(55, 18);
            this.label_project_amount.TabIndex = 104;
            this.label_project_amount.Text = "Amount";
            // 
            // label_project_id
            // 
            this.label_project_id.AutoSize = true;
            this.label_project_id.BackColor = System.Drawing.Color.White;
            this.label_project_id.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_project_id.Location = new System.Drawing.Point(432, 88);
            this.label_project_id.Name = "label_project_id";
            this.label_project_id.Size = new System.Drawing.Size(69, 18);
            this.label_project_id.TabIndex = 103;
            this.label_project_id.Text = "Project ID";
            // 
            // label_project_name
            // 
            this.label_project_name.AutoSize = true;
            this.label_project_name.BackColor = System.Drawing.Color.White;
            this.label_project_name.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_project_name.Location = new System.Drawing.Point(220, 88);
            this.label_project_name.Name = "label_project_name";
            this.label_project_name.Size = new System.Drawing.Size(91, 18);
            this.label_project_name.TabIndex = 102;
            this.label_project_name.Text = "Project Name";
            // 
            // label_add_projectincome
            // 
            this.label_add_projectincome.AutoSize = true;
            this.label_add_projectincome.BackColor = System.Drawing.Color.White;
            this.label_add_projectincome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_add_projectincome.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_add_projectincome.Location = new System.Drawing.Point(40, 81);
            this.label_add_projectincome.Name = "label_add_projectincome";
            this.label_add_projectincome.Size = new System.Drawing.Size(129, 18);
            this.label_add_projectincome.TabIndex = 111;
            this.label_add_projectincome.Text = "Add Project Income";
            this.label_add_projectincome.Click += new System.EventHandler(this.label_add_projectincome_Click);
            // 
            // groupBox_View
            // 
            this.groupBox_View.BackColor = System.Drawing.Color.White;
            this.groupBox_View.Controls.Add(this.btn_view_project_income);
            this.groupBox_View.Controls.Add(this.btn_view_academy_income);
            this.groupBox_View.Location = new System.Drawing.Point(335, 56);
            this.groupBox_View.Name = "groupBox_View";
            this.groupBox_View.Size = new System.Drawing.Size(258, 54);
            this.groupBox_View.TabIndex = 113;
            this.groupBox_View.TabStop = false;
            this.groupBox_View.Text = "VIEW";
            // 
            // btn_view_project_income
            // 
            this.btn_view_project_income.AutoSize = true;
            this.btn_view_project_income.BackColor = System.Drawing.Color.White;
            this.btn_view_project_income.Checked = true;
            this.btn_view_project_income.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_project_income.Location = new System.Drawing.Point(6, 19);
            this.btn_view_project_income.Name = "btn_view_project_income";
            this.btn_view_project_income.Size = new System.Drawing.Size(119, 22);
            this.btn_view_project_income.TabIndex = 97;
            this.btn_view_project_income.TabStop = true;
            this.btn_view_project_income.Text = "Project Income";
            this.btn_view_project_income.UseVisualStyleBackColor = false;
            this.btn_view_project_income.CheckedChanged += new System.EventHandler(this.btn_view_project_income_CheckedChanged);
            // 
            // btn_view_academy_income
            // 
            this.btn_view_academy_income.AutoSize = true;
            this.btn_view_academy_income.BackColor = System.Drawing.Color.White;
            this.btn_view_academy_income.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_academy_income.Location = new System.Drawing.Point(129, 19);
            this.btn_view_academy_income.Name = "btn_view_academy_income";
            this.btn_view_academy_income.Size = new System.Drawing.Size(129, 22);
            this.btn_view_academy_income.TabIndex = 98;
            this.btn_view_academy_income.Text = "Academy Income";
            this.btn_view_academy_income.UseVisualStyleBackColor = false;
            this.btn_view_academy_income.CheckedChanged += new System.EventHandler(this.btn_view_academy_income_CheckedChanged);
            // 
            // groupBox_Total_Income
            // 
            this.groupBox_Total_Income.BackColor = System.Drawing.Color.White;
            this.groupBox_Total_Income.Controls.Add(this.label_overall_income);
            this.groupBox_Total_Income.Controls.Add(this.label_academy_income);
            this.groupBox_Total_Income.Controls.Add(this.label_project_income);
            this.groupBox_Total_Income.Controls.Add(this.txt_select_income);
            this.groupBox_Total_Income.Location = new System.Drawing.Point(599, 56);
            this.groupBox_Total_Income.Name = "groupBox_Total_Income";
            this.groupBox_Total_Income.Size = new System.Drawing.Size(547, 54);
            this.groupBox_Total_Income.TabIndex = 114;
            this.groupBox_Total_Income.TabStop = false;
            this.groupBox_Total_Income.Text = "Total Income";
            // 
            // label_overall_income
            // 
            this.label_overall_income.AutoSize = true;
            this.label_overall_income.BackColor = System.Drawing.Color.White;
            this.label_overall_income.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_overall_income.Location = new System.Drawing.Point(405, 21);
            this.label_overall_income.Name = "label_overall_income";
            this.label_overall_income.Size = new System.Drawing.Size(52, 18);
            this.label_overall_income.TabIndex = 119;
            this.label_overall_income.Text = "Overall";
            // 
            // label_academy_income
            // 
            this.label_academy_income.AutoSize = true;
            this.label_academy_income.BackColor = System.Drawing.Color.White;
            this.label_academy_income.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_academy_income.Location = new System.Drawing.Point(250, 22);
            this.label_academy_income.Name = "label_academy_income";
            this.label_academy_income.Size = new System.Drawing.Size(63, 18);
            this.label_academy_income.TabIndex = 118;
            this.label_academy_income.Text = "Academy";
            // 
            // label_project_income
            // 
            this.label_project_income.AutoSize = true;
            this.label_project_income.BackColor = System.Drawing.Color.White;
            this.label_project_income.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_project_income.Location = new System.Drawing.Point(113, 21);
            this.label_project_income.Name = "label_project_income";
            this.label_project_income.Size = new System.Drawing.Size(53, 18);
            this.label_project_income.TabIndex = 117;
            this.label_project_income.Text = "Project";
            // 
            // txt_select_income
            // 
            this.txt_select_income.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_select_income.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_select_income.FormattingEnabled = true;
            this.txt_select_income.Items.AddRange(new object[] {
            "Today",
            "This Month",
            "This Year"});
            this.txt_select_income.Location = new System.Drawing.Point(7, 19);
            this.txt_select_income.Name = "txt_select_income";
            this.txt_select_income.Size = new System.Drawing.Size(99, 21);
            this.txt_select_income.TabIndex = 99;
            this.txt_select_income.SelectedIndexChanged += new System.EventHandler(this.txt_select_income_SelectedIndexChanged);
            // 
            // groupBox_Search_By
            // 
            this.groupBox_Search_By.BackColor = System.Drawing.Color.White;
            this.groupBox_Search_By.Controls.Add(this.txt_search_pro_id);
            this.groupBox_Search_By.Controls.Add(this.txt_search_pro_name);
            this.groupBox_Search_By.Location = new System.Drawing.Point(73, 13);
            this.groupBox_Search_By.Name = "groupBox_Search_By";
            this.groupBox_Search_By.Size = new System.Drawing.Size(305, 54);
            this.groupBox_Search_By.TabIndex = 115;
            this.groupBox_Search_By.TabStop = false;
            this.groupBox_Search_By.Text = "SEARCH BY";
            // 
            // txt_search_pro_id
            // 
            this.txt_search_pro_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_search_pro_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_search_pro_id.BackColor = System.Drawing.Color.White;
            this.txt_search_pro_id.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_pro_id.FormattingEnabled = true;
            this.txt_search_pro_id.Location = new System.Drawing.Point(170, 20);
            this.txt_search_pro_id.Name = "txt_search_pro_id";
            this.txt_search_pro_id.Size = new System.Drawing.Size(121, 26);
            this.txt_search_pro_id.TabIndex = 100;
            this.txt_search_pro_id.SelectedIndexChanged += new System.EventHandler(this.txt_search_pro_id_SelectedIndexChanged);
            this.txt_search_pro_id.Click += new System.EventHandler(this.txt_search_pro_id_Click);
            // 
            // txt_search_pro_name
            // 
            this.txt_search_pro_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_search_pro_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_search_pro_name.BackColor = System.Drawing.Color.White;
            this.txt_search_pro_name.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_pro_name.FormattingEnabled = true;
            this.txt_search_pro_name.Location = new System.Drawing.Point(6, 19);
            this.txt_search_pro_name.Name = "txt_search_pro_name";
            this.txt_search_pro_name.Size = new System.Drawing.Size(158, 26);
            this.txt_search_pro_name.TabIndex = 101;
            this.txt_search_pro_name.SelectedIndexChanged += new System.EventHandler(this.txt_search_pro_name_SelectedIndexChanged);
            this.txt_search_pro_name.Click += new System.EventHandler(this.txt_search_pro_name_Click);
            // 
            // groupBox_Sort_By
            // 
            this.groupBox_Sort_By.BackColor = System.Drawing.Color.White;
            this.groupBox_Sort_By.Controls.Add(this.btn_sort_pro_amount_desc);
            this.groupBox_Sort_By.Controls.Add(this.btn_sort_pro_name);
            this.groupBox_Sort_By.Controls.Add(this.btn_sort_pro_amount_asc);
            this.groupBox_Sort_By.Location = new System.Drawing.Point(384, 13);
            this.groupBox_Sort_By.Name = "groupBox_Sort_By";
            this.groupBox_Sort_By.Size = new System.Drawing.Size(445, 54);
            this.groupBox_Sort_By.TabIndex = 116;
            this.groupBox_Sort_By.TabStop = false;
            this.groupBox_Sort_By.Text = "SORT BY";
            // 
            // btn_sort_pro_amount_desc
            // 
            this.btn_sort_pro_amount_desc.AutoSize = true;
            this.btn_sort_pro_amount_desc.BackColor = System.Drawing.Color.White;
            this.btn_sort_pro_amount_desc.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sort_pro_amount_desc.Location = new System.Drawing.Point(286, 21);
            this.btn_sort_pro_amount_desc.Name = "btn_sort_pro_amount_desc";
            this.btn_sort_pro_amount_desc.Size = new System.Drawing.Size(147, 22);
            this.btn_sort_pro_amount_desc.TabIndex = 99;
            this.btn_sort_pro_amount_desc.Text = "Amount Descending";
            this.btn_sort_pro_amount_desc.UseVisualStyleBackColor = false;
            this.btn_sort_pro_amount_desc.CheckedChanged += new System.EventHandler(this.btn_sort_pro_amount_desc_CheckedChanged);
            // 
            // btn_sort_pro_name
            // 
            this.btn_sort_pro_name.AutoSize = true;
            this.btn_sort_pro_name.BackColor = System.Drawing.Color.White;
            this.btn_sort_pro_name.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sort_pro_name.Location = new System.Drawing.Point(22, 21);
            this.btn_sort_pro_name.Name = "btn_sort_pro_name";
            this.btn_sort_pro_name.Size = new System.Drawing.Size(109, 22);
            this.btn_sort_pro_name.TabIndex = 97;
            this.btn_sort_pro_name.Text = "Project Name";
            this.btn_sort_pro_name.UseVisualStyleBackColor = false;
            this.btn_sort_pro_name.CheckedChanged += new System.EventHandler(this.btn_sort_pro_name_CheckedChanged);
            // 
            // btn_sort_pro_amount_asc
            // 
            this.btn_sort_pro_amount_asc.AutoSize = true;
            this.btn_sort_pro_amount_asc.BackColor = System.Drawing.Color.White;
            this.btn_sort_pro_amount_asc.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sort_pro_amount_asc.Location = new System.Drawing.Point(141, 21);
            this.btn_sort_pro_amount_asc.Name = "btn_sort_pro_amount_asc";
            this.btn_sort_pro_amount_asc.Size = new System.Drawing.Size(139, 22);
            this.btn_sort_pro_amount_asc.TabIndex = 98;
            this.btn_sort_pro_amount_asc.Text = "Amount Ascending";
            this.btn_sort_pro_amount_asc.UseVisualStyleBackColor = false;
            this.btn_sort_pro_amount_asc.CheckedChanged += new System.EventHandler(this.btn_sort_pro_amount_asc_CheckedChanged);
            // 
            // groupBox_Search_By_Date
            // 
            this.groupBox_Search_By_Date.BackColor = System.Drawing.Color.White;
            this.groupBox_Search_By_Date.Controls.Add(this.txt_search_project_specific_year);
            this.groupBox_Search_By_Date.Controls.Add(this.txt_search_project_specific_date);
            this.groupBox_Search_By_Date.Controls.Add(this.txt_search_project_specific_month);
            this.groupBox_Search_By_Date.Location = new System.Drawing.Point(834, 13);
            this.groupBox_Search_By_Date.Name = "groupBox_Search_By_Date";
            this.groupBox_Search_By_Date.Size = new System.Drawing.Size(238, 54);
            this.groupBox_Search_By_Date.TabIndex = 116;
            this.groupBox_Search_By_Date.TabStop = false;
            this.groupBox_Search_By_Date.Text = "Search Data By Date";
            // 
            // txt_search_project_specific_year
            // 
            this.txt_search_project_specific_year.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_search_project_specific_year.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_search_project_specific_year.BackColor = System.Drawing.Color.White;
            this.txt_search_project_specific_year.DisplayMember = "Project_Date";
            this.txt_search_project_specific_year.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_project_specific_year.FormattingEnabled = true;
            this.txt_search_project_specific_year.Location = new System.Drawing.Point(6, 18);
            this.txt_search_project_specific_year.Name = "txt_search_project_specific_year";
            this.txt_search_project_specific_year.Size = new System.Drawing.Size(82, 26);
            this.txt_search_project_specific_year.TabIndex = 102;
            this.txt_search_project_specific_year.ValueMember = "Project_Date";
            this.txt_search_project_specific_year.SelectedIndexChanged += new System.EventHandler(this.txt_search_project_specific_year_SelectedIndexChanged);
            this.txt_search_project_specific_year.Click += new System.EventHandler(this.txt_search_project_specific_year_Click);
            // 
            // txt_search_project_specific_date
            // 
            this.txt_search_project_specific_date.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_search_project_specific_date.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_search_project_specific_date.BackColor = System.Drawing.Color.White;
            this.txt_search_project_specific_date.DisplayMember = "Name";
            this.txt_search_project_specific_date.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_project_specific_date.FormattingEnabled = true;
            this.txt_search_project_specific_date.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.txt_search_project_specific_date.Location = new System.Drawing.Point(165, 18);
            this.txt_search_project_specific_date.Name = "txt_search_project_specific_date";
            this.txt_search_project_specific_date.Size = new System.Drawing.Size(59, 26);
            this.txt_search_project_specific_date.TabIndex = 101;
            this.txt_search_project_specific_date.ValueMember = "Name";
            this.txt_search_project_specific_date.SelectedIndexChanged += new System.EventHandler(this.txt_search_project_specific_date_SelectedIndexChanged);
            this.txt_search_project_specific_date.Click += new System.EventHandler(this.txt_search_project_specific_date_Click);
            // 
            // txt_search_project_specific_month
            // 
            this.txt_search_project_specific_month.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_search_project_specific_month.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_search_project_specific_month.BackColor = System.Drawing.Color.White;
            this.txt_search_project_specific_month.DisplayMember = "Project_Date";
            this.txt_search_project_specific_month.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_project_specific_month.FormattingEnabled = true;
            this.txt_search_project_specific_month.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.txt_search_project_specific_month.Location = new System.Drawing.Point(98, 18);
            this.txt_search_project_specific_month.Name = "txt_search_project_specific_month";
            this.txt_search_project_specific_month.Size = new System.Drawing.Size(56, 26);
            this.txt_search_project_specific_month.TabIndex = 100;
            this.txt_search_project_specific_month.ValueMember = "Project_Date";
            this.txt_search_project_specific_month.SelectedIndexChanged += new System.EventHandler(this.txt_search_project_specific_month_SelectedIndexChanged);
            this.txt_search_project_specific_month.Click += new System.EventHandler(this.txt_search_project_specific_month_Click);
            // 
            // picture_add_projectincome
            // 
            this.picture_add_projectincome.BackColor = System.Drawing.Color.White;
            this.picture_add_projectincome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_add_projectincome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_add_projectincome.Image = global::Technomide_Corporation.Properties.Resources.Add;
            this.picture_add_projectincome.Location = new System.Drawing.Point(18, 81);
            this.picture_add_projectincome.Name = "picture_add_projectincome";
            this.picture_add_projectincome.Size = new System.Drawing.Size(20, 18);
            this.picture_add_projectincome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_add_projectincome.TabIndex = 112;
            this.picture_add_projectincome.TabStop = false;
            this.picture_add_projectincome.Click += new System.EventHandler(this.picture_add_projectincome_Click);
            // 
            // panel_Project_Income
            // 
            this.panel_Project_Income.Controls.Add(this.label8);
            this.panel_Project_Income.Controls.Add(this.panel_project_data);
            this.panel_Project_Income.Controls.Add(this.label6);
            this.panel_Project_Income.Controls.Add(this.groupBox_Search_By);
            this.panel_Project_Income.Controls.Add(this.groupBox_Search_By_Date);
            this.panel_Project_Income.Controls.Add(this.label_project_name);
            this.panel_Project_Income.Controls.Add(this.groupBox_Sort_By);
            this.panel_Project_Income.Controls.Add(this.label_project_id);
            this.panel_Project_Income.Controls.Add(this.label_project_amount);
            this.panel_Project_Income.Controls.Add(this.label_project_date);
            this.panel_Project_Income.Location = new System.Drawing.Point(18, 116);
            this.panel_Project_Income.Name = "panel_Project_Income";
            this.panel_Project_Income.Size = new System.Drawing.Size(1108, 478);
            this.panel_Project_Income.TabIndex = 117;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(76, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 18);
            this.label8.TabIndex = 118;
            this.label8.Text = "Project Income ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(929, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 18);
            this.label6.TabIndex = 117;
            this.label6.Text = "NOTE";
            // 
            // panel_Academy_Income
            // 
            this.panel_Academy_Income.Controls.Add(this.panel_add_student);
            this.panel_Academy_Income.Controls.Add(this.picture_add_student);
            this.panel_Academy_Income.Controls.Add(this.label_add_student);
            this.panel_Academy_Income.Controls.Add(this.label9);
            this.panel_Academy_Income.Controls.Add(this.label7);
            this.panel_Academy_Income.Controls.Add(this.groupBox1);
            this.panel_Academy_Income.Controls.Add(this.groupBox2);
            this.panel_Academy_Income.Controls.Add(this.label2);
            this.panel_Academy_Income.Controls.Add(this.groupBox3);
            this.panel_Academy_Income.Controls.Add(this.label3);
            this.panel_Academy_Income.Controls.Add(this.label4);
            this.panel_Academy_Income.Controls.Add(this.label5);
            this.panel_Academy_Income.Controls.Add(this.panel_academy_data);
            this.panel_Academy_Income.Location = new System.Drawing.Point(18, 116);
            this.panel_Academy_Income.Name = "panel_Academy_Income";
            this.panel_Academy_Income.Size = new System.Drawing.Size(1108, 478);
            this.panel_Academy_Income.TabIndex = 118;
            this.panel_Academy_Income.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Academy_Income_Paint);
            // 
            // panel_add_student
            // 
            this.panel_add_student.Controls.Add(this.btn_add_student);
            this.panel_add_student.Controls.Add(this.label11);
            this.panel_add_student.Controls.Add(this.txt_student_name);
            this.panel_add_student.Location = new System.Drawing.Point(753, 41);
            this.panel_add_student.Name = "panel_add_student";
            this.panel_add_student.Size = new System.Drawing.Size(292, 26);
            this.panel_add_student.TabIndex = 123;
            // 
            // btn_add_student
            // 
            this.btn_add_student.BackColor = System.Drawing.Color.White;
            this.btn_add_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_student.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_student.Location = new System.Drawing.Point(233, 2);
            this.btn_add_student.Name = "btn_add_student";
            this.btn_add_student.Size = new System.Drawing.Size(53, 21);
            this.btn_add_student.TabIndex = 127;
            this.btn_add_student.Text = "Add";
            this.btn_add_student.UseVisualStyleBackColor = false;
            this.btn_add_student.Click += new System.EventHandler(this.btn_add_student_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(0, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 18);
            this.label11.TabIndex = 124;
            this.label11.Text = "Student Name";
            // 
            // txt_student_name
            // 
            this.txt_student_name.Location = new System.Drawing.Point(95, 2);
            this.txt_student_name.Name = "txt_student_name";
            this.txt_student_name.Size = new System.Drawing.Size(132, 20);
            this.txt_student_name.TabIndex = 0;
            this.txt_student_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // picture_add_student
            // 
            this.picture_add_student.BackColor = System.Drawing.Color.White;
            this.picture_add_student.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_add_student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_add_student.Image = global::Technomide_Corporation.Properties.Resources.Add;
            this.picture_add_student.Location = new System.Drawing.Point(848, 19);
            this.picture_add_student.Name = "picture_add_student";
            this.picture_add_student.Size = new System.Drawing.Size(20, 18);
            this.picture_add_student.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_add_student.TabIndex = 122;
            this.picture_add_student.TabStop = false;
            this.picture_add_student.Click += new System.EventHandler(this.picture_add_student_Click);
            // 
            // label_add_student
            // 
            this.label_add_student.AutoSize = true;
            this.label_add_student.BackColor = System.Drawing.Color.White;
            this.label_add_student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_add_student.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_add_student.Location = new System.Drawing.Point(874, 19);
            this.label_add_student.Name = "label_add_student";
            this.label_add_student.Size = new System.Drawing.Size(84, 18);
            this.label_add_student.TabIndex = 121;
            this.label_add_student.Text = "Add Student";
            this.label_add_student.Click += new System.EventHandler(this.label_add_student_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(98, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 18);
            this.label9.TabIndex = 119;
            this.label9.Text = "Academy Income ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(876, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 18);
            this.label7.TabIndex = 118;
            this.label7.Text = "NOTE";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txt_search_std_name);
            this.groupBox1.Controls.Add(this.txt_search_std_id);
            this.groupBox1.Location = new System.Drawing.Point(73, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 54);
            this.groupBox1.TabIndex = 115;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SEARCH BY";
            // 
            // txt_search_std_name
            // 
            this.txt_search_std_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_search_std_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_search_std_name.BackColor = System.Drawing.Color.White;
            this.txt_search_std_name.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_std_name.FormattingEnabled = true;
            this.txt_search_std_name.Location = new System.Drawing.Point(6, 19);
            this.txt_search_std_name.Name = "txt_search_std_name";
            this.txt_search_std_name.Size = new System.Drawing.Size(121, 26);
            this.txt_search_std_name.TabIndex = 101;
            this.txt_search_std_name.SelectedIndexChanged += new System.EventHandler(this.txt_search_std_name_SelectedIndexChanged);
            this.txt_search_std_name.Click += new System.EventHandler(this.txt_search_std_name_Click);
            // 
            // txt_search_std_id
            // 
            this.txt_search_std_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_search_std_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_search_std_id.BackColor = System.Drawing.Color.White;
            this.txt_search_std_id.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_std_id.FormattingEnabled = true;
            this.txt_search_std_id.Location = new System.Drawing.Point(137, 20);
            this.txt_search_std_id.Name = "txt_search_std_id";
            this.txt_search_std_id.Size = new System.Drawing.Size(121, 26);
            this.txt_search_std_id.TabIndex = 100;
            this.txt_search_std_id.SelectedIndexChanged += new System.EventHandler(this.txt_search_std_id_SelectedIndexChanged);
            this.txt_search_std_id.Click += new System.EventHandler(this.txt_search_std_id_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txt_search_academy_specific_year);
            this.groupBox2.Controls.Add(this.txt_search_academy_specific_date);
            this.groupBox2.Controls.Add(this.txt_search_academy_specific_month);
            this.groupBox2.Location = new System.Drawing.Point(541, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 54);
            this.groupBox2.TabIndex = 116;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Data By Date";
            // 
            // txt_search_academy_specific_year
            // 
            this.txt_search_academy_specific_year.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_search_academy_specific_year.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_search_academy_specific_year.BackColor = System.Drawing.Color.White;
            this.txt_search_academy_specific_year.DisplayMember = "Project_Date";
            this.txt_search_academy_specific_year.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_academy_specific_year.FormattingEnabled = true;
            this.txt_search_academy_specific_year.Location = new System.Drawing.Point(6, 19);
            this.txt_search_academy_specific_year.Name = "txt_search_academy_specific_year";
            this.txt_search_academy_specific_year.Size = new System.Drawing.Size(82, 26);
            this.txt_search_academy_specific_year.TabIndex = 102;
            this.txt_search_academy_specific_year.ValueMember = "Project_Date";
            this.txt_search_academy_specific_year.SelectedIndexChanged += new System.EventHandler(this.txt_search_academy_specific_year_SelectedIndexChanged);
            this.txt_search_academy_specific_year.Click += new System.EventHandler(this.txt_search_academy_specific_year_Click);
            // 
            // txt_search_academy_specific_date
            // 
            this.txt_search_academy_specific_date.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_search_academy_specific_date.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_search_academy_specific_date.BackColor = System.Drawing.Color.White;
            this.txt_search_academy_specific_date.DisplayMember = "Name";
            this.txt_search_academy_specific_date.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_academy_specific_date.FormattingEnabled = true;
            this.txt_search_academy_specific_date.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.txt_search_academy_specific_date.Location = new System.Drawing.Point(148, 19);
            this.txt_search_academy_specific_date.Name = "txt_search_academy_specific_date";
            this.txt_search_academy_specific_date.Size = new System.Drawing.Size(52, 26);
            this.txt_search_academy_specific_date.TabIndex = 101;
            this.txt_search_academy_specific_date.ValueMember = "Name";
            this.txt_search_academy_specific_date.SelectedIndexChanged += new System.EventHandler(this.txt_search_academy_specific_date_SelectedIndexChanged);
            this.txt_search_academy_specific_date.Click += new System.EventHandler(this.txt_search_academy_specific_date_Click);
            // 
            // txt_search_academy_specific_month
            // 
            this.txt_search_academy_specific_month.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_search_academy_specific_month.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_search_academy_specific_month.BackColor = System.Drawing.Color.White;
            this.txt_search_academy_specific_month.DisplayMember = "Project_Date";
            this.txt_search_academy_specific_month.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_academy_specific_month.FormattingEnabled = true;
            this.txt_search_academy_specific_month.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.txt_search_academy_specific_month.Location = new System.Drawing.Point(94, 19);
            this.txt_search_academy_specific_month.Name = "txt_search_academy_specific_month";
            this.txt_search_academy_specific_month.Size = new System.Drawing.Size(48, 26);
            this.txt_search_academy_specific_month.TabIndex = 100;
            this.txt_search_academy_specific_month.ValueMember = "Project_Date";
            this.txt_search_academy_specific_month.SelectedIndexChanged += new System.EventHandler(this.txt_search_academy_specific_month_SelectedIndexChanged);
            this.txt_search_academy_specific_month.Click += new System.EventHandler(this.txt_search_academy_specific_month_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 102;
            this.label2.Text = "Student ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btn_sort_by_std_name);
            this.groupBox3.Controls.Add(this.btn_sort_by_date);
            this.groupBox3.Location = new System.Drawing.Point(352, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(183, 54);
            this.groupBox3.TabIndex = 116;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SORT BY";
            // 
            // btn_sort_by_std_name
            // 
            this.btn_sort_by_std_name.AutoSize = true;
            this.btn_sort_by_std_name.BackColor = System.Drawing.Color.White;
            this.btn_sort_by_std_name.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sort_by_std_name.Location = new System.Drawing.Point(6, 19);
            this.btn_sort_by_std_name.Name = "btn_sort_by_std_name";
            this.btn_sort_by_std_name.Size = new System.Drawing.Size(112, 22);
            this.btn_sort_by_std_name.TabIndex = 97;
            this.btn_sort_by_std_name.Text = "Student Name";
            this.btn_sort_by_std_name.UseVisualStyleBackColor = false;
            this.btn_sort_by_std_name.CheckedChanged += new System.EventHandler(this.btn_sort_by_std_name_CheckedChanged);
            // 
            // btn_sort_by_date
            // 
            this.btn_sort_by_date.AutoSize = true;
            this.btn_sort_by_date.BackColor = System.Drawing.Color.White;
            this.btn_sort_by_date.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sort_by_date.Location = new System.Drawing.Point(124, 19);
            this.btn_sort_by_date.Name = "btn_sort_by_date";
            this.btn_sort_by_date.Size = new System.Drawing.Size(53, 22);
            this.btn_sort_by_date.TabIndex = 98;
            this.btn_sort_by_date.Text = "Date";
            this.btn_sort_by_date.UseVisualStyleBackColor = false;
            this.btn_sort_by_date.CheckedChanged += new System.EventHandler(this.btn_sort_by_date_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(333, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 103;
            this.label3.Text = "Student Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(500, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 104;
            this.label4.Text = "Amount";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(641, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 18);
            this.label5.TabIndex = 105;
            this.label5.Text = "Date";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel_academy_data
            // 
            this.panel_academy_data.AutoScroll = true;
            this.panel_academy_data.BackColor = System.Drawing.Color.White;
            this.panel_academy_data.Location = new System.Drawing.Point(92, 109);
            this.panel_academy_data.Name = "panel_academy_data";
            this.panel_academy_data.Size = new System.Drawing.Size(926, 360);
            this.panel_academy_data.TabIndex = 101;
            // 
            // picture_add_academyincome
            // 
            this.picture_add_academyincome.BackColor = System.Drawing.Color.White;
            this.picture_add_academyincome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_add_academyincome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_add_academyincome.Image = global::Technomide_Corporation.Properties.Resources.Add;
            this.picture_add_academyincome.Location = new System.Drawing.Point(175, 81);
            this.picture_add_academyincome.Name = "picture_add_academyincome";
            this.picture_add_academyincome.Size = new System.Drawing.Size(20, 18);
            this.picture_add_academyincome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_add_academyincome.TabIndex = 120;
            this.picture_add_academyincome.TabStop = false;
            this.picture_add_academyincome.Click += new System.EventHandler(this.picture_add_academyincome_Click);
            // 
            // label_add_academyincome
            // 
            this.label_add_academyincome.AutoSize = true;
            this.label_add_academyincome.BackColor = System.Drawing.Color.White;
            this.label_add_academyincome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_add_academyincome.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_add_academyincome.Location = new System.Drawing.Point(196, 81);
            this.label_add_academyincome.Name = "label_add_academyincome";
            this.label_add_academyincome.Size = new System.Drawing.Size(138, 18);
            this.label_add_academyincome.TabIndex = 119;
            this.label_add_academyincome.Text = "Add Academy Income";
            this.label_add_academyincome.Click += new System.EventHandler(this.label_add_academyincome_Click);
            // 
            // Income_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1149, 598);
            this.Controls.Add(this.picture_add_academyincome);
            this.Controls.Add(this.label_add_academyincome);
            this.Controls.Add(this.groupBox_Total_Income);
            this.Controls.Add(this.groupBox_View);
            this.Controls.Add(this.picture_add_projectincome);
            this.Controls.Add(this.label_add_projectincome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_Academy_Income);
            this.Controls.Add(this.panel_Project_Income);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Income_form";
            this.Text = "Income_form";
            this.Load += new System.EventHandler(this.Income_form_Load);
            this.groupBox_View.ResumeLayout(false);
            this.groupBox_View.PerformLayout();
            this.groupBox_Total_Income.ResumeLayout(false);
            this.groupBox_Total_Income.PerformLayout();
            this.groupBox_Search_By.ResumeLayout(false);
            this.groupBox_Sort_By.ResumeLayout(false);
            this.groupBox_Sort_By.PerformLayout();
            this.groupBox_Search_By_Date.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_add_projectincome)).EndInit();
            this.panel_Project_Income.ResumeLayout(false);
            this.panel_Project_Income.PerformLayout();
            this.panel_Academy_Income.ResumeLayout(false);
            this.panel_Academy_Income.PerformLayout();
            this.panel_add_student.ResumeLayout(false);
            this.panel_add_student.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_add_student)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_add_academyincome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_project_data;
        public System.Windows.Forms.Label label_project_date;
        public System.Windows.Forms.Label label_project_amount;
        public System.Windows.Forms.Label label_project_id;
        public System.Windows.Forms.Label label_project_name;
        public System.Windows.Forms.PictureBox picture_add_projectincome;
        public System.Windows.Forms.Label label_add_projectincome;
        private System.Windows.Forms.GroupBox groupBox_View;
        private System.Windows.Forms.RadioButton btn_view_project_income;
        private System.Windows.Forms.RadioButton btn_view_academy_income;
        private System.Windows.Forms.GroupBox groupBox_Total_Income;
        private System.Windows.Forms.ComboBox txt_select_income;
        private System.Windows.Forms.GroupBox groupBox_Search_By;
        private System.Windows.Forms.ComboBox txt_search_pro_name;
        private System.Windows.Forms.ComboBox txt_search_pro_id;
        private System.Windows.Forms.GroupBox groupBox_Sort_By;
        private System.Windows.Forms.RadioButton btn_sort_pro_amount_desc;
        private System.Windows.Forms.RadioButton btn_sort_pro_name;
        private System.Windows.Forms.RadioButton btn_sort_pro_amount_asc;
        private System.Windows.Forms.GroupBox groupBox_Search_By_Date;
        private System.Windows.Forms.ComboBox txt_search_project_specific_year;
        private System.Windows.Forms.ComboBox txt_search_project_specific_date;
        private System.Windows.Forms.ComboBox txt_search_project_specific_month;
        public System.Windows.Forms.Label label_overall_income;
        public System.Windows.Forms.Label label_academy_income;
        public System.Windows.Forms.Label label_project_income;
        private System.Windows.Forms.Panel panel_Project_Income;
        private System.Windows.Forms.Panel panel_Academy_Income;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txt_search_std_name;
        private System.Windows.Forms.ComboBox txt_search_std_id;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox txt_search_academy_specific_year;
        private System.Windows.Forms.ComboBox txt_search_academy_specific_date;
        private System.Windows.Forms.ComboBox txt_search_academy_specific_month;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton btn_sort_by_std_name;
        private System.Windows.Forms.RadioButton btn_sort_by_date;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_academy_data;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.PictureBox picture_add_academyincome;
        public System.Windows.Forms.Label label_add_academyincome;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.PictureBox picture_add_student;
        public System.Windows.Forms.Label label_add_student;
        private System.Windows.Forms.Panel panel_add_student;
        public System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_student_name;
        private System.Windows.Forms.Button btn_add_student;
    }
}