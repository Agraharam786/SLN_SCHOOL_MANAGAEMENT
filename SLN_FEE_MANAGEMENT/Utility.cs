using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml.Linq;
using System.CodeDom;
using System.Windows.Input;

namespace SLN_FEE_MANAGEMENT
{
    public class Utility
    {
        private string connectionString;
        public Utility() 
        {
            connectionString = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="procedureName"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public DataSet GetDataSet(string storedProc, params SqlParameter[] parameters)
        {
            DataSet resultDataSet = new DataSet();

            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();

                    using (SqlCommand cmd = new SqlCommand(storedProc, sqlCon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add parameters if provided
                        if (parameters != null && parameters.Length > 0)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(resultDataSet);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;                
                // Handle the exception as needed, log it, or rethrow
            }

            return resultDataSet;
        }

        public int ExecuteNonQuery(string storedProc, SqlParameter[]? parameters = null)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(storedProc, connection))
                {
                    if (parameters != null)
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddRange(parameters);
                    }

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Handle or log the exception as needed
                        Console.WriteLine($"Error: {ex.Message}");
                        throw ex;
                    }
                }
            }

            return rowsAffected;
        }

       

    }
}
