using System;

namespace BerlinClock.Classes
{
    interface ITimeParser
    {
        bool TryParse(string stringTime, out TimeSpan timeSpan);
    }
}