#nullable disable
using System.ComponentModel.DataAnnotations;
using Airport.Domain.Constants;

namespace Airport.Domain.Models
{
    /// <summary>
    /// Модель рейса, представляющая прибывающий рейс в аэропорт
    /// </summary>
    public class Flight
    {
        private static int nextId = BusinessConstants.StartId;

        /// <summary>
        /// Конструктор по умолчанию. Создает новый рейс с автоматическим ID и текущей датой
        /// </summary>
        public Flight()
        {
            Id = nextId++;
            ArrivalTime = DateTime.Now;
        }

        /// <summary>
        /// Конструктор для создания рейса с указанием всех параметров
        /// </summary>
        /// <param name="flightNumber">Номер рейса</param>
        /// <param name="aircraftType">Тип самолёта</param>
        /// <param name="arrivalTime">Время прибытия</param>
        /// <param name="passengerCount">Количество пассажиров</param>
        /// <param name="passengerFee">Сбор на пассажира</param>
        /// <param name="crewCount">Количество членов экипажа</param>
        /// <param name="crewFee">Сбор на экипаж</param>
        /// <param name="serviceSurchargePercent">Процент надбавки за обслуживание</param>
        public Flight(string flightNumber, AircraftType aircraftType, DateTime arrivalTime,
                      int passengerCount, decimal passengerFee, int crewCount, decimal crewFee,
                      decimal serviceSurchargePercent)
        {
            Id = nextId++;
            FlightNumber = flightNumber;
            AircraftType = aircraftType;
            ArrivalTime = arrivalTime;
            PassengerCount = passengerCount;
            PassengerFee = passengerFee;
            CrewCount = crewCount;
            CrewFee = crewFee;
            ServiceSurchargePercent = serviceSurchargePercent;
        }

        /// <summary>
        /// Уникальный идентификатор рейса
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Номер рейса
        /// </summary>
        [Display(Name = "Номер рейса")]
        [Required(ErrorMessage = "Номер рейса обязателен")]
        [StringLength(BusinessConstants.FlightNumberMaxLength,
            MinimumLength = BusinessConstants.FlightNumberMinLength,
            ErrorMessage = "Номер рейса должен содержать от 2 до 20 символов")]
        public string FlightNumber { get; set; }

        /// <summary>
        /// Тип самолёта (Boeing, Airbus, OAK)
        /// </summary>
        [Display(Name = "Тип самолёта")]
        public AircraftType AircraftType { get; set; }

        /// <summary>
        /// Время прибытия рейса
        /// </summary>
        [Display(Name = "Время прибытия")]
        [Required(ErrorMessage = "Время прибытия обязательно")]
        public DateTime ArrivalTime { get; set; }

        /// <summary>
        /// Количество пассажиров на борту
        /// </summary>
        [Display(Name = "Количество пассажиров")]
        [Range(BusinessConstants.MinPassengerCount, BusinessConstants.MaxPassengerCount,
            ErrorMessage = "Количество пассажиров должно быть от 0 до 500")]
        public int PassengerCount { get; set; }

        /// <summary>
        /// Сбор за обслуживание одного пассажира
        /// </summary>
        [Display(Name = "Сбор на пассажира")]
        [Range((double)BusinessConstants.MinPassengerFee, (double)BusinessConstants.MaxPassengerFee,
            ErrorMessage = "Сбор на пассажира должен быть от 0 до 10000")]
        public decimal PassengerFee { get; set; }

        /// <summary>
        /// Количество членов экипажа
        /// </summary>
        [Display(Name = "Количество экипажа")]
        [Range(BusinessConstants.MinCrewCount, BusinessConstants.MaxCrewCount,
            ErrorMessage = "Количество экипажа должно быть от 0 до 50")]
        public int CrewCount { get; set; }

        /// <summary>
        /// Сбор за обслуживание одного члена экипажа
        /// </summary>
        [Display(Name = "Сбор на экипаж")]
        [Range((double)BusinessConstants.MinCrewFee, (double)BusinessConstants.MaxCrewFee,
            ErrorMessage = "Сбор на экипаж должен быть от 0 до 10000")]
        public decimal CrewFee { get; set; }

        /// <summary>
        /// Процент надбавки за обслуживание рейса
        /// </summary>
        [Display(Name = "Процент надбавки за обслуживание")]
        [Range((double)BusinessConstants.MinSurchargePercent, (double)BusinessConstants.MaxSurchargePercent,
            ErrorMessage = "Процент надбавки должен быть от 0 до 100")]
        public decimal ServiceSurchargePercent { get; set; }

        /// <summary>
        /// Рассчитывает общую выручку от рейса
        /// </summary>
        /// <returns>Общая выручка с учётом всех сборов и надбавок</returns>
        public decimal GetRevenue()
        {
            var baseRevenue = (PassengerCount * PassengerFee) + (CrewCount * CrewFee);
            var surcharge = baseRevenue * (ServiceSurchargePercent / BusinessConstants.PercentDivider);
            return baseRevenue + surcharge;
        }
    }
}
