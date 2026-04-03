using System.Globalization;
using Airport.Domain.Models;
using Airport.WinForms.Forms.Constants;
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
            return dateTime.ToString(UiConstants.Formatting.DateTimeFormat, CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Форматирует денежную сумму
        /// </summary>
        /// <param name="amount">Сумма</param>
        /// <returns>Отформатированная строка с валютой</returns>
        public static string FormatMoney(decimal amount)
        {
            return amount.ToString(UiConstants.Formatting.CurrencyFormat, CultureInfo.CurrentCulture);
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
                AircraftType.Boeing => UiConstants.ComboBoxItems.Boeing,
                AircraftType.Airbus => UiConstants.ComboBoxItems.Airbus,
                AircraftType.Oak => UiConstants.ComboBoxItems.Oak,
                _ => aircraftType.ToString()
            };
        }
    }
}
