using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2024_12_01_PlaneJourneyCalculator.models
{
    class PlaneJourney
    {
        public int InitialJourneyDistance { get; set; }
        public int KilometersPerHour { get; set; }
        public int AdditionalKilometersPerHour { get; set; }

        public PlaneJourney(int initialDistance, int speed, int additionalDistance)
        {
            InitialJourneyDistance = initialDistance;
            KilometersPerHour = speed;
            AdditionalKilometersPerHour = additionalDistance;
        }

        public int CalculateJourneyTime()
        {
            int totalDistance = InitialJourneyDistance;
            int hours = 0;

            // Calculate the number of hours to complete the journey
            while (totalDistance > 0)
            {
                hours++; // Increment the hour count
                totalDistance -= KilometersPerHour; // Subtract the kilometers flown in that hour
                if (totalDistance > 0)
                {
                    totalDistance += AdditionalKilometersPerHour; // Add extra kilometers for the next hour
                }
            }

            return hours;
        }
    }
}
