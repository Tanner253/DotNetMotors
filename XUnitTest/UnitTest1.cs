using System;
using Xunit;
using DotNetMotors.classes;
namespace XUnitTest 
{
    public class UnitTest1 

    {
        [Fact]
        public void RowBoatHasBow()
        {
            //arrange
            RowBoat rowboat = new RowBoat();
            //act
            bool output1 = rowboat.HasBow;
            //assert
            Assert.True(output1);
        }
        [Fact]
        public void RowBoatCanNotHasBow()
        {
            //arrange
            RowBoat rowboat = new RowBoat();
            //act
            rowboat.HasBow = false;
            bool output1 = rowboat.HasBow;
            
            //assert
            Assert.False(output1);
        }
        [Fact]
        public void RowBoatIsReal()
        {
            //arrange
            RowBoat rowboat = new RowBoat();
            //act
            
            bool output1 = rowboat.IsReal;

            //assert
            Assert.False(output1);
        }
        [Fact]
        public void RowBoatCanNotIsReal()
        {
            //arrange
            RowBoat rowboat = new RowBoat();
            //act
            rowboat.IsReal = true;
            bool output1 = rowboat.IsReal;

            //assert
            Assert.True(output1);
        }
        [Fact]
        public void RowBoatIsCool()
        {
            //arrange
            RowBoat rowboat = new RowBoat();
            //act
           
            bool output1 = rowboat.IsCool;

            //assert
            Assert.True(output1);
        }
        [Fact]
        public void RowBoatCanNotBeCool()
        {
            //arrange
            RowBoat rowboat = new RowBoat();
            //act
            rowboat.IsCool = false;
            bool output1 = rowboat.IsCool;

            //assert
            Assert.False(output1);
        }
        [Fact]
        public void RowBoatCanDrive()
        {
            //arrange
            RowBoat rowboat = new RowBoat();
            //act
            string var = rowboat.Drives();

            //assert
            Assert.Equal("The Boat is going somewhere. and is cool : True", var);
        }
        [Fact]
        public void RowBoatCanTurnOff()
        {
            //arrange
            RowBoat rowboat = new RowBoat();
            //act
            string var = rowboat.TurnOff();

            //assert
            Assert.Equal("The boat has turned off.", var);
        }
         [Fact]
         public void RowBoatCanTurnOn()
        {
            //arrange
            RowBoat rowboat = new RowBoat();

            //act
            string var = rowboat.TurnOn();

            Assert.Equal("The boat cannot turn on", var);



        }
        [Fact]
        public void SpeedBoatMakesNoise()
        {
            //arrange
            SpeedBoat speedboat = new SpeedBoat();
            //act
            bool output1 = speedboat.MakesNoise;
            //assert
            Assert.True(output1);
        }
        [Fact]
        public void SpeedBoatIsReaL()
        {
            //arrange
            SpeedBoat speedboat = new SpeedBoat();

            //act
            bool output = speedboat.IsReal;
            
            //assert
            Assert.True(output);
        }
        [Fact]
        public void SpeedBoatPrice()
        {
            //arrange
            SpeedBoat speedboat = new SpeedBoat();
            //act

            int output1 = speedboat.Price ;

            //assert
            Assert.Equal(32000, output1);
        }
        [Fact]
        public void SpeedBoatCanDrive()
        {
            //arrange
            SpeedBoat speedboat = new SpeedBoat();
            //act
            string output = speedboat.Drives();
            

            //assert
            Assert.Equal("The Boat is Driving!", output);
        }
        [Fact]
        public void SpeedBoatCanreverse()
        {
            //arrange
            SpeedBoat speedboat = new SpeedBoat();


            //act

            string output = speedboat.CanReverse();

            //assert
            Assert.Equal("the boat is going in reverse", output);
        }
        
        [Fact]
        public void SpeedBoatCanTurnOff()
        {
            //arrange
            SpeedBoat speedboat = new SpeedBoat();
                //act
            string var = speedboat.TurnOff();

            //assert
            Assert.Equal("The boat has turned off.", var);
        }
        [Fact]
        public void SpeedBoatCanTurnOn()
        {
            //arrange
            SpeedBoat speedboat = new SpeedBoat();
            //act
            string var = speedboat.TurnOn();

            //assert
            Assert.Equal("The boat has turned on.", var);
        }
        [Fact]
        public void CoupeMakesnoise()
        {
            //arrange
            Coupe coupe = new Coupe();
            //act
            bool output1 = coupe.MakesNoise;
            //assert
            Assert.True(output1);
        }
        [Fact]
        public void CoupeIsReaL()
        {
            //arrange
            Coupe coupe = new Coupe();
            //act
            bool output = coupe.IsReal;

            //assert
            Assert.False(output);
        }
        [Fact]
        public void CoupePrice()
        {
            //arrange
            Coupe coupe = new Coupe();
            //act

            int output1 = coupe.Price;

            //assert
            Assert.Equal(3000, output1);
        }
        [Fact]
        public void CoupeCanDrive()
        {
            //arrange
            Coupe coupe = new Coupe();
            //act
            string output = coupe.DriveForward();


            //assert
            Assert.Equal("The car drives forward", output);
        }
        [Fact]
        public void TheCoupeCanreverse()
        {
            //arrange
            Coupe coupe = new Coupe();

            //act

            string output = coupe.Reverse();

            //assert
            Assert.Equal("The car Reverses", output);
        }
        [Fact]
        public void CoupeCanHonk()
        {
            //arrange
            Coupe coupe = new Coupe();
            //act
            string output = coupe.Honk();


            //assert
            Assert.Equal("BEEP BEEP im a coupe!", output);
        }
        [Fact]
        public void CoupeCanTurnOff()
        {
            //arrange
            Coupe coupe = new Coupe();
            //act
            string var = coupe.TurnOff();

            //assert
            Assert.Equal("The Coupe has turned off", var);
        }
        [Fact]
        public void CoupeCanTurnOn()
        {
            //arrange
            Coupe coupe = new Coupe();
            //act
            string var = coupe.TurnOn();

            //assert
            Assert.Equal("The Coupe has turned on", var);
        }

