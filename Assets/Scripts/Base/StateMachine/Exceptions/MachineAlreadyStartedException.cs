﻿using System;

namespace CuscuzBane.StateMachine
{
    public class MachineAlreadyStartedException : MachineException
    {
        public Machine Machine { get; }

        public MachineAlreadyStartedException(Machine machine) : base($"Trying to start a machine that is already started.")
        {
            Machine = machine;
        }
    }
}
