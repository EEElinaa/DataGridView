namespace Airport.WinForms.Forms.Constants
{
    /// <summary>
    /// Константы форматирования данных для отображения в UI
    /// </summary>
    public static class FormattingConstants
    {
        /// <summary>Формат отображения даты и времени (день.месяц.год часы:минуты)</summary>
        public const string DateTimeFormat = "dd.MM.yyyy HH:mm";

        /// <summary>Формат отображения валюты (2 знака после запятой)</summary>
        public const string CurrencyFormat = "N2";

        /// <summary>Формат отображения процентов (без знака процента)</summary>
        public const string PercentFormat = "0.##";

        /// <summary>Символ процента для отображения в UI</summary>
        public const string PercentSymbol = "%";
    }
}
