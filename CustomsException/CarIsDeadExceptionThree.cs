using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomsException
{
    class CarIsDeadExceptionThree: ApplicationException
    {
        //fields
        private string _customMessage = String.Empty;
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

        public CarIsDeadExceptionThree() { }
        public CarIsDeadExceptionThree(string cause, DateTime time) : this(cause, time, string.Empty)
        {
        }
        public CarIsDeadExceptionThree(string cause, DateTime time, string message) :
       this(cause, time, message, null)
        {
        }
        public CarIsDeadExceptionThree(string cause, DateTime time, string message, System.
       Exception inner)
        : base(message, inner)
        {
            CauseofError = cause;
            ErrorTimeStamp = time;
        }

    }

}
