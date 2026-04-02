using Airport.WinForms.Forms.Constants;
namespace Airport.WinForms.Forms
{
    partial class FlightForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox FlightNumberTextBox;
        private System.Windows.Forms.ComboBox AircraftTypeComboBox;
        private System.Windows.Forms.DateTimePicker ArrivalTimeDateTimePicker;
        private System.Windows.Forms.NumericUpDown PassengerCountNumericUpDown;
        private System.Windows.Forms.NumericUpDown PassengerFeeNumericUpDown;
        private System.Windows.Forms.NumericUpDown CrewCountNumericUpDown;
        private System.Windows.Forms.NumericUpDown CrewFeeNumericUpDown;
        private System.Windows.Forms.NumericUpDown ServiceSurchargePercentNumericUpDown;
        private System.Windows.Forms.Button SaveButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label FlightNumberLabel;
        private System.Windows.Forms.Label AircraftTypeLabel;
        private System.Windows.Forms.Label ArrivalTimeLabel;
        private System.Windows.Forms.Label PassengerCountLabel;
        private System.Windows.Forms.Label PassengerFeeLabel;
        private System.Windows.Forms.Label CrewCountLabel;
        private System.Windows.Forms.Label CrewFeeLabel;
        private System.Windows.Forms.Label ServiceSurchargePercentLabel;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.GroupBox FlightInfoGroupBox;
        private System.Windows.Forms.Label RevenuePreviewLabel;
        private System.Windows.Forms.Label RevenuePreviewValueLabel;
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
            FlightNumberTextBox = new System.Windows.Forms.TextBox();
            AircraftTypeComboBox = new System.Windows.Forms.ComboBox();
            ArrivalTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            PassengerCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            PassengerFeeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            CrewCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            CrewFeeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ServiceSurchargePercentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            SaveButton = new System.Windows.Forms.Button();
            CancelButton = new System.Windows.Forms.Button();
            FlightNumberLabel = new System.Windows.Forms.Label();
            AircraftTypeLabel = new System.Windows.Forms.Label();
            ArrivalTimeLabel = new System.Windows.Forms.Label();
            PassengerCountLabel = new System.Windows.Forms.Label();
            PassengerFeeLabel = new System.Windows.Forms.Label();
            CrewCountLabel = new System.Windows.Forms.Label();
            CrewFeeLabel = new System.Windows.Forms.Label();
            ServiceSurchargePercentLabel = new System.Windows.Forms.Label();
            ErrorProvider = new System.Windows.Forms.ErrorProvider(components);
            FlightInfoGroupBox = new System.Windows.Forms.GroupBox();
            RevenuePreviewValueLabel = new System.Windows.Forms.Label();
            RevenuePreviewLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)PassengerCountNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PassengerFeeNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CrewCountNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CrewFeeNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ServiceSurchargePercentNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
            FlightInfoGroupBox.SuspendLayout();
            SuspendLayout();

            // FlightInfoGroupBox
            FlightInfoGroupBox.Controls.Add(RevenuePreviewValueLabel);
            FlightInfoGroupBox.Controls.Add(RevenuePreviewLabel);
            FlightInfoGroupBox.Controls.Add(FlightNumberLabel);
            FlightInfoGroupBox.Controls.Add(FlightNumberTextBox);
            FlightInfoGroupBox.Controls.Add(AircraftTypeLabel);
            FlightInfoGroupBox.Controls.Add(AircraftTypeComboBox);
            FlightInfoGroupBox.Controls.Add(ArrivalTimeLabel);
            FlightInfoGroupBox.Controls.Add(ArrivalTimeDateTimePicker);
            FlightInfoGroupBox.Controls.Add(PassengerCountLabel);
            FlightInfoGroupBox.Controls.Add(PassengerCountNumericUpDown);
            FlightInfoGroupBox.Controls.Add(PassengerFeeLabel);
            FlightInfoGroupBox.Controls.Add(PassengerFeeNumericUpDown);
            FlightInfoGroupBox.Controls.Add(CrewCountLabel);
            FlightInfoGroupBox.Controls.Add(CrewCountNumericUpDown);
            FlightInfoGroupBox.Controls.Add(CrewFeeLabel);
            FlightInfoGroupBox.Controls.Add(CrewFeeNumericUpDown);
            FlightInfoGroupBox.Controls.Add(ServiceSurchargePercentLabel);
            FlightInfoGroupBox.Controls.Add(ServiceSurchargePercentNumericUpDown);
            FlightInfoGroupBox.Location = new System.Drawing.Point(
                UiConstants.FlightFormLayout.GroupBoxLeft,
                UiConstants.FlightFormLayout.GroupBoxTop);
            FlightInfoGroupBox.Name = "FlightInfoGroupBox";
            FlightInfoGroupBox.Size = new System.Drawing.Size(
                UiConstants.FlightFormLayout.GroupBoxWidth,
                UiConstants.FlightFormLayout.GroupBoxHeight);
            FlightInfoGroupBox.TabIndex = 0;
            FlightInfoGroupBox.TabStop = false;
            FlightInfoGroupBox.Text = "Информация о рейсе";

            // FlightNumberLabel
            FlightNumberLabel.AutoSize = true;
            FlightNumberLabel.Location = new System.Drawing.Point(
                UiConstants.FlightFormLayout.LabelLeft,
                UiConstants.FlightFormLayout.FirstControlTop);
            FlightNumberLabel.Name = "FlightNumberLabel";
            FlightNumberLabel.Size = new System.Drawing.Size(109, 20);
            FlightNumberLabel.Text = "Номер рейса:";

            // FlightNumberTextBox
            FlightNumberTextBox.Location = new System.Drawing.Point(
                UiConstants.FlightFormLayout.ControlLeft,
                UiConstants.FlightFormLayout.FirstControlTop);
            FlightNumberTextBox.Name = "FlightNumberTextBox";
            FlightNumberTextBox.Size = new System.Drawing.Size(
                UiConstants.FlightFormLayout.ControlWidth,
                UiConstants.FlightFormLayout.FirstControlTop);
            FlightNumberTextBox.TabIndex = 0;

            // AircraftTypeLabel
            AircraftTypeLabel.AutoSize = true;
            AircraftTypeLabel.Location = new System.Drawing.Point(
                UiConstants.FlightFormLayout.LabelLeft,
                UiConstants.FlightFormLayout.SecondControlTop);
            AircraftTypeLabel.Name = "AircraftTypeLabel";
            AircraftTypeLabel.Size = new System.Drawing.Size(109, 20);
            AircraftTypeLabel.Text = "Тип самолёта:";

            // AircraftTypeComboBox
            AircraftTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            AircraftTypeComboBox.Items.AddRange(UiConstants.ComboBoxItems.AllItems);
            AircraftTypeComboBox.Location = new System.Drawing.Point(
                UiConstants.FlightFormLayout.ControlLeft,
                UiConstants.FlightFormLayout.SecondControlTop);
            AircraftTypeComboBox.Name = "AircraftTypeComboBox";
            AircraftTypeComboBox.Size = new System.Drawing.Size(
                UiConstants.FlightFormLayout.ControlWidth,
                UiConstants.FlightFormLayout.SecondControlTop + 1);
            AircraftTypeComboBox.TabIndex = 1;

            // ArrivalTimeLabel
            ArrivalTimeLabel.AutoSize = true;
            ArrivalTimeLabel.Location = new System.Drawing.Point(
                UiConstants.FlightFormLayout.LabelLeft,
                UiConstants.FlightFormLayout.ThirdControlTop);
            ArrivalTimeLabel.Name = "ArrivalTimeLabel";
            ArrivalTimeLabel.Size = new System.Drawing.Size(129, 20);
            ArrivalTimeLabel.Text = "Время прибытия:";

            // ArrivalTimeDateTimePicker
            ArrivalTimeDateTimePicker.CustomFormat = UiConstants.Formatting.DateTimeFormat;
            ArrivalTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            ArrivalTimeDateTimePicker.Location = new System.Drawing.Point(
                UiConstants.FlightFormLayout.ControlLeft,
                UiConstants.FlightFormLayout.ThirdControlTop);
            ArrivalTimeDateTimePicker.Name = "ArrivalTimeDateTimePicker";
            ArrivalTimeDateTimePicker.Size = new System.Drawing.Size(
                UiConstants.FlightFormLayout.ControlWidth,
                UiConstants.FlightFormLayout.ThirdControlTop);
            ArrivalTimeDateTimePicker.TabIndex = 2;

            // PassengerCountLabel
            PassengerCountLabel.AutoSize = true;
            PassengerCountLabel.Location = new System.Drawing.Point(
                UiConstants.FlightFormLayout.LabelLeft,
                UiConstants.FlightFormLayout.FourthControlTop);
            PassengerCountLabel.Name = "PassengerCountLabel";
            PassengerCountLabel.Size = new System.Drawing.Size(189, 20);
            PassengerCountLabel.Text = "Количество пассажиров:";

            // PassengerCountNumericUpDown
            PassengerCountNumericUpDown.Location = new System.Drawing.Point(
                UiConstants.FlightFormLayout.ControlLeft + 70,
                UiConstants.FlightFormLayout.FourthControlTop);
            PassengerCountNumericUpDown.Maximum = UiConstants.NumericLimits.MaxPassengerCount;
            PassengerCountNumericUpDown.Minimum = UiConstants.NumericLimits.MinPassengerCount;
            PassengerCountNumericUpDown.Name = "PassengerCountNumericUpDown";
            PassengerCountNumericUpDown.Size = new System.Drawing.Size(
                UiConstants.FlightFormLayout.ControlWidthMedium,
                UiConstants.FlightFormLayout.FourthControlTop);
            PassengerCountNumericUpDown.TabIndex = 3;

            // PassengerFeeLabel
            PassengerFeeLabel.AutoSize = true;
            PassengerFeeLabel.Location = new System.Drawing.Point(
                UiConstants.FlightFormLayout.LabelLeft,
                UiConstants.FlightFormLayout.FifthControlTop);
            PassengerFeeLabel.Name = "PassengerFeeLabel";
            PassengerFeeLabel.Size = new System.Drawing.Size(159, 20);
            PassengerFeeLabel.Text = "Сбор на пассажира:";

            // PassengerFeeNumericUpDown
            PassengerFeeNumericUpDown.DecimalPlaces = UiConstants.NumericLimits.DecimalPlaces;
            PassengerFeeNumericUpDown.Location = new System.Drawing.Point(
                UiConstants.FlightFormLayout.ControlLeft + 40,
                UiConstants.FlightFormLayout.FifthControlTop);
            PassengerFeeNumericUpDown.Maximum = UiConstants.NumericLimits.MaxFee;
            PassengerFeeNumericUpDown.Minimum = UiConstants.NumericLimits.MinFee;
            PassengerFeeNumericUpDown.Name = "PassengerFeeNumericUpDown";
            PassengerFeeNumericUpDown.Size = new System.Drawing.Size(
                UiConstants.FlightFormLayout.ControlWidth,
                UiConstants.FlightFormLayout.FifthControlTop);
            PassengerFeeNumericUpDown.TabIndex = 4;

            // CrewCountLabel
            CrewCountLabel.AutoSize = true;
            CrewCountLabel.Location = new System.Drawing.Point(
                UiConstants.FlightFormLayout.LabelLeft,
                UiConstants.FlightFormLayout.SixthControlTop);
            CrewCountLabel.Name = "CrewCountLabel";
            CrewCountLabel.Size = new System.Drawing.Size(169, 20);
            CrewCountLabel.Text = "Количество экипажа:";

            // CrewCountNumericUpDown
            CrewCountNumericUpDown.Location = new System.Drawing.Point(
                UiConstants.FlightFormLayout.ControlLeft + 50,
                UiConstants.FlightFormLayout.SixthControlTop);
            CrewCountNumericUpDown.Maximum = UiConstants.NumericLimits.MaxCrewCount;
            CrewCountNumericUpDown.Minimum = UiConstants.NumericLimits.MinCrewCount;
            CrewCountNumericUpDown.Name = "CrewCountNumericUpDown";
            CrewCountNumericUpDown.Size = new System.Drawing.Size(
                UiConstants.FlightFormLayout.ControlWidthMedium,
                UiConstants.FlightFormLayout.SixthControlTop);
            CrewCountNumericUpDown.TabIndex = 5;

            // CrewFeeLabel
            CrewFeeLabel.AutoSize = true;
            CrewFeeLabel.Location = new System.Drawing.Point(
                UiConstants.FlightFormLayout.LabelLeft,
                UiConstants.FlightFormLayout.SeventhControlTop);
            CrewFeeLabel.Name = "CrewFeeLabel";
            CrewFeeLabel.Size = new System.Drawing.Size(139, 20);
            CrewFeeLabel.Text = "Сбор на экипаж:";

            // CrewFeeNumericUpDown
            CrewFeeNumericUpDown.DecimalPlaces = UiConstants.NumericLimits.DecimalPlaces;
            CrewFeeNumericUpDown.Location = new System.Drawing.Point(
                UiConstants.FlightFormLayout.ControlLeft + 20,
                UiConstants.FlightFormLayout.SeventhControlTop);
            CrewFeeNumericUpDown.Maximum = UiConstants.NumericLimits.MaxFee;
            CrewFeeNumericUpDown.Minimum = UiConstants.NumericLimits.MinFee;
            CrewFeeNumericUpDown.Name = "CrewFeeNumericUpDown";
            CrewFeeNumericUpDown.Size = new System.Drawing.Size(
                UiConstants.FlightFormLayout.ControlWidth,
                UiConstants.FlightFormLayout.SeventhControlTop);
            CrewFeeNumericUpDown.TabIndex = 6;

            // ServiceSurchargePercentLabel
            ServiceSurchargePercentLabel.AutoSize = true;
            ServiceSurchargePercentLabel.Location = new System.Drawing.Point(
                UiConstants.FlightFormLayout.LabelLeft,
                UiConstants.FlightFormLayout.EighthControlTop);
            ServiceSurchargePercentLabel.Name = "ServiceSurchargePercentLabel";
            ServiceSurchargePercentLabel.Size = new System.Drawing.Size(219, 20);
            ServiceSurchargePercentLabel.Text = "Процент надбавки за обслуживание:";

            // ServiceSurchargePercentNumericUpDown
            ServiceSurchargePercentNumericUpDown.DecimalPlaces = UiConstants.NumericLimits.DecimalPlaces;
            ServiceSurchargePercentNumericUpDown.Location = new System.Drawing.Point(
                UiConstants.FlightFormLayout.ControlLeft + 100,
                UiConstants.FlightFormLayout.EighthControlTop);
            ServiceSurchargePercentNumericUpDown.Maximum = UiConstants.NumericLimits.MaxSurchargePercent;
            ServiceSurchargePercentNumericUpDown.Minimum = UiConstants.NumericLimits.MinSurchargePercent;
            ServiceSurchargePercentNumericUpDown.Name = "ServiceSurchargePercentNumericUpDown";
            ServiceSurchargePercentNumericUpDown.Size = new System.Drawing.Size(
                UiConstants.FlightFormLayout.ControlWidthSmall,
                UiConstants.FlightFormLayout.EighthControlTop);
            ServiceSurchargePercentNumericUpDown.TabIndex = 7;

            // RevenuePreviewLabel
            RevenuePreviewLabel.AutoSize = true;
            RevenuePreviewLabel.Font = new System.Drawing.Font(
                UiConstants.Fonts.DefaultFontName,
                UiConstants.Fonts.BoldFontSize,
                System.Drawing.FontStyle.Bold);
            RevenuePreviewLabel.Location = new System.Drawing.Point(
                UiConstants.FlightFormLayout.LabelLeft,
                UiConstants.FlightFormLayout.RevenueLabelTop);
            RevenuePreviewLabel.Name = "RevenuePreviewLabel";
            RevenuePreviewLabel.Size = new System.Drawing.Size(80, 20);
            RevenuePreviewLabel.Text = "Выручка:";

            // RevenuePreviewValueLabel
            RevenuePreviewValueLabel.AutoSize = true;
            RevenuePreviewValueLabel.Font = new System.Drawing.Font(
                UiConstants.Fonts.DefaultFontName,
                UiConstants.Fonts.BoldFontSize,
                System.Drawing.FontStyle.Bold);
            RevenuePreviewValueLabel.ForeColor = UiConstants.Colors.RevenuePreviewForeColor;
            RevenuePreviewValueLabel.Location = new System.Drawing.Point(
                UiConstants.FlightFormLayout.LabelLeft + 86,
                UiConstants.FlightFormLayout.RevenueLabelTop);
            RevenuePreviewValueLabel.Name = "RevenuePreviewValueLabel";
            RevenuePreviewValueLabel.Size = new System.Drawing.Size(33, 20);
            RevenuePreviewValueLabel.Text = $"0 {UiConstants.Formatting.CurrencySymbol}";

            // SaveButton
            SaveButton.Location = new System.Drawing.Point(
                UiConstants.FlightFormLayout.SaveButtonLeft,
                UiConstants.FlightFormLayout.ButtonTop);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new System.Drawing.Size(
                UiConstants.FlightFormLayout.ButtonWidth,
                UiConstants.FlightFormLayout.ButtonHeight);
            SaveButton.TabIndex = 1;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;

            // CancelButton
            CancelButton.Location = new System.Drawing.Point(
                UiConstants.FlightFormLayout.CancelButtonLeft,
                UiConstants.FlightFormLayout.ButtonTop);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new System.Drawing.Size(
                UiConstants.FlightFormLayout.ButtonWidth,
                UiConstants.FlightFormLayout.ButtonHeight);
            CancelButton.TabIndex = 2;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;

            // FlightForm
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(
                UiConstants.FlightFormLayout.FormWidth,
                UiConstants.FlightFormLayout.FormHeight);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(FlightInfoGroupBox);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FlightForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Рейс";
            ((System.ComponentModel.ISupportInitialize)PassengerCountNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)PassengerFeeNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)CrewCountNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)CrewFeeNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ServiceSurchargePercentNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            FlightInfoGroupBox.ResumeLayout(false);
            FlightInfoGroupBox.PerformLayout();
            ResumeLayout(false);
        }
    }
}
