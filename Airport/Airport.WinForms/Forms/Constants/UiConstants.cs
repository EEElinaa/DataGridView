namespace Airport.WinForms.Forms.Constants
{
    /// <summary>
    /// Константы пользовательского интерфейса
    /// </summary>
    public static class UiConstants
    {
        /// <summary>
        /// Константы форматирования данных
        /// </summary>
        public static class Formatting
        {
            public const string DateTimeFormat = "dd.MM.yyyy HH:mm";
            public const string CurrencyFormat = "N2";
            public const string CurrencySymbol = "₽";
            public const string PercentFormat = "0.##";
            public const string PercentSymbol = "%";
        }

        /// <summary>
        /// Тексты для элементов ComboBox
        /// </summary>
        public static class ComboBoxItems
        {
            public const string Boeing = "Боинг";
            public const string Airbus = "Эйрбас";
            public const string Oak = "ОАК";
            public static readonly string[] AllItems = { Boeing, Airbus, Oak };
        }

        /// <summary>
        /// Цветовые константы
        /// </summary>
        public static class Colors
        {
            public static readonly Color DataGridViewAlternatingRowColor = Color.FromArgb(248, 248, 248);
            public static readonly Color DataGridViewHeaderBackColor = Color.FromArgb(64, 64, 64);
            public static readonly Color DataGridViewHeaderForeColor = Color.White;
            public static readonly Color DataGridViewBackgroundColor = Color.White;
            public static readonly Color RevenueForeColor = Color.FromArgb(0, 128, 0);
            public static readonly Color RevenuePreviewForeColor = Color.FromArgb(0, 100, 0);
        }

        /// <summary>
        /// Шрифтовые константы
        /// </summary>
        public static class Fonts
        {
            public const string DefaultFontName = "Segoe UI";
            public const float DefaultFontSize = 10f;
            public const float HeaderFontSize = 10f;
            public const float BoldFontSize = 10f;
            public const float StatisticsFontSize = 9f;
        }

        /// <summary>
        /// Сообщения пользовательского интерфейса
        /// </summary>
        public static class Messages
        {
            public const string ValidationError = "Пожалуйста, исправьте ошибки в форме перед сохранением.";
            public const string ValidationErrorTitle = "Ошибка валидации";
            public const string SelectFlightForEdit = "Пожалуйста, выберите рейс для редактирования.";
            public const string SelectFlightForDelete = "Пожалуйста, выберите рейс для удаления.";
            public const string ConfirmDelete = "Вы уверены, что хотите удалить рейс {0}?";
            public const string ConfirmDeleteTitle = "Подтверждение удаления";
            public const string SuccessEdit = "Рейс {0} успешно отредактирован.";
            public const string SuccessDelete = "Рейс {0} успешно удален.";
            public const string SuccessTitle = "Успех";
            public const string Attention = "Внимание";
            public const string IconsNotFound = "Папка с иконками не найдена: {0}";
            public const string IconsLoaded = "Иконки успешно загружены";
            public const string IconsError = "Ошибка загрузки иконок: {0}";
            public const string StatisticsError = "Ошибка обновления статистики: {0}";
        }

        /// <summary>
        /// Константы для иконок
        /// </summary>
        public static class Icons
        {
            public const string IconsFolder = "Icons";
            public const string AddIcon = "add.png";
            public const string EditIcon = "edit.png";
            public const string DeleteIcon = "delete.png";
            public const int IconSize = 20;
            public const int ButtonWidthWithIcon = 130;
            public const int ButtonHeightWithIcon = 35;
            public const int ButtonSpacing = 10;
        }

        /// <summary>
        /// Константы для DataGridView (ширины колонок)
        /// </summary>
        public static class DataGridView
        {
            public const int FlightNumberWidth = 120;
            public const int AircraftTypeWidth = 120;
            public const int ArrivalTimeWidth = 150;
            public const int PassengerCountWidth = 100;
            public const int PassengerFeeWidth = 120;
            public const int CrewCountWidth = 80;
            public const int CrewFeeWidth = 120;
            public const int SurchargePercentWidth = 100;
            public const int RevenueWidth = 120;
        }
    }
}
