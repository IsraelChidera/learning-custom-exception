using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomsException
{
    class CarIsDeadExceptionTwo: ApplicationException
    {
        //properties
        public string CauseofError
        {
            get;
            set;
        }
       
        public DateTime ErrorTimeStamp
        {
            get;
            set;
        }

        public CarIsDeadExceptionTwo() { }

        // Feed message to parent constructor.
        public CarIsDeadExceptionTwo(string message, string cause, DateTime time)
        : base(message)
        {
            CauseofError = cause;
            ErrorTimeStamp = time;
        }
    }
}
