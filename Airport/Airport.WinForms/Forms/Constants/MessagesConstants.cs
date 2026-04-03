namespace Airport.WinForms.Forms.Constants
{
    /// <summary>
    /// Текстовые сообщения для отображения пользователю (ошибки, подтверждения, уведомления)
    /// </summary>
    public static class MessagesConstants
    {
        /// <summary>Сообщение об ошибке валидации формы</summary>
        public const string ValidationError = "Пожалуйста, исправьте ошибки в форме перед сохранением.";

        /// <summary>Заголовок окна ошибки валидации</summary>
        public const string ValidationErrorTitle = "Ошибка валидации";

        /// <summary>Сообщение о необходимости выбора рейса для редактирования</summary>
        public const string SelectFlightForEdit = "Пожалуйста, выберите рейс для редактирования.";

        /// <summary>Сообщение о необходимости выбора рейса для удаления</summary>
        public const string SelectFlightForDelete = "Пожалуйста, выберите рейс для удаления.";

        /// <summary>Шаблон сообщения подтверждения удаления рейса</summary>
        /// <param name="flightNumber">Номер рейса</param>
        public const string ConfirmDelete = "Вы уверены, что хотите удалить рейс {0}?";

        /// <summary>Заголовок окна подтверждения удаления</summary>
        public const string ConfirmDeleteTitle = "Подтверждение удаления";

        /// <summary>Шаблон сообщения об успешном редактировании рейса</summary>
        public const string SuccessEdit = "Рейс {0} успешно отредактирован.";

        /// <summary>Шаблон сообщения об успешном удалении рейса</summary>
        public const string SuccessDelete = "Рейс {0} успешно удален.";

        /// <summary>Заголовок окна успешной операции</summary>
        public const string SuccessTitle = "Успех";

        /// <summary>Заголовок для информационных сообщений</summary>
        public const string Attention = "Внимание";

        /// <summary>Шаблон сообщения об отсутствии папки с иконками</summary>
        public const string IconsNotFound = "Папка с иконками не найдена: {0}";

        /// <summary>Сообщение об успешной загрузке иконок</summary>
        public const string IconsLoaded = "Иконки успешно загружены";

        /// <summary>Шаблон сообщения об ошибке загрузки иконок</summary>
        public const string IconsError = "Ошибка загрузки иконок: {0}";

        /// <summary>Шаблон сообщения об ошибке обновления статистики</summary>
        public const string StatisticsError = "Ошибка обновления статистики: {0}";
    }
}
