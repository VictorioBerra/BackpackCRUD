using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private readonly SQLiteConnection sqliteDbConnection;

        public MainForm()
        {
            InitializeComponent();

            // Initialize connection
            sqliteDbConnection = new SQLiteConnection($"Data Source={Constants.SqliteFile};Version=3;");
            sqliteDbConnection.Open();

            // Set up GridView control columns
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Volume", "Volume");
            dataGridView1.Columns.Add("Cost", "Cost");

            PopulateDataTable();

        }

        private void PopulateDataTable()
        {
            string select = @"SELECT * FROM Backpack ORDER BY Name DESC;";
            var command = new SQLiteCommand(select, sqliteDbConnection);

            PopulateDataTable(command);
        }

        private void PopulateDataTable(SQLiteCommand command)
        {
            dataGridView1.Rows.Clear();
            using (SQLiteDataReader read = command.ExecuteReader())
            {
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[] {
                        read.GetValue(read.GetOrdinal("Id")),
                        read.GetValue(read.GetOrdinal("Name")),
                        read.GetValue(read.GetOrdinal("Volume")),
                        read.GetValue(read.GetOrdinal("Cost"))
                    });
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var normalizedName = NameTxt.Text.Trim();
            var normalizedVolume = CostTxt.Text.Trim();
            var normalizedCost = VolumeTxt.Text.Trim();

            // TODO dont do all this validation here. But its a demo app so.
            var decimalCostValidateSuccess = decimal.TryParse(normalizedCost, out decimal cost);
            var decimalVolumeValidateSuccess = decimal.TryParse(normalizedVolume, out decimal volume);

            // TODO: These would be a lot cleaner refactored to use C# ValueTuples.
            // http://www.devsanon.com/c/understanding-c-7-valuetuples/
            // Example new method: `public (bool Success, decimal Result) TryParseDecimal(string decimalStr){... }`
            if (!decimalCostValidateSuccess)
            {
                ErrorLabel.Text = "Cost must be a valid decimal.";
                ErrorLabel.Visible = true;
                return;
            }

            if (!decimalVolumeValidateSuccess)
            {
                ErrorLabel.Text = "Volume must be a valid decimal.";
                ErrorLabel.Visible = true;
                return;
            }

            if (string.IsNullOrEmpty(normalizedName))
            {
                ErrorLabel.Text = "Name must not be empty.";
                ErrorLabel.Visible = true;
                return;
            }

            // Check if item exists already
            int result = GetItemIdByName(normalizedName);

            if (result != 0)
            {
                ErrorLabel.Text = "An item with that name exists already.";
                ErrorLabel.Visible = true;
                return;
            }

            ErrorLabel.Visible = false;

            string insertSql = @"INSERT INTO Backpack
                (Name, Volume, Cost)
                VALUES
                (@name, @volume, @cost)
            ";
            var insertSQLCommand = new SQLiteCommand(insertSql, sqliteDbConnection);
            insertSQLCommand.Parameters.AddWithValue("@name", normalizedName);
            insertSQLCommand.Parameters.AddWithValue("@volume", cost);
            insertSQLCommand.Parameters.AddWithValue("@cost", volume);

            // TODO All commands should be try catch and logged or handled. Ideally, they wqould all go into a "repository layer" where you can handle exceptions more centrally.
            // In reality, you should be using something like Entity Framework
            insertSQLCommand.ExecuteNonQuery();

            PopulateDataTable();

        }

        private int GetItemIdByName(string normalizedName)
        {
            string selectAlreadyExists = @"SELECT Id FROM Backpack WHERE Name = @name;";
            var selectAlreadyExistsCommand = new SQLiteCommand(selectAlreadyExists, sqliteDbConnection);
            selectAlreadyExistsCommand.Parameters.AddWithValue("@name", normalizedName);
            var result = Convert.ToInt32(selectAlreadyExistsCommand.ExecuteScalar());
            return result;
        }

        private void SearchBynameBtn_Click(object sender, EventArgs e)
        {
            var normalizedName = SearchByNameTxt.Text.Trim();

            string select = @"SELECT * FROM Backpack WHERE Name = @name;";
            var selectAlreadyExistsCommand = new SQLiteCommand(select, sqliteDbConnection);
            selectAlreadyExistsCommand.Parameters.AddWithValue("@name", normalizedName);

            PopulateDataTable(selectAlreadyExistsCommand);

        }
    }
}
