using Microsoft.Data.SqlClient;

namespace projectt
{
    class User
    {
        private int Id;
        private string Name;
        private string TelegramId;
        private Array FriendList;
        private DatabaseHandler Databaseconnection;

        public User(string Id, SqlConnection databaseconnection)
        {
            throw new System.NotImplementedException();
        }

        public int Get
        {
            get => default;
            set
            {
            }
        }

        public int Set
        {
            get => default;
            set
            {
            }
        }
    }
}