using Airport.Domain.Constants;
using Airport.Domain.Models;
using Airport.Services.Contracts;
using Airport.Storage.Contracts;
namespace Airport.Services
{
    /// <summary>
    /// Сервис для управления рейсами. Содержит бизнес-логику приложения
    /// </summary>
    public class FlightService : IFlightService
    {
        private readonly IFlightRepository flightRepository;

        /// <summary>
        /// Конструктор сервиса рейсов
        /// </summary>
        /// <param name="flightRepository">Репозиторий для работы с данными рейсов</param>
        public FlightService(IFlightRepository flightRepository)
        {
            this.flightRepository = flightRepository;
        }

        /// <summary>
        /// Получает все рейсы
        /// </summary>
        /// <returns>Коллекция всех рейсов</returns>
        public IEnumerable<Flight> GetAllFlights()
        {
            return flightRepository.GetAll();
        }

        /// <summary>
        /// Получает рейс по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор рейса</param>
        /// <returns>Найденный рейс или null</returns>
        public Flight? GetFlightById(int id)
        {
            if (id < BusinessConstants.MinValidId)
            {
                return null;
            }
            return flightRepository.GetById(id);
        }

        /// <summary>
        /// Добавляет новый рейс
        /// </summary>
        /// <param name="flight">Добавляемый рейс</param>
        /// <exception cref="ArgumentNullException">Выбрасывается, если flight равен null</exception>
        public void AddFlight(Flight flight)
        {
            if (flight == null)
            {
                throw new ArgumentNullException(nameof(flight));
            }
            flightRepository.Add(flight);
        }

        /// <summary>
        /// Обновляет существующий рейс
        /// </summary>
        /// <param name="flight">Рейс с обновлёнными данными</param>
        /// <exception cref="ArgumentNullException">Выбрасывается, если flight равен null</exception>
        public void UpdateFlight(Flight flight)
        {
            if (flight == null)
            {
                throw new ArgumentNullException(nameof(flight));
            }
            flightRepository.Update(flight);
        }

        /// <summary>
        /// Удаляет рейс по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор удаляемого рейса</param>
        /// <exception cref="ArgumentException">Выбрасывается, если ID меньше минимального допустимого</exception>
        public void DeleteFlight(int id)
        {
            if (id < BusinessConstants.MinValidId)
            {
                throw new ArgumentException($"ID должен быть не меньше {BusinessConstants.MinValidId}", nameof(id));
            }
            flightRepository.Delete(id);
        }

        /// <summary>
        /// Рассчитывает статистику по рейсам
        /// </summary>
        /// <param name="flights">Коллекция рейсов</param>
        /// <returns>Статистика по рейсам (общее количество, пассажиры, экипаж, выручка)</returns>
        public FlightStatistics CalculateStatistics(IEnumerable<Flight> flights)
        {
            if (flights == null || !flights.Any())
            {
                return CreateEmptyStatistics();
            }
            var flightList = flights.ToList();
            return new FlightStatistics
            {
                TotalFlights = flightList.Count,
                TotalPassengers = flightList.Sum(flight => flight.PassengerCount),
                TotalCrew = flightList.Sum(flight => flight.CrewCount),
                TotalRevenue = flightList.Sum(flight => flight.GetRevenue())
            };
        }

        /// <summary>
        /// Создает пустую статистику с нулевыми значениями
        /// </summary>
        /// <returns>Статистика с нулевыми показателями</returns>
        private FlightStatistics CreateEmptyStatistics()
        {
            return new FlightStatistics
            {
                TotalFlights = BusinessConstants.NoDataFlag,
                TotalPassengers = BusinessConstants.NoDataFlag,
                TotalCrew = BusinessConstants.NoDataFlag,
                TotalRevenue = BusinessConstants.DefaultEmptyDecimal
            };
        }
    }
}
