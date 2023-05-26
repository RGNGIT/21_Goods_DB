using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

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

        public string AddOrganization(string Name, string Inn, string Phone, string Email, string Site, string PName, string PSurname, string PPatron, string AddressId, string OrgReq)
        {
            try
            {
                SqlCommand command = new SqlCommand($"INSERT INTO Goods.dbo.Organization (name, inn, phone, email, site, predName, predSurname, predPatron, addressId, req) VALUES ('{Name}', '{Inn}', '{Phone}', '{Email}', '{Site}', '{PName}', '{PSurname}', '{PPatron}', '{AddressId}', '{OrgReq}');", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string AddPriceListItem(string Req, string DateReleased, string GoodDesc, string GoodPrice, string GoodId)
        {
            try
            {
                SqlCommand command = new SqlCommand($"INSERT INTO Goods.dbo.PriceList (req, dateReleased, goodDesc, goodPrice, goodId) VALUES ('{Req}', '{DateReleased}', '{GoodDesc}', '{GoodPrice}', '{GoodId}');", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string ConnectItemOrg(string PriceListId, string OrgId)
        {
            try
            {
                SqlCommand command = new SqlCommand($"INSERT INTO Goods.dbo.PriceList_Organization (priceListId, organizationId) VALUES ('{PriceListId}', '{OrgId}');", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string AddPassport(string Series, string Number, string DateIssued, string IssuerName)
        {
            try
            {
                SqlCommand command = new SqlCommand($"INSERT INTO Goods.dbo.Passport (series, number, dateIssued, issuerName) VALUES ('{Series}', '{Number}', '{DateIssued}', '{IssuerName}');", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string AddPhys(string Name, string Surname, string Patron, string Inn, string PassportId)
        {
            try
            {
                SqlCommand command = new SqlCommand($"INSERT INTO Goods.dbo.Phys (inn, name, surname, patron, passportId) VALUES ('{Inn}', '{Name}', '{Surname}', '{Patron}', '{PassportId}');", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

    }
}
