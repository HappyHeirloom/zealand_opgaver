namespace EmployeesV10
{
    public class Teacher : Employee
    {
        #region Instance fields
        #endregion

        #region Constructor
        public Teacher(string name, int hoursPerWeek, int payGrade)
        {
            _name = name;
            _hoursPerWeek = hoursPerWeek;
            _payGrade = payGrade;
        }
        #endregion

        #region Properties

        public int PayGrade
        {
            get { return _payGrade; }
            set { _payGrade = value; }
        }

        public string AllInformation
        {
            get
            {
                return $"Teacher {Name} works {HoursPerWeek} hours/week, at paygrade {PayGrade}";
            }
        }
        #endregion
    }
}
