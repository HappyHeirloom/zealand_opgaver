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
        public static int carsCalls;
        public static int numberPlatesCalls;
        public static int pricesCalls;
        #endregion

        #region Constructor
        public Car(string licensePlate, int price)
        {
            _licensePlate = licensePlate;
            _price = price;
            ++carsCalls;
        }
        #endregion

        #region Properties
        public string LicensePlate
        {
            get { ++numberPlatesCalls; return _licensePlate; }
            set { _licensePlate = value; }
        }

        public int Price
        {
            get { ++pricesCalls; return _price; }
            set { _price = value; }
        }
        #endregion
        public static void PrintUsageStatistics()
        {
            Console.WriteLine($"Number of cars created: {Car.carsCalls}  Number of numberplates created: {Car.numberPlatesCalls} and number of prices created: {Car.pricesCalls}");
        }
    }
}