using System;
using System.Linq;

namespace BerlinClock.Classes.Clock
{
    class OneHourLampsRow : ClockRowBase
    {
        protected override string GetRowRepresentation(TimeSpan time)
        {
            var hours = (time.Hours + 24 * time.Days) % 5;
            return string.Concat(Enumerable.Repeat(Constants.Red, hours).Concat(Enumerable.Repeat(Constants.Off, 4 - hours)));
        }
    }
}
