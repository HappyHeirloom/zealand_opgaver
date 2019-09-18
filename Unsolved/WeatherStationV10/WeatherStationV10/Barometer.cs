namespace WeatherStationV10
{
    /// <summary>
    ///  Simple barometer, measuring pressure in hPa (hectopascal)
    /// </summary>
    public class Barometer
    {
        #region Instance fields
        private double _pressureInHPa;
        #endregion

        #region Constructor
        public Barometer(int pressure)
        {
            _pressureInHPa = pressure;
            System.Console.WriteLine(WeatherDescription);
        }
        #endregion

        #region Properties
        public double Pressure
        {
            get { return _pressureInHPa; }
            set { _pressureInHPa = value; }
        }

        public string WeatherDescription
        {
            get
            {
                if (Pressure < 980)
                {
                    return "stormy";
                }
                else if (Pressure > 980 || Pressure < 1000)
                {
                    return "Rainy";
                }
                else if (Pressure > 1000 || Pressure < 1020)
                {
                    return "Changing";
                }
                else if (Pressure > 1020 || Pressure < 1040)
                {
                    return "Fair";
                }
                else if (Pressure > 1040)
                {
                    return "Very dry";
                }
                else
                {
                    return "Error: Out of scale";
                }
            }
        }
        #endregion
    }
}