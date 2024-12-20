using System;
using System.Data;
using System.Data.SqlClient;

namespace FootballClubSystem
{
    public static class DatabaseHelper
    {
        // Укажите вашу строку подключения к базе данных
        private static string connectionString = "your_connection_string_here";

        // Метод для выполнения SQL-запросов на выборку данных (SELECT)
        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                if (parameters != null)
                    dataAdapter.SelectCommand.Parameters.AddRange(parameters);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }

        // Метод для выполнения команд (INSERT, UPDATE, DELETE)
        public static void ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddRange(parameters);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Пример метода для создания таблицы матчей
        public static void CreateMatchesTable()
        {
            string createTableQuery = @"
                CREATE TABLE Matches (
                    Id INT PRIMARY KEY IDENTITY(1,1),
                    HomeTeam NVARCHAR(100),
                    AwayTeam NVARCHAR(100),
                    MatchDate DATETIME,
                    TicketPrice DECIMAL(18,2)
                )";
            ExecuteNonQuery(createTableQuery, null);
        }

        // Пример метода для создания таблицы пользователей
        public static void CreateUsersTable()
        {
            string createTableQuery = @"
                CREATE TABLE Users (
                    Id INT PRIMARY KEY IDENTITY(1,1),
                    Username NVARCHAR(50),
                    Password NVARCHAR(50),
                    Role NVARCHAR(50)
                )";
            ExecuteNonQuery(createTableQuery, null);
        }

        // Метод для добавления нового пользователя
        public static void AddUser(string username, string password, string role)
        {
            string query = "INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, @Role)";
            SqlParameter[] parameters = {
                new SqlParameter("@Username", SqlDbType.NVarChar) { Value = username },
                new SqlParameter("@Password", SqlDbType.NVarChar) { Value = password },
                new SqlParameter("@Role", SqlDbType.NVarChar) { Value = role }
            };
            ExecuteNonQuery(query, parameters);
        }

        // Метод для получения списка матчей
        public static DataTable GetMatches()
        {
            string query = "SELECT * FROM Matches";
            return ExecuteQuery(query);
        }

        // Метод для добавления нового матча
        public static void AddMatch(string homeTeam, string awayTeam, DateTime matchDate, decimal ticketPrice)
        {
            string query = "INSERT INTO Matches (HomeTeam, AwayTeam, MatchDate, TicketPrice) VALUES (@HomeTeam, @AwayTeam, @MatchDate, @TicketPrice)";
            SqlParameter[] parameters = {
                new SqlParameter("@HomeTeam", SqlDbType.NVarChar) { Value = homeTeam },
                new SqlParameter("@AwayTeam", SqlDbType.NVarChar) { Value = awayTeam },
                new SqlParameter("@MatchDate", SqlDbType.DateTime) { Value = matchDate },
                new SqlParameter("@TicketPrice", SqlDbType.Decimal) { Value = ticketPrice }
            };
            ExecuteNonQuery(query, parameters);
        }

        // Метод для удаления матча по его Id
        public static void DeleteMatch(int matchId)
        {
            string query = "DELETE FROM Matches WHERE Id = @Id";
            SqlParameter[] parameters = {
                new SqlParameter("@Id", SqlDbType.Int) { Value = matchId }
            };
            ExecuteNonQuery(query, parameters);
        }

        // Метод для обновления информации о матче
        public static void UpdateMatch(int matchId, string homeTeam, string awayTeam, DateTime matchDate, decimal ticketPrice)
        {
            string query = @"
                UPDATE Matches
                SET HomeTeam = @HomeTeam, AwayTeam = @AwayTeam, MatchDate = @MatchDate, TicketPrice = @TicketPrice
                WHERE Id = @Id";
            SqlParameter[] parameters = {
                new SqlParameter("@Id", SqlDbType.Int) { Value = matchId },
                new SqlParameter("@HomeTeam", SqlDbType.NVarChar) { Value = homeTeam },
                new SqlParameter("@AwayTeam", SqlDbType.NVarChar) { Value = awayTeam },
                new SqlParameter("@MatchDate", SqlDbType.DateTime) { Value = matchDate },
                new SqlParameter("@TicketPrice", SqlDbType.Decimal) { Value = ticketPrice }
            };
            ExecuteNonQuery(query, parameters);
        }
    }
}
