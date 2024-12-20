using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FootballClubSystem.Models;


namespace FootballClubSystem
{
    public partial class MatchAdminForm : Form
    {
        public MatchAdminForm()
        {
            InitializeComponent();
        }

        private void MatchAdminForm_Load(object sender, EventArgs e)
        {

        }
        private void btnAddMatch_Click(object sender, EventArgs e)
        {
            string homeTeam = txtHomeTeam.Text;
            string awayTeam = txtAwayTeam.Text;
            DateTime matchDate = dtpMatchDate.Value;
            decimal ticketPrice = numericTicketPrice.Value;
            int ticketsAvailable = int.Parse(txtTicketsAvailable.Text);

            MatchService.AddMatch(matchDate, homeTeam + " vs " + awayTeam, ticketsAvailable, ticketPrice);

            MessageBox.Show("Матч добавлен!");
            LoadMatches();
        }
        private void btnAddNews_Click(object sender, EventArgs e)
        {
            string content = txtNewsContent.Text;  // Текст новости из текстового поля

            // Добавляем новость в базу данных
            NewsService.AddNews(content);

            // Обновляем список новостей на форме
            LoadNews();

            MessageBox.Show("Новость добавлена!");
        }

    }
}
