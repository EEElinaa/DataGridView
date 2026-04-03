using System.ComponentModel;
using System.Drawing.Drawing2D;
using Airport.Domain.Models;
using Airport.Services.Contracts;
using Airport.WinForms.Formatters;
using Airport.WinForms.Forms.Constants;

// Импорты для констант из отдельных файлов
using FormattingConstants = Airport.WinForms.Forms.Constants.FormattingConstants;
using ComboBoxItemsConstants = Airport.WinForms.Forms.Constants.ComboBoxItemsConstants;
using ColorsConstants = Airport.WinForms.Forms.Constants.ColorsConstants;
using FontsConstants = Airport.WinForms.Forms.Constants.FontsConstants;
using MessagesConstants = Airport.WinForms.Forms.Constants.MessagesConstants;
using IconsConstants = Airport.WinForms.Forms.Constants.IconsConstants;
using DataGridViewConstants = Airport.WinForms.Forms.Constants.DataGridViewConstants;

namespace Airport.WinForms.Forms
{
    /// <summary>
    /// Главная форма приложения "Аэропорт"
    /// Отображает список прибывающих рейсов и статистику
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly IFlightService flightService;
        private BindingList<Flight> flightsBinding = null!;

        /// <summary>
        /// Конструктор главной формы
        /// </summary>
        /// <param name="flightService">Сервис для работы с рейсами</param>
        public MainForm(IFlightService flightService)
        {
            this.flightService = flightService;
            InitializeComponent();
            ConfigureDataGridView();
            BindFlights();
            LoadData();
            UpdateStatistics();
            SetupEventHandlers();
            SetButtonIcons();
            FormClosing += MainForm_FormClosing!;
        }

        /// <summary>
        /// Настраивает обработчики событий для кнопок
        /// </summary>
        private void SetupEventHandlers()
        {
            AddFlightButton.Click += AddFlightButton_Click!;
            EditFlightButton.Click += EditFlightButton_Click!;
            DeleteFlightButton.Click += DeleteFlightButton_Click!;
        }

        /// <summary>
        /// Обработчик закрытия формы
        /// Отписывается от событий для предотвращения утечек памяти
        /// </summary>
        private void MainForm_FormClosing(object? sender, FormClosingEventArgs eventArgs)
        {
            AddFlightButton.Click -= AddFlightButton_Click;
            EditFlightButton.Click -= EditFlightButton_Click;
            DeleteFlightButton.Click -= DeleteFlightButton_Click;
        }

        /// <summary>
        /// Устанавливает иконки на кнопки главной формы
        /// </summary>
        private void SetButtonIcons()
        {
            try
            {
                var iconsPath = Path.Combine(Application.StartupPath, IconsConstants.IconsFolder);

                if (!Directory.Exists(iconsPath))
                {
                    System.Diagnostics.Debug.WriteLine(
                        string.Format(MessagesConstants.IconsNotFound, iconsPath));
                    return;
                }
                const int iconSize = IconsConstants.IconSize;
                var addIconPath = Path.Combine(iconsPath, IconsConstants.AddIcon);
                if (File.Exists(addIconPath))
                {
                    using (var originalImage = Image.FromFile(addIconPath))
                    {
                        AddFlightButton.Image = ResizeImage(originalImage, iconSize, iconSize);
                    }
                    AddFlightButton.ImageAlign = ContentAlignment.MiddleLeft;
                    AddFlightButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                }
                var editIconPath = Path.Combine(iconsPath, IconsConstants.EditIcon);
                if (File.Exists(editIconPath))
                {
                    using (var originalImage = Image.FromFile(editIconPath))
                    {
                        EditFlightButton.Image = ResizeImage(originalImage, iconSize, iconSize);
                    }
                    EditFlightButton.ImageAlign = ContentAlignment.MiddleLeft;
                    EditFlightButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                }
                var deleteIconPath = Path.Combine(iconsPath, IconsConstants.DeleteIcon);
                if (File.Exists(deleteIconPath))
                {
                    using (var originalImage = Image.FromFile(deleteIconPath))
                    {
                        DeleteFlightButton.Image = ResizeImage(originalImage, iconSize, iconSize);
                    }
                    DeleteFlightButton.ImageAlign = ContentAlignment.MiddleLeft;
                    DeleteFlightButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                }
                AddFlightButton.Size = new Size(
                    IconsConstants.ButtonWidthWithIcon,
                    IconsConstants.ButtonHeightWithIcon);
                EditFlightButton.Size = new Size(
                    IconsConstants.ButtonWidthWithIcon,
                    IconsConstants.ButtonHeightWithIcon);
                DeleteFlightButton.Size = new Size(
                    IconsConstants.ButtonWidthWithIcon,
                    IconsConstants.ButtonHeightWithIcon);
                EditFlightButton.Location = new Point(
                    AddFlightButton.Right + IconsConstants.ButtonSpacing,
                    AddFlightButton.Top);
                DeleteFlightButton.Location = new Point(
                    EditFlightButton.Right + IconsConstants.ButtonSpacing,
                    EditFlightButton.Top);
                System.Diagnostics.Debug.WriteLine(MessagesConstants.IconsLoaded);
            }
            catch (Exception exception)
            {
                System.Diagnostics.Debug.WriteLine(
                    string.Format(MessagesConstants.IconsError, exception.Message));
            }
        }

