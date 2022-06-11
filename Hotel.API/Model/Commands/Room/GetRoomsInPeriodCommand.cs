using System;

namespace Hotel.API.Model.Commands.Room
{
    public class GetRoomsInPeriodCommand
    {
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
    }
}