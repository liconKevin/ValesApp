using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValesApp.AppVal.Implementation;
using Windows.Storage;

namespace ValesApp.DB
{
    public static class DataAccess
    {
        private static string dbName = "MyValeDb.db";

        public async static void InitDb()
        {
            await ApplicationData.Current.LocalFolder.CreateFileAsync(dbName, CreationCollisionOption.OpenIfExists);
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, dbName);

            using (SqliteConnection db = new SqliteConnection($"Filename = {dbpath}"))
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT EXISTS" +
                    " Clientes (phoneNumber INTEGER PRIMARY KEY, " +
                    "name VARCHAR(20), lastName VARCHAR(20))";

                SqliteCommand createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteNonQuery();

            }

        }

        public static void InsertClient(ImpCliente cliente)
        {
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, dbName);

            using (SqliteConnection db = new SqliteConnection($"Filename = {dbpath}"))
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();

                insertCommand.Connection = db;

                insertCommand.CommandText = "INSERT INTO Clientes VALUES (@phone, @name, @lastname)";

                insertCommand.Parameters.AddWithValue("@phone", cliente.getNumber());

                insertCommand.Parameters.AddWithValue("@name", cliente.getName());

                insertCommand.Parameters.AddWithValue("@lastname", cliente.getLastName());

                insertCommand.ExecuteReader();

            }

        }

        public static List<ImpCliente> GetClients()
        {
            List<ImpCliente> listClients = new List<ImpCliente>();

            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, dbName);

            using (SqliteConnection db = new SqliteConnection($"Filename = {dbpath}"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand("SELECT * FROM Clientes", db);

                SqliteDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    listClients.Add(new ImpCliente(int.Parse(reader.GetString(0)), reader.GetString(1), reader.GetString(2)));
                }

            }

            return listClients;

        }


    }
}
