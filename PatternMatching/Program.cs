using System;

namespace PatternMatching
{
    // ge
    internal class Program
    {
        private static void Main(string[] args)
        {
            DeclarationTypePattern();
            // g

            TollCalculator.CalculateToll(new Truck());

            GetGroupTicketPrice(3);
        }

        #region Declaration and type pattern
        private static void DeclarationTypePattern()
        {
            object message = "Hello";

            if (message is string mes)
            {
                Console.WriteLine(mes.ToLower());
            }
        }

        private abstract class Vehicle {}
        private class Car : Vehicle {}
        private class Truck : Vehicle {}

        private static class TollCalculator
        {
            public static decimal CalculateToll(Vehicle vehicle) => vehicle switch
            {
                Car => 2.00m,
                Truck => 7.50m,
                null => throw new ArgumentNullException(nameof(vehicle)),
                _ => throw new ArgumentException("Unknown type of a vehicle", nameof(vehicle)),
            };
        }
        #endregion

        #region Constant pattern
        private static decimal GetGroupTicketPrice(int visitorCount) => visitorCount switch
        {
            1 => 12.0m,
            2 => 20.0m,
            3 => 27.0m,
            4 => 32.0m,
            0 => 0.0m,
            _ => throw new ArgumentException($"Not supported number of visitors: {visitorCount}", nameof(visitorCount)),
        };
        #endregion
    }
}