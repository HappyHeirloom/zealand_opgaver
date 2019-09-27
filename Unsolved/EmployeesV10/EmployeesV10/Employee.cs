using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesV10
{
   public class Employee
    {

        #region instance field
        internal string _name;
        internal int _hoursPerWeek;

        internal string _primaryWorkArea; //it-supporter

        internal int _payGrade; //Teacher
        #endregion


        #region Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int HoursPerWeek
        {
            get { return _hoursPerWeek; }
            set { _hoursPerWeek = value; }
        } 
        #endregion

    }
}
