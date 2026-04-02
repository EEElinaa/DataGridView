#nullable disable
using Airport.Domain.Constants;
using Airport.Domain.Models;
using Airport.WinForms.Extensions;
using Airport.WinForms.Formatters;
using Airport.WinForms.Forms.Constants;
namespace Airport.WinForms.Forms
{
    /// <summary>
    /// Форма для добавления и редактирования рейса
    /// </summary>
    public partial class FlightForm : Form
    {
        private readonly Flight flight;
        private readonly bool isEditMode;

        /// <summary>
        /// Конструктор формы рейса
        /// </summary>
        /// <param name="flight">Рейс для редактирования (null для создания нового)</param>
        public FlightForm(Flight flight = null)
        {
            InitializeComponent();

            this.flight = flight ?? new Flight();
            isEditMode = flight != null;
            if (!isEditMode && this.flight.ArrivalTime == default)
            {
                this.flight.ArrivalTime = DateTime.Now;
            }
            if (isEditMode)
            {
                Text = "Редактирование рейса";
            }
            else
            {
                Text = "Добавление рейса";
            }
            LoadFlightData();
            SetupRevenuePreview();
            SetupButtonHandlers();
        }

        /// <summary>
        /// Получает результат работы формы - созданный или отредактированный рейс
        /// </summary>
        public Flight ResultFlight => flight;

        /// <summary>
        /// Настраивает обработчики кнопок
        /// </summary>
        private void SetupButtonHandlers()
        {
            SaveButton.Click += SaveButton_Click;
            CancelButton.Click += CancelButton_Click;
        }

        /// <summary>
        /// Загружает данные рейса в элементы управления
        /// </summary>
        private void LoadFlightData()
        {
            FlightNumberTextBox.AddBinding(
                targetProperty: textBox => textBox.Text,
                source: flight,
                sourceProperty: flight => flight.FlightNumber,
                errorProvider: ErrorProvider);
            var aircraftTypeDisplay = FlightFormatter.FormatAircraftType(flight.AircraftType);
            AircraftTypeComboBox.SelectedItem = aircraftTypeDisplay;

            ArrivalTimeDateTimePicker.AddBinding(
                targetProperty: dateTimePicker => dateTimePicker.Value,
                source: flight,
                sourceProperty: flight => flight.ArrivalTime);
            PassengerCountNumericUpDown.AddBinding(
                targetProperty: numericUpDown => numericUpDown.Value,
                source: flight,
                sourceProperty: flight => flight.PassengerCount,
                errorProvider: ErrorProvider);
            PassengerFeeNumericUpDown.AddBinding(
                targetProperty: numericUpDown => numericUpDown.Value,
                source: flight,
                sourceProperty: flight => flight.PassengerFee,
                errorProvider: ErrorProvider);
            CrewCountNumericUpDown.AddBinding(
                targetProperty: numericUpDown => numericUpDown.Value,
                source: flight,
                sourceProperty: flight => flight.CrewCount,
                errorProvider: ErrorProvider);
            CrewFeeNumericUpDown.AddBinding(
                targetProperty: numericUpDown => numericUpDown.Value,
                source: flight,
                sourceProperty: flight => flight.CrewFee,
                errorProvider: ErrorProvider);
            ServiceSurchargePercentNumericUpDown.AddBinding(
                targetProperty: numericUpDown => numericUpDown.Value,
                source: flight,
                sourceProperty: flight => flight.ServiceSurchargePercent,
                errorProvider: ErrorProvider);
            SetupComboBoxDisplay();
        }

        /// <summary>
        /// Настраивает предпросмотр выручки в реальном времени
        /// </summary>
        private void SetupRevenuePreview()
        {
            UpdateRevenuePreview();

            PassengerCountNumericUpDown.ValueChanged += (sender, eventArgs) => UpdateRevenuePreview();
            PassengerFeeNumericUpDown.ValueChanged += (sender, eventArgs) => UpdateRevenuePreview();
            CrewCountNumericUpDown.ValueChanged += (sender, eventArgs) => UpdateRevenuePreview();
            CrewFeeNumericUpDown.ValueChanged += (sender, eventArgs) => UpdateRevenuePreview();
            ServiceSurchargePercentNumericUpDown.ValueChanged += (sender, eventArgs) => UpdateRevenuePreview();
        }

        /// <summary>
        /// Обновляет отображение предпросмотра выручки
        /// </summary>
        private void UpdateRevenuePreview()
        {
            var passengerCount = (int)PassengerCountNumericUpDown.Value;
            var passengerFee = PassengerFeeNumericUpDown.Value;
            var crewCount = (int)CrewCountNumericUpDown.Value;
            var crewFee = CrewFeeNumericUpDown.Value;
            var surchargePercent = ServiceSurchargePercentNumericUpDown.Value;
            var baseRevenue = (passengerCount * passengerFee) + (crewCount * crewFee);
            var surcharge = baseRevenue * (surchargePercent / 100);
            var revenue = baseRevenue + surcharge;
            RevenuePreviewValueLabel.Text = FlightFormatter.FormatMoney(revenue);
        }

        /// <summary>
        /// Настраивает отображение ComboBox для типа самолёта
        /// </summary>
        private void SetupComboBoxDisplay()
        {
            AircraftTypeComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            AircraftTypeComboBox.DrawItem += AircraftTypeComboBox_DrawItem;
        }

        /// <summary>
        /// Обработчик отрисовки элемента ComboBox
        /// </summary>
        private void AircraftTypeComboBox_DrawItem(object sender, DrawItemEventArgs eventArgs)
        {
            if (eventArgs.Index == -1)
            {
                return;
            }
            eventArgs.DrawBackground();
            eventArgs.DrawFocusRectangle();
            var itemText = AircraftTypeComboBox.Items[eventArgs.Index].ToString();
            using var brush = new SolidBrush(eventArgs.ForeColor);
            eventArgs.Graphics.DrawString(itemText, eventArgs.Font, brush, eventArgs.Bounds);
        }

        /// <summary>
        /// Обработчик нажатия кнопки Сохранить
        /// </summary>
        private void SaveButton_Click(object sender, EventArgs eventArgs)
        {
            FlightNumberTextBox.DataBindings["Text"]?.WriteValue();
            PassengerCountNumericUpDown.DataBindings["Value"]?.WriteValue();
            PassengerFeeNumericUpDown.DataBindings["Value"]?.WriteValue();
            CrewCountNumericUpDown.DataBindings["Value"]?.WriteValue();
            CrewFeeNumericUpDown.DataBindings["Value"]?.WriteValue();
            ServiceSurchargePercentNumericUpDown.DataBindings["Value"]?.WriteValue();
            ArrivalTimeDateTimePicker.DataBindings["Value"]?.WriteValue();
            var selectedItem = AircraftTypeComboBox.SelectedItem?.ToString();
            flight.AircraftType = selectedItem switch
            {
                UiConstants.ComboBoxItems.Boeing => AircraftType.Boeing,
                UiConstants.ComboBoxItems.Airbus => AircraftType.Airbus,
                UiConstants.ComboBoxItems.OAK => AircraftType.OAK,
                _ => AircraftType.Boeing
            };
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(
                    UiConstants.Messages.ValidationError,
                    UiConstants.Messages.ValidationErrorTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки Отмена
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs eventArgs)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
