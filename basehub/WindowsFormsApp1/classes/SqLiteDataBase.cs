using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;

namespace basehub
{
    public class SqLiteDataBase
    {
        public SqLiteDataBase()
        {
            
        }

        public string Path { set; get; }

        public string ConnectionString { set; get; }

        public void CreateDatabase(string path)
        {
            Path = path;

            if (!File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                              
            }
            ConnectionString = $"Data Source={path};Version=3;";  
            this.CreateTelemetryTable();
            return;
        }

        public void CreateTelemetryTable()
        {
            SQLiteConnection connection = new SQLiteConnection(ConnectionString);
            connection.Open();
            string sqlCommand = @"
                CREATE TABLE IF NOT EXISTS telemetry (
	                id	INTEGER PRIMARY KEY AUTOINCREMENT,
                    name	TEXT NOT NULL,
                    time TEXT,
	                longitude	REAL,
	                latitude	REAL,
	                height	INTEGER,
                    velocity INTEGER,
	                heading	TEXT,
	                battery	INTEGER)";
            SQLiteCommand command = new SQLiteCommand(sqlCommand, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void InsertTelemetry(Telemetry telemetry)
        {
            SQLiteConnection connection = new SQLiteConnection(ConnectionString);
            connection.Open();
            string sqlCommand = "INSERT INTO telemetry (name, time, longitude, latitude, height, velocity, heading, battery)" +
                                " VALUES(@name, @time, @longitude, @latitude, @height, @velocity, @heading, @battery)";
            SQLiteCommand command = new SQLiteCommand(sqlCommand, connection);
            
            //add parameters and values to command
            command.Parameters.AddWithValue("@name", telemetry.Name);
            command.Parameters.AddWithValue("@time", telemetry.Time);
            command.Parameters.AddWithValue("@longitude", telemetry.Longitude);
            command.Parameters.AddWithValue("@latitude", telemetry.Latitude);
            command.Parameters.AddWithValue("@height", telemetry.Height);
            command.Parameters.AddWithValue("@heading", telemetry.Heading);
            command.Parameters.AddWithValue("@velocity", telemetry.Velocity);
            command.Parameters.AddWithValue("@battery", telemetry.Battery);

            //execute command
            command.ExecuteNonQuery();
            connection.Close();
        }

        public Telemetry SelectLatestTelemetry(string name)
        {
            Telemetry telemetry = new Telemetry();

            SQLiteConnection connection = new SQLiteConnection(ConnectionString);
            connection.Open();
            string sqlCommand = "SELECT * FROM telemetry WHERE name=@name ORDER BY id DESC LIMIT 1";            
            SQLiteCommand command = new SQLiteCommand(sqlCommand, connection);
            command.Parameters.AddWithValue("@name", name);

            

            using(SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    telemetry.Name = reader.GetString(1);
                    telemetry.Time = reader.GetDateTime(2);
                    telemetry.Longitude = reader.GetDouble(3);
                    telemetry.Latitude = reader.GetDouble(4);
                    telemetry.Height = reader.GetInt16(5);
                    telemetry.Velocity = reader.GetInt16(6);
                    telemetry.Heading = reader.GetString(7);
                    telemetry.Battery = reader.GetInt16(8);
                }
            }
         
            connection.Close();
            return telemetry;
        }
    }
}
