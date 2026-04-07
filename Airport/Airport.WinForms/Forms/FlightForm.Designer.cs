using Airport.WinForms.Forms.Constants;

using ComboBoxItemsConstants = Airport.WinForms.Forms.Constants.ComboBoxItemsConstants;
using FormattingConstants = Airport.WinForms.Forms.Constants.FormattingConstants;

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
            FlightInfoGroupBox.Location = new System.Drawing.Point(12, 12);
            FlightInfoGroupBox.Name = "FlightInfoGroupBox";
            FlightInfoGroupBox.Size = new System.Drawing.Size(520, 380);
            FlightInfoGroupBox.TabIndex = 0;
            FlightInfoGroupBox.TabStop = false;
            FlightInfoGroupBox.Text = "Информация о рейсе";

            // FlightNumberLabel
            FlightNumberLabel.AutoSize = true;
            FlightNumberLabel.Location = new System.Drawing.Point(20, 35);
            FlightNumberLabel.Name = "FlightNumberLabel";
            FlightNumberLabel.Size = new System.Drawing.Size(109, 20);
            FlightNumberLabel.Text = "Номер рейса:";

            // FlightNumberTextBox
            FlightNumberTextBox.Location = new System.Drawing.Point(180, 32);
            FlightNumberTextBox.Name = "FlightNumberTextBox";
            FlightNumberTextBox.Size = new System.Drawing.Size(300, 27);
            FlightNumberTextBox.TabIndex = 0;

            // AircraftTypeLabel
            AircraftTypeLabel.AutoSize = true;
            AircraftTypeLabel.Location = new System.Drawing.Point(20, 75);
            AircraftTypeLabel.Name = "AircraftTypeLabel";
            AircraftTypeLabel.Size = new System.Drawing.Size(109, 20);
            AircraftTypeLabel.Text = "Тип самолёта:";

            // AircraftTypeComboBox
            AircraftTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            AircraftTypeComboBox.Items.AddRange(ComboBoxItemsConstants.AllItems);
            AircraftTypeComboBox.Location = new System.Drawing.Point(180, 72);
            AircraftTypeComboBox.Name = "AircraftTypeComboBox";
            AircraftTypeComboBox.Size = new System.Drawing.Size(300, 28);
            AircraftTypeComboBox.TabIndex = 1;

            // ArrivalTimeLabel
            ArrivalTimeLabel.AutoSize = true;
            ArrivalTimeLabel.Location = new System.Drawing.Point(20, 115);
            ArrivalTimeLabel.Name = "ArrivalTimeLabel";
            ArrivalTimeLabel.Size = new System.Drawing.Size(129, 20);
            ArrivalTimeLabel.Text = "Время прибытия:";

            // ArrivalTimeDateTimePicker
            ArrivalTimeDateTimePicker.CustomFormat = FormattingConstants.DateTimeFormat;
            ArrivalTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            ArrivalTimeDateTimePicker.Location = new System.Drawing.Point(180, 112);
            ArrivalTimeDateTimePicker.Name = "ArrivalTimeDateTimePicker";
            ArrivalTimeDateTimePicker.Size = new System.Drawing.Size(300, 27);
            ArrivalTimeDateTimePicker.TabIndex = 2;

            // PassengerCountLabel
            PassengerCountLabel.AutoSize = true;
            PassengerCountLabel.Location = new System.Drawing.Point(20, 155);
            PassengerCountLabel.Name = "PassengerCountLabel";
            PassengerCountLabel.Size = new System.Drawing.Size(189, 20);
            PassengerCountLabel.Text = "Количество пассажиров:";

            // PassengerCountNumericUpDown
            PassengerCountNumericUpDown.Location = new System.Drawing.Point(250, 153);
            PassengerCountNumericUpDown.Maximum = 500;
            PassengerCountNumericUpDown.Minimum = 0;
            PassengerCountNumericUpDown.Name = "PassengerCountNumericUpDown";
            PassengerCountNumericUpDown.Size = new System.Drawing.Size(100, 27);
            PassengerCountNumericUpDown.TabIndex = 3;

            // PassengerFeeLabel
            PassengerFeeLabel.AutoSize = true;
            PassengerFeeLabel.Location = new System.Drawing.Point(20, 195);
            PassengerFeeLabel.Name = "PassengerFeeLabel";
            PassengerFeeLabel.Size = new System.Drawing.Size(159, 20);
            PassengerFeeLabel.Text = "Сбор на пассажира:";

            // PassengerFeeNumericUpDown
            PassengerFeeNumericUpDown.DecimalPlaces = 2;
            PassengerFeeNumericUpDown.Location = new System.Drawing.Point(220, 193);
            PassengerFeeNumericUpDown.Maximum = 10000m;
            PassengerFeeNumericUpDown.Minimum = 0m;
            PassengerFeeNumericUpDown.Name = "PassengerFeeNumericUpDown";
            PassengerFeeNumericUpDown.Size = new System.Drawing.Size(260, 27);
            PassengerFeeNumericUpDown.TabIndex = 4;

            // CrewCountLabel
            CrewCountLabel.AutoSize = true;
            CrewCountLabel.Location = new System.Drawing.Point(20, 235);
            CrewCountLabel.Name = "CrewCountLabel";
            CrewCountLabel.Size = new System.Drawing.Size(169, 20);
            CrewCountLabel.Text = "Количество экипажа:";

            // CrewCountNumericUpDown
            CrewCountNumericUpDown.Location = new System.Drawing.Point(230, 233);
            CrewCountNumericUpDown.Maximum = 50;
            CrewCountNumericUpDown.Minimum = 0;
            CrewCountNumericUpDown.Name = "CrewCountNumericUpDown";
            CrewCountNumericUpDown.Size = new System.Drawing.Size(100, 27);
            CrewCountNumericUpDown.TabIndex = 5;

            // CrewFeeLabel
            CrewFeeLabel.AutoSize = true;
            CrewFeeLabel.Location = new System.Drawing.Point(20, 275);
            CrewFeeLabel.Name = "CrewFeeLabel";
            CrewFeeLabel.Size = new System.Drawing.Size(139, 20);
            CrewFeeLabel.Text = "Сбор на экипаж:";

            // CrewFeeNumericUpDown
            CrewFeeNumericUpDown.DecimalPlaces = 2;
            CrewFeeNumericUpDown.Location = new System.Drawing.Point(200, 273);
            CrewFeeNumericUpDown.Maximum = 10000m;
            CrewFeeNumericUpDown.Minimum = 0m;
            CrewFeeNumericUpDown.Name = "CrewFeeNumericUpDown";
            CrewFeeNumericUpDown.Size = new System.Drawing.Size(280, 27);
            CrewFeeNumericUpDown.TabIndex = 6;

            // ServiceSurchargePercentLabel
            ServiceSurchargePercentLabel.AutoSize = true;
            ServiceSurchargePercentLabel.Location = new System.Drawing.Point(20, 315);
            ServiceSurchargePercentLabel.Name = "ServiceSurchargePercentLabel";
            ServiceSurchargePercentLabel.Size = new System.Drawing.Size(219, 20);
            ServiceSurchargePercentLabel.Text = "Процент надбавки за обслуживание:";

            // ServiceSurchargePercentNumericUpDown
            ServiceSurchargePercentNumericUpDown.DecimalPlaces = 2;
            ServiceSurchargePercentNumericUpDown.Location = new System.Drawing.Point(280, 313);
            ServiceSurchargePercentNumericUpDown.Maximum = 100m;
            ServiceSurchargePercentNumericUpDown.Minimum = 0m;
            ServiceSurchargePercentNumericUpDown.Name = "ServiceSurchargePercentNumericUpDown";
            ServiceSurchargePercentNumericUpDown.Size = new System.Drawing.Size(80, 27);
            ServiceSurchargePercentNumericUpDown.TabIndex = 7;

            // RevenuePreviewLabel
            RevenuePreviewLabel.AutoSize = true;
            RevenuePreviewLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            RevenuePreviewLabel.Location = new System.Drawing.Point(20, 350);
            RevenuePreviewLabel.Name = "RevenuePreviewLabel";
            RevenuePreviewLabel.Size = new System.Drawing.Size(85, 23);
            RevenuePreviewLabel.Text = "Выручка:";

            // RevenuePreviewValueLabel
            RevenuePreviewValueLabel.AutoSize = true;
            RevenuePreviewValueLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            RevenuePreviewValueLabel.ForeColor = System.Drawing.Color.FromArgb(0, 100, 0);
            RevenuePreviewValueLabel.Location = new System.Drawing.Point(105, 350);
            RevenuePreviewValueLabel.Name = "RevenuePreviewValueLabel";
            RevenuePreviewValueLabel.Size = new System.Drawing.Size(38, 23);
            RevenuePreviewValueLabel.Text = "0 ₽";

            // SaveButton
            SaveButton.Location = new System.Drawing.Point(130, 405);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new System.Drawing.Size(120, 40);
            SaveButton.TabIndex = 1;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;

            // CancelButton
            CancelButton.Location = new System.Drawing.Point(280, 405);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new System.Drawing.Size(120, 40);
            CancelButton.TabIndex = 2;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;

            // FlightForm
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(544, 460);
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
