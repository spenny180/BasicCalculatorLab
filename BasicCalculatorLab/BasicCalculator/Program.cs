using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** BASIC  Weather CALCULATOR ***");

            Console.WriteLine("Enter the Temperature");

            // int.Parse will take a string data type and convert it to an int data type
            int temp = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Humidity");
            int humidity = int.Parse(Console.ReadLine());
            double DewPt = temp - 9 * (100 - humidity) / 25;
            Console.WriteLine("The Dew Point " + DewPt);

            Console.WriteLine("Enter the Windspeed");
            int windSpeed = int.Parse(Console.ReadLine());
            double Windchill = 35.74 + (0.6215 * temp) - (35.75 * Math.Pow(windSpeed, 0.16)) + (0.4275 * Math.Pow(windSpeed, 0.16) * temp);

            Console.WriteLine("The Windshill is " + Windchill);

        }
    }
}
