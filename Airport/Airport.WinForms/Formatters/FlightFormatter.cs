using System.Globalization;
using Airport.Domain.Models;
using Airport.WinForms.Forms.Constants;

using FormattingConstants = Airport.WinForms.Forms.Constants.FormattingConstants;
using ComboBoxItemsConstants = Airport.WinForms.Forms.Constants.ComboBoxItemsConstants;

namespace Airport.WinForms.Formatters
{
    /// <summary>
    /// Класс для форматирования данных рейсов
    /// </summary>
    public static class FlightFormatter
    {
        /// <summary>
        /// Форматирует дату и время
        /// </summary>
        /// <param name="dateTime">Дата и время</param>
        /// <returns>Отформатированная строка даты и времени</returns>
        public static string FormatDateTime(DateTime dateTime)
        {
            return dateTime.ToString(FormattingConstants.DateTimeFormat, CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Форматирует денежную сумму
        /// </summary>
        /// <param name="amount">Сумма</param>
        /// <returns>Отформатированная строка с валютой</returns>
        public static string FormatMoney(decimal amount)
        {
            return amount.ToString(FormattingConstants.CurrencyFormat, CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Форматирует тип самолёта в читаемый вид
        /// </summary>
        /// <param name="aircraftType">Тип самолёта</param>
        /// <returns>Строковое представление типа самолёта на русском</returns>
        public static string FormatAircraftType(AircraftType aircraftType)
        {
            return aircraftType switch
            {
                AircraftType.Boeing => ComboBoxItemsConstants.Boeing,
                AircraftType.Airbus => ComboBoxItemsConstants.Airbus,
                AircraftType.Oak => ComboBoxItemsConstants.Oak,
                _ => aircraftType.ToString()
            };
        }
    }
}
