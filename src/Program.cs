using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // This should be passed in from a config file
            var sqliteFileName = Constants.SqliteFile;

            // We will delete the DB ever time and "seed" it with new data. This is just a demo after all.
            if (File.Exists($"./{sqliteFileName}"))
            {
                File.Delete($"./{sqliteFileName}");
            }

            // Create the new DB
            SQLiteConnection.CreateFile(sqliteFileName);

            // Create a connection, a table and seed.
            var sqliteDbConnection = new SQLiteConnection($"Data Source={sqliteFileName};Version=3;");

            sqliteDbConnection.Open();


            var createTable = @"CREATE TABLE Backpack 
	                            (
                                    Id integer primary key AUTOINCREMENT, 
                                    Name varchar(500), 
                                    Weight REAL,
                                    Volume REAL,
                                    Cost REAL,
                                    Waterproof NUMERIC,
                                    Consumable NUMERIC,
                                    IncludeIn NUMERIC, 
                                    OutsidePack NUMERIC, 
                                    Notes varchar(5000)
                                );
                            ";

            SQLiteCommand command = new SQLiteCommand(createTable, sqliteDbConnection);
            command.ExecuteNonQuery();

            string sql = @"INSERT INTO Backpack
                            (Name, Weight, Volume, Cost, Waterproof, Consumable, IncludeIn, OutsidePack)
                            VALUES
                            ('Osprey Exos 58L Mens (small)', NULL, 1220, 220, 0, 0, 1, 0);
                        ";
            command = new SQLiteCommand(sql, sqliteDbConnection);
            command.ExecuteNonQuery();

            sql = @"INSERT INTO Backpack
                            (Name, Weight, Volume, Cost, Waterproof, Consumable, IncludeIn, OutsidePack)
                            VALUES
                            ('Sierra Designs 3P Tent', NULL, 2100, 173, 0, 0, 1, 0);
                        ";
            command = new SQLiteCommand(sql, sqliteDbConnection);
            command.ExecuteNonQuery();

            sql = @"INSERT INTO Backpack
                            (Name, Weight, Volume, Cost, Waterproof, Consumable, IncludeIn, OutsidePack)
                            VALUES
                            ('HG Burrow Econ 20', NULL, 454, 189, 0, 0, 1, 0);
                        ";
            command = new SQLiteCommand(sql, sqliteDbConnection);
            command.ExecuteNonQuery();

            sqliteDbConnection.Close();

            Application.Run(new MainForm());
        }
    }
}