        [Fact]
        public void SedanMakesnoise()
        {
            //arrange
            Sedan sedan = new Sedan();
            //act
            bool output1 = sedan.MakesNoise;
            //assert
            Assert.True(output1);
        }
        [Fact]
        public void SedanIsReaL()
        {
            //arrange
            Sedan sedan = new Sedan();
            //act
            bool output = sedan.IsReal;

            //assert
            Assert.False(output);
        }
        [Fact]
        public void SedanPrice()
        {
            //arrange
            Sedan sedan = new Sedan();
            //act

            int output1 = sedan.Price;

            //assert
            Assert.Equal(1000, output1);
        }
        [Fact]
        public void SedanCanDrive()
        {
            //arrange
            Sedan sedan = new Sedan();
            //act
            string output = sedan.DriveForward();


            //assert
            Assert.Equal("The car drives forward", output);
        }
        [Fact]
        public void TheSedanCanreverse()
        {
            //arrange
            Sedan sedan = new Sedan();

            //act

            string output = sedan.Reverse();

            //assert
            Assert.Equal("The car Reverses", output);
        }
        [Fact]
        public void SedanCanHonk()
        {
            //arrange
            Sedan sedan = new Sedan();
            //act
            string output = sedan.Honk();


            //assert
            Assert.Equal("BEEP BEEP", output);
        }
        [Fact]
        public void SedanCanTurnOff()
        {
            //arrange
            Sedan sedan = new Sedan();
            //act
            string var = sedan.TurnOff();

            //assert
            Assert.Equal("The sedan has turned off", var);
        }
        [Fact]
        public void SedanCanTurnOn()
        {
            //arrange
            Sedan sedan = new Sedan();
            //act
            string var = sedan.TurnOn();

            //assert
            Assert.Equal("The sedan has turned on", var);
        }
        [Fact]
        public void ReallyReallyLongBusMakesnoise()
        {
            //arrange
            ReallyReallyLongBus rl = new ReallyReallyLongBus();
            //act
            bool output1 = rl.MakesNoise;
            //assert
            Assert.False(output1);
        }
        [Fact]
        public void ReallyReallyLonBusIsReaL()
        {
            //arrange
            ReallyReallyLongBus rl = new ReallyReallyLongBus();
            //act
            bool output = rl.IsReal;

            //assert
            Assert.False(output);
        }
        [Fact]
        public void ReallyReallyLongBusPrice()
        {
            //arrange
            ReallyReallyLongBus rl = new ReallyReallyLongBus();            

            int output1 = rl.Price;

            //assert
            Assert.Equal(13000, output1);
        }
        [Fact]
        public void ReallyReallyLongBusCanDrive()
        {
            //arrange
            ReallyReallyLongBus rl = new ReallyReallyLongBus();         
            string output = rl.DriveForward();


            //assert
            Assert.Equal("The Really Really Long Bus doesn't drive forward", output);
        }
        [Fact]
        public void TheReallyReallyongBusCanreverse()
        {
            //arrange
            ReallyReallyLongBus rl = new ReallyReallyLongBus();
            //act

            string output = rl.Reverse();

            //assert
            Assert.Equal("The Really Really Long Bus doesn't go in reverse", output);
        }
        [Fact]
        public void ReallyReallyLongBusCanHonk()
        {
            //arrange
            ReallyReallyLongBus rl = new ReallyReallyLongBus();            
            string output = rl.Honk();


            //assert
            Assert.Equal("BEEP BEEP", output);
        }
        [Fact]
        public void ReallyReallyLongBusCanTurnOff()
        {
            //arrange
            ReallyReallyLongBus rl = new ReallyReallyLongBus();
            //act
            string var = rl.TurnOff();

            //assert
            Assert.Equal("The Really Really Long Bus has been turned off forever", var);
        }
        [Fact]
        public void ReallyReallyLongBusCanTurnOn()
        {
            //arrange
            ReallyReallyLongBus rl = new ReallyReallyLongBus();              
            string var = rl.TurnOn();

            //assert
            Assert.Equal("The Really Really Long Bus doesn't turn on", var);
        }

    }
}
