﻿using MarsRover.Models;
using System;

namespace MarsRover.States
{
    /// <summary>
    /// Base class of derived rover states.
    /// </summary>
    public abstract class RoverState : IState
    {
        public const string North = "N";
        public const string East  = "E";
        public const string South = "S";
        public const string West  = "W";

        //TODO

        protected RoverState(string code)
        {
            Code = code;
        }
        public string Code { get; private set; }

        public abstract void Move(Rover rover);

        public abstract void TurnLeft(Rover rover);

        public abstract void TurnRight(Rover rover);

        /// <summary>
        /// Gets instances of implemented by IRoverState
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static IState GetInstance(string code)
        {
            switch (code)
            {
                case North:
                    return NorthState.Instance;
                case East:
                    return EastState.Instance;
                case South:
                    return SouthState.Instance;
                case West:
                    return WestState.Instance;
                default:
                    throw new ArgumentOutOfRangeException(string.Format("This is not valid: {code}", code));
            }

        }
    }
}
