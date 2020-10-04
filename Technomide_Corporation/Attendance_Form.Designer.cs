namespace Technomide_Corporation
{
    partial class Attendance_Form
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
            this.groupBox_View = new System.Windows.Forms.GroupBox();
            this.btn_view_overall_attendance = new System.Windows.Forms.RadioButton();
            this.btn_view_today_attendance = new System.Windows.Forms.RadioButton();
            this.btn_view_month_attendance = new System.Windows.Forms.RadioButton();
            this.groupBox_SearchByDate = new System.Windows.Forms.GroupBox();
            this.txt_search_specific_year = new System.Windows.Forms.ComboBox();
            this.txt_search_specific_day = new System.Windows.Forms.ComboBox();
            this.txt_search_specific_month = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_search_EmpName = new System.Windows.Forms.ComboBox();
            this.txt_search_EmpID = new System.Windows.Forms.ComboBox();
            this.panel_today = new System.Windows.Forms.Panel();
            this.btn_generate_attendance = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_count_absent = new System.Windows.Forms.Label();
            this.label_count_late = new System.Windows.Forms.Label();
            this.label_count_leave = new System.Windows.Forms.Label();
            this.label_count_marked = new System.Windows.Forms.Label();
            this.label_count_unmarked = new System.Windows.Forms.Label();
            this.label_count_present = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_view_unmarked_attendance = new System.Windows.Forms.RadioButton();
            this.btn_view_marked_attendance = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel_today_data_unmarked = new System.Windows.Forms.Panel();
            this.panel_today_data_marked = new System.Windows.Forms.Panel();
            this.panel_month_overall = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel_overall_data = new System.Windows.Forms.Panel();
            this.panel_month_data = new System.Windows.Forms.Panel();
            this.groupBox_View.SuspendLayout();
            this.groupBox_SearchByDate.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel_today.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel_month_overall.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(498, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Attendance";
            // 
            // groupBox_View
            // 
            this.groupBox_View.BackColor = System.Drawing.Color.White;
            this.groupBox_View.Controls.Add(this.btn_view_overall_attendance);
            this.groupBox_View.Controls.Add(this.btn_view_today_attendance);
            this.groupBox_View.Controls.Add(this.btn_view_month_attendance);
            this.groupBox_View.Location = new System.Drawing.Point(343, 87);
            this.groupBox_View.Name = "groupBox_View";
            this.groupBox_View.Size = new System.Drawing.Size(482, 54);
            this.groupBox_View.TabIndex = 121;
            this.groupBox_View.TabStop = false;
            this.groupBox_View.Text = "VIEW";
            // 
            // btn_view_overall_attendance
            // 
            this.btn_view_overall_attendance.AutoSize = true;
            this.btn_view_overall_attendance.BackColor = System.Drawing.Color.White;
            this.btn_view_overall_attendance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_overall_attendance.Location = new System.Drawing.Point(333, 23);
            this.btn_view_overall_attendance.Name = "btn_view_overall_attendance";
            this.btn_view_overall_attendance.Size = new System.Drawing.Size(143, 22);
            this.btn_view_overall_attendance.TabIndex = 99;
            this.btn_view_overall_attendance.Text = "Overall Attendance";
            this.btn_view_overall_attendance.UseVisualStyleBackColor = false;
            // 
            // btn_view_today_attendance
            // 
            this.btn_view_today_attendance.AutoSize = true;
            this.btn_view_today_attendance.BackColor = System.Drawing.Color.White;
            this.btn_view_today_attendance.Checked = true;
            this.btn_view_today_attendance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_today_attendance.Location = new System.Drawing.Point(6, 23);
            this.btn_view_today_attendance.Name = "btn_view_today_attendance";
            this.btn_view_today_attendance.Size = new System.Drawing.Size(134, 22);
            this.btn_view_today_attendance.TabIndex = 97;
            this.btn_view_today_attendance.TabStop = true;
            this.btn_view_today_attendance.Text = "Today Attendance";
            this.btn_view_today_attendance.UseVisualStyleBackColor = false;
            this.btn_view_today_attendance.CheckedChanged += new System.EventHandler(this.btn_view_today_attendance_CheckedChanged);
            // 
            // btn_view_month_attendance
            // 
            this.btn_view_month_attendance.AutoSize = true;
            this.btn_view_month_attendance.BackColor = System.Drawing.Color.White;
            this.btn_view_month_attendance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_month_attendance.Location = new System.Drawing.Point(151, 23);
            this.btn_view_month_attendance.Name = "btn_view_month_attendance";
            this.btn_view_month_attendance.Size = new System.Drawing.Size(167, 22);
            this.btn_view_month_attendance.TabIndex = 98;
            this.btn_view_month_attendance.Text = "This Month Attendance";
            this.btn_view_month_attendance.UseVisualStyleBackColor = false;
            this.btn_view_month_attendance.CheckedChanged += new System.EventHandler(this.btn_view_month_attendance_CheckedChanged);
            // 
            // groupBox_SearchByDate
            // 
            this.groupBox_SearchByDate.BackColor = System.Drawing.Color.White;
            this.groupBox_SearchByDate.Controls.Add(this.txt_search_specific_year);
            this.groupBox_SearchByDate.Controls.Add(this.txt_search_specific_day);
            this.groupBox_SearchByDate.Controls.Add(this.txt_search_specific_month);
            this.groupBox_SearchByDate.Location = new System.Drawing.Point(609, 5);
            this.groupBox_SearchByDate.Name = "groupBox_SearchByDate";
            this.groupBox_SearchByDate.Size = new System.Drawing.Size(206, 54);
            this.groupBox_SearchByDate.TabIndex = 122;
            this.groupBox_SearchByDate.TabStop = false;
            this.groupBox_SearchByDate.Text = "Search Data By Date";
            // 
            // txt_search_specific_year
            // 
            this.txt_search_specific_year.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_search_specific_year.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_search_specific_year.BackColor = System.Drawing.Color.White;
            this.txt_search_specific_year.DisplayMember = "Project_Date";
            this.txt_search_specific_year.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_specific_year.FormattingEnabled = true;
            this.txt_search_specific_year.Location = new System.Drawing.Point(6, 19);
            this.txt_search_specific_year.Name = "txt_search_specific_year";
            this.txt_search_specific_year.Size = new System.Drawing.Size(82, 26);
            this.txt_search_specific_year.TabIndex = 102;
            this.txt_search_specific_year.ValueMember = "Project_Date";
            this.txt_search_specific_year.SelectedIndexChanged += new System.EventHandler(this.txt_search_specific_year_SelectedIndexChanged);
            this.txt_search_specific_year.Click += new System.EventHandler(this.txt_search_specific_year_Click);
            // 
            // txt_search_specific_day
            // 
            this.txt_search_specific_day.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_search_specific_day.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_search_specific_day.BackColor = System.Drawing.Color.White;
            this.txt_search_specific_day.DisplayMember = "Name";
            this.txt_search_specific_day.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_specific_day.FormattingEnabled = true;
            this.txt_search_specific_day.Items.AddRange(new object[] {
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
            this.txt_search_specific_day.Location = new System.Drawing.Point(148, 19);
            this.txt_search_specific_day.Name = "txt_search_specific_day";
            this.txt_search_specific_day.Size = new System.Drawing.Size(52, 26);
            this.txt_search_specific_day.TabIndex = 101;
            this.txt_search_specific_day.ValueMember = "Name";
            this.txt_search_specific_day.SelectedIndexChanged += new System.EventHandler(this.txt_search_specific_day_SelectedIndexChanged);
            // 
            // txt_search_specific_month
            // 
            this.txt_search_specific_month.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_search_specific_month.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_search_specific_month.BackColor = System.Drawing.Color.White;
            this.txt_search_specific_month.DisplayMember = "Project_Date";
            this.txt_search_specific_month.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_specific_month.FormattingEnabled = true;
            this.txt_search_specific_month.Items.AddRange(new object[] {
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
            this.txt_search_specific_month.Location = new System.Drawing.Point(94, 19);
            this.txt_search_specific_month.Name = "txt_search_specific_month";
            this.txt_search_specific_month.Size = new System.Drawing.Size(48, 26);
            this.txt_search_specific_month.TabIndex = 100;
            this.txt_search_specific_month.ValueMember = "Project_Date";
            this.txt_search_specific_month.SelectedIndexChanged += new System.EventHandler(this.txt_search_specific_month_SelectedIndexChanged);
            this.txt_search_specific_month.Click += new System.EventHandler(this.txt_search_specific_month_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txt_search_EmpName);
            this.groupBox2.Controls.Add(this.txt_search_EmpID);
            this.groupBox2.Location = new System.Drawing.Point(333, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 54);
            this.groupBox2.TabIndex = 123;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SEARCH BY";
            // 
            // txt_search_EmpName
            // 
            this.txt_search_EmpName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_search_EmpName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_search_EmpName.BackColor = System.Drawing.Color.White;
            this.txt_search_EmpName.DisplayMember = "Name";
            this.txt_search_EmpName.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_EmpName.FormattingEnabled = true;
            this.txt_search_EmpName.Location = new System.Drawing.Point(6, 19);
            this.txt_search_EmpName.Name = "txt_search_EmpName";
            this.txt_search_EmpName.Size = new System.Drawing.Size(138, 26);
            this.txt_search_EmpName.TabIndex = 101;
            this.txt_search_EmpName.ValueMember = "Name";
            this.txt_search_EmpName.SelectedIndexChanged += new System.EventHandler(this.txt_search_EmpName_SelectedIndexChanged);
            this.txt_search_EmpName.Click += new System.EventHandler(this.txt_search_EmpName_Click);
            // 
            // txt_search_EmpID
            // 
            this.txt_search_EmpID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_search_EmpID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_search_EmpID.BackColor = System.Drawing.Color.White;
            this.txt_search_EmpID.DisplayMember = "Cons_ID";
            this.txt_search_EmpID.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_EmpID.FormattingEnabled = true;
            this.txt_search_EmpID.Location = new System.Drawing.Point(150, 19);
            this.txt_search_EmpID.Name = "txt_search_EmpID";
            this.txt_search_EmpID.Size = new System.Drawing.Size(110, 26);
            this.txt_search_EmpID.TabIndex = 100;
            this.txt_search_EmpID.ValueMember = "Cons_ID";
            this.txt_search_EmpID.SelectedIndexChanged += new System.EventHandler(this.txt_search_EmpID_SelectedIndexChanged);
            this.txt_search_EmpID.Click += new System.EventHandler(this.txt_search_EmpID_Click);
            // 
            // panel_today
            // 
            this.panel_today.Controls.Add(this.btn_generate_attendance);
            this.panel_today.Controls.Add(this.groupBox1);
            this.panel_today.Controls.Add(this.groupBox4);
            this.panel_today.Controls.Add(this.label10);
            this.panel_today.Controls.Add(this.label9);
            this.panel_today.Controls.Add(this.label11);
            this.panel_today.Controls.Add(this.label12);
            this.panel_today.Controls.Add(this.panel_today_data_unmarked);
            this.panel_today.Controls.Add(this.panel_today_data_marked);
            this.panel_today.Location = new System.Drawing.Point(10, 147);
            this.panel_today.Name = "panel_today";
            this.panel_today.Size = new System.Drawing.Size(1050, 441);
            this.panel_today.TabIndex = 127;
            // 
            // btn_generate_attendance
            // 
            this.btn_generate_attendance.BackColor = System.Drawing.Color.White;
            this.btn_generate_attendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generate_attendance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generate_attendance.Location = new System.Drawing.Point(876, 19);
            this.btn_generate_attendance.Name = "btn_generate_attendance";
            this.btn_generate_attendance.Size = new System.Drawing.Size(161, 40);
            this.btn_generate_attendance.TabIndex = 123;
            this.btn_generate_attendance.Text = "Generate Attendance";
            this.btn_generate_attendance.UseVisualStyleBackColor = false;
            this.btn_generate_attendance.Click += new System.EventHandler(this.btn_generate_attendance_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label_count_absent);
            this.groupBox1.Controls.Add(this.label_count_late);
            this.groupBox1.Controls.Add(this.label_count_leave);
            this.groupBox1.Controls.Add(this.label_count_marked);
            this.groupBox1.Controls.Add(this.label_count_unmarked);
            this.groupBox1.Controls.Add(this.label_count_present);
            this.groupBox1.Location = new System.Drawing.Point(249, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 47);
            this.groupBox1.TabIndex = 122;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COUNT";
            // 
            // label_count_absent
            // 
            this.label_count_absent.AutoSize = true;
            this.label_count_absent.BackColor = System.Drawing.Color.White;
            this.label_count_absent.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_count_absent.Location = new System.Drawing.Point(333, 19);
            this.label_count_absent.Name = "label_count_absent";
            this.label_count_absent.Size = new System.Drawing.Size(79, 18);
            this.label_count_absent.TabIndex = 128;
            this.label_count_absent.Text = "Absent : 10";
            // 
            // label_count_late
            // 
            this.label_count_late.AutoSize = true;
            this.label_count_late.BackColor = System.Drawing.Color.White;
            this.label_count_late.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_count_late.Location = new System.Drawing.Point(436, 19);
            this.label_count_late.Name = "label_count_late";
            this.label_count_late.Size = new System.Drawing.Size(63, 18);
            this.label_count_late.TabIndex = 126;
            this.label_count_late.Text = "Late : 10";
            // 
            // label_count_leave
            // 
            this.label_count_leave.AutoSize = true;
            this.label_count_leave.BackColor = System.Drawing.Color.White;
            this.label_count_leave.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_count_leave.Location = new System.Drawing.Point(522, 19);
            this.label_count_leave.Name = "label_count_leave";
            this.label_count_leave.Size = new System.Drawing.Size(72, 18);
            this.label_count_leave.TabIndex = 127;
            this.label_count_leave.Text = "Leave : 10";
            // 
            // label_count_marked
            // 
            this.label_count_marked.AutoSize = true;
            this.label_count_marked.BackColor = System.Drawing.Color.White;
            this.label_count_marked.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_count_marked.Location = new System.Drawing.Point(6, 19);
            this.label_count_marked.Name = "label_count_marked";
            this.label_count_marked.Size = new System.Drawing.Size(82, 18);
            this.label_count_marked.TabIndex = 125;
            this.label_count_marked.Text = "Marked : 10";
            // 
            // label_count_unmarked
            // 
            this.label_count_unmarked.AutoSize = true;
            this.label_count_unmarked.BackColor = System.Drawing.Color.White;
            this.label_count_unmarked.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_count_unmarked.Location = new System.Drawing.Point(109, 19);
            this.label_count_unmarked.Name = "label_count_unmarked";
            this.label_count_unmarked.Size = new System.Drawing.Size(100, 18);
            this.label_count_unmarked.TabIndex = 123;
            this.label_count_unmarked.Text = "Unmarked : 10";
            // 
            // label_count_present
            // 
            this.label_count_present.AutoSize = true;
            this.label_count_present.BackColor = System.Drawing.Color.White;
            this.label_count_present.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_count_present.Location = new System.Drawing.Point(224, 19);
            this.label_count_present.Name = "label_count_present";
            this.label_count_present.Size = new System.Drawing.Size(84, 18);
            this.label_count_present.TabIndex = 124;
            this.label_count_present.Text = "Present : 10";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.btn_view_unmarked_attendance);
            this.groupBox4.Controls.Add(this.btn_view_marked_attendance);
            this.groupBox4.Location = new System.Drawing.Point(71, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(172, 47);
            this.groupBox4.TabIndex = 121;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "VIEW";
            // 
            // btn_view_unmarked_attendance
            // 
            this.btn_view_unmarked_attendance.AutoSize = true;
            this.btn_view_unmarked_attendance.BackColor = System.Drawing.Color.White;
            this.btn_view_unmarked_attendance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_unmarked_attendance.Location = new System.Drawing.Point(83, 19);
            this.btn_view_unmarked_attendance.Name = "btn_view_unmarked_attendance";
            this.btn_view_unmarked_attendance.Size = new System.Drawing.Size(89, 22);
            this.btn_view_unmarked_attendance.TabIndex = 99;
            this.btn_view_unmarked_attendance.Text = "Unmarked";
            this.btn_view_unmarked_attendance.UseVisualStyleBackColor = false;
            this.btn_view_unmarked_attendance.CheckedChanged += new System.EventHandler(this.btn_view_unmarked_attendance_CheckedChanged);
            // 
            // btn_view_marked_attendance
            // 
            this.btn_view_marked_attendance.AutoSize = true;
            this.btn_view_marked_attendance.BackColor = System.Drawing.Color.White;
            this.btn_view_marked_attendance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_marked_attendance.Location = new System.Drawing.Point(6, 19);
            this.btn_view_marked_attendance.Name = "btn_view_marked_attendance";
            this.btn_view_marked_attendance.Size = new System.Drawing.Size(71, 22);
            this.btn_view_marked_attendance.TabIndex = 98;
            this.btn_view_marked_attendance.Text = "Marked";
            this.btn_view_marked_attendance.UseVisualStyleBackColor = false;
            this.btn_view_marked_attendance.CheckedChanged += new System.EventHandler(this.btn_view_marked_attendance_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(227, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 18);
            this.label10.TabIndex = 119;
            this.label10.Text = "Employee Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(661, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 18);
            this.label9.TabIndex = 117;
            this.label9.Text = "Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(413, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 18);
            this.label11.TabIndex = 104;
            this.label11.Text = "Employee ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(562, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 18);
            this.label12.TabIndex = 105;
            this.label12.Text = "Date";
            // 
            // panel_today_data_unmarked
            // 
            this.panel_today_data_unmarked.AutoScroll = true;
            this.panel_today_data_unmarked.BackColor = System.Drawing.Color.White;
            this.panel_today_data_unmarked.Location = new System.Drawing.Point(230, 100);
            this.panel_today_data_unmarked.Name = "panel_today_data_unmarked";
            this.panel_today_data_unmarked.Size = new System.Drawing.Size(666, 313);
            this.panel_today_data_unmarked.TabIndex = 120;
            // 
            // panel_today_data_marked
            // 
            this.panel_today_data_marked.AutoScroll = true;
            this.panel_today_data_marked.BackColor = System.Drawing.Color.White;
            this.panel_today_data_marked.Location = new System.Drawing.Point(230, 100);
            this.panel_today_data_marked.Name = "panel_today_data_marked";
            this.panel_today_data_marked.Size = new System.Drawing.Size(666, 313);
            this.panel_today_data_marked.TabIndex = 101;
            // 
            // panel_month_overall
            // 
            this.panel_month_overall.Controls.Add(this.groupBox_SearchByDate);
            this.panel_month_overall.Controls.Add(this.groupBox2);
            this.panel_month_overall.Controls.Add(this.label2);
            this.panel_month_overall.Controls.Add(this.label3);
            this.panel_month_overall.Controls.Add(this.label8);
            this.panel_month_overall.Controls.Add(this.label13);
            this.panel_month_overall.Controls.Add(this.label14);
            this.panel_month_overall.Controls.Add(this.label15);
            this.panel_month_overall.Controls.Add(this.panel_overall_data);
            this.panel_month_overall.Controls.Add(this.panel_month_data);
            this.panel_month_overall.Location = new System.Drawing.Point(10, 147);
            this.panel_month_overall.Name = "panel_month_overall";
            this.panel_month_overall.Size = new System.Drawing.Size(1050, 449);
            this.panel_month_overall.TabIndex = 128;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(626, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 121;
            this.label2.Text = "Intime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(712, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 122;
            this.label3.Text = "Outtime";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(199, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 18);
            this.label8.TabIndex = 119;
            this.label8.Text = "Employee Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(813, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 18);
            this.label13.TabIndex = 117;
            this.label13.Text = "Status";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(385, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 18);
            this.label14.TabIndex = 104;
            this.label14.Text = "Employee ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(534, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 18);
            this.label15.TabIndex = 105;
            this.label15.Text = "Date";
            // 
            // panel_overall_data
            // 
            this.panel_overall_data.AutoScroll = true;
            this.panel_overall_data.BackColor = System.Drawing.Color.White;
            this.panel_overall_data.Location = new System.Drawing.Point(202, 100);
            this.panel_overall_data.Name = "panel_overall_data";
            this.panel_overall_data.Size = new System.Drawing.Size(777, 310);
            this.panel_overall_data.TabIndex = 101;
            // 
            // panel_month_data
            // 
            this.panel_month_data.AutoScroll = true;
            this.panel_month_data.BackColor = System.Drawing.Color.White;
            this.panel_month_data.Location = new System.Drawing.Point(202, 100);
            this.panel_month_data.Name = "panel_month_data";
            this.panel_month_data.Size = new System.Drawing.Size(777, 310);
            this.panel_month_data.TabIndex = 120;
            // 
            // Attendance_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 600);
            this.Controls.Add(this.groupBox_View);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_today);
            this.Controls.Add(this.panel_month_overall);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Attendance_Form";
            this.Text = "Attendance_Form";
            this.Load += new System.EventHandler(this.Attendance_Form_Load);
            this.groupBox_View.ResumeLayout(false);
            this.groupBox_View.PerformLayout();
            this.groupBox_SearchByDate.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel_today.ResumeLayout(false);
            this.panel_today.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel_month_overall.ResumeLayout(false);
            this.panel_month_overall.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_View;
        private System.Windows.Forms.GroupBox groupBox_SearchByDate;
        private System.Windows.Forms.ComboBox txt_search_specific_year;
        private System.Windows.Forms.ComboBox txt_search_specific_day;
        private System.Windows.Forms.ComboBox txt_search_specific_month;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox txt_search_EmpName;
        private System.Windows.Forms.ComboBox txt_search_EmpID;
        private System.Windows.Forms.Panel panel_today;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel_today_data_unmarked;
        private System.Windows.Forms.Panel panel_today_data_marked;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label_count_absent;
        public System.Windows.Forms.Label label_count_late;
        public System.Windows.Forms.Label label_count_leave;
        public System.Windows.Forms.Label label_count_marked;
        public System.Windows.Forms.Label label_count_unmarked;
        public System.Windows.Forms.Label label_count_present;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_generate_attendance;
        private System.Windows.Forms.Panel panel_month_overall;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel_overall_data;
        private System.Windows.Forms.Panel panel_month_data;
        public System.Windows.Forms.RadioButton btn_view_overall_attendance;
        public System.Windows.Forms.RadioButton btn_view_today_attendance;
        public System.Windows.Forms.RadioButton btn_view_month_attendance;
        public System.Windows.Forms.RadioButton btn_view_unmarked_attendance;
        public System.Windows.Forms.RadioButton btn_view_marked_attendance;
    }
}