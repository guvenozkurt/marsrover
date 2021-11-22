using MarsRover.CustomExceptions;
using MarsRover.Directions;
using MarsRover.Models;
using MarsRover.States;
using System;
using Xunit;

namespace MarsRover.Tests
{
    public class DirectionTests
    {
        public const string North = "N";
        public const string East = "E";
        public const string South = "S";
        public const string West = "W";

        [Fact]
        public void When_Rover_Turn_Right_ShouldBeEast()
        {
            var plateau = new Plateau(4, 4);
            var rover = plateau.AddRover(2, 2, RoverState.GetInstance(North));
            var command = RoverDirection.Create(rover, RoverDirection.Right);

            command.Invoke();
            Assert.Equal(RoverState.GetInstance(East), rover.State);

            //command.Invoke();
            //Assert.Equal(RoverState.GetInstance(South), rover.State);

        }
    }
}
