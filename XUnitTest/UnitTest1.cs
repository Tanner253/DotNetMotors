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
         public void CanTurnOn()
        {
            //arrange
            RowBoat rowboat = new RowBoat();

            //act
            string var = rowboat.TurnOn();

            Assert.Equal("The boat cannot turn on", var);



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

            int output1 = coupe.Price ;

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
            Assert.Equal("BEEP BEEP im a coupe!", output) ;
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
        public void RowBoatCanTurnOn()
        {
            //arrange
            Coupe coupe = new Coupe();
            //act
            string var = coupe.TurnOn();

            //assert
            Assert.Equal("The Coupe has turned on", var);
        }
        
    }
}
