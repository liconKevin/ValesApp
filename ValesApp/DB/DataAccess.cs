using Microsoft.Data.Sqlite;
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

    }
}
