﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladosBank.Domain
{
    class Worker : User
    {
        public decimal Salary { get; set; }

        public static Documentation GetDocumentation() => null;

        public void TransferMoney() { } 
    }
}
