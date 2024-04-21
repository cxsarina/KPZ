using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTask2
{
    public class Runway
    {
        public Guid Id { get; private set; }
        public Aircraft? IsBusyWithAircraft { get; private set; }

        public Runway()
        {
            Id = Guid.NewGuid();
        }

        public bool IsAvailable()
        {
            return IsBusyWithAircraft == null;
        }

        public void Land(Aircraft aircraft)
        {
            Console.WriteLine($"Aircraft {aircraft.Name} is landing.");
            IsBusyWithAircraft = aircraft;
            Console.WriteLine($"Aircraft {aircraft.Name} has landed.");
        }

        public void TakeOff()
        {
            Console.WriteLine($"Aircraft {IsBusyWithAircraft?.Name} is taking off.");
            IsBusyWithAircraft = null;
            Console.WriteLine($"Aircraft has taken off.");
        }
    }
}
