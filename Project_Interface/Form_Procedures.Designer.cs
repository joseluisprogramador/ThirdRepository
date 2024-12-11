namespace Project_Interface
{
    partial class Form_Procedures
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
            GroupBox_StudentTeacher = new GroupBox();
            Button_Save = new Button();
            TextBox_StudentTeacher = new TextBox();
            label1 = new Label();
            label6 = new Label();
            ComboBox_StudentCourse = new ComboBox();
            label2 = new Label();
            TextBox_StudentId = new TextBox();
            TextBox_StudentNames = new TextBox();
            ComboBox_StudentAge = new ComboBox();
            label3 = new Label();
            label5 = new Label();
            TextBox_StudentLastNames = new TextBox();
            label4 = new Label();
            GroupBox_StudentTeacher.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBox_StudentTeacher
            // 
            GroupBox_StudentTeacher.BackColor = Color.Snow;
            GroupBox_StudentTeacher.Controls.Add(Button_Save);
            GroupBox_StudentTeacher.Controls.Add(TextBox_StudentTeacher);
            GroupBox_StudentTeacher.Controls.Add(label1);
            GroupBox_StudentTeacher.Controls.Add(label6);
            GroupBox_StudentTeacher.Controls.Add(ComboBox_StudentCourse);
            GroupBox_StudentTeacher.Controls.Add(label2);
            GroupBox_StudentTeacher.Controls.Add(TextBox_StudentId);
            GroupBox_StudentTeacher.Controls.Add(TextBox_StudentNames);
            GroupBox_StudentTeacher.Controls.Add(ComboBox_StudentAge);
            GroupBox_StudentTeacher.Controls.Add(label3);
            GroupBox_StudentTeacher.Controls.Add(label5);
            GroupBox_StudentTeacher.Controls.Add(TextBox_StudentLastNames);
            GroupBox_StudentTeacher.Controls.Add(label4);
            GroupBox_StudentTeacher.FlatStyle = FlatStyle.Flat;
            GroupBox_StudentTeacher.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBox_StudentTeacher.ForeColor = Color.Black;
            GroupBox_StudentTeacher.Location = new Point(12, 12);
            GroupBox_StudentTeacher.Name = "GroupBox_StudentTeacher";
            GroupBox_StudentTeacher.Size = new Size(256, 367);
            GroupBox_StudentTeacher.TabIndex = 0;
            GroupBox_StudentTeacher.TabStop = false;
            GroupBox_StudentTeacher.Text = "Procedures";
            // 
            // Button_Save
            // 
            Button_Save.FlatStyle = FlatStyle.Flat;
            Button_Save.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Button_Save.ForeColor = Color.Salmon;
            Button_Save.Location = new Point(69, 321);
            Button_Save.Name = "Button_Save";
            Button_Save.Size = new Size(113, 29);
            Button_Save.TabIndex = 1;
            Button_Save.Text = "Save Student";
            Button_Save.UseVisualStyleBackColor = true;
            Button_Save.Click += Button_Save_Click;
            // 
            // TextBox_StudentTeacher
            // 
            TextBox_StudentTeacher.BackColor = Color.White;
            TextBox_StudentTeacher.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_StudentTeacher.ForeColor = Color.Black;
            TextBox_StudentTeacher.Location = new Point(36, 279);
            TextBox_StudentTeacher.Multiline = true;
            TextBox_StudentTeacher.Name = "TextBox_StudentTeacher";
            TextBox_StudentTeacher.Size = new Size(186, 26);
            TextBox_StudentTeacher.TabIndex = 1;
            TextBox_StudentTeacher.TextChanged += TextBox_StudentTeacher_TextChanged;
            TextBox_StudentTeacher.KeyPress += TextBox_StudentTeacher_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 31);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 11;
            label1.Text = "Student Id";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(36, 81);
            label6.Name = "label6";
            label6.Size = new Size(92, 17);
            label6.TabIndex = 16;
            label6.Text = "Student Names";
            // 
            // ComboBox_StudentCourse
            // 
            ComboBox_StudentCourse.BackColor = Color.White;
            ComboBox_StudentCourse.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBox_StudentCourse.ForeColor = Color.Black;
            ComboBox_StudentCourse.FormattingEnabled = true;
            ComboBox_StudentCourse.Items.AddRange(new object[] { "6°A", "6°B", "6°C", "6°D", "7°A", "7°B", "7°C", "7°D", "8°A", "8°B", "8°C", "8°D", "9°A", "9°B", "9°C", "9°D", "10°A", "10°B", "10°C", "10°D", "11°A", "11°B", "11°C", "11°D" });
            ComboBox_StudentCourse.Location = new Point(36, 234);
            ComboBox_StudentCourse.Name = "ComboBox_StudentCourse";
            ComboBox_StudentCourse.Size = new Size(186, 25);
            ComboBox_StudentCourse.TabIndex = 0;
            ComboBox_StudentCourse.KeyPress += ComboBox_StudentCourse_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 262);
            label2.Name = "label2";
            label2.Size = new Size(100, 17);
            label2.TabIndex = 12;
            label2.Text = "Student Teacher";
            // 
            // TextBox_StudentId
            // 
            TextBox_StudentId.BackColor = Color.White;
            TextBox_StudentId.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_StudentId.ForeColor = Color.Black;
            TextBox_StudentId.Location = new Point(36, 52);
            TextBox_StudentId.Multiline = true;
            TextBox_StudentId.Name = "TextBox_StudentId";
            TextBox_StudentId.Size = new Size(186, 26);
            TextBox_StudentId.TabIndex = 1;
            TextBox_StudentId.KeyPress += TextBox_StudentId_KeyPress;
            // 
            // TextBox_StudentNames
            // 
            TextBox_StudentNames.BackColor = Color.White;
            TextBox_StudentNames.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_StudentNames.ForeColor = Color.Black;
            TextBox_StudentNames.Location = new Point(36, 101);
            TextBox_StudentNames.Multiline = true;
            TextBox_StudentNames.Name = "TextBox_StudentNames";
            TextBox_StudentNames.Size = new Size(186, 26);
            TextBox_StudentNames.TabIndex = 1;
            TextBox_StudentNames.TextChanged += TextBox_StudentNames_TextChanged;
            TextBox_StudentNames.KeyPress += TextBox_StudentNames_KeyPress;
            // 
            // ComboBox_StudentAge
            // 
            ComboBox_StudentAge.BackColor = Color.White;
            ComboBox_StudentAge.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBox_StudentAge.ForeColor = Color.Black;
            ComboBox_StudentAge.FormattingEnabled = true;
            ComboBox_StudentAge.Items.AddRange(new object[] { "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            ComboBox_StudentAge.Location = new Point(36, 190);
            ComboBox_StudentAge.Name = "ComboBox_StudentAge";
            ComboBox_StudentAge.Size = new Size(186, 25);
            ComboBox_StudentAge.TabIndex = 1;
            ComboBox_StudentAge.KeyPress += ComboBox_StudentAge_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(36, 217);
            label3.Name = "label3";
            label3.Size = new Size(93, 17);
            label3.TabIndex = 13;
            label3.Text = "Student Course";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(36, 126);
            label5.Name = "label5";
            label5.Size = new Size(117, 17);
            label5.TabIndex = 15;
            label5.Text = "Student LastNames";
            // 
            // TextBox_StudentLastNames
            // 
            TextBox_StudentLastNames.BackColor = Color.White;
            TextBox_StudentLastNames.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_StudentLastNames.ForeColor = Color.Black;
            TextBox_StudentLastNames.Location = new Point(36, 147);
            TextBox_StudentLastNames.Multiline = true;
            TextBox_StudentLastNames.Name = "TextBox_StudentLastNames";
            TextBox_StudentLastNames.Size = new Size(186, 26);
            TextBox_StudentLastNames.TabIndex = 1;
            TextBox_StudentLastNames.TextChanged += TextBox_StudentLastNames_TextChanged;
            TextBox_StudentLastNames.KeyPress += TextBox_StudentLastNames_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(36, 173);
            label4.Name = "label4";
            label4.Size = new Size(76, 17);
            label4.TabIndex = 14;
            label4.Text = "Student Age";
            // 
            // Form_Procedures
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(280, 390);
            Controls.Add(GroupBox_StudentTeacher);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form_Procedures";
            GroupBox_StudentTeacher.ResumeLayout(false);
            GroupBox_StudentTeacher.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupBox_StudentTeacher;
        private TextBox TextBox_StudentNames;
        private TextBox TextBox_StudentId;
        private TextBox TextBox_StudentLastNames;
        private TextBox TextBox_StudentTeacher;
        private ComboBox ComboBox_StudentCourse;
        private ComboBox ComboBox_StudentAge;
        private Button Button_Save;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}