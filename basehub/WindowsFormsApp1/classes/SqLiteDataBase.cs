using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;

namespace basehub.classes
{
    class SqLiteDataBase
    {
        public SqLiteDataBase()
        {

        }

        public string Path { set; get; }

        public string connectionString { set; get; }

        public void CreateDatabase(string path)
        {
            Path = path;

            if (!File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
            }

            connectionString = $"Data Source={path};Version=3;";

            return;
        }

        public void CreateTable()
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();

            connection.Close();
        }

    }
}
