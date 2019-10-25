using System;
using System.Linq;

namespace BerlinClock.Classes.Clock
{
    class OneMinuteLampsRow : ClockRowBase
    {
        protected override string GetRowRepresentation(TimeSpan time)
        {
            var minutes = time.Minutes % 5;
            return string.Concat(Enumerable.Repeat(Constants.Yellow, minutes).Concat(Enumerable.Repeat(Constants.Off, 4 - minutes)));
        }
    }
}
