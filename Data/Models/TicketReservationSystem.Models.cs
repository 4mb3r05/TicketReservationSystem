using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TicketReservationSystem.Models; 
using Microsoft.AspNetCore.Identity;

namespace TicketReservationSystem.Models
{
    public class Station
    {
        public int StationId { get; set; }
        public string Name { get; set; } = "";
    }

    public class City
    {
        public int CityId { get; set; }
        public string Name { get; set; } = "";
    }

    public class Trace
    {
        public int TrainId { get; set; }
        public string TrainNumber { get; set; } = "";
        public int FromStationId { get; set; }
        public int ToStationId { get; set; }

        public Station FromStation { get; set; } = new Station();
        public Station ToStation { get; set; } = new Station();
    }
}

namespace TicketReservationSystem.Data
{




}