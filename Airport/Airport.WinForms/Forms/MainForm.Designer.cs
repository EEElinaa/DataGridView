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
            FlightsDataGridView.BackgroundColor = System.Drawing.Color.White;
            FlightsDataGridView.BorderStyle = BorderStyle.Fixed3D;
            FlightsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FlightsDataGridView.DataSource = FlightsBindingSource;
            FlightsDataGridView.Location = new Point(12, 12);
            FlightsDataGridView.Name = "FlightsDataGridView";
            FlightsDataGridView.ReadOnly = true;
            FlightsDataGridView.RowHeadersWidth = 51;
            FlightsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FlightsDataGridView.Size = new Size(900, 300);
            FlightsDataGridView.TabIndex = 0;

            // AddFlightButton - наверху
            AddFlightButton.Location = new Point(12, 325);
            AddFlightButton.Name = "AddFlightButton";
            AddFlightButton.Size = new Size(120, 35);
            AddFlightButton.TabIndex = 1;
            AddFlightButton.Text = "Добавить рейс";
            AddFlightButton.UseVisualStyleBackColor = true;

            // EditFlightButton - наверху
            EditFlightButton.Location = new Point(142, 325);
            EditFlightButton.Name = "EditFlightButton";
            EditFlightButton.Size = new Size(120, 35);
            EditFlightButton.TabIndex = 2;
            EditFlightButton.Text = "Редактировать";
            EditFlightButton.UseVisualStyleBackColor = true;

            // DeleteFlightButton - наверху
            DeleteFlightButton.Location = new Point(272, 325);
            DeleteFlightButton.Name = "DeleteFlightButton";
            DeleteFlightButton.Size = new Size(120, 35);
            DeleteFlightButton.TabIndex = 3;
            DeleteFlightButton.Text = "Удалить рейс";
            DeleteFlightButton.UseVisualStyleBackColor = true;

            // MainStatusStrip
            MainStatusStrip.ImageScalingSize = new Size(20, 20);
            MainStatusStrip.Items.AddRange(new ToolStripItem[] {
                TotalFlightsLabel,
                TotalPassengersLabel,
                TotalCrewLabel,
                TotalRevenueLabel});
            MainStatusStrip.Location = new Point(0, 470);
            MainStatusStrip.Name = "MainStatusStrip";
            MainStatusStrip.Size = new Size(924, 30);
            MainStatusStrip.TabIndex = 6;

            // TotalFlightsLabel
            TotalFlightsLabel.Name = "TotalFlightsLabel";
            TotalFlightsLabel.Size = new Size(117, 25);
            TotalFlightsLabel.Text = "Всего рейсов: 0";

            // TotalPassengersLabel
            TotalPassengersLabel.Name = "TotalPassengersLabel";
            TotalPassengersLabel.Size = new Size(152, 25);
            TotalPassengersLabel.Text = "Всего пассажиров: 0";

            // TotalCrewLabel
            TotalCrewLabel.Name = "TotalCrewLabel";
            TotalCrewLabel.Size = new Size(126, 25);
            TotalCrewLabel.Text = "Всего экипажа: 0";

            // TotalRevenueLabel
            TotalRevenueLabel.Name = "TotalRevenueLabel";
            TotalRevenueLabel.Size = new Size(134, 25);
            TotalRevenueLabel.Text = "Общая выручка: 0 ₽";

            // StatisticsGroupBox - под кнопками
            StatisticsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StatisticsGroupBox.Controls.Add(TotalRevenueValueLabel);
            StatisticsGroupBox.Controls.Add(TotalRevenueTitleLabel);
            StatisticsGroupBox.Controls.Add(TotalCrewValueLabel);
            StatisticsGroupBox.Controls.Add(TotalCrewTitleLabel);
            StatisticsGroupBox.Controls.Add(TotalPassengersValueLabel);
            StatisticsGroupBox.Controls.Add(TotalPassengersTitleLabel);
            StatisticsGroupBox.Controls.Add(TotalFlightsValueLabel);
            StatisticsGroupBox.Controls.Add(TotalFlightsTitleLabel);
            StatisticsGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            StatisticsGroupBox.Location = new Point(12, 370);
            StatisticsGroupBox.Name = "StatisticsGroupBox";
            StatisticsGroupBox.Size = new Size(900, 85);
            StatisticsGroupBox.TabIndex = 5;
            StatisticsGroupBox.TabStop = false;
            StatisticsGroupBox.Text = "Статистика аэропорта";

            // TotalRevenueValueLabel
            TotalRevenueValueLabel.AutoSize = true;
            TotalRevenueValueLabel.Font = new System.Drawing.Font("Segoe UI", 10F, FontStyle.Bold);
            TotalRevenueValueLabel.ForeColor = System.Drawing.Color.FromArgb(0, 128, 0);
            TotalRevenueValueLabel.Location = new Point(730, 45);
            TotalRevenueValueLabel.Name = "TotalRevenueValueLabel";
            TotalRevenueValueLabel.Size = new Size(38, 23);
            TotalRevenueValueLabel.TabIndex = 0;
            TotalRevenueValueLabel.Text = "0 ₽";

            // TotalRevenueTitleLabel
            TotalRevenueTitleLabel.AutoSize = true;
            TotalRevenueTitleLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            TotalRevenueTitleLabel.Location = new Point(608, 45);
            TotalRevenueTitleLabel.Name = "TotalRevenueTitleLabel";
            TotalRevenueTitleLabel.Size = new Size(122, 23);
            TotalRevenueTitleLabel.Text = "Общая выручка:";

            // TotalCrewValueLabel
            TotalCrewValueLabel.AutoSize = true;
            TotalCrewValueLabel.Font = new System.Drawing.Font("Segoe UI", 10F, FontStyle.Bold);
            TotalCrewValueLabel.Location = new Point(525, 45);
            TotalCrewValueLabel.Name = "TotalCrewValueLabel";
            TotalCrewValueLabel.Size = new Size(18, 23);
            TotalCrewValueLabel.TabIndex = 2;
            TotalCrewValueLabel.Text = "0";

            // TotalCrewTitleLabel
            TotalCrewTitleLabel.AutoSize = true;
            TotalCrewTitleLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            TotalCrewTitleLabel.Location = new Point(411, 45);
            TotalCrewTitleLabel.Name = "TotalCrewTitleLabel";
            TotalCrewTitleLabel.Size = new Size(114, 23);
            TotalCrewTitleLabel.Text = "Всего экипажа:";

            // TotalPassengersValueLabel
            TotalPassengersValueLabel.AutoSize = true;
            TotalPassengersValueLabel.Font = new System.Drawing.Font("Segoe UI", 10F, FontStyle.Bold);
            TotalPassengersValueLabel.Location = new Point(320, 45);
            TotalPassengersValueLabel.Name = "TotalPassengersValueLabel";
            TotalPassengersValueLabel.Size = new Size(18, 23);
            TotalPassengersValueLabel.TabIndex = 4;
            TotalPassengersValueLabel.Text = "0";

            // TotalPassengersTitleLabel
            TotalPassengersTitleLabel.AutoSize = true;
            TotalPassengersTitleLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            TotalPassengersTitleLabel.Location = new Point(180, 45);
            TotalPassengersTitleLabel.Name = "TotalPassengersTitleLabel";
            TotalPassengersTitleLabel.Size = new Size(140, 23);
            TotalPassengersTitleLabel.Text = "Всего пассажиров:";

            // TotalFlightsValueLabel
            TotalFlightsValueLabel.AutoSize = true;
            TotalFlightsValueLabel.Font = new System.Drawing.Font("Segoe UI", 10F, FontStyle.Bold);
            TotalFlightsValueLabel.Location = new Point(125, 45);
            TotalFlightsValueLabel.Name = "TotalFlightsValueLabel";
            TotalFlightsValueLabel.Size = new Size(18, 23);
            TotalFlightsValueLabel.TabIndex = 6;
            TotalFlightsValueLabel.Text = "0";

            // TotalFlightsTitleLabel
            TotalFlightsTitleLabel.AutoSize = true;
            TotalFlightsTitleLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            TotalFlightsTitleLabel.Location = new Point(20, 45);
            TotalFlightsTitleLabel.Name = "TotalFlightsTitleLabel";
            TotalFlightsTitleLabel.Size = new Size(105, 23);
            TotalFlightsTitleLabel.Text = "Всего рейсов:";

            // MainForm
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 500);
            Controls.Add(MainStatusStrip);
            Controls.Add(StatisticsGroupBox);
            Controls.Add(DeleteFlightButton);
            Controls.Add(EditFlightButton);
            Controls.Add(AddFlightButton);
            Controls.Add(FlightsDataGridView);
            MinimumSize = new Size(800, 450);
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
