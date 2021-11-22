using MarsRover.Models;

namespace MarsRover.Directions
{
    internal class RightDirection : RoverDirection
    {
        public RightDirection(Rover rover) : base(rover)
        {
        }

        public override void Invoke()
        {
            Rover.TurnRight();
        }
    }
}
