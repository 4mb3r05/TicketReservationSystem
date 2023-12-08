using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


namespace TicketReservationSystem.Controllers
{
    public class TimetableController : Controller {

        private readonly ApplicationDbContext _context;

        public TimetableController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public IActionResult GetTimetables()
        {
            List<Timetable> trainSchedules = [];
            // Populate the trainSchedules list with data
            return View(trainSchedules); // Assuming you have a corresponding view named GetTimetables.cshtml
        }
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
