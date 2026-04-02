#nullable disable
using System.ComponentModel;
using System.Drawing.Drawing2D;
using Airport.Domain.Models;
using Airport.Services.Contracts;
using Airport.WinForms.Formatters;
using Airport.WinForms.Forms.Constants;
namespace Airport.WinForms.Forms
{
    /// <summary>
    /// Главная форма приложения "Аэропорт"
    /// Отображает список прибывающих рейсов и статистику
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly IFlightService flightService;
        private BindingList<Flight> flightsBinding;

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
            FormClosing += MainForm_FormClosing;
        }

        /// <summary>
        /// Настраивает обработчики событий для кнопок
        /// </summary>
        private void SetupEventHandlers()
        {
            AddFlightButton.Click += AddFlightButton_Click;
            EditFlightButton.Click += EditFlightButton_Click;
            DeleteFlightButton.Click += DeleteFlightButton_Click;
        }

        /// <summary>
        /// Обработчик закрытия формы
        /// Отписывается от событий для предотвращения утечек памяти
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs eventArgs)
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
                var iconsPath = Path.Combine(Application.StartupPath, UiConstants.Icons.IconsFolder);

                if (!Directory.Exists(iconsPath))
                {
                    System.Diagnostics.Debug.WriteLine(
                        string.Format(UiConstants.Messages.IconsNotFound, iconsPath));
                    return;
                }

                const int iconSize = UiConstants.Icons.IconSize;

                // Загружаем иконку добавления
                var addIconPath = Path.Combine(iconsPath, UiConstants.Icons.AddIcon);
                if (File.Exists(addIconPath))
                {
                    using (var originalImage = Image.FromFile(addIconPath))
                    {
                        AddFlightButton.Image = ResizeImage(originalImage, iconSize, iconSize);
                    }
                    AddFlightButton.ImageAlign = ContentAlignment.MiddleLeft;
                    AddFlightButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                }

                // Загружаем иконку редактирования
                var editIconPath = Path.Combine(iconsPath, UiConstants.Icons.EditIcon);
                if (File.Exists(editIconPath))
                {
                    using (var originalImage = Image.FromFile(editIconPath))
                    {
                        EditFlightButton.Image = ResizeImage(originalImage, iconSize, iconSize);
                    }
                    EditFlightButton.ImageAlign = ContentAlignment.MiddleLeft;
                    EditFlightButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                }

                // Загружаем иконку удаления
                var deleteIconPath = Path.Combine(iconsPath, UiConstants.Icons.DeleteIcon);
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
                    UiConstants.Icons.ButtonWidthWithIcon,
                    UiConstants.Icons.ButtonHeightWithIcon);
                EditFlightButton.Size = new Size(
                    UiConstants.Icons.ButtonWidthWithIcon,
                    UiConstants.Icons.ButtonHeightWithIcon);
                DeleteFlightButton.Size = new Size(
                    UiConstants.Icons.ButtonWidthWithIcon,
                    UiConstants.Icons.ButtonHeightWithIcon);
                EditFlightButton.Location = new Point(
                    AddFlightButton.Right + UiConstants.Icons.ButtonSpacing,
                    AddFlightButton.Top);
                DeleteFlightButton.Location = new Point(
                    EditFlightButton.Right + UiConstants.Icons.ButtonSpacing,
                    EditFlightButton.Top);
                System.Diagnostics.Debug.WriteLine(UiConstants.Messages.IconsLoaded);
            }
            catch (Exception exception)
            {
                System.Diagnostics.Debug.WriteLine(
                    string.Format(UiConstants.Messages.IconsError, exception.Message));
            }
        }

        /// <summary>
        /// Изменяет размер изображения с сохранением качества
        /// </summary>
        /// <param name="image">Исходное изображение</param>
        /// <param name="width">Новая ширина</param>
        /// <param name="height">Новая высота</param>
        /// <returns>Измененное изображение</returns>
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
            FlightsDataGridView.AlternatingRowsDefaultCellStyle.BackColor = UiConstants.Colors.DataGridViewAlternatingRowColor;
            FlightsDataGridView.DefaultCellStyle.Font = new Font(
                UiConstants.Fonts.DefaultFontName,
                UiConstants.Fonts.DefaultFontSize);
            FlightsDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(
                UiConstants.Fonts.DefaultFontName,
                UiConstants.Fonts.HeaderFontSize,
                FontStyle.Bold);
            FlightsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = UiConstants.Colors.DataGridViewHeaderBackColor;
            FlightsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = UiConstants.Colors.DataGridViewHeaderForeColor;

            var flightNumberColumn = new DataGridViewTextBoxColumn
            {
                Name = "FlightNumber",
                HeaderText = "Номер рейса",
                DataPropertyName = nameof(Flight.FlightNumber),
                Width = UiConstants.DataGridView.FlightNumberWidth
            };

            var aircraftTypeColumn = new DataGridViewTextBoxColumn
            {
                Name = "AircraftType",
                HeaderText = "Тип самолёта",
                DataPropertyName = nameof(Flight.AircraftType),
                Width = UiConstants.DataGridView.AircraftTypeWidth
            };

            var arrivalTimeColumn = new DataGridViewTextBoxColumn
            {
                Name = "ArrivalTime",
                HeaderText = "Время прибытия",
                DataPropertyName = nameof(Flight.ArrivalTime),
                Width = UiConstants.DataGridView.ArrivalTimeWidth
            };

            var passengerCountColumn = new DataGridViewTextBoxColumn
            {
                Name = "PassengerCount",
                HeaderText = "Пассажиры",
                DataPropertyName = nameof(Flight.PassengerCount),
                Width = UiConstants.DataGridView.PassengerCountWidth
            };

            var passengerFeeColumn = new DataGridViewTextBoxColumn
            {
                Name = "PassengerFee",
                HeaderText = "Сбор с пассажира",
                DataPropertyName = nameof(Flight.PassengerFee),
                Width = UiConstants.DataGridView.PassengerFeeWidth
            };

            var crewCountColumn = new DataGridViewTextBoxColumn
            {
                Name = "CrewCount",
                HeaderText = "Экипаж",
                DataPropertyName = nameof(Flight.CrewCount),
                Width = UiConstants.DataGridView.CrewCountWidth
            };

            var crewFeeColumn = new DataGridViewTextBoxColumn
            {
                Name = "CrewFee",
                HeaderText = "Сбор с экипажа",
                DataPropertyName = nameof(Flight.CrewFee),
                Width = UiConstants.DataGridView.CrewFeeWidth
            };

            var surchargePercentColumn = new DataGridViewTextBoxColumn
            {
                Name = "SurchargePercent",
                HeaderText = "Надбавка, %",
                DataPropertyName = nameof(Flight.ServiceSurchargePercent),
                Width = UiConstants.DataGridView.SurchargePercentWidth
            };

            var revenueColumn = new DataGridViewTextBoxColumn
            {
                Name = "Revenue",
                HeaderText = "Выручка",
                Width = UiConstants.DataGridView.RevenueWidth,
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    ForeColor = UiConstants.Colors.RevenueForeColor,
                    Font = new Font(UiConstants.Fonts.DefaultFontName, UiConstants.Fonts.DefaultFontSize, FontStyle.Bold)
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
            FlightsDataGridView.CellFormatting += FlightsDataGridView_CellFormatting;
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
        /// Преобразует данные в читаемый вид (дата, валюта, тип самолёта)
        /// </summary>
        private void FlightsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs eventArgs)
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
                eventArgs.Value = FlightFormatter.FormatMoney((decimal)eventArgs.Value);
                eventArgs.FormattingApplied = true;
            }
            else if (column.Name == "Revenue")
            {
                eventArgs.Value = FlightFormatter.FormatMoney(flight.GetRevenue());
                eventArgs.FormattingApplied = true;
            }
            else if (column.Name == "SurchargePercent")
            {
                eventArgs.Value = string.Format("{0}{1}",
                    flight.ServiceSurchargePercent.ToString(UiConstants.Formatting.PercentFormat),
                    UiConstants.Formatting.PercentSymbol);
                eventArgs.FormattingApplied = true;
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки добавления рейса
        /// </summary>
        private void AddFlightButton_Click(object sender, EventArgs eventArgs)
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
        private void EditFlightButton_Click(object sender, EventArgs eventArgs)
        {
            var selectedFlight = GetSelectedFlight();

            if (selectedFlight == null)
            {
                MessageBox.Show(
                    UiConstants.Messages.SelectFlightForEdit,
                    UiConstants.Messages.Attention,
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
                    string.Format(UiConstants.Messages.SuccessEdit, originalFlightNumber),
                    UiConstants.Messages.SuccessTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки удаления рейса
        /// </summary>
        private void DeleteFlightButton_Click(object sender, EventArgs eventArgs)
        {
            var selectedFlight = GetSelectedFlight();

            if (selectedFlight == null)
            {
                MessageBox.Show(
                    UiConstants.Messages.SelectFlightForDelete,
                    UiConstants.Messages.Attention,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            var confirmResult = MessageBox.Show(
                string.Format(UiConstants.Messages.ConfirmDelete, selectedFlight.FlightNumber),
                UiConstants.Messages.ConfirmDeleteTitle,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                flightService.DeleteFlight(selectedFlight.Id);
                flightsBinding.Remove(selectedFlight);
                UpdateStatistics();

                MessageBox.Show(
                    string.Format(UiConstants.Messages.SuccessDelete, selectedFlight.FlightNumber),
                    UiConstants.Messages.SuccessTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Получает выбранный в DataGridView рейс
        /// </summary>
        /// <returns>Выбранный рейс или null, если ничего не выбрано</returns>
        private Flight GetSelectedFlight()
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
                if (TotalFlightsValueLabel != null && !TotalFlightsValueLabel.IsDisposed)
                {
                    TotalFlightsValueLabel.Text = statistics.TotalFlights.ToString();
                }
                if (TotalPassengersValueLabel != null && !TotalPassengersValueLabel.IsDisposed)
                {
                    TotalPassengersValueLabel.Text = statistics.TotalPassengers.ToString();
                }
                if (TotalCrewValueLabel != null && !TotalCrewValueLabel.IsDisposed)
                {
                    TotalCrewValueLabel.Text = statistics.TotalCrew.ToString();
                }
                if (TotalRevenueValueLabel != null && !TotalRevenueValueLabel.IsDisposed)
                {
                    TotalRevenueValueLabel.Text = FlightFormatter.FormatMoney(statistics.TotalRevenue);
                }
                if (TotalFlightsLabel != null && !TotalFlightsLabel.IsDisposed)
                {
                    TotalFlightsLabel.Text = $"Всего рейсов: {statistics.TotalFlights}";
                }
                if (TotalPassengersLabel != null && !TotalPassengersLabel.IsDisposed)
                {
                    TotalPassengersLabel.Text = $"Всего пассажиров: {statistics.TotalPassengers}";
                }
                if (TotalCrewLabel != null && !TotalCrewLabel.IsDisposed)
                {
                    TotalCrewLabel.Text = $"Всего экипажа: {statistics.TotalCrew}";
                }
                if (TotalRevenueLabel != null && !TotalRevenueLabel.IsDisposed)
                {
                    TotalRevenueLabel.Text = $"Общая выручка: {FlightFormatter.FormatMoney(statistics.TotalRevenue)}";
                }
                if (MainStatusStrip != null && !MainStatusStrip.IsDisposed)
                {
                    MainStatusStrip.Visible = statistics.TotalFlights > 0;
                }
                if (StatisticsGroupBox != null && !StatisticsGroupBox.IsDisposed)
                {
                    StatisticsGroupBox.Visible = statistics.TotalFlights > 0;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(
                    string.Format(UiConstants.Messages.StatisticsError, ex.Message));
            }
        }
    }
}
