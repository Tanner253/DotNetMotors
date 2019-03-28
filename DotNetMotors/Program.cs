using DotNetMotors.classes;
using System;

namespace DotNetMotors
{
    class Program
    {
        static void Main(string[] args)
        {
            ThingsSpeedBoatCanDo();
            ThingsARowBoatCanDo();
            ThingsASedanCanDo();
            ThingsACoupeCanDo();
            ThingsAReallyReallyLongBusCanDo();
            Console.ReadKey();


        }
        static void ThingsSpeedBoatCanDo()
        {
            SpeedBoat speedboat = new SpeedBoat();
            Console.WriteLine("Hello World!");
            Console.WriteLine("-----Does a speedBoat have a Bow?-----");
            bool output1 = speedboat.HasBow; 
            Console.WriteLine(output1);
            Console.WriteLine("-----is a speedBoat Real?-----");
            bool output2 = speedboat.IsReal; 
            Console.WriteLine(output2);
            Console.WriteLine("-----can a speedBoat drive?-----");
            speedboat.Drives();
            Console.WriteLine("-----Can the speedBoat turn on?-----");
            speedboat.TurnOn();
            Console.WriteLine("-----Can the speedBoat turn off?-----");
            speedboat.TurnOff();
            Console.WriteLine("price:");
            Console.WriteLine(speedboat.Price);
            Console.ReadLine();


        }
        static void ThingsARowBoatCanDo()
        {
            RowBoat rowboat = new RowBoat();
            Console.WriteLine("-----Does a rowBoat have a Bow?-----");
            bool output1 = rowboat.HasBow;
            Console.WriteLine(output1);
            Console.WriteLine("-----is a rowBoat Real?-----");
            bool output2 = rowboat.IsReal;
            Console.WriteLine(output2);
            Console.WriteLine("is a row boat cool?");
            bool output3 = rowboat.IsCool;
            Console.WriteLine(output3);
            Console.WriteLine("-----can a rowBoat drive?-----");
            rowboat.Drives();
            Console.WriteLine("-----Can the rowBoat turn on?-----");
            rowboat.TurnOn();
            Console.WriteLine("-----Can the rowBoat turn off?-----");
            rowboat.TurnOff();
            Console.WriteLine("price:");
            Console.WriteLine(rowboat.Price);
        }
        static void ThingsASedanCanDo()
        {
            Sedan sedan = new Sedan();
            Console.WriteLine("-----does a sedan make noise?-----");
            bool output1 = sedan.MakesNoise;
            Console.WriteLine(output1);
            Console.WriteLine("-----does a sedan start?-----");
            bool output2 = sedan.Starts;
            Console.WriteLine(output2);
            Console.WriteLine("Does a Sedan honk?");
            sedan.Honk();
            Console.WriteLine("Does the car drive?");
            sedan.DriveForward();
            Console.WriteLine("Does the car go in reverse?");
            sedan.Reverse();
            Console.WriteLine("price:");
            Console.WriteLine(sedan.Price);
        }
        static void ThingsACoupeCanDo()
        {
            Coupe coupe = new Coupe();
            Console.WriteLine("-----does a coupe make noise?-----");
            bool output1 = coupe.MakesNoise;
            Console.WriteLine(output1);
            Console.WriteLine("-----does a coupe start?-----");
            bool output2 = coupe.Starts;
            Console.WriteLine(output2);
            Console.WriteLine("Does a coupe honk?");
            coupe.Honk();
            Console.WriteLine("Does a coupe turn on?");
            coupe.TurnOn();
            Console.WriteLine("Does the coupe drive?");
            coupe.DriveForward();
            Console.WriteLine("Does the coupe go in reverse?");
            coupe.Reverse();
            Console.WriteLine("Does a coupe turn off?");
            coupe.TurnOff();
            Console.WriteLine("price:");
            Console.WriteLine(coupe.Price);
        }
        static void ThingsAReallyReallyLongBusCanDo()
        {

            ReallyReallyLongBus bus = new ReallyReallyLongBus();
            Console.WriteLine("-----does a ReallyReallyLongBus make noise?-----");
            bool output1 = bus.MakesNoise;
            Console.WriteLine(output1);
            Console.WriteLine("-----does a ReallyReallyLongBu start?-----");
            bool output2 = bus.Starts;
            Console.WriteLine(output2);
            Console.WriteLine("Does a ReallyReallyLongBu honk?");
            bus.Honk();
            Console.WriteLine("Does a ReallyReallyLongBu turn on?");
            bus.TurnOn();
            Console.WriteLine("Does the ReallyReallyLongBu drive?");
            bus.DriveForward();
            Console.WriteLine("Does the ReallyReallyLongBu go in reverse?");
            bus.Reverse();
            Console.WriteLine("Does a ReallyReallyLongBu turn off?");
            bus.TurnOff();
            Console.WriteLine("price:");
            Console.WriteLine(bus.Price);
        }
    }
}
