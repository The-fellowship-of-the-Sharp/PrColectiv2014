﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraveyardManagement.Utils.Exceptions
{
    public class ConflictCetateanDecedatException : Exception
    {
    }

    public class ValidationException : Exception
    {
        public ValidationException(String msg) : base(msg){}
    }
}
