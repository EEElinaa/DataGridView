using Airport.Domain.Constants;
using Airport.Domain.Models;
using Airport.Services;
using Airport.Services.Contracts;
using Airport.Storage.Contracts;
using Airport.Storage.InMemory;
using Airport.WinForms.Forms;
using System;
using System.Windows.Forms;

namespace Airport.WinForms
{
    /// <summary>
    /// Главный класс приложения
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var flightRepository = new FlightRepository();
            IFlightService flightService = new FlightService(flightRepository);
            AddSampleData(flightRepository);

            Application.Run(new MainForm(flightService));
        }

        /// <summary>
        /// Добавляет примеры данных для демонстрации
        /// </summary>
        /// <param name="repository">Репозиторий рейсов</param>
        private static void AddSampleData(IFlightRepository repository)
        {
            var sampleFlights = new[]
            {
                new Flight(
                    flightNumber: "S1234",
                    aircraftType: AircraftType.Boeing,
                    arrivalTime: DateTime.Now.AddHours(2),
                    passengerCount: 110,
                    passengerFee: 70m,
                    crewCount: 15,
                    crewFee: 80m,
                    serviceSurchargePercent: 10m),

                new Flight(
                    flightNumber: "A5678",
                    aircraftType: AircraftType.Airbus,
                    arrivalTime: DateTime.Now.AddHours(4),
                    passengerCount: 200,
                    passengerFee: 55m,
                    crewCount: 14,
                    crewFee: 85m,
                    serviceSurchargePercent: 12m),

                new Flight(
                    flightNumber: "D91011",
                    aircraftType: AircraftType.OAK,
                    arrivalTime: DateTime.Now.AddHours(6),
                    passengerCount: 220,
                    passengerFee: 45m,
                    crewCount: 10,
                    crewFee: 75m,
                    serviceSurchargePercent: 8m)
            };

            foreach (var flight in sampleFlights)
            {
                repository.Add(flight);
            }
        }
    }
}
