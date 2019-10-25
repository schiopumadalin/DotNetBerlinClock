using System;
using System.Linq;

namespace BerlinClock.Classes.Clock
{
    class FiveHourLampsRow : ClockRowBase
    {
        protected override string GetRowRepresentation(TimeSpan time)
        {
            var onLamps = (time.Hours + 24 * time.Days) / 5 % 5;
            return string.Concat(Enumerable.Repeat(Constants.Red, onLamps).Concat(Enumerable.Repeat(Constants.Off, 4 - onLamps)));
        }
    }
}
