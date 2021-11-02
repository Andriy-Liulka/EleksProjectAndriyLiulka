﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladosBank.Services.Exceptions
{
    public class ExistingUserLoginException : Exception
    {
        public ExistingUserLoginException(string message) : base(message) { }
    }
}
