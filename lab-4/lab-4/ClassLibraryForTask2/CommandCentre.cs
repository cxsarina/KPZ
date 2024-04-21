using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTask2
{
    public class CommandCentre
    {
        private List<Runway> _runways = new List<Runway>();
        private List<Aircraft> _aircrafts = new List<Aircraft>();

        public void RegisterRunway(Runway runway)
        {
            _runways.Add(runway);
        }

        public void RegisterAircraft(Aircraft aircraft)
        {
            _aircrafts.Add(aircraft);
        }

        public void RequestLanding(Aircraft aircraft)
        {
            Console.WriteLine($"Requesting landing for {aircraft.Name}");
            foreach (var runway in _runways)
            {
                if (runway.IsAvailable())
                {
                    runway.Land(aircraft);
                    return;
                }
            }
            Console.WriteLine("No available runway for landing.");
        }

        public void RequestTakeoff(Aircraft aircraft)
        {
            Console.WriteLine($"Requesting takeoff for {aircraft.Name}");
            foreach (var runway in _runways)
            {
                if (runway.IsAvailable())
                {
                    runway.TakeOff();
                    return;
                }
            }
            Console.WriteLine("No available runway for takeoff.");
        }
    }
}
