﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Context.Shared.Commands
{
    public interface ICommand
    {
        void Validate();
    }
}
