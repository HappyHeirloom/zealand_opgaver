using System;

namespace StaticExamples
{
    /// <summary>
    /// A very simple representation of a car
    /// </summary>
    public class Car
    {
        #region Instance fields
        private static string _licensePlate;
        private static int _price;
        private static int _cars = 0;
        private static int _numberplates = 0;
        private static int _prices = 0;
        #endregion

        #region Constructor
        public Car(string licensePlate, int price)
        {
            _licensePlate = licensePlate;
            _price = price;
            _cars++;
            _numberplates++;
            _prices++;
        }
        #endregion

        #region Properties
        public static string LicensePlate
        {
            get { return _licensePlate; }
            set { _licensePlate = value; }
        }

        public static int Price
        {
            get { return _price; }
            set { _price = value; }
        }
        #endregion
        public static void PrintUsageStatistics()
        {
            Console.WriteLine($"Number of cars created: {_cars}  Number of numberplates created: {_numberplates} and number of prices created: {_prices}");
        }
    }
}