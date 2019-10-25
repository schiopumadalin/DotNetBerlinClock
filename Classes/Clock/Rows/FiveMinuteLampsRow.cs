using System;
using System.Linq;

namespace BerlinClock.Classes.Clock
{
    class FiveMinuteLampsRow : ClockRowBase
    {
        protected override string GetRowRepresentation(TimeSpan time)
        {
            var minutes = time.Minutes / 5 % 12;
            var representation = Enumerable.Repeat(Constants.Yellow, minutes)
                .Concat(Enumerable.Repeat(Constants.Off, 11 - minutes))
                .Select(GetRightColor );

            return string.Concat(representation);
        }

        private string GetRightColor(string color, int index)
        {
            if (color == Constants.Off || index % 3 != 2)
                return color;

            return Constants.Red;
        }
    }
}
