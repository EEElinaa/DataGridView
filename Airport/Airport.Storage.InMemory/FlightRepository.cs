#nullable disable
using Airport.Domain.Constants;
using Airport.Domain.Models;
using Airport.Storage.Contracts;

namespace Airport.Storage.InMemory
{
    /// <summary>
    /// Реализация репозитория для работы с рейсами в памяти
    /// </summary>
    public class FlightRepository : IFlightRepository
    {
        private readonly List<Flight> flights = new List<Flight>();

        /// <summary>
        /// Получает все рейсы, отсортированные по времени прибытия
        /// </summary>
        /// <returns>Коллекция всех рейсов</returns>
        public IEnumerable<Flight> GetAll()
        {
            return flights.OrderBy(flight => flight.ArrivalTime);
        }

        /// <summary>
        /// Получает рейс по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор рейса</param>
        /// <returns>Найденный рейс или null, если не найден или ID некорректный</returns>
        public Flight GetById(int id)
        {
            if (id < BusinessConstants.MinValidId)
            {
                return null;
            }
            return flights.FirstOrDefault(flight => flight.Id == id);
        }

        /// <summary>
        /// Добавляет новый рейс в хранилище
        /// </summary>
        /// <param name="flight">Добавляемый рейс</param>
        /// <exception cref="ArgumentNullException">Выбрасывается, если flight равен null</exception>
        public void Add(Flight flight)
        {
            if (flight == null)
            {
                throw new ArgumentNullException(nameof(flight));
            }
            flights.Add(flight);
        }

        /// <summary>
        /// Обновляет существующий рейс
        /// </summary>
        /// <param name="flight">Рейс с обновлёнными данными</param>
        /// <exception cref="ArgumentNullException">Выбрасывается, если flight равен null</exception>
        public void Update(Flight flight)
        {
            if (flight == null)
            {
                throw new ArgumentNullException(nameof(flight));
            }
            var existingFlight = GetById(flight.Id);
            if (existingFlight != null)
            {
                existingFlight.FlightNumber = flight.FlightNumber;
                existingFlight.AircraftType = flight.AircraftType;
                existingFlight.ArrivalTime = flight.ArrivalTime;
                existingFlight.PassengerCount = flight.PassengerCount;
                existingFlight.PassengerFee = flight.PassengerFee;
                existingFlight.CrewCount = flight.CrewCount;
                existingFlight.CrewFee = flight.CrewFee;
                existingFlight.ServiceSurchargePercent = flight.ServiceSurchargePercent;
            }
        }

        /// <summary>
        /// Удаляет рейс по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор удаляемого рейса</param>
        public void Delete(int id)
        {
            if (id < BusinessConstants.MinValidId)
            {
                return;
            }
            var flight = GetById(id);
            if (flight != null)
            {
                flights.Remove(flight);
            }
        }
    }
}
