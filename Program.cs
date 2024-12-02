// See https://aka.ms/new-console-template for more information
using oop_2024_12_01_PlaneJourneyCalculator.models;

Console.WriteLine("Plane Journey Calculator");  // Initial journey distance in kilometers (New York to Vietnam)


PlaneDriver.Run();











int initialJourneyDistance = 14000;  // Distance in kilometers
int kilometersPerHour = 800;         // Plane speed in km/h
int additionalKilometersPerHour = 10; // Additional kilometers added each hour
int totalDistance = initialJourneyDistance;
int hours = 0;

// While loop to calculate the hours taken
while (totalDistance > 0)
{
    hours++;                         // Increment the hour count
    totalDistance -= kilometersPerHour;  // Subtract the kilometers flown in that hour
    if (totalDistance > 0)
    {
        totalDistance += additionalKilometersPerHour;  // Add extra kilometers for the next hour
    }
}

// Display the result
Console.WriteLine($"It takes {hours} hours for the plane to complete its journey from New York to Vietnam.");
