using Airport.Domain.Models;
namespace Airport.Services.Contracts
{
    /// <summary>
    /// Интерфейс сервиса для работы с рейсами
    /// </summary>
    public interface IFlightService
    {
        /// <summary>
        /// Получает все рейсы
        /// </summary>
        /// <returns>Коллекция всех рейсов</returns>
        IEnumerable<Flight> GetAllFlights();

        /// <summary>
        /// Получает рейс по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор рейса</param>
        /// <returns>Найденный рейс или null</returns>
        Flight? GetFlightById(int id);

        /// <summary>
        /// Добавляет новый рейс
        /// </summary>
        /// <param name="flight">Добавляемый рейс</param>
        void AddFlight(Flight flight);

        /// <summary>
        /// Обновляет существующий рейс
        /// </summary>
        /// <param name="flight">Рейс с обновлёнными данными</param>
        void UpdateFlight(Flight flight);

        /// <summary>
        /// Удаляет рейс по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор удаляемого рейса</param>
        void DeleteFlight(int id);

        /// <summary>
        /// Рассчитывает статистику по рейсам
        /// </summary>
        /// <param name="flights">Коллекция рейсов</param>
        /// <returns>Статистика по рейсам</returns>
        FlightStatistics CalculateStatistics(IEnumerable<Flight> flights);
    }
}
