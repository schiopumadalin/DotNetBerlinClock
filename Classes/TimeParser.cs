using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    class TimeParser : ITimeParser
    {
        public bool TryParse(string stringTime, out TimeSpan timeSpan)
        {
            timeSpan = new TimeSpan();
            var timeParts = stringTime.Split(':');

            int hours;
            int minutes;
            int seconds;

            if (!int.TryParse(timeParts[0], out hours) || !int.TryParse(timeParts[1], out minutes) || !int.TryParse(timeParts[2], out seconds))
                return false;

            if (seconds < 0 || seconds > 59 || minutes < 0 || minutes > 59 || hours < 0 || hours > 24)
                return false;

            timeSpan = new TimeSpan(hours, minutes, seconds);
            return true;
        }
    }
}
