using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoFrame
{
    public static class ConvertUnixDate
    {
      public static string ConvertOutputDateTime(double unixDateTime)
        {
            // First make a System.DateTime equivalent to the UNIX Epoch.
            DateTime _result = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);

            // Add the number of seconds in UNIX timestamp to be converted.
            _result = _result.AddSeconds(unixDateTime);

            return _result.ToLocalTime().ToShortDateString() + _result.ToLocalTime().ToShortTimeString();
        }

        public static string ConvertOutputDate(double unixDateTime)
        {
            // First make a System.DateTime equivalent to the UNIX Epoch.
            DateTime _result = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);

            // Add the number of seconds in UNIX timestamp to be converted.
            _result = _result.AddSeconds(unixDateTime);

            return _result.ToLocalTime().ToShortDateString();
        }
    }
}
