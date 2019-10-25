using System;

namespace BerlinClock.Classes
{
    abstract class ClockRowBase : IClock
    {
        private ClockRowBase nextHandler;

        public string GetStringRepresentation(TimeSpan time)
        {
            var representation = GetRowRepresentation(time);
            if (this.nextHandler != null)
                representation += $"\r\n{nextHandler.GetStringRepresentation(time)}";

            return representation;
        }

        protected abstract string GetRowRepresentation(TimeSpan time);

        public ClockRowBase AddRowOnTop(ClockRowBase rowHandler)
        {
            rowHandler.nextHandler = this;
            return rowHandler;
        }
    }
}
