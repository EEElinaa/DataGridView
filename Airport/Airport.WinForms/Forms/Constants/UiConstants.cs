namespace Airport.WinForms.Forms.Constants
{
    /// <summary>
    /// Константы для UI элементов
    /// </summary>
    internal static class UiConstants
    {
        /// <summary>
        /// Константы для размеров и расположения элементов формы FlightForm
        /// </summary>
        public static class FlightFormLayout
        {
            /// <summary>Ширина GroupBox на форме FlightForm</summary>
            public const int GroupBoxWidth = 450;

            /// <summary>Высота GroupBox на форме FlightForm</summary>
            public const int GroupBoxHeight = 380;

            /// <summary>Отступ GroupBox сверху</summary>
            public const int GroupBoxTop = 12;

            /// <summary>Отступ GroupBox слева</summary>
            public const int GroupBoxLeft = 12;

            /// <summary>Отступ для Label слева</summary>
            public const int LabelLeft = 20;

            /// <summary>Отступ для контролов слева</summary>
            public const int ControlLeft = 150;

            /// <summary>Стандартная ширина контролов</summary>
            public const int ControlWidth = 250;

            /// <summary>Средняя ширина контролов</summary>
            public const int ControlWidthMedium = 180;

            /// <summary>Уменьшенная ширина контролов</summary>
            public const int ControlWidthSmall = 150;

            /// <summary>Вертикальная позиция первого контрола</summary>
            public const int FirstControlTop = 27;

            /// <summary>Вертикальная позиция второго контрола</summary>
            public const int SecondControlTop = 67;

            /// <summary>Вертикальная позиция третьего контрола</summary>
            public const int ThirdControlTop = 107;

            /// <summary>Вертикальная позиция четвертого контрола</summary>
            public const int FourthControlTop = 148;

            /// <summary>Вертикальная позиция пятого контрола</summary>
            public const int FifthControlTop = 188;

            /// <summary>Вертикальная позиция шестого контрола</summary>
            public const int SixthControlTop = 228;

            /// <summary>Вертикальная позиция седьмого контрола</summary>
            public const int SeventhControlTop = 268;

            /// <summary>Вертикальная позиция восьмого контрола</summary>
            public const int EighthControlTop = 308;

            /// <summary>Вертикальная позиция метки выручки</summary>
            public const int RevenueLabelTop = 350;

            /// <summary>Ширина кнопок на форме</summary>
            public const int ButtonWidth = 110;

            /// <summary>Высота кнопок на форме</summary>
            public const int ButtonHeight = 40;

            /// <summary>Вертикальная позиция кнопок</summary>
            public const int ButtonTop = 400;

            /// <summary>Отступ кнопки Сохранить слева</summary>
            public const int SaveButtonLeft = 150;

            /// <summary>Отступ кнопки Отмена слева</summary>
            public const int CancelButtonLeft = 270;

            /// <summary>Отступ между кнопками</summary>
            public const int ButtonSpacing = 10;

            /// <summary>Ширина формы FlightForm</summary>
            public const int FormWidth = 474;

            /// <summary>Высота формы FlightForm</summary>
            public const int FormHeight = 452;
        }

        /// <summary>
        /// Константы для размеров и расположения элементов главной формы
        /// </summary>
        public static class MainFormLayout
        {
            /// <summary>Вертикальный отступ кнопок</summary>
            public const int ButtonTop = 12;

            /// <summary>Горизонтальный отступ кнопок</summary>
            public const int ButtonLeft = 12;

            /// <summary>Стандартная ширина кнопок</summary>
            public const int ButtonDefaultWidth = 130;

            /// <summary>Стандартная высота кнопок</summary>
            public const int ButtonDefaultHeight = 40;

            /// <summary>Вертикальный отступ блока статистики</summary>
            public const int StatisticsTop = 60;

            /// <summary>Высота блока статистики</summary>
            public const int StatisticsHeight = 70;

            /// <summary>Вертикальный отступ DataGridView</summary>
            public const int DataGridViewTop = 140;

            /// <summary>Высота DataGridView</summary>
            public const int DataGridViewHeight = 350;

            /// <summary>Минимальная ширина главной формы</summary>
            public const int FormMinWidth = 900;

            /// <summary>Минимальная высота главной формы</summary>
            public const int FormMinHeight = 500;

            /// <summary>Ширина главной формы</summary>
            public const int FormWidth = 1024;

            /// <summary>Высота главной формы</summary>
            public const int FormHeight = 526;

            /// <summary>Высота статусной строки</summary>
            public const int StatusStripHeight = 26;

            /// <summary>Вертикальный отступ статусной строки</summary>
            public const int StatusStripTop = 500;

            /// <summary>Горизонтальный отступ GroupBox</summary>
            public const int GroupBoxLeft = 12;
        }

        /// <summary>
        /// Предельные значения для NumericUpDown контролов
        /// </summary>
        public static class NumericLimits
        {
            /// <summary>Максимальное количество пассажиров</summary>
            public const int MaxPassengerCount = 500;

            /// <summary>Минимальное количество пассажиров</summary>
            public const int MinPassengerCount = 0;

            /// <summary>Максимальное количество членов экипажа</summary>
            public const int MaxCrewCount = 50;

            /// <summary>Минимальное количество членов экипажа</summary>
            public const int MinCrewCount = 0;

            /// <summary>Максимальная сумма сбора</summary>
            public const decimal MaxFee = 10000m;

            /// <summary>Минимальная сумма сбора</summary>
            public const decimal MinFee = 0m;

            /// <summary>Максимальный процент надбавки</summary>
            public const decimal MaxSurchargePercent = 100m;

            /// <summary>Минимальный процент надбавки</summary>
            public const decimal MinSurchargePercent = 0m;

            /// <summary>Количество знаков после запятой для decimal значений</summary>
            public const int DecimalPlaces = 2;
        }

        /// <summary>
        /// Константы для форматирования отображаемых данных
        /// </summary>
        public static class Formatting
        {
            /// <summary>Формат отображения даты и времени</summary>
            public const string DateTimeFormat = "dd.MM.yyyy HH:mm";

            /// <summary>Формат отображения валюты</summary>
            public const string CurrencyFormat = "C2";

            /// <summary>Формат отображения процентов</summary>
            public const string PercentFormat = "F2";

            /// <summary>Символ процента</summary>
            public const string PercentSymbol = "%";

            /// <summary>Символ валюты</summary>
            public const string CurrencySymbol = "₽";
        }

        /// <summary>
        /// Константы для элементов ComboBox (типы самолётов)
        /// </summary>
        public static class ComboBoxItems
        {
            /// <summary>Текст для типа самолёта Boeing</summary>
            public const string Boeing = "Боинг";

            /// <summary>Текст для типа самолёта Airbus</summary>
            public const string Airbus = "Эйрбас";

            /// <summary>Текст для типа самолёта ОАК</summary>
            public const string OAK = "ОАК";

            /// <summary>Массив всех типов самолётов</summary>
            public static readonly string[] AllItems = { Boeing, Airbus, OAK };
        }

        /// <summary>
        /// Константы для работы с иконками
        /// </summary>
        public static class Icons
        {
            /// <summary>Имя папки с иконками</summary>
            public const string IconsFolder = "Icons";

            /// <summary>Имя файла иконки добавления</summary>
            public const string AddIcon = "add.png";

            /// <summary>Имя файла иконки редактирования</summary>
            public const string EditIcon = "edit.png";

            /// <summary>Имя файла иконки удаления</summary>
            public const string DeleteIcon = "delete.png";

            /// <summary>Размер иконки на кнопке</summary>
            public const int IconSize = 18;

            /// <summary>Ширина кнопки с иконкой</summary>
            public const int ButtonWidthWithIcon = 135;

            /// <summary>Высота кнопки с иконкой</summary>
            public const int ButtonHeightWithIcon = 38;

            /// <summary>Отступ между кнопками</summary>
            public const int ButtonSpacing = 10;
        }

        /// <summary>
        /// Константы для настройки DataGridView
        /// </summary>
        public static class DataGridView
        {
            /// <summary>Ширина колонки "Номер рейса"</summary>
            public const int FlightNumberWidth = 120;

            /// <summary>Ширина колонки "Тип самолёта"</summary>
            public const int AircraftTypeWidth = 120;

            /// <summary>Ширина колонки "Время прибытия"</summary>
            public const int ArrivalTimeWidth = 150;

            /// <summary>Ширина колонки "Пассажиры"</summary>
            public const int PassengerCountWidth = 100;

            /// <summary>Ширина колонки "Сбор с пассажира"</summary>
            public const int PassengerFeeWidth = 120;

            /// <summary>Ширина колонки "Экипаж"</summary>
            public const int CrewCountWidth = 80;

            /// <summary>Ширина колонки "Сбор с экипажа"</summary>
            public const int CrewFeeWidth = 120;

            /// <summary>Ширина колонки "Надбавка, %"</summary>
            public const int SurchargePercentWidth = 100;

            /// <summary>Ширина колонки "Выручка"</summary>
            public const int RevenueWidth = 120;

            /// <summary>Размер шрифта для ячеек по умолчанию</summary>
            public const int DefaultFontSize = 9;

            /// <summary>Размер шрифта для заголовков</summary>
            public const int HeaderFontSize = 9;
        }

        /// <summary>
        /// Константы для расположения элементов статистики на главной форме
        /// </summary>
        public static class StatisticsLayout
        {
            /// <summary>Отступ заголовков статистики слева</summary>
            public const int TitleLabelLeft = 10;

            /// <summary>Отступ значения "Всего рейсов" слева</summary>
            public const int FlightsValueLeft = 122;

            /// <summary>Отступ заголовка "Всего пассажиров" слева</summary>
            public const int PassengersTitleLeft = 200;

            /// <summary>Отступ значения "Всего пассажиров" слева</summary>
            public const int PassengersValueLeft = 344;

            /// <summary>Отступ заголовка "Всего экипажа" слева</summary>
            public const int CrewTitleLeft = 450;

            /// <summary>Отступ значения "Всего экипажа" слева</summary>
            public const int CrewValueLeft = 570;

            /// <summary>Отступ заголовка "Общая выручка" слева</summary>
            public const int RevenueTitleLeft = 700;

            /// <summary>Отступ значения "Общая выручка" слева</summary>
            public const int RevenueValueLeft = 816;

            /// <summary>Вертикальный отступ элементов статистики</summary>
            public const int LabelTop = 25;
        }

        /// <summary>
        /// Цвета для UI элементов
        /// </summary>
        public static class Colors
        {
            /// <summary>Цвет фона четных строк DataGridView</summary>
            public static readonly Color DataGridViewAlternatingRowColor = Color.LightGray;

            /// <summary>Цвет фона заголовков DataGridView</summary>
            public static readonly Color DataGridViewHeaderBackColor = Color.Navy;

            /// <summary>Цвет текста заголовков DataGridView</summary>
            public static readonly Color DataGridViewHeaderForeColor = Color.White;

            /// <summary>Цвет текста предпросмотра выручки</summary>
            public static readonly Color RevenuePreviewForeColor = Color.Green;

            /// <summary>Цвет текста выручки в таблице</summary>
            public static readonly Color RevenueForeColor = Color.DarkGreen;

            /// <summary>Цвет фона DataGridView</summary>
            public static readonly Color DataGridViewBackgroundColor = Color.White;
        }

        /// <summary>
        /// Шрифты для UI элементов
        /// </summary>
        public static class Fonts
        {
            /// <summary>Название шрифта по умолчанию</summary>
            public static readonly string DefaultFontName = "Segoe UI";

            /// <summary>Размер шрифта по умолчанию</summary>
            public const int DefaultFontSize = 9;

            /// <summary>Размер жирного шрифта</summary>
            public const int BoldFontSize = 9;

            /// <summary>Размер шрифта заголовков</summary>
            public const int HeaderFontSize = 9;

            /// <summary>Размер шрифта статистики</summary>
            public const int StatisticsFontSize = 10;
        }

        /// <summary>
        /// Тексты сообщений для пользователя
        /// </summary>
        public static class Messages
        {
            /// <summary>Сообщение об ошибке валидации</summary>
            public const string ValidationError = "Пожалуйста, заполните все поля правильно";

            /// <summary>Заголовок сообщения об ошибке валидации</summary>
            public const string ValidationErrorTitle = "Ошибка валидации";

            /// <summary>Сообщение о необходимости выбрать рейс для редактирования</summary>
            public const string SelectFlightForEdit = "Выберите рейс для редактирования";

            /// <summary>Сообщение о необходимости выбрать рейс для удаления</summary>
            public const string SelectFlightForDelete = "Выберите рейс для удаления";

            /// <summary>Заголовок предупреждения</summary>
            public const string Attention = "Внимание";

            /// <summary>Шаблон сообщения подтверждения удаления</summary>
            public const string ConfirmDelete = "Удалить рейс {0}?";

            /// <summary>Заголовок подтверждения удаления</summary>
            public const string ConfirmDeleteTitle = "Подтверждение удаления";

            /// <summary>Шаблон сообщения об успешном редактировании</summary>
            public const string SuccessEdit = "Рейс {0} успешно отредактирован";

            /// <summary>Шаблон сообщения об успешном удалении</summary>
            public const string SuccessDelete = "Рейс {0} успешно удален";

            /// <summary>Заголовок сообщения об успехе</summary>
            public const string SuccessTitle = "Успех";

            /// <summary>Сообщение о том, что папка с иконками не найдена</summary>
            public const string IconsNotFound = "Папка с иконками не найдена: {0}";

            /// <summary>Сообщение об успешной загрузке иконок</summary>
            public const string IconsLoaded = "Иконки успешно загружены";

            /// <summary>Шаблон сообщения об ошибке загрузки иконок</summary>
            public const string IconsError = "Ошибка при загрузке иконок: {0}";

            /// <summary>Шаблон сообщения об ошибке статистики</summary>
            public const string StatisticsError = "Ошибка при обновлении статистики: {0}";
        }
    }
}
