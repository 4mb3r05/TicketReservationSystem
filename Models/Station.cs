namespace TicketReservationSystem.Models
{
    public class Station
    {

        public int Id { get; set; }
        public required string StationName { get; set; }
        public required string TrainTimes { get; set;}

        public Station()
        {
            
        }
    }
}
