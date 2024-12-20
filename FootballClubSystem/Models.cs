
using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballClubSystem.Models
{
    // Класс для пользователя
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }  // "Fan" или "Admin"
    }

    // Класс для матча
    public class Match
    {
        public int MatchId { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public DateTime MatchDate { get; set; }
        public decimal TicketPrice { get; set; }
        public int AvailableTickets { get; set; }
    }

    // Класс для билета
    public class Ticket
    {
        public int TicketId { get; set; }
        public int UserId { get; set; }
        public int MatchId { get; set; }
        public decimal Price { get; set; }
        public DateTime PurchaseDate { get; set; }
    }

    // Класс для статистики затрат
    public class Expenditure
    {
        public int ExpenditureId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}
