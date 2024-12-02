using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2024_12_01_PlaneJourneyCalculator.models
{
    public static class PlaneDriver {

        public static void Run()
        {
            int journeyDistance = 14000;  // Distance in kilometers (New York to Vietnam)
            int planeSpeed = 800;         // Plane speed in km/h
            int additionalKilometers = 10; // Extra kilometers added per hour

            // Create a PlaneJourney object with the given parameters
            PlaneJourney journey = new PlaneJourney(journeyDistance, planeSpeed, additionalKilometers);

            // Calculate and display the time it takes for the plane to complete the journey
            int journeyTime = journey.CalculateJourneyTime();
            Console.WriteLine($"It takes {journeyTime} hours for the plane to complete its journey from New York to Vietnam.");


        }
    }
}
