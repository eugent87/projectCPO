using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Microsoft.Data.SqlClient;
namespace projectt
{
    public class DatabaseHandler
    {
        private string Database_connection;
        private SqlConnection sql_connect;

        public string Get
        {
            get => default;
            set
            {
            }
        }

        public string Set
        {
            get => default;
            set
            {
            }
        }

        public void SaveFriend()
        {
            throw new System.NotImplementedException();
        }

        public void GetFriends()
        {
            throw new System.NotImplementedException();
        }

        public void LogAction()
        {
            throw new System.NotImplementedException();
        }

        public SqlConnection Getconnection()
        {
            throw new System.NotImplementedException();
        }
    }
}