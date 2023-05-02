using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        const string strconnection = "Data Source=W-674PY03-1;Initial Catalog=Shivam;User ID=sa;Password=Password@12345";
        const string select = "Select * from Employee";
        static void Main(string[] args)
        {
            // readreacordsform();
           // insertRecord(18, "Dev", "text3.gmail.com", 60000, 5, 5);
           // insertRecordStoredProc(19, "Izhar", "text4.gmail.com", 66000, 6, 5);
           // deleterecord(18);
            updateemployee(1);
        }

        private static void updateemployee(int id)
        {
            const string storeproc = "UpdateEmployee";
            var con = new SqlConnection(strconnection);
            var cmd = new SqlCommand(storeproc, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empid",1);
            cmd.Parameters.AddWithValue("@empname", "SHIVAM");
            cmd.Parameters.AddWithValue("@empemail", "text@gmail.com");
            cmd.Parameters.AddWithValue("@empsal", 90000);
            cmd.Parameters.AddWithValue("@deptid", 1);
            cmd.Parameters.AddWithValue("@cityid", 1);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Row Updated");
                con.Close();
            }


        }

        private static void deleterecord(int empid)
        {
            const string storeproc = "DeleteEmployee";
            var con = new SqlConnection(strconnection);
            var cmd = new SqlCommand(storeproc, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empid", empid);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Row Deleted");
                con.Close();
            }
        }

        private static void insertRecordStoredProc(int empid, string empname, string empemail, int empsal, int deptid, int cityid)
        {
            const string storeproc = "InsertEmployee";
            var con = new SqlConnection(strconnection);
            var cmd = new SqlCommand(storeproc, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empid", empid);
            cmd.Parameters.AddWithValue("@empname", empname);
           cmd.Parameters.AddWithValue("@empemail", empemail);
            cmd.Parameters.AddWithValue("@empsal", empsal);
            cmd.Parameters.AddWithValue("@deptid", deptid);
            cmd.Parameters.AddWithValue("@cityid", cityid);

            
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
               // Console.WriteLine("the id is" + cmd.Parameters[0].Value);
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

                 Console.WriteLine("Row Inserted!!!");
                //Console.WriteLine("Row Deleted");
                con.Close();

            }
        }

        private static void insertRecord(int id, string empname, string empemail, int empsal, int deptid, int cityid)
        {
            var statement = $"Insert into Employee values ({id},'{empname}','{empemail}',{empsal},{deptid},{cityid})";
            var statement1 = $"Delete  Employee  where empid=7";
            var con = new SqlConnection(strconnection);
            var cmd = new SqlCommand(statement1, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
               
                 
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

                // Console.WriteLine("Row Inserted!!!");
                Console.WriteLine("Row Deleted");
                    con.Close();

            }
        }

        private static void readreacordsform()
        {
            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = strconnection;
            try
            {
                sql.Open();//Connects to Database..
                //A class to execute queries
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sql;
                sqlCmd.CommandText = select;

                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["Empname"]);
                }
            }
            catch(SqlException ex)
            {
                Exercise20.UIConsole.PrintError(ex.Message);
            }
            finally
            {
                if (sql.State == System.Data.ConnectionState.Open) 
                sql.Close();
            }
                        
        }
    }
}
