
using Project_Connection.Class_Connection;
using System.Data;
using Project_Logic.Class_Logic;
using System.Globalization;
using System.Text.RegularExpressions;
using Timer = System.Windows.Forms.Timer ;

namespace Project_Interface
{
    public partial class Form_Students : Form
    {

        public Form_Students()
        {
            InitializeComponent();
            ShowQueryStudentsList();
            ShowCurrentDateAndTime();
            TextBox_SearchStudent.Enabled = false;
            Timer_TimerReal.Start();

        }

        /*FUNCIONES*/
        public static void TestConnection()
        {

            (bool IsConnect, Exception? oException) = Class_Connection.Connection();

            if (IsConnect is false && oException is not null)
            {
                MessageBox.Show($"Error Of Connection : {oException.Message}");
            }
            else
            {
    
                MessageBox.Show("Verifying connection. . .");
                MessageBox.Show("Connected", "Message Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void Button_Test_Click(object sender, EventArgs e)
        {
            TestConnection();
        }

        public void ShowQueryStudentsList()
        {
            (List<Class_Students>, Exception?) TestQuery = Class_LogicToSelectQuery.QueryStudentsSelect();
            (List<Class_Students> oListStudent, Exception? oException) = TestQuery;

            if (oException is not null)
            {
                MessageBox.Show($"I cannot make the query {oException.Message}");
            }
            else
            {
                DataGridView_ShowStudentsQuery.DataSource = oListStudent;
            }

        }
        public void EditQueryStudentList()
        {
            oFormProcedures = new Form_Procedures();

            foreach (DataGridViewRow oRow in DataGridView_ShowStudentsQuery.Rows)
            {
                if (DataGridView_ShowStudentsQuery.SelectedRows.Count > 1)
                {
                    break;
                }

                if (oRow.Selected)
                {
                    oFormProcedures.EditMode = oRow.Selected;
                    oFormProcedures.SelectedStudentId = Convert.ToInt32(oRow.Cells[0].Value);
                    oFormProcedures.PTextBox_StudentId = oRow.Cells[0].Value.ToString();
                    oFormProcedures.PTextBox_StudentNames = oRow.Cells[1].Value.ToString();
                    oFormProcedures.PTextBox_StudentLastNames = oRow.Cells[2].Value.ToString();
                    oFormProcedures.PComboBox_StudentAge = oRow.Cells[3].Value.ToString();
                    oFormProcedures.PComboBox_StudentCourse = oRow.Cells[4].Value.ToString();
                    oFormProcedures.PTextBox_StudentTeacher = oRow.Cells[5].Value.ToString();

                    oFormProcedures.ShowDialog();
                    ShowQueryStudentsList();
                }

            }

        }
        public void DeleteQueryStudentsList()
        {

            foreach (DataGridViewRow oDataGridViewRow
                in DataGridView_ShowStudentsQuery.Rows)
            {

                if (oDataGridViewRow.Selected)
                {
                    int StudentId = Convert.ToInt32(oDataGridViewRow.Cells[0].Value);

                    (bool, Exception?) TestDelete =
                    Class_LogicToDeleteQueryData.
                    QueryStudentsDelete(StudentId);

                    (bool oEdit, Exception? oException) = TestDelete;

                    if (oEdit is false && oException is not null)
                    {
                        MessageBox.Show($"No se pudo eliminar el estudiante {oException.Message}");
                    }

                    ShowQueryStudentsList();

                }

            }

        }
        public void ShowCurrentDateAndTime()
        {
            DateTime DateAndTime = DateTime.Now;
            string DateAndTimeModified = DateAndTime.ToString("dd/MM/yyyy HH:mm:ss");
            Label_DateAndTimeCurrent.Text = Label_DateAndTimeCurrent.Text + DateAndTimeModified;
        }

        /*EVENTOS*/

        private void Timer_TimerReal_Tick(object sender, EventArgs e)
        {
            DateTime oDateTime = DateTime.Now;
            Label_DateAndTimeCurrent.Text = oDateTime.ToString("HH:mm:ss");
        }


        Form_Procedures? oFormProcedures = null;
        private void Button_AddStudent_Click(object sender, EventArgs e)
        {
            oFormProcedures = new Form_Procedures();
            oFormProcedures.ShowDialog();
            ShowQueryStudentsList();
        }
        private void Button_EditStudent_Click(object sender, EventArgs e)
        {
            EditQueryStudentList();
        }
        private void Button_DeleteStudent_Click(object sender, EventArgs e)
        {
            DeleteQueryStudentsList();
        }
        private void TextBox_SearchStudent_TextChanged(object sender, EventArgs e)
        {

            string InputText = TextBox_SearchStudent.Text;
            TextInfo oTextInfo = CultureInfo.CurrentCulture.TextInfo;
            string CapitalizedText = oTextInfo.ToTitleCase(InputText);
            TextBox_SearchStudent.Text = CapitalizedText;
            TextBox_SearchStudent.SelectionStart = TextBox_SearchStudent.Text.Length;

            string SearchText = TextBox_SearchStudent.Text;

            // Verifica si el DataSource es nulo y si no, realiza la búsqueda
            if (DataGridView_ShowStudentsQuery.DataSource is List<Class_Students> StudentsList)
            {

                if (!string.IsNullOrEmpty(SearchText))
                {
                    if (int.TryParse(SearchText, out _))
                    {
                        List<Class_Students> FilteredList =
                            StudentsList.Where(Student => Student.Id.ToString().Contains(SearchText)).ToList();
                        DataGridView_ShowStudentsQuery.DataSource = FilteredList;
                    }
                    else
                    {
                        if (!int.TryParse(SearchText, out _))
                        {
                            List<Class_Students> FilteredList =
                           StudentsList.Where(Student => Student.StudentNames != null
                           && Student.StudentNames.Contains(SearchText)).ToList();
                            DataGridView_ShowStudentsQuery.DataSource = FilteredList;
                        }
                        else
                        {
                            List<Class_Students> FilteredList =
                           StudentsList.Where(Student => Student.Course != null
                           && Student.Course.Contains(SearchText)).ToList();
                            DataGridView_ShowStudentsQuery.DataSource = FilteredList;
                        }

                    }

                }
                else
                {
                    ShowQueryStudentsList();
                }

            }

            if (CheckBox_CourseStudent.Checked is true)
            {
                oFormProcedures = new Form_Procedures();
                string Pattern = @"^[6-9]|1[0-1][A-D]$";

                if (!Regex.IsMatch(TextBox_SearchStudent.Text, Pattern))
                {
                    TextBox_SearchStudent.Text = "";
                }
            }

        }

        private void Timer_DateAndTimeCurrent_Tick(object sender, EventArgs e)
        {
            ShowCurrentDateAndTime();
        }

        private void CheckBox_CodeStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_CodeStudent.Checked is true)
            {
                CheckBox_NamesStudent.Enabled = false;
                CheckBox_CourseStudent.Enabled = false;
                TextBox_SearchStudent.Enabled = true;
            }
            else
            {
                CheckBox_NamesStudent.Enabled = true;
                CheckBox_CourseStudent.Enabled = true;
                TextBox_SearchStudent.Enabled = false;
            }
        }

        private void CheckBox_NamesStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_NamesStudent.Checked is true)
            {
                CheckBox_CodeStudent.Enabled = false;
                CheckBox_CourseStudent.Enabled = false;
                TextBox_SearchStudent.Enabled = true;
            }
            else
            {
                CheckBox_CodeStudent.Enabled = true;
                CheckBox_CourseStudent.Enabled = true;
                TextBox_SearchStudent.Enabled = false;
            }
        }

        private void CheckBox_CourseStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_CourseStudent.Checked is true)
            {
                CheckBox_CodeStudent.Enabled = false;
                CheckBox_NamesStudent.Enabled = false;
                TextBox_SearchStudent.Enabled = true;
            }
            else
            {
                CheckBox_CodeStudent.Enabled = true;
                CheckBox_NamesStudent.Enabled = true;
                TextBox_SearchStudent.Enabled = false;
            }
        }

        private void TextBox_SearchStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CheckBox_CodeStudent.Checked is true)
            {
                if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == 8))
                {
                    e.Handled = true;
                }
            }

            if (CheckBox_NamesStudent.Checked is true)
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !(e.KeyChar == 8))
                {
                    e.Handled = true;
                }
            }

        }

    }
}



