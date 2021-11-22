using MarsRover.Models;

namespace MarsRover.Directions
{
    internal class MoveDirection : RoverDirection
    {
        public MoveDirection(Rover rover) : base(rover)
        {
        }

        public override void Invoke()
        {
            Rover.Move();
        }
    }
}
