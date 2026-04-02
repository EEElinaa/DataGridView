namespace Airport.Domain.Constants
{
    /// <summary>
    /// Константы логики приложения
    /// </summary>
    public static class BusinessConstants
    {
        /// <summary>Минимальная длина номера рейса</summary>
        public const int FlightNumberMinLength = 2;

        /// <summary>Максимальная длина номера рейса</summary>
        public const int FlightNumberMaxLength = 20;

        /// <summary>Максимальное количество пассажиров</summary>
        public const int MaxPassengerCount = 500;

        /// <summary>Минимальное количество пассажиров</summary>
        public const int MinPassengerCount = 0;

        /// <summary>Максимальное количество членов экипажа</summary>
        public const int MaxCrewCount = 50;

        /// <summary>Минимальное количество членов экипажа</summary>
        public const int MinCrewCount = 0;

        /// <summary>Максимальный сбор с пассажира</summary>
        public const decimal MaxPassengerFee = 10000m;

        /// <summary>Минимальный сбор с пассажира</summary>
        public const decimal MinPassengerFee = 0m;

        /// <summary>Максимальный сбор с экипажа</summary>
        public const decimal MaxCrewFee = 10000m;

        /// <summary>Минимальный сбор с экипажа</summary>
        public const decimal MinCrewFee = 0m;

        /// <summary>Максимальный процент надбавки</summary>
        public const decimal MaxSurchargePercent = 100m;

        /// <summary>Минимальный процент надбавки</summary>
        public const decimal MinSurchargePercent = 0m;

        /// <summary>Делитель для расчета процента (100%)</summary>
        public const decimal PercentDivider = 100m;

        /// <summary>Начальное значение ID</summary>
        public const int StartId = 1;

        /// <summary>Минимальное положительное значение ID</summary>
        public const int MinValidId = 1;

        /// <summary>Значение по умолчанию для пустых числовых полей</summary>
        public const int DefaultEmptyValue = 0;

        /// <summary>Значение по умолчанию для пустых десятичных полей</summary>
        public const decimal DefaultEmptyDecimal = 0m;

        /// <summary>Флаг отсутствия данных</summary>
        public const int NoDataFlag = 0;

        /// <summary>Порог для округления при расчетах</summary>
        public const int RoundingDecimalPlaces = 2;

        /// <summary>Максимальное количество элементов в списке по умолчанию</summary>
        public const int DefaultMaxListSize = 1000;

        /// <summary>Таймаут операций в миллисекундах</summary>
        public const int DefaultOperationTimeoutMs = 30000;
    }
}