        /// <summary>
        /// Изменяет размер изображения с сохранением качества
        /// </summary>
        private Image ResizeImage(Image image, int width, int height)
        {
            var resizedImage = new Bitmap(width, height);
            using (var graphics = Graphics.FromImage(resizedImage))
            {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }

        /// <summary>
        /// Настраивает отображение DataGridView
        /// </summary>
        private void ConfigureDataGridView()
        {
            FlightsDataGridView.AutoGenerateColumns = false;
            FlightsDataGridView.AlternatingRowsDefaultCellStyle.BackColor = ColorsConstants.DataGridViewAlternatingRowColor;
            FlightsDataGridView.DefaultCellStyle.Font = new Font(
                FontsConstants.DefaultFontName,
                FontsConstants.DefaultFontSize);
            FlightsDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(
                FontsConstants.DefaultFontName,
                FontsConstants.HeaderFontSize,
                FontStyle.Bold);
            FlightsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = ColorsConstants.DataGridViewHeaderBackColor;
            FlightsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = ColorsConstants.DataGridViewHeaderForeColor;
            var flightNumberColumn = new DataGridViewTextBoxColumn
            {
                Name = "FlightNumber",
                HeaderText = "Номер рейса",
                DataPropertyName = nameof(Flight.FlightNumber),
                Width = DataGridViewConstants.FlightNumberWidth
            };
            var aircraftTypeColumn = new DataGridViewTextBoxColumn
            {
                Name = "AircraftType",
                HeaderText = "Тип самолёта",
                DataPropertyName = nameof(Flight.AircraftType),
                Width = DataGridViewConstants.AircraftTypeWidth
            };
            var arrivalTimeColumn = new DataGridViewTextBoxColumn
            {
                Name = "ArrivalTime",
                HeaderText = "Время прибытия",
                DataPropertyName = nameof(Flight.ArrivalTime),
                Width = DataGridViewConstants.ArrivalTimeWidth
            };
            var passengerCountColumn = new DataGridViewTextBoxColumn
            {
                Name = "PassengerCount",
                HeaderText = "Пассажиры",
                DataPropertyName = nameof(Flight.PassengerCount),
                Width = DataGridViewConstants.PassengerCountWidth
            };
            var passengerFeeColumn = new DataGridViewTextBoxColumn
            {
                Name = "PassengerFee",
                HeaderText = "Сбор с пассажира",
                DataPropertyName = nameof(Flight.PassengerFee),
                Width = DataGridViewConstants.PassengerFeeWidth
            };
            var crewCountColumn = new DataGridViewTextBoxColumn
            {
                Name = "CrewCount",
                HeaderText = "Экипаж",
                DataPropertyName = nameof(Flight.CrewCount),
                Width = DataGridViewConstants.CrewCountWidth
            };
            var crewFeeColumn = new DataGridViewTextBoxColumn
            {
                Name = "CrewFee",
                HeaderText = "Сбор с экипажа",
                DataPropertyName = nameof(Flight.CrewFee),
                Width = DataGridViewConstants.CrewFeeWidth
            };
            var surchargePercentColumn = new DataGridViewTextBoxColumn
            {
                Name = "SurchargePercent",
                HeaderText = "Надбавка, %",
                DataPropertyName = nameof(Flight.ServiceSurchargePercent),
                Width = DataGridViewConstants.SurchargePercentWidth
            };
            var revenueColumn = new DataGridViewTextBoxColumn
            {
                Name = "Revenue",
                HeaderText = "Выручка",
                Width = DataGridViewConstants.RevenueWidth,
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    ForeColor = ColorsConstants.RevenueForeColor,
                    Font = new Font(FontsConstants.DefaultFontName, FontsConstants.DefaultFontSize, FontStyle.Bold)
                }
            };
            FlightsDataGridView.Columns.AddRange(new DataGridViewColumn[]
            {
                flightNumberColumn,
                aircraftTypeColumn,
                arrivalTimeColumn,
                passengerCountColumn,
                passengerFeeColumn,
                crewCountColumn,
                crewFeeColumn,
                surchargePercentColumn,
                revenueColumn
            });

            FlightsDataGridView.CellFormatting += FlightsDataGridView_CellFormatting!;
        }

