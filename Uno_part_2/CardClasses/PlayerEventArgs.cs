﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClasses
{
    public class PlayerEventArgs : EventArgs
    {
        public Player Player { get; set; }
        public PlayerState State { get; set; }
    }
}