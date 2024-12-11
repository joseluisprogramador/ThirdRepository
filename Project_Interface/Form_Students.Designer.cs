namespace Project_Interface
{
    partial class Form_Students
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridView_ShowStudentsQuery = new DataGridView();
            Button_AddStudent = new Button();
            Button_EditStudent = new Button();
            Button_DeleteStudent = new Button();
            TextBox_SearchStudent = new TextBox();
            GroupBox_SearchStudent = new GroupBox();
            CheckBox_CodeStudent = new CheckBox();
            CheckBox_NamesStudent = new CheckBox();
            CheckBox_CourseStudent = new CheckBox();
            GroupBox_FilterBy = new GroupBox();
            Button_Test = new Button();
            Label_DateAndTimeCurrent = new Label();
            Timer_TimerReal = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)DataGridView_ShowStudentsQuery).BeginInit();
            GroupBox_SearchStudent.SuspendLayout();
            GroupBox_FilterBy.SuspendLayout();
            SuspendLayout();
            // 
            // DataGridView_ShowStudentsQuery
            // 
            DataGridView_ShowStudentsQuery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DataGridView_ShowStudentsQuery.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridView_ShowStudentsQuery.BackgroundColor = Color.Snow;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGridView_ShowStudentsQuery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataGridView_ShowStudentsQuery.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Snow;
            dataGridViewCellStyle2.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = Color.Salmon;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DataGridView_ShowStudentsQuery.DefaultCellStyle = dataGridViewCellStyle2;
            DataGridView_ShowStudentsQuery.GridColor = Color.CornflowerBlue;
            DataGridView_ShowStudentsQuery.Location = new Point(12, 168);
            DataGridView_ShowStudentsQuery.Name = "DataGridView_ShowStudentsQuery";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DataGridView_ShowStudentsQuery.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DataGridView_ShowStudentsQuery.RowHeadersWidth = 51;
            DataGridView_ShowStudentsQuery.RowTemplate.Height = 25;
            DataGridView_ShowStudentsQuery.Size = new Size(660, 186);
            DataGridView_ShowStudentsQuery.TabIndex = 1;
            // 
            // Button_AddStudent
            // 
            Button_AddStudent.FlatStyle = FlatStyle.Flat;
            Button_AddStudent.Font = new Font("Roboto", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Button_AddStudent.ForeColor = Color.Salmon;
            Button_AddStudent.Location = new Point(104, 366);
            Button_AddStudent.Name = "Button_AddStudent";
            Button_AddStudent.Size = new Size(155, 45);
            Button_AddStudent.TabIndex = 3;
            Button_AddStudent.Text = "Add Student";
            Button_AddStudent.UseVisualStyleBackColor = false;
            Button_AddStudent.Click += Button_AddStudent_Click;
            // 
            // Button_EditStudent
            // 
            Button_EditStudent.FlatStyle = FlatStyle.Flat;
            Button_EditStudent.Font = new Font("Roboto", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Button_EditStudent.ForeColor = Color.Salmon;
            Button_EditStudent.Location = new Point(265, 366);
            Button_EditStudent.Name = "Button_EditStudent";
            Button_EditStudent.Size = new Size(155, 45);
            Button_EditStudent.TabIndex = 4;
            Button_EditStudent.Text = "Edit Student";
            Button_EditStudent.UseVisualStyleBackColor = false;
            Button_EditStudent.Click += Button_EditStudent_Click;
            // 
            // Button_DeleteStudent
            // 
            Button_DeleteStudent.FlatStyle = FlatStyle.Flat;
            Button_DeleteStudent.Font = new Font("Roboto", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Button_DeleteStudent.ForeColor = Color.Salmon;
            Button_DeleteStudent.Location = new Point(426, 366);
            Button_DeleteStudent.Name = "Button_DeleteStudent";
            Button_DeleteStudent.Size = new Size(155, 45);
            Button_DeleteStudent.TabIndex = 5;
            Button_DeleteStudent.Text = "Delete Student";
            Button_DeleteStudent.UseVisualStyleBackColor = false;
            Button_DeleteStudent.Click += Button_DeleteStudent_Click;
            // 
            // TextBox_SearchStudent
            // 
            TextBox_SearchStudent.Location = new Point(20, 28);
            TextBox_SearchStudent.Multiline = true;
            TextBox_SearchStudent.Name = "TextBox_SearchStudent";
            TextBox_SearchStudent.Size = new Size(219, 24);
            TextBox_SearchStudent.TabIndex = 0;
            TextBox_SearchStudent.TextChanged += TextBox_SearchStudent_TextChanged;
            TextBox_SearchStudent.KeyPress += TextBox_SearchStudent_KeyPress;
            // 
            // GroupBox_SearchStudent
            // 
            GroupBox_SearchStudent.Controls.Add(TextBox_SearchStudent);
            GroupBox_SearchStudent.Font = new Font("Roboto", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBox_SearchStudent.ForeColor = Color.Black;
            GroupBox_SearchStudent.Location = new Point(20, 59);
            GroupBox_SearchStudent.Name = "GroupBox_SearchStudent";
            GroupBox_SearchStudent.Size = new Size(258, 72);
            GroupBox_SearchStudent.TabIndex = 9;
            GroupBox_SearchStudent.TabStop = false;
            GroupBox_SearchStudent.Text = "Search Student";
            // 
            // CheckBox_CodeStudent
            // 
            CheckBox_CodeStudent.AutoSize = true;
            CheckBox_CodeStudent.Font = new Font("Roboto", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CheckBox_CodeStudent.ForeColor = Color.Black;
            CheckBox_CodeStudent.Location = new Point(20, 31);
            CheckBox_CodeStudent.Name = "CheckBox_CodeStudent";
            CheckBox_CodeStudent.Size = new Size(117, 22);
            CheckBox_CodeStudent.TabIndex = 1;
            CheckBox_CodeStudent.Text = "Code Student";
            CheckBox_CodeStudent.UseVisualStyleBackColor = true;
            CheckBox_CodeStudent.CheckedChanged += CheckBox_CodeStudent_CheckedChanged;
            // 
            // CheckBox_NamesStudent
            // 
            CheckBox_NamesStudent.AutoSize = true;
            CheckBox_NamesStudent.Font = new Font("Roboto", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CheckBox_NamesStudent.ForeColor = Color.Black;
            CheckBox_NamesStudent.Location = new Point(153, 30);
            CheckBox_NamesStudent.Name = "CheckBox_NamesStudent";
            CheckBox_NamesStudent.Size = new Size(130, 22);
            CheckBox_NamesStudent.TabIndex = 2;
            CheckBox_NamesStudent.Text = "Names Student";
            CheckBox_NamesStudent.UseVisualStyleBackColor = true;
            CheckBox_NamesStudent.CheckedChanged += CheckBox_NamesStudent_CheckedChanged;
            // 
            // CheckBox_CourseStudent
            // 
            CheckBox_CourseStudent.AutoSize = true;
            CheckBox_CourseStudent.Font = new Font("Roboto", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CheckBox_CourseStudent.ForeColor = Color.Black;
            CheckBox_CourseStudent.Location = new Point(299, 30);
            CheckBox_CourseStudent.Name = "CheckBox_CourseStudent";
            CheckBox_CourseStudent.Size = new Size(130, 22);
            CheckBox_CourseStudent.TabIndex = 3;
            CheckBox_CourseStudent.Text = "Course Student";
            CheckBox_CourseStudent.UseVisualStyleBackColor = true;
            CheckBox_CourseStudent.CheckedChanged += CheckBox_CourseStudent_CheckedChanged;
            // 
            // GroupBox_FilterBy
            // 
            GroupBox_FilterBy.Controls.Add(Button_Test);
            GroupBox_FilterBy.Controls.Add(Label_DateAndTimeCurrent);
            GroupBox_FilterBy.Controls.Add(CheckBox_CourseStudent);
            GroupBox_FilterBy.Controls.Add(CheckBox_NamesStudent);
            GroupBox_FilterBy.Controls.Add(GroupBox_SearchStudent);
            GroupBox_FilterBy.Controls.Add(CheckBox_CodeStudent);
            GroupBox_FilterBy.Font = new Font("Roboto", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBox_FilterBy.ForeColor = Color.Black;
            GroupBox_FilterBy.Location = new Point(12, 15);
            GroupBox_FilterBy.Name = "GroupBox_FilterBy";
            GroupBox_FilterBy.Size = new Size(660, 147);
            GroupBox_FilterBy.TabIndex = 4;
            GroupBox_FilterBy.TabStop = false;
            GroupBox_FilterBy.Text = "Filter By";
            // 
            // Button_Test
            // 
            Button_Test.Location = new Point(594, 23);
            Button_Test.Margin = new Padding(3, 2, 3, 2);
            Button_Test.Name = "Button_Test";
            Button_Test.Size = new Size(52, 26);
            Button_Test.TabIndex = 11;
            Button_Test.Text = "Test";
            Button_Test.UseVisualStyleBackColor = true;
            Button_Test.Click += Button_Test_Click;
            // 
            // Label_DateAndTimeCurrent
            // 
            Label_DateAndTimeCurrent.AutoSize = true;
            Label_DateAndTimeCurrent.Font = new Font("Roboto", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label_DateAndTimeCurrent.ForeColor = Color.Black;
            Label_DateAndTimeCurrent.Location = new Point(432, 108);
            Label_DateAndTimeCurrent.Name = "Label_DateAndTimeCurrent";
            Label_DateAndTimeCurrent.Size = new Size(11, 18);
            Label_DateAndTimeCurrent.TabIndex = 10;
            Label_DateAndTimeCurrent.Text = "'";
            // 
            // Timer_TimerReal
            // 
            Timer_TimerReal.Tick += Timer_TimerReal_Tick;
            // 
            // Form_Students
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(685, 423);
            Controls.Add(GroupBox_FilterBy);
            Controls.Add(Button_DeleteStudent);
            Controls.Add(Button_EditStudent);
            Controls.Add(Button_AddStudent);
            Controls.Add(DataGridView_ShowStudentsQuery);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form_Students";
            ((System.ComponentModel.ISupportInitialize)DataGridView_ShowStudentsQuery).EndInit();
            GroupBox_SearchStudent.ResumeLayout(false);
            GroupBox_SearchStudent.PerformLayout();
            GroupBox_FilterBy.ResumeLayout(false);
            GroupBox_FilterBy.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public DataGridView DataGridView_ShowStudentsQuery;
        private Button Button_AddStudent;
        private Button Button_EditStudent;
        private Button Button_DeleteStudent;
        private TextBox TextBox_SearchStudent;
        private GroupBox GroupBox_SearchStudent;
        private CheckBox CheckBox_CourseStudent;
        private CheckBox CheckBox_NamesStudent;
        private CheckBox CheckBox_CodeStudent;
        private GroupBox GroupBox_FilterBy;
        private Label Label_DateAndTimeCurrent;
        private System.Windows.Forms.Timer Timer_TimerReal;
        private Button Button_Test;
    }
}
