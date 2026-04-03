namespace Airport.WinForms.Forms.Constants
{
    /// <summary>
    /// Константы элементов для выпадающих списков (ComboBox)
    /// </summary>
    public static class ComboBoxItemsConstants
    {
        /// <summary>Наименование производителя Boeing</summary>
        public const string Boeing = "Боинг";

        /// <summary>Наименование производителя Airbus</summary>
        public const string Airbus = "Эйрбас";

        /// <summary>Наименование производителя ОАК (Объединенная авиастроительная корпорация)</summary>
        public const string Oak = "ОАК";

        /// <summary>Массив всех доступных производителей для заполнения ComboBox</summary>
        public static readonly string[] AllItems = { Boeing, Airbus, Oak };
    }
}
