using Airport.Domain.Models;
namespace Airport.Storage.Contracts
{
    /// <summary>
    /// Интерфейс репозитория для работы с данными рейсов
    /// </summary>
    public interface IFlightRepository
    {
        /// <summary>
        /// Получает все рейсы из хранилища
        /// </summary>
        /// <returns>Коллекция всех рейсов</returns>
        IEnumerable<Flight> GetAll();

        /// <summary>
        /// Получает рейс по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор рейса</param>
        /// <returns>Рейс или null, если не найден</returns>
        Flight? GetById(int id);

        /// <summary>
        /// Добавляет новый рейс в хранилище
        /// </summary>
        /// <param name="flight">Добавляемый рейс</param>
        void Add(Flight flight);

        /// <summary>
        /// Обновляет существующий рейс
        /// </summary>
        /// <param name="flight">Рейс с обновлёнными данными</param>
        void Update(Flight flight);

        /// <summary>
        /// Удаляет рейс по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор удаляемого рейса</param>
        void Delete(int id);
    }
}
