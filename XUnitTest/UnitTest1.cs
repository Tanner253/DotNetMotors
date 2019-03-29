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
            Assert.Equal("The Boat is going somewhere.", var);
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
    }
}
