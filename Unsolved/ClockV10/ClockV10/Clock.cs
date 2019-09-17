using System;


namespace ClockV10
{
    public class Clock
    {
        #region Instance Fields
        private int _timeSinceStart;
        #endregion

        #region Contructers
        public Clock(int hours, int minutes, int seconds)
        {
            setTime(hours, minutes);
        }
        #endregion


        #region Properties
        public int Hours
        {
            get { return _timeSinceStart / 60; }
        }

        public int Minutes
        {
            get { return _timeSinceStart % 60; }
        }

        public String displayClock
        {
            get { return $"{Hours}:{Minutes}"; }
        }

        #endregion

        #region Methods

        public void setTime(int hour, int minute)
        {
            _timeSinceStart = (hour * 60) + minute;
        }

        public void plusMinutes()
        {
            _timeSinceStart = _timeSinceStart + 1;
        }

        #endregion
    }

}