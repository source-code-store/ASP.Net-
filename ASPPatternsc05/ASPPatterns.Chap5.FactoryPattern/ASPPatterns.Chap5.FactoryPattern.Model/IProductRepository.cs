﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASPPatterns.Chap4.FactoryPattern.Model
{
    public interface ICustomerRepository
    {
        IList<Product> FindAll(); 
    }
}
