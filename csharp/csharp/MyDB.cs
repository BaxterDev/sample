using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace csharp
{
    internal class MyDB
    {

        MySqlConnection myConn = new MySqlConnection("server=localhost;uid=root;password=;database=dbcsharp;");
        MySqlCommand? myCmd;
        MySqlDataReader? myReader;

        public DataTable ViewRecords(string sql)
        {
            myConn.Open();
            myCmd = new MySqlCommand(sql, myConn);
            myReader = myCmd.ExecuteReader();
            DataTable dTbl = new DataTable();
            dTbl.Load(myReader);
            myReader.Close();
            myConn.Close();

            return dTbl;
        }

        public int AddRecord(string tblsource, string fields, string fieldvalues)
        {
            int insertedId = 0;
            try
            {
                myConn.Open();
                myCmd = new MySqlCommand("INSERT INTO " + tblsource + "(" + fields + ") VALUES(" + fieldvalues + "); SELECT LAST_INSERT_ID();", myConn);
                insertedId = Convert.ToInt32(myCmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
             
            }

            finally
            {
                myConn.Close();
            }

            return insertedId;
        }


        public int UpdateRecord(string tblsource, string updateQuery)
        {
            int result;
            myConn.Open();
            myCmd = new MySqlCommand("UPDATE " + tblsource + " SET " + updateQuery, myConn);
            result = myCmd.ExecuteNonQuery();
            myConn.Close();

            return result;
        }

        public int DeleteRecord(string tblsource, string condition)
        {
            int result;
            myConn.Open();
            myCmd = new MySqlCommand("DELETE FROM " + tblsource + " WHERE " + condition, myConn);
            result = myCmd.ExecuteNonQuery();
            myConn.Close();

            return result;
        }

        public Boolean RecExist(string tblsource, string filter)
        {
            Boolean result;
            myConn.Open();
            myCmd = new MySqlCommand("SELECT * FROM " + tblsource + " WHERE " + filter + ";", myConn);
            myReader = myCmd.ExecuteReader();
            result = myReader.HasRows;
            myReader.Close();
            myConn.Close();

            return result;
        }





    }
}
