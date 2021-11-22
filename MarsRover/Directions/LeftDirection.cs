using MarsRover.Models;

namespace MarsRover.Directions
{
    internal class LeftDirection : RoverDirection
    {
        public LeftDirection(Rover rover) : base(rover)
        {
        }

        public override void Invoke()
        {
            Rover.TurnLeft();
        }
    }
}
