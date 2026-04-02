using Airport.WinForms.Forms.Constants;
namespace Airport.WinForms.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView FlightsDataGridView;
        private System.Windows.Forms.Button AddFlightButton;
        private System.Windows.Forms.Button EditFlightButton;
        private System.Windows.Forms.Button DeleteFlightButton;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel TotalFlightsLabel;
        private System.Windows.Forms.ToolStripStatusLabel TotalPassengersLabel;
        private System.Windows.Forms.ToolStripStatusLabel TotalCrewLabel;
        private System.Windows.Forms.ToolStripStatusLabel TotalRevenueLabel;
        private System.Windows.Forms.BindingSource FlightsBindingSource;
        private System.Windows.Forms.GroupBox StatisticsGroupBox;
        private System.Windows.Forms.Label TotalFlightsValueLabel;
        private System.Windows.Forms.Label TotalPassengersValueLabel;
        private System.Windows.Forms.Label TotalCrewValueLabel;
        private System.Windows.Forms.Label TotalRevenueValueLabel;
        private System.Windows.Forms.Label TotalFlightsTitleLabel;
        private System.Windows.Forms.Label TotalPassengersTitleLabel;
        private System.Windows.Forms.Label TotalCrewTitleLabel;
        private System.Windows.Forms.Label TotalRevenueTitleLabel;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            FlightsDataGridView = new DataGridView();
            FlightsBindingSource = new BindingSource(components);
            AddFlightButton = new Button();
            EditFlightButton = new Button();
            DeleteFlightButton = new Button();
            MainStatusStrip = new StatusStrip();
            TotalFlightsLabel = new ToolStripStatusLabel();
            TotalPassengersLabel = new ToolStripStatusLabel();
            TotalCrewLabel = new ToolStripStatusLabel();
            TotalRevenueLabel = new ToolStripStatusLabel();
            StatisticsGroupBox = new GroupBox();
            TotalRevenueValueLabel = new Label();
            TotalRevenueTitleLabel = new Label();
            TotalCrewValueLabel = new Label();
            TotalCrewTitleLabel = new Label();
            TotalPassengersValueLabel = new Label();
            TotalPassengersTitleLabel = new Label();
            TotalFlightsValueLabel = new Label();
            TotalFlightsTitleLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)FlightsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FlightsBindingSource).BeginInit();
            MainStatusStrip.SuspendLayout();
            StatisticsGroupBox.SuspendLayout();
            SuspendLayout();

            // FlightsDataGridView
            FlightsDataGridView.AllowUserToAddRows = false;
            FlightsDataGridView.AllowUserToDeleteRows = false;
            FlightsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FlightsDataGridView.AutoGenerateColumns = false;
            FlightsDataGridView.BackgroundColor = UiConstants.Colors.DataGridViewBackgroundColor;
            FlightsDataGridView.BorderStyle = BorderStyle.Fixed3D;
            FlightsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FlightsDataGridView.DataSource = FlightsBindingSource;
            FlightsDataGridView.Location = new Point(
                UiConstants.MainFormLayout.GroupBoxLeft,
                UiConstants.MainFormLayout.DataGridViewTop);
            FlightsDataGridView.Name = "FlightsDataGridView";
            FlightsDataGridView.ReadOnly = true;
            FlightsDataGridView.RowHeadersWidth = 51;
            FlightsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FlightsDataGridView.Size = new Size(
                UiConstants.MainFormLayout.FormWidth - 2 * UiConstants.MainFormLayout.GroupBoxLeft,
                UiConstants.MainFormLayout.DataGridViewHeight);
            FlightsDataGridView.TabIndex = 0;

            // AddFlightButton
            AddFlightButton.Location = new Point(
                UiConstants.MainFormLayout.ButtonLeft,
                UiConstants.MainFormLayout.ButtonTop);
            AddFlightButton.Name = "AddFlightButton";
            AddFlightButton.Size = new Size(
                UiConstants.MainFormLayout.ButtonDefaultWidth,
                UiConstants.MainFormLayout.ButtonDefaultHeight);
            AddFlightButton.TabIndex = 1;
            AddFlightButton.Text = "Добавить рейс";
            AddFlightButton.UseVisualStyleBackColor = true;

            // EditFlightButton
            EditFlightButton.Location = new Point(
                UiConstants.MainFormLayout.ButtonLeft + UiConstants.MainFormLayout.ButtonDefaultWidth + UiConstants.Icons.ButtonSpacing,
                UiConstants.MainFormLayout.ButtonTop);
            EditFlightButton.Name = "EditFlightButton";
            EditFlightButton.Size = new Size(
                UiConstants.MainFormLayout.ButtonDefaultWidth,
                UiConstants.MainFormLayout.ButtonDefaultHeight);
            EditFlightButton.TabIndex = 2;
            EditFlightButton.Text = "Редактировать";
            EditFlightButton.UseVisualStyleBackColor = true;

            // DeleteFlightButton
            DeleteFlightButton.Location = new Point(
                UiConstants.MainFormLayout.ButtonLeft + 2 * (UiConstants.MainFormLayout.ButtonDefaultWidth + UiConstants.Icons.ButtonSpacing),
                UiConstants.MainFormLayout.ButtonTop);
            DeleteFlightButton.Name = "DeleteFlightButton";
            DeleteFlightButton.Size = new Size(
                UiConstants.MainFormLayout.ButtonDefaultWidth,
                UiConstants.MainFormLayout.ButtonDefaultHeight);
            DeleteFlightButton.TabIndex = 3;
            DeleteFlightButton.Text = "Удалить рейс";
            DeleteFlightButton.UseVisualStyleBackColor = true;

            // MainStatusStrip
            MainStatusStrip.ImageScalingSize = new Size(20, 20);
            MainStatusStrip.Items.AddRange(new ToolStripItem[] {
                TotalFlightsLabel,
                TotalPassengersLabel,
                TotalCrewLabel,
                TotalRevenueLabel });
            MainStatusStrip.Location = new Point(0, UiConstants.MainFormLayout.StatusStripTop);
            MainStatusStrip.Name = "MainStatusStrip";
            MainStatusStrip.Size = new Size(
                UiConstants.MainFormLayout.FormWidth,
                UiConstants.MainFormLayout.StatusStripHeight);
            MainStatusStrip.TabIndex = 6;

            // TotalFlightsLabel
            TotalFlightsLabel.Name = "TotalFlightsLabel";
            TotalFlightsLabel.Size = new Size(117, 20);
            TotalFlightsLabel.Text = "Всего рейсов: 0";

            // TotalPassengersLabel
            TotalPassengersLabel.Name = "TotalPassengersLabel";
            TotalPassengersLabel.Size = new Size(152, 20);
            TotalPassengersLabel.Text = "Всего пассажиров: 0";

            // TotalCrewLabel
            TotalCrewLabel.Name = "TotalCrewLabel";
            TotalCrewLabel.Size = new Size(126, 20);
            TotalCrewLabel.Text = "Всего экипажа: 0";

            // TotalRevenueLabel
            TotalRevenueLabel.Name = "TotalRevenueLabel";
            TotalRevenueLabel.Size = new Size(134, 20);
            TotalRevenueLabel.Text = $"Общая выручка: 0 {UiConstants.Formatting.CurrencySymbol}";

            // StatisticsGroupBox
            StatisticsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StatisticsGroupBox.Controls.Add(TotalRevenueValueLabel);
            StatisticsGroupBox.Controls.Add(TotalRevenueTitleLabel);
            StatisticsGroupBox.Controls.Add(TotalCrewValueLabel);
            StatisticsGroupBox.Controls.Add(TotalCrewTitleLabel);
            StatisticsGroupBox.Controls.Add(TotalPassengersValueLabel);
            StatisticsGroupBox.Controls.Add(TotalPassengersTitleLabel);
            StatisticsGroupBox.Controls.Add(TotalFlightsValueLabel);
            StatisticsGroupBox.Controls.Add(TotalFlightsTitleLabel);
            StatisticsGroupBox.Font = new System.Drawing.Font(
                UiConstants.Fonts.DefaultFontName,
                UiConstants.Fonts.StatisticsFontSize,
                FontStyle.Bold);
            StatisticsGroupBox.Location = new Point(
                UiConstants.MainFormLayout.GroupBoxLeft,
                UiConstants.MainFormLayout.StatisticsTop);
            StatisticsGroupBox.Name = "StatisticsGroupBox";
            StatisticsGroupBox.Size = new Size(
                UiConstants.MainFormLayout.FormWidth - 2 * UiConstants.MainFormLayout.GroupBoxLeft,
                UiConstants.MainFormLayout.StatisticsHeight);
            StatisticsGroupBox.TabIndex = 5;
            StatisticsGroupBox.TabStop = false;
            StatisticsGroupBox.Text = "Статистика аэропорта";

            // TotalRevenueValueLabel
            TotalRevenueValueLabel.AutoSize = true;
            TotalRevenueValueLabel.Font = new System.Drawing.Font(
                UiConstants.Fonts.DefaultFontName,
                UiConstants.Fonts.DefaultFontSize,
                FontStyle.Bold);
            TotalRevenueValueLabel.ForeColor = UiConstants.Colors.RevenueForeColor;
            TotalRevenueValueLabel.Location = new Point(
                UiConstants.StatisticsLayout.RevenueValueLeft,
                UiConstants.StatisticsLayout.LabelTop);
            TotalRevenueValueLabel.Name = "TotalRevenueValueLabel";
            TotalRevenueValueLabel.Size = new Size(31, 20);
            TotalRevenueValueLabel.TabIndex = 0;
            TotalRevenueValueLabel.Text = $"0 {UiConstants.Formatting.CurrencySymbol}";

            // TotalRevenueTitleLabel
            TotalRevenueTitleLabel.AutoSize = true;
            TotalRevenueTitleLabel.Font = new System.Drawing.Font(
                UiConstants.Fonts.DefaultFontName,
                UiConstants.Fonts.DefaultFontSize);
            TotalRevenueTitleLabel.Location = new Point(
                UiConstants.StatisticsLayout.RevenueTitleLeft,
                UiConstants.StatisticsLayout.LabelTop);
            TotalRevenueTitleLabel.Name = "TotalRevenueTitleLabel";
            TotalRevenueTitleLabel.Size = new Size(122, 20);
            TotalRevenueTitleLabel.TabIndex = 1;
            TotalRevenueTitleLabel.Text = "Общая выручка:";

            // TotalCrewValueLabel
            TotalCrewValueLabel.AutoSize = true;
            TotalCrewValueLabel.Font = new System.Drawing.Font(
                UiConstants.Fonts.DefaultFontName,
                UiConstants.Fonts.DefaultFontSize,
                FontStyle.Bold);
            TotalCrewValueLabel.Location = new Point(
                UiConstants.StatisticsLayout.CrewValueLeft,
                UiConstants.StatisticsLayout.LabelTop);
            TotalCrewValueLabel.Name = "TotalCrewValueLabel";
            TotalCrewValueLabel.Size = new Size(18, 20);
            TotalCrewValueLabel.TabIndex = 2;
            TotalCrewValueLabel.Text = "0";

            // TotalCrewTitleLabel
            TotalCrewTitleLabel.AutoSize = true;
            TotalCrewTitleLabel.Font = new System.Drawing.Font(
                UiConstants.Fonts.DefaultFontName,
                UiConstants.Fonts.DefaultFontSize);
            TotalCrewTitleLabel.Location = new Point(
                UiConstants.StatisticsLayout.CrewTitleLeft,
                UiConstants.StatisticsLayout.LabelTop);
            TotalCrewTitleLabel.Name = "TotalCrewTitleLabel";
            TotalCrewTitleLabel.Size = new Size(114, 20);
            TotalCrewTitleLabel.TabIndex = 3;
            TotalCrewTitleLabel.Text = "Всего экипажа:";

            // TotalPassengersValueLabel
            TotalPassengersValueLabel.AutoSize = true;
            TotalPassengersValueLabel.Font = new System.Drawing.Font(
                UiConstants.Fonts.DefaultFontName,
                UiConstants.Fonts.DefaultFontSize,
                FontStyle.Bold);
            TotalPassengersValueLabel.Location = new Point(
                UiConstants.StatisticsLayout.PassengersValueLeft,
                UiConstants.StatisticsLayout.LabelTop);
            TotalPassengersValueLabel.Name = "TotalPassengersValueLabel";
            TotalPassengersValueLabel.Size = new Size(18, 20);
            TotalPassengersValueLabel.TabIndex = 4;
            TotalPassengersValueLabel.Text = "0";

            // TotalPassengersTitleLabel
            TotalPassengersTitleLabel.AutoSize = true;
            TotalPassengersTitleLabel.Font = new System.Drawing.Font(
                UiConstants.Fonts.DefaultFontName,
                UiConstants.Fonts.DefaultFontSize);
            TotalPassengersTitleLabel.Location = new Point(
                UiConstants.StatisticsLayout.PassengersTitleLeft,
                UiConstants.StatisticsLayout.LabelTop);
            TotalPassengersTitleLabel.Name = "TotalPassengersTitleLabel";
            TotalPassengersTitleLabel.Size = new Size(140, 20);
            TotalPassengersTitleLabel.TabIndex = 5;
            TotalPassengersTitleLabel.Text = "Всего пассажиров:";

            // TotalFlightsValueLabel
            TotalFlightsValueLabel.AutoSize = true;
            TotalFlightsValueLabel.Font = new System.Drawing.Font(
                UiConstants.Fonts.DefaultFontName,
                UiConstants.Fonts.DefaultFontSize,
                FontStyle.Bold);
            TotalFlightsValueLabel.Location = new Point(
                UiConstants.StatisticsLayout.FlightsValueLeft,
                UiConstants.StatisticsLayout.LabelTop);
            TotalFlightsValueLabel.Name = "TotalFlightsValueLabel";
            TotalFlightsValueLabel.Size = new Size(18, 20);
            TotalFlightsValueLabel.TabIndex = 6;
            TotalFlightsValueLabel.Text = "0";

            // TotalFlightsTitleLabel
            TotalFlightsTitleLabel.AutoSize = true;
            TotalFlightsTitleLabel.Font = new System.Drawing.Font(
                UiConstants.Fonts.DefaultFontName,
                UiConstants.Fonts.DefaultFontSize);
            TotalFlightsTitleLabel.Location = new Point(
                UiConstants.StatisticsLayout.TitleLabelLeft,
                UiConstants.StatisticsLayout.LabelTop);
            TotalFlightsTitleLabel.Name = "TotalFlightsTitleLabel";
            TotalFlightsTitleLabel.Size = new Size(105, 20);
            TotalFlightsTitleLabel.TabIndex = 7;
            TotalFlightsTitleLabel.Text = "Всего рейсов:";

            // MainForm
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(
                UiConstants.MainFormLayout.FormWidth,
                UiConstants.MainFormLayout.FormHeight);
            Controls.Add(MainStatusStrip);
            Controls.Add(StatisticsGroupBox);
            Controls.Add(DeleteFlightButton);
            Controls.Add(EditFlightButton);
            Controls.Add(AddFlightButton);
            Controls.Add(FlightsDataGridView);
            MinimumSize = new Size(
                UiConstants.MainFormLayout.FormMinWidth,
                UiConstants.MainFormLayout.FormMinHeight);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Аэропорт - Реестр прибывающих рейсов";
            ((System.ComponentModel.ISupportInitialize)FlightsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)FlightsBindingSource).EndInit();
            MainStatusStrip.ResumeLayout(false);
            MainStatusStrip.PerformLayout();
            StatisticsGroupBox.ResumeLayout(false);
            StatisticsGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
