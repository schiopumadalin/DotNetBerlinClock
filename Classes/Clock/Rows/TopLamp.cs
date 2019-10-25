using System;

namespace BerlinClock.Classes.Clock
{
    class TopLamp : ClockRowBase
    {
        protected override string GetRowRepresentation(TimeSpan time)
        {
            return time.Minutes % 2 == 0 ? Constants.Yellow : Constants.Off;
        }
    }
}
