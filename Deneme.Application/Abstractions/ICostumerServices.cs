﻿using Deneme.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme.Application.Abstractions
{
    public interface ICostumerServices
    {
        List<Customer> GetCustomers();
    }
}
