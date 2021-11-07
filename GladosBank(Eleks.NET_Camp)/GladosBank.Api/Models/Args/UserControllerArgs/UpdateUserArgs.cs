﻿using GladosBank.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GladosBank.Api.Models.Args.UserControllerArgs
{
    public sealed class UpdateUserArgs
    {
        public string Login { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
