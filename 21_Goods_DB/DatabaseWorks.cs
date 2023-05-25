using System.Data;
using System.Data.SqlClient;

namespace _21_Goods_DB
{
    internal class DatabaseWorks
    {

        public SqlConnection connection;

        public DatabaseWorks(string Credentials)
        {
            connection = new SqlConnection(Credentials);
            connection.Open();
        }

        public DataView ReturnTable(string Columns, string TablesName, string Arguments)
        {
            SqlDataAdapter sqlData = new SqlDataAdapter($"SELECT {Columns} FROM {TablesName} {Arguments}", connection);
            DataSet dataSet = new DataSet();
            sqlData.Fill(dataSet);
            return dataSet.Tables[0].DefaultView;
        }

        public string AddStreetType(string Name)
        {
            try
            {
                SqlCommand command = new SqlCommand($"INSERT INTO Goods.dbo.StreetType (name) VALUES ('{Name}');", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string AddLocalityType(string Name)
        {
            try
            {
                SqlCommand command = new SqlCommand($"INSERT INTO Goods.dbo.LocalityType (name) VALUES ('{Name}');", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string AddStreet(string Name, string TypeId)
        {
            try
            {
                SqlCommand command = new SqlCommand($"INSERT INTO Goods.dbo.Street (name, streetTypeId) VALUES ('{Name}', '{TypeId}');", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string AddLocality(string Name, string TypeId)
        {
            try
            {
                SqlCommand command = new SqlCommand($"INSERT INTO Goods.dbo.Locality (name, localityTypeId) VALUES ('{Name}', '{TypeId}');", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string AddAddress(string HouseNumber, string Campus, string StreetId, string LocalityId)
        {
            try
            {
                SqlCommand command = new SqlCommand($"INSERT INTO Goods.dbo.Address (houseNumber, campus, streetId, localityId) VALUES ('{HouseNumber}', '{Campus}', '{StreetId}', '{LocalityId}');", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string AddGood(string Name, string Amount)
        {
            try
            {
                SqlCommand command = new SqlCommand($"INSERT INTO Goods.dbo.Good (name, amount) VALUES ('{Name}', '{Amount}');", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

    }
}
