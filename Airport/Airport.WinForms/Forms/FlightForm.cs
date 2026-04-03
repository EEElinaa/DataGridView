using Airport.Domain.Constants;
using Airport.Domain.Models;
using Airport.WinForms.Extensions;
using Airport.WinForms.Formatters;
using Airport.WinForms.Forms.Constants;
namespace Airport.WinForms.Forms
{
    /// <summary>
    /// Форма для добавления или редактирования информации о рейсе.
    /// </summary>
    public partial class FlightForm : Form
    {
        private readonly Flight flight;
        private readonly bool isEditMode;

        /// <summary>
        /// Инициализирует новый экземпляр формы FlightForm.
        /// </summary>
        /// <param name="flight">Объект рейса для редактирования. Если null, создаётся новый рейс.</param>
        public FlightForm(Flight? flight = null)
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
        }

        /// <summary>
        /// Возвращает объект рейса, созданный или отредактированный в форме.
        /// </summary>
        public Flight ResultFlight => flight;

        /// <summary>
        /// Загружает данные из объекта рейса в элементы управления формы.
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
        /// Настраивает предварительный просмотр выручки и подписывается на события изменения данных.
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
        /// Обновляет отображение предварительной выручки на основе введённых данных.
        /// </summary>
        private void UpdateRevenuePreview()
        {
            var passengerCount = (int)PassengerCountNumericUpDown.Value;
            var passengerFee = PassengerFeeNumericUpDown.Value;
            var crewCount = (int)CrewCountNumericUpDown.Value;
            var crewFee = CrewFeeNumericUpDown.Value;
            var surchargePercent = ServiceSurchargePercentNumericUpDown.Value;
            var baseRevenue = (passengerCount * passengerFee) + (crewCount * crewFee);
            var surcharge = baseRevenue * (surchargePercent / BusinessConstants.PercentDivider);
            var revenue = baseRevenue + surcharge;
            RevenuePreviewValueLabel.Text = FlightFormatter.FormatMoney(revenue);
        }

        /// <summary>
        /// Настраивает отображение выпадающего списка с типами воздушных судов.
        /// </summary>
        private void SetupComboBoxDisplay()
        {
            AircraftTypeComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            AircraftTypeComboBox.DrawItem += AircraftTypeComboBox_DrawItem;
        }
        /// <summary>
        /// Обрабатывает отрисовку элемента в выпадающем списке типов воздушных судов.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="eventArgs">Аргументы события отрисовки.</param>
        private void AircraftTypeComboBox_DrawItem(object? sender, DrawItemEventArgs eventArgs)
        {
            if (eventArgs.Index == -1)
            {
                return;
            }
            eventArgs.DrawBackground();
            eventArgs.DrawFocusRectangle();
            var itemText = AircraftTypeComboBox.Items[eventArgs.Index]?.ToString();
            using var brush = new SolidBrush(eventArgs.ForeColor);
            eventArgs.Graphics.DrawString(itemText, eventArgs.Font!, brush, eventArgs.Bounds);
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки сохранения. Проверяет введённые данные и сохраняет рейс.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="eventArgs">Аргументы события.</param>
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
                UiConstants.ComboBoxItems.Oak => AircraftType.Oak,
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
        /// Обрабатывает нажатие кнопки отмены. Закрывает форму без сохранения.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="eventArgs">Аргументы события.</param>
        private void CancelButton_Click(object sender, EventArgs eventArgs)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
