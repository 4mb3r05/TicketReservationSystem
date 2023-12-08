using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


namespace TicketReservationSystem.Controllers
{
    public class TimetableController : Controller {

       
    }
    public class Timetable
    {
        public string TrainNumber { get; set; } = "";
        public string DepartureStation { get; set; } = ""; 
        public string ArrivalStation { get; set; } = "";
        public DateTime DepartureTime { get; set; } 
        public DateTime ArrivalTime { get; set; }
        public decimal Price { get; set; }

      
    }
    

    
}
