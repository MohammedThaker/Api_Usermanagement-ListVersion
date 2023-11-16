﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Application.Interfaces
{
    public interface  ICustomerRepository<T> where T : class
    {
     public  T GetByIdi(int id);
   

    }
}
