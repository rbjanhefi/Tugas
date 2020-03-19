using System;

namespace taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek Taxi
            taxi taxi = new taxi();

            // pengesetan nilai Properties
            taxi.DriverName = "Rizqi";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            // pemanggilan Method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}