using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using FootballClubSystem.Models;  // Подключение модели (если она есть)

namespace FootballClubSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Загрузка матчей в DataGridView
        private void LoadMatches()
        {
            string query = "SELECT * FROM Matches";  // Пример запроса для получения всех матчей
            DataTable matchesTable = DatabaseHelper.ExecuteQuery(query);

            // Очистка и загрузка данных в DataGridView
            dataGridViewMatches.DataSource = matchesTable;

            // Добавление кнопки "Купить билет" в таблицу
            DataGridViewButtonColumn buyButtonColumn = new DataGridViewButtonColumn();
            buyButtonColumn.HeaderText = "Купить билет";
            buyButtonColumn.Text = "Купить";
            buyButtonColumn.UseColumnTextForButtonValue = true;
            dataGridViewMatches.Columns.Add(buyButtonColumn);

            // Подключение обработчика событий для кнопки в таблице
            dataGridViewMatches.CellContentClick += DataGridViewMatches_CellContentClick;
        }

        // Обработчик клика на кнопку "Купить билет"
        private void DataGridViewMatches_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewMatches.Columns["Купить билет"].Index && e.RowIndex >= 0)
            {
                int matchId = Convert.ToInt32(dataGridViewMatches.Rows[e.RowIndex].Cells["MatchId"].Value);
                decimal ticketPrice = Convert.ToDecimal(dataGridViewMatches.Rows[e.RowIndex].Cells["TicketPrice"].Value);
                int userId = 1;  // Пример, предполагаем, что ID пользователя 1 (замените на реальное значение)

                // Вставка в базу данных
                BuyTicket(matchId, userId, ticketPrice);

                MessageBox.Show("Билет успешно куплен!");
            }
        }

        // Покупка билета
        private void BuyTicket(int matchId, int userId, decimal price)
        {
            string query = "INSERT INTO Tickets (MatchId, UserId, Price) VALUES (@MatchId, @UserId, @Price)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MatchId", SqlDbType.Int) { Value = matchId },
                new SqlParameter("@UserId", SqlDbType.Int) { Value = userId },
                new SqlParameter("@Price", SqlDbType.Decimal) { Value = price }
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        // Загрузка матчей с сортировкой
        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Matches";

            switch (comboBoxSort.SelectedIndex)
            {
                case 0:
                    query = "SELECT * FROM Matches ORDER BY HomeTeam";  // Сортировка по имени команды
                    break;
                case 1:
                    query = "SELECT * FROM Matches ORDER BY MatchDate";  // Сортировка по дате
                    break;
                case 2:
                    query = "SELECT * FROM Matches ORDER BY TicketPrice";  // Сортировка по цене билета
                    break;
            }

            DataTable matchesTable = DatabaseHelper.ExecuteQuery(query);
            dataGridViewMatches.DataSource = matchesTable;
        }

        // Добавление нового матча в базу данных
        private void AddMatch(string homeTeam, string awayTeam, DateTime matchDate, decimal ticketPrice)
        {
            string query = "INSERT INTO Matches (HomeTeam, AwayTeam, MatchDate, TicketPrice) VALUES (@HomeTeam, @AwayTeam, @MatchDate, @TicketPrice)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@HomeTeam", SqlDbType.NVarChar) { Value = homeTeam },
                new SqlParameter("@AwayTeam", SqlDbType.NVarChar) { Value = awayTeam },
                new SqlParameter("@MatchDate", SqlDbType.DateTime) { Value = matchDate },
                new SqlParameter("@TicketPrice", SqlDbType.Decimal) { Value = ticketPrice }
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

       
        

        // Загрузка данных при запуске формы
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMatches();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
