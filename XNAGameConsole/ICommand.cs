﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XNAGameConsole
{
    public interface ICommand
    {
        string Name { get; }
        string Description { get; }
        string Execute(string[] arguments);
    }
}
