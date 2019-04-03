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
            Console.WriteLine(speedboat.Drives());
            Console.WriteLine("-----Can the speedBoat turn on?-----");
            Console.WriteLine(speedboat.TurnOn());
            Console.WriteLine("-----Can the speedBoat turn off?-----");
            Console.WriteLine(speedboat.TurnOff());
            Console.WriteLine("price:");
            Console.WriteLine(speedboat.Price);
            Console.ReadLine();
            Console.WriteLine(speedboat.RaiseFlag());

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
            Console.WriteLine(rowboat.Drives());
            Console.WriteLine("-----Can the rowBoat turn on?-----");
            Console.WriteLine(rowboat.TurnOn());
            Console.WriteLine("-----Can the rowBoat turn off?-----");
            Console.WriteLine(rowboat.TurnOff());
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
            Console.WriteLine("-------Does a Sedan honk?------");
            Console.WriteLine(sedan.Honk());
            Console.WriteLine("------Does the car drive?------");
            Console.WriteLine(sedan.DriveForward());
            Console.WriteLine("------Does the car go in reverse?------");
            Console.WriteLine(sedan.Reverse());
            Console.WriteLine("price:");
            Console.WriteLine(sedan.Price);
            Console.WriteLine(sedan.Honk());
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
            Console.WriteLine("----------Does a coupe honk?-------------");
            Console.WriteLine(coupe.Honk());
            Console.WriteLine("-----Does a coupe turn on?-----");
            Console.WriteLine(coupe.TurnOn());
            Console.WriteLine("-----Does the coupe drive?-----");
            Console.WriteLine(coupe.DriveForward());
            Console.WriteLine("------Does the coupe go in reverse?------");
            Console.WriteLine(coupe.Reverse());
            Console.WriteLine("------Does a coupe turn off?------");
            Console.WriteLine(coupe.TurnOff());
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
            Console.WriteLine("======Does a ReallyReallyLongBu honk?======");
            Console.WriteLine(bus.Honk());
            Console.WriteLine("======Does a ReallyReallyLongBu turn on?======");
            Console.WriteLine(bus.TurnOn());
            Console.WriteLine("======Does the ReallyReallyLongBu drive?======");
            Console.WriteLine(bus.DriveForward());
            Console.WriteLine("======Does the ReallyReallyLongBu go in reverse?======");
            Console.WriteLine(bus.Reverse());
            Console.WriteLine("======Does a ReallyReallyLongBu turn off?======");
            Console.WriteLine(bus.TurnOff());
            Console.WriteLine("price:");
            Console.WriteLine(bus.Price);
        }
    }
}