        /// <summary>
        /// Привязывает список рейсов к DataGridView
        /// </summary>
        private void BindFlights()
        {
            flightsBinding = new BindingList<Flight>();
            FlightsBindingSource.DataSource = flightsBinding;
        }

        /// <summary>
        /// Загружает данные из сервиса в BindingList
        /// </summary>
        private void LoadData()
        {
            flightsBinding.Clear();
            foreach (var flight in flightService.GetAllFlights())
            {
                flightsBinding.Add(flight);
            }
        }

        /// <summary>
        /// Обработчик форматирования ячеек DataGridView
        /// </summary>
        private void FlightsDataGridView_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs eventArgs)
        {
            if (eventArgs.RowIndex < 0 || eventArgs.ColumnIndex < 0)
            {
                return;
            }
            var column = FlightsDataGridView.Columns[eventArgs.ColumnIndex];
            var flight = FlightsDataGridView.Rows[eventArgs.RowIndex].DataBoundItem as Flight;
            if (flight == null)
            {
                return;
            }
            if (column.Name == "AircraftType")
            {
                eventArgs.Value = FlightFormatter.FormatAircraftType(flight.AircraftType);
                eventArgs.FormattingApplied = true;
            }
            else if (column.Name == "ArrivalTime")
            {
                eventArgs.Value = FlightFormatter.FormatDateTime(flight.ArrivalTime);
                eventArgs.FormattingApplied = true;
            }
            else if (column.Name == "PassengerFee" || column.Name == "CrewFee")
            {
                if (eventArgs.Value is decimal value)
                {
                    eventArgs.Value = FlightFormatter.FormatMoney(value);
                    eventArgs.FormattingApplied = true;
                }
            }
            else if (column.Name == "Revenue")
            {
                eventArgs.Value = FlightFormatter.FormatMoney(flight.GetRevenue());
                eventArgs.FormattingApplied = true;
            }
            else if (column.Name == "SurchargePercent")
            {
                eventArgs.Value = string.Format("{0}{1}",
                    flight.ServiceSurchargePercent.ToString(FormattingConstants.PercentFormat),
                    FormattingConstants.PercentSymbol);
                eventArgs.FormattingApplied = true;
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки добавления рейса
        /// </summary>
        private void AddFlightButton_Click(object? sender, EventArgs eventArgs)
        {
            using var form = new FlightForm();

            if (form.ShowDialog() == DialogResult.OK && form.ResultFlight != null)
            {
                var flight = form.ResultFlight;
                flightService.AddFlight(flight);
                flightsBinding.Add(flight);
                UpdateStatistics();
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки редактирования рейса
        /// </summary>
        private void EditFlightButton_Click(object? sender, EventArgs eventArgs)
        {
            var selectedFlight = GetSelectedFlight();
            if (selectedFlight == null)
            {
                MessageBox.Show(
                    MessagesConstants.SelectFlightForEdit,
                    MessagesConstants.Attention,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            var originalFlightNumber = selectedFlight.FlightNumber;
            var originalId = selectedFlight.Id;
            using var form = new FlightForm(selectedFlight);
            if (form.ShowDialog() == DialogResult.OK && form.ResultFlight != null)
            {
                var updatedFlight = form.ResultFlight;
                flightService.UpdateFlight(updatedFlight);
                for (var i = 0; i < flightsBinding.Count; i++)
                {
                    if (flightsBinding[i].Id == originalId)
                    {
                        flightsBinding[i] = updatedFlight;
                        break;
                    }
                }
                flightsBinding.ResetBindings();
                FlightsDataGridView.Refresh();
                UpdateStatistics();
                MessageBox.Show(
                    string.Format(MessagesConstants.SuccessEdit, originalFlightNumber),
                    MessagesConstants.SuccessTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки удаления рейса
        /// </summary>
        private void DeleteFlightButton_Click(object? sender, EventArgs eventArgs)
        {
            var selectedFlight = GetSelectedFlight();
            if (selectedFlight == null)
            {
                MessageBox.Show(
                    MessagesConstants.SelectFlightForDelete,
                    MessagesConstants.Attention,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            var confirmResult = MessageBox.Show(
                string.Format(MessagesConstants.ConfirmDelete, selectedFlight.FlightNumber),
                MessagesConstants.ConfirmDeleteTitle,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                flightService.DeleteFlight(selectedFlight.Id);
                flightsBinding.Remove(selectedFlight);
                UpdateStatistics();
                MessageBox.Show(
                    string.Format(MessagesConstants.SuccessDelete, selectedFlight.FlightNumber),
                    MessagesConstants.SuccessTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Получает выбранный в DataGridView рейс
        /// </summary>
        private Flight? GetSelectedFlight()
        {
            if (FlightsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = FlightsDataGridView.SelectedRows[0];
                if (selectedRow.DataBoundItem is Flight flight)
                {
                    return flight;
                }
            }
            if (FlightsDataGridView.CurrentRow?.DataBoundItem is Flight currentFlight)
            {
                return currentFlight;
            }
            return null;
        }

        /// <summary>
        /// Обновляет отображение статистики на форме
        /// </summary>
        private void UpdateStatistics()
        {
            try
            {
                var statistics = flightService.CalculateStatistics(flightsBinding);
                TotalFlightsValueLabel.Text = statistics.TotalFlights.ToString();
                TotalPassengersValueLabel.Text = statistics.TotalPassengers.ToString();
                TotalCrewValueLabel.Text = statistics.TotalCrew.ToString();
                TotalRevenueValueLabel.Text = FlightFormatter.FormatMoney(statistics.TotalRevenue);
                TotalFlightsLabel.Text = $"Всего рейсов: {statistics.TotalFlights}";
                TotalPassengersLabel.Text = $"Всего пассажиров: {statistics.TotalPassengers}";
                TotalCrewLabel.Text = $"Всего экипажа: {statistics.TotalCrew}";
                TotalRevenueLabel.Text = $"Общая выручка: {FlightFormatter.FormatMoney(statistics.TotalRevenue)}";
                bool hasData = statistics.TotalFlights > 0;
                MainStatusStrip.Visible = hasData;
                StatisticsGroupBox.Visible = hasData;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(
                    string.Format(MessagesConstants.StatisticsError, ex.Message));
            }
        }
    }
}
