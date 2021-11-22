using MarsRover.Models;
using System;

namespace MarsRover.Directions
{
    /// <summary>
    /// Base class of implementations of ICommand
    /// </summary>
    public abstract class RoverDirection : IDirection
    {
        public const string Move = "M";
        public const string Right = "R";
        public const string Left = "L";

        protected readonly Rover Rover;

        protected RoverDirection(Rover rover)
        {
            Rover = rover;            
        }

        public abstract void Invoke();

        public static IDirection Create(Rover rover, string command)
        {
            if (rover == null)
                throw new ArgumentNullException("Rover not found");
            if (command == Move)
                return new MoveDirection(rover);
            if (command == Right)
                return new RightDirection(rover);
            if (command == Left)
                return new LeftDirection(rover);

            throw new ArgumentOutOfRangeException("Invalid command");
        }
    }
}
