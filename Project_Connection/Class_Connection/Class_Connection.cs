using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Project_Connection.Class_Connection
{
    public sealed class Class_Connection
    {   
   
        private static (bool,Exception ?) DataBase()
        {

            string ConnectionString = "Data Source=DESKTOP-K8321M2\\SQLEXPRESS;Initial Catalog=Db_School;" +
                "Integrated Security=True;";

            (bool IsConnect , Exception ? oException) CheckingRequestAcces = (true,null);

            try
            {
                using (SqlConnection oConnection = new(ConnectionString))
                {
                    if (oConnection.State is ConnectionState.Closed)
                    {
                        oConnection.Open();
                    }
                }
                  
                return CheckingRequestAcces ;
            }
            catch(Exception oException) 
            {
                CheckingRequestAcces.IsConnect = false ;
                CheckingRequestAcces.oException = oException ;             
            }
         
            return CheckingRequestAcces ;
            
        }

        public static (bool,Exception?) Connection()
        {
            return DataBase();
        }

    }
}
