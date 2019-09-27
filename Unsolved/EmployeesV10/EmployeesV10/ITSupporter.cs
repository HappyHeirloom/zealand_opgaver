namespace EmployeesV10
{
    public class ITSupporter : Employee
    {
        #region Instance fields
        #endregion

        #region Constructor
        public ITSupporter(string name, int hoursPerWeek, string primaryWorkArea)
        {
            _name = name;
            _hoursPerWeek = hoursPerWeek;
            _primaryWorkArea = primaryWorkArea;
        }
        #endregion

        #region Properties


        public string PrimaryWorkArea
        {
            get { return _primaryWorkArea; }
            set { _primaryWorkArea = value; }
        }

        public string AllInformation
        {
            get
            {
                return $"IT-Supporter {Name} works {HoursPerWeek} hours/week, mostly with {PrimaryWorkArea}";
            }
        } 
        #endregion
    }
}
