using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Logic.Class_Logic
{
    public class Class_LogicToEditDataQuery
    {
        public static (bool, Exception?) QueryStudentsEdit(string ? StudentNames,
           string ? StudentLastNames, int StudentAge, string ? StudentCourse, string ? StudentTeacher, int StudentId)
        {

            string ConnectionString = "Data Source=DESKTOP-K8321M2\\SQLEXPRESS;Initial Catalog=Db_School;" +
             "Integrated Security=True;";

            string QueryStudentsEdit = "Pro_EditStudents";

            SqlConnection oConnection;

            (bool, Exception?) oTupla = (true, null);

            using (oConnection = new SqlConnection(ConnectionString))
            {
                SqlCommand oCommand;

                try
                {

                    oCommand = new SqlCommand(QueryStudentsEdit, oConnection);             
                    oCommand.Parameters.AddWithValue("@c_StudentNames", StudentNames);
                    oCommand.Parameters.AddWithValue("@c_StudentLastNames", StudentLastNames);
                    oCommand.Parameters.AddWithValue("@c_Age", StudentAge);
                    oCommand.Parameters.AddWithValue("@c_Course", StudentCourse);
                    oCommand.Parameters.AddWithValue("@c_Teacher", StudentTeacher);
                    oCommand.Parameters.AddWithValue("@c_Id", StudentId);

                    oCommand.CommandType = CommandType.StoredProcedure;

                    oConnection.Open();
                    oCommand.ExecuteNonQuery();
                    oConnection.Close();

                    return oTupla;

                }
                catch (Exception oException)
                {
                    oTupla.Item1 = false;
                    oTupla.Item2 = oException;
                }

            }

            return oTupla;

        }

    }
}
