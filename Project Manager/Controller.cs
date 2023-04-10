using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Project_Manager
{
    public class Controller
    {
        private DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool Login(string Username, string Password)
        {
            string query = "SELECT COUNT(1) FROM Users WHERE username = '" + Username + "' AND password = '" + Password + "';";
            bool isExist = (int)dbMan.ExecuteScalar(query) == 0 ? false : true;
            return isExist;
        }

        public DataTable Projects()
        {
            string query = "SELECT * FROM projects";
            return dbMan.ExecuteReader(query);
        }

        public bool Create(string code, string name)
        {         
            string query = "INSERT INTO projects (code, name, status) Values ('" + code + "' , '" + name + "' , 'New') ;";
            int ret = dbMan.ExecuteNonQuery(query);
            if (ret == 0)
                return false;
            else
                return true;            
        }

        public bool Edit(string code, string name, string status)
        {
            string query = "UPDATE projects SET name = '" + name + "', status = '" + status + "' "
            + "WHERE code='" + code + "';";
            int ret = dbMan.ExecuteNonQuery(query);
            if (ret == 0)
                return false;
            else
                return true;
        }

        public bool Delete(string code)
        {
            string query = "DELETE FROM projects WHERE code='" + code + "';";
            int ret = dbMan.ExecuteNonQuery(query);
            if (ret == 0)
                return false;
            else
                return true;
        }
    }
}
