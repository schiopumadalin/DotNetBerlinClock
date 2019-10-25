namespace BerlinClock.Classes.Clock
{
    class ClockBuilder : IClockBuilder
    {
        public IClock GetClock()
        {
            return new OneMinuteLampsRow()
                .AddRowOnTop(new FiveMinuteLampsRow())
                .AddRowOnTop(new OneHourLampsRow())
                .AddRowOnTop(new FiveHourLampsRow())
                .AddRowOnTop(new TopLamp());
        }
    }
}
