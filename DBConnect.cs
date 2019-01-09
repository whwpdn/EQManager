using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EQManager
{
    class DBConnect
    {
        string ConnectionInfo = "SERVER=localhost; DATABASE=equipment; UID=root; PASSWORD=mbcmbc;";
        MySqlConnection dbConnection;
        public DBConnect()
        {
            dbConnection = new MySqlConnection(ConnectionInfo);
        }

        public DBConnect( string user, string pw ,string addr = "localhost" , string DBName = "equipment")
        {
            ConnectionInfo = string.Format("SERVER={0}; DATABASE={1}; UID={2}; PASSWORD={3};CharSet=utf8;",addr, DBName, user, pw);
            dbConnection = new MySqlConnection(ConnectionInfo);
        }

        //private StringBuilder GetSelectQuery(string strQuery)
        //{

        //    StringBuilder sb = new StringBuilder();
        //    try
        //    {
        //        MySqlDataReader reader;
        //        MySqlCommand command = this.dbConnection.CreateCommand();
        //        command.CommandText = strQuery;
        //        this.dbConnection.Open();

        //        reader = command.ExecuteReader();


        //        while (reader.Read())
        //        {
        //            string thisrow = string.Empty;
        //            for (int i = 0; i < reader.FieldCount; i++)
        //            {
        //                thisrow += reader.GetValue(i).ToString() + ",";
        //            }
        //            sb.AppendLine(thisrow);
        //        }
        //    }
        //    catch(Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    finally
        //    {
        //        this.dbConnection.Close();
        //    }

        //    return sb;
        //}        
        private List<string[]> GetSelectQuery(string strQuery)
        {

            List<string[]> result = new List<string[]>();
            try
            {
                MySqlCommand command = this.dbConnection.CreateCommand();
                command.CommandText = strQuery;
                this.dbConnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                
                while(reader.Read())
                {
                    string[] rowResult = new string[reader.FieldCount];
                    
                    for (int i = 0; i < reader.FieldCount; i++ )
                    {
                        rowResult[i] =reader.GetValue(i).ToString();
                    }
                        
                    result.Add(rowResult);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.dbConnection.Close();
            }

            return result;
        }

        private bool InsertDataQuery(string strTableName, string strValues)
        {
            string strQuery = string.Format("INSERT INTO {0} VALUES ({1});", strTableName, strValues);
            return InsertQuery(strQuery);
        }

        private bool InsertQuery(string strQuery)
        {
            bool result = true;
            try
            {
                this.dbConnection.Open();
                MySqlCommand command = this.dbConnection.CreateCommand();
                command.CommandText = strQuery;
                command.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                result = false;
            }
            finally
            {
                dbConnection.Close();
            }

            return result;
        }

        private bool UpdatetQuery(string strQuery)
        {
            bool result = true;
            try
            {
                this.dbConnection.Open();
                MySqlCommand command = this.dbConnection.CreateCommand();
                command.CommandText = strQuery;
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                result = false;
            }
            finally
            {
                dbConnection.Close();
            }

            return result;
        }

        private bool DeleteQuery(string strQuery)
        {
            bool result = true;
            try
            {
                this.dbConnection.Open();
                MySqlCommand command = this.dbConnection.CreateCommand();
                command.CommandText = strQuery;
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                result = false;
            }
            finally
            {
                dbConnection.Close();
            }

            return result;
        }
    

        public List<string[]> GetModelList(int type = 0)
        {
           return GetSelectQuery(string.Format("SELECT modelname, _id FROM model WHERE type={0};",type));
        }
        public List<string[]> GetUserList()
        {
            return GetSelectQuery(string.Format("SELECT name,id FROM user;"));
        }
        
        public List<string[]> GetBoardDetail(string strModelId)
        {
            if (strModelId.Equals(""))
                //return GetSelectQuery("Select * from detailview");
                return GetSelectQuery("SELECT b.use, b.ManageNum, m.modelname, b.serialNum, b.user, b.location, b.incoming, b.Note FROM boarddetails b, model m WHERE b._id = m._id");
            else
                //return GetSelectQuery(String.Format("Select * from detailview where detailview.modelname = '{0}';", strModelName));
                return GetSelectQuery(String.Format("SELECT b.use, b.ManageNum, m.modelname, b.serialNum, b.user, b.location, b.incoming, b.Note FROM boarddetails b, model m WHERE b._id = '{0}' && m._id = b._id;;", strModelId));
        }
        public List<string[]> GetEquipmentDetails(string strModelName = "All")
        {
            if(strModelName.Equals("All"))
                //return GetSelectQuery("Select * from detailview");
                return GetSelectQuery("SELECT * FROM equipment");
            else
                //return GetSelectQuery(String.Format("Select * from detailview where detailview.modelname = '{0}';", strModelName));
                return GetSelectQuery(String.Format("SELECT * FROM equipment WHERE SystemName = '{0}';", strModelName));

        }
        public List<string[]> GetEquipmentDetailsConditions(string strConditions)
        {
            return GetSelectQuery(String.Format("Select * from equipment {0};", strConditions));
        }
        //public List<string[]> GetBoardDetails(string strBoardName = "All")
        //{
        //    if (strBoardName.Equals("All"))
        //        //return GetSelectQuery("Select * from detailview");
        //        return GetSelectQuery("SELECT * FROM equipment");
        //    else
        //        //return GetSelectQuery(String.Format("Select * from detailview where detailview.boardname = '{0}';", strBoardName));
        //        return GetSelectQuery(String.Format("SELECT serialNum,ManageNum, Note FROM boarddetails WHERE _id = (SELECT m._id FROM model m WHERE modelname= '{0}');", strBoardName));

        //}

        public List<string[]> GetEquipmentHistory(string strManageNum)
        {
            return GetSelectQuery(string.Format("SELECT * FROM equipmenthistory WHERE managenum = '{0}';",strManageNum));

        }
        public bool UpdateTableData(string tablename, string strSet , string strCondition)
        {
            string strQuery = string.Format("UPDATE {0} SET {1} WHERE {2};", tablename, strSet, strCondition);
            return UpdatetQuery(strQuery);
        }

        public bool UpdateEquipmentData(Dictionary<string,string> updatedData, string strManagenum)
        {
            string strSET = "";
            foreach (KeyValuePair<string, string> aData in updatedData)
            {
                if (strSET != "") strSET += ", ";
                strSET += string.Format("{0}='{1}'", aData.Key, aData.Value);
            }
            string strCondition = string.Format("managenum='{0}'", strManagenum);
            return UpdateTableData("equipment", strSET, strCondition);
        }

        public bool InsertEquipmentHistoryData(string[] datalist, DateTime dateNowTime)
        {
            bool result = true;

            string strValues = "";
            for (int i = 0; i < datalist.Length; i++)
            {
                if (strValues != "")
                    strValues += ", ";
                else
                    strValues = string.Format("'{0}', ", dateNowTime.ToString("yyyy-MM-dd HH:mm:ss"));
                strValues += string.Format("'{0}'", datalist[i]);
            }

            result = InsertDataQuery("equipmenthistory", strValues);
            return result;
        }

 
        public bool InsertEquipmentData(List<string[]> listData)
        {
            //string strQuery = "";
            bool result = true;
            foreach(string[] data in listData)
            {
                string strValues = "";
                for (int i = 0; i < data.Length; i++)
                {
                    if (i != 0) strValues += ", ";
                    strValues += string.Format("'{0}'", data[i]);
                }
                //strQuery = string.Format("INSERT INTO equipment VALUES ({0}); ", strValues);
                //result = InsertQuery(strQuery);
                result = InsertDataQuery("equipment" , strValues);
            }
            //return InsertQuery("");
            return result;
        }

        public bool DeleteEquipmentData(string strManageNum)
        {
            string strQuery = string.Format("DELETE FROM equipment WHERE managenum='{0}';",strManageNum);
            DeleteQuery(strQuery);
            return true;
        }

    }
}
