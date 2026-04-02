namespace Airport.Domain.Models
{
    /// <summary>
    /// Статистика по рейсам для администратора
    /// </summary>
    public class FlightStatistics
    {
        /// <summary>
        /// Общее количество прибывающих рейсов
        /// </summary>
        public int TotalFlights { get; set; }

        /// <summary>
        /// Общее количество пассажиров на всех рейсах
        /// </summary>
        public int TotalPassengers { get; set; }

        /// <summary>
        /// Общее количество членов экипажа на всех рейсах
        /// </summary>
        public int TotalCrew { get; set; }

        /// <summary>
        /// Общая сумма выручки от всех рейсов
        /// </summary>
        public decimal TotalRevenue { get; set; }
    }
}
