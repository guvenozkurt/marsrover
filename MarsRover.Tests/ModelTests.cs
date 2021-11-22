using MarsRover.Models;
using MarsRover.States;
using System.Text;
using Xunit;

namespace MarsRover.Tests
{
    public class ModelTests
    {
        public const string North = "N";
        public const string East = "E";
        public const string South = "S";
        public const string West = "W";

        [Fact]
        public void Create_Plateau_ReturnsSameWidthAndHeight()
        {
            var plateau = new Plateau(7, 10);
            Assert.Equal(8, plateau.Width);
            Assert.Equal(10, plateau.Height);
        }

        [Fact]
        public void Add_Rover_EqualCoordinate()
        {
            var plateau = new Plateau(7, 10);
            var rover = plateau.AddRover(3, 5, RoverState.GetInstance(North));

            Assert.Equal(3, rover.XCoordinate);
            Assert.Equal(5, rover.YCoordinate);
            Assert.Equal(RoverState.GetInstance(North), rover.State);
        }

    }
}

