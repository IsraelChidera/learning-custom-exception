using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomsException
{
    //custom exceptions
    class CarIsDeadException: ApplicationException
    {
        //fields
        private string _customMessage=String.Empty;
        private string _causeofError;

        //properties
        public DateTime ErrorTimeStamp
        {
            get;
            set;
        }

        public CarIsDeadException(string message, string error, DateTime time)
        {
            _customMessage = message;
            _causeofError = error;
            ErrorTimeStamp = time;
        }

        public override string Message => $"Car Error Message: {_customMessage}";


    }
}
