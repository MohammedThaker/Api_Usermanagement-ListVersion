﻿using Domain.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public abstract class IPaymentBy
    {
        public abstract void ProcessPayment(string name);
    }
}
