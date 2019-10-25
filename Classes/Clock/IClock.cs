using System;

namespace BerlinClock.Classes
{
    interface IClock
    {
        string GetStringRepresentation(TimeSpan time);
    }
}