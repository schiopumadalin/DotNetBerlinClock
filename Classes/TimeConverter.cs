using BerlinClock.Classes;
using BerlinClock.Classes.Clock;
using System;

namespace BerlinClock
{
    public class TimeConverter : ITimeConverter
    {
        private readonly IClockBuilder clockBuilder;
        private readonly ITimeParser timeParser;

        public TimeConverter()
        {
            this.clockBuilder = new ClockBuilder();
            this.timeParser = new TimeParser();
        }

        public string ConvertTime(string aTime)
        {
            TimeSpan time;
            if (!timeParser.TryParse(aTime, out time))
                throw new ArgumentException("Wrong format for aTime");
            
            var retval =  clockBuilder.GetClock().GetStringRepresentation(time);
            return retval;

        }
    }
}
