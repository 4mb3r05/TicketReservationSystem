using System;

namespace TicketReservationSystem.Models
{
    public class TrainSchedule
    {
        public int Id { get; set; }
        public string TrainNumber { get; set; } = "";
        public string DepartureStation { get; set; } = "";
        public string ArrivalStation { get; set; } = "";
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public decimal Price { get; set; }

        public Station? FromStation { get; set; } 
        public Station? ToStation { get; set; } 
    }
}
