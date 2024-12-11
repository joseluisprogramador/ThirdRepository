using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Logic.Class_Logic
{
    public class Class_LogicToSelectQuery
    {
        public static (List<Class_Students>, Exception?) QueryStudentsSelect()
        {

            string ConnectionString = "Data Source=DESKTOP-K8321M2\\SQLEXPRESS;Initial Catalog=Db_School;" +
             "Integrated Security=True;";

            string QueryStudentsList = "Pro_SelectStudents";

            SqlConnection oConnection;

            List<Class_Students> oListStudents;
            oListStudents = new List<Class_Students>();

            (List<Class_Students>, Exception?) oTupla = (oListStudents, null);

            using (oConnection = new SqlConnection(ConnectionString))
            {
                SqlCommand oCommand;
                SqlDataReader oDataReader;

                try
                {

                    oCommand = new SqlCommand(QueryStudentsList, oConnection);
                    oCommand.CommandType = CommandType.StoredProcedure;
                    oConnection.Open();
                    oDataReader = oCommand.ExecuteReader();
                    Class_Students oStudents;

                    while (oDataReader.Read())
                    {
                        oStudents = new Class_Students
                        {
                            Id = oDataReader.GetInt32(0),
                            StudentNames = oDataReader.GetString(1),
                            StudentLastNames = oDataReader.GetString(2),
                            Age = oDataReader.GetInt32(3),
                            Course = oDataReader.GetString(4),
                            Teacher = oDataReader.GetString(5),
                            Fecha = oDataReader.GetDateTime(6)
                        };

                        oListStudents.Add(oStudents);
                    }

                    oTupla.Item1 = oListStudents;
                    oTupla.Item2 = null;

                    oDataReader.Close();
                    oConnection.Close();

                    return oTupla;

                }
                catch (Exception oException)
                {
                    oTupla.Item2 = oException;
                }

            }

            return oTupla;

        }

    }

}







