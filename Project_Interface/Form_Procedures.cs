using Project_Logic.Class_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms ;

namespace Project_Interface
{
    public partial class Form_Procedures : Form
    {

        public Form_Procedures()
        {
            InitializeComponent();
        }

        public string ? PTextBox_StudentId  
        { 
            get { return TextBox_StudentId.Text;  } 
            set { TextBox_StudentId.Text = value ; }   
        }
        public string ? PTextBox_StudentNames
        {
            get { return TextBox_StudentNames.Text; }
            set { TextBox_StudentNames.Text = value; }
        }

        public string ? PTextBox_StudentLastNames
        {
            get { return TextBox_StudentLastNames.Text; }
            set { TextBox_StudentLastNames.Text = value; }
        }

        public string ? PComboBox_StudentAge
        {
            get { return ComboBox_StudentAge.Text; }
            set { ComboBox_StudentAge.Text = value; }
        }

        public string ? PComboBox_StudentCourse
        {
            get { return ComboBox_StudentCourse.Text; }
            set { ComboBox_StudentCourse.Text = value; }
        }

        public string ? PTextBox_StudentTeacher
        {
            get { return TextBox_StudentTeacher.Text; }
            set { TextBox_StudentTeacher.Text = value; }
        }

        public void ClearInputText()
        {
            foreach (Control oControl in Controls)
            {
                if (oControl is TextBox oTextBox && oControl is ComboBox oComboBox)
                {
                    oTextBox.Clear();
                    oComboBox.Text = "";
                }
            }
        }
        public bool EditMode { get; set; } = false;
        public int SelectedStudentId { get; set; }
        public void AddQueryStudentsList()
        {

            string StudentNames = TextBox_StudentNames.Text;
            string StudentLastNames = TextBox_StudentLastNames.Text;
            int StudentAge = Convert.ToInt32(Convert.ToString(ComboBox_StudentAge.SelectedItem));
            string? StudentCourse = Convert.ToString(ComboBox_StudentCourse.SelectedItem);
            string StudentTeacher = TextBox_StudentTeacher.Text;

            if (EditMode is true)
            {
                // Modo de edición: Llamar al método para editar el estudiante existente
                int StudentId = SelectedStudentId;
                (bool, Exception?) testEdit = Class_LogicToEditDataQuery.QueryStudentsEdit(
                    StudentNames, StudentLastNames, StudentAge, StudentCourse, StudentTeacher, StudentId);

                (bool oEdit, Exception? oException) = testEdit;

                if (oEdit is false && oException is not null)
                {
                    MessageBox.Show($"No se pudo editar el estudiante {oException.Message}");
                    return;
                }
            }
            else
            {
                // Modo de agregar: Llamar al método para agregar un nuevo estudiante
                (bool, Exception?) testAdd = Class_LogicToAddDataQuery.QueryStudentsAdd(
                    StudentNames, StudentLastNames, StudentAge, StudentCourse, StudentTeacher);

                (bool oAdd, Exception? oException) = testAdd;

                if (oAdd is false && oException is not null)
                {
                    MessageBox.Show($"No se pudo agregar el estudiante {oException.Message}");
                    return;
                }
            }

            ClearInputText();
            this.Close();

        }


        /*+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
         ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
         */

        /*EVENTOS*/


        private void TextBox_StudentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) || char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /*TextBox_StudentNames*/
        private void TextBox_StudentNames_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !(e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }
        private void TextBox_StudentNames_TextChanged(object sender, EventArgs e)
        {

            string InputText = TextBox_StudentNames.Text;
            TextInfo oTextInfo = CultureInfo.CurrentCulture.TextInfo;
            string CapitalizedText = oTextInfo.ToTitleCase(InputText);
            TextBox_StudentNames.Text = CapitalizedText;
            TextBox_StudentNames.SelectionStart = TextBox_StudentNames.Text.Length;

        }

        /*TextBox_StudentLastNames*/
        private void TextBox_StudentLastNames_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TextBox_StudentNames.Text is not "")
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !(e.KeyChar == 8))
                {
                    e.Handled = true;
                    TextBox_StudentLastNames.Text = "";
                }
                else
                {
                    e.Handled = false;
                }
            }
            else
            {
                e.Handled = true;
                TextBox_StudentLastNames.Text = "";
            }

        }

        private void TextBox_StudentLastNames_TextChanged(object sender, EventArgs e)
        {

            string InputText = TextBox_StudentLastNames.Text;
            TextInfo oTextInfo = CultureInfo.CurrentCulture.TextInfo;
            string CapitalizedText = oTextInfo.ToTitleCase(InputText);
            TextBox_StudentLastNames.Text = CapitalizedText;
            TextBox_StudentLastNames.SelectionStart = TextBox_StudentLastNames.Text.Length;

        }

        private void ComboBox_StudentAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void ComboBox_StudentCourse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        /* TextBox_StudentTeacher*/
        private void TextBox_StudentTeacher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ComboBox_StudentCourse.Text is not "")
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !(e.KeyChar == 8))
                {
                    e.Handled = true;
                    TextBox_StudentTeacher.Text = "";
                }
                else
                {
                    e.Handled = false;
                }
            }
            else
            {
                e.Handled = true;
                TextBox_StudentTeacher.Text = "";

            }

        }
        private void TextBox_StudentTeacher_TextChanged(object sender, EventArgs e)
        {

            string InputText = TextBox_StudentTeacher.Text;
            TextInfo oTextInfo = CultureInfo.CurrentCulture.TextInfo;
            string CapitalizedText = oTextInfo.ToTitleCase(InputText);
            TextBox_StudentTeacher.Text = CapitalizedText;
            TextBox_StudentTeacher.SelectionStart = TextBox_StudentTeacher.Text.Length;

        }

        private void Button_Save_Click(object sender, EventArgs e)
        {

            if (TextBox_StudentNames.Text is not ""
                && TextBox_StudentLastNames.Text is not "" && ComboBox_StudentAge.Text is not ""
                && ComboBox_StudentCourse.Text is not "" && TextBox_StudentTeacher.Text is not "")
            {
                AddQueryStudentsList();
            }

        }
    }
}




