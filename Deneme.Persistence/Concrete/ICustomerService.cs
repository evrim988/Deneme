using Deneme.Application.Abstractions;
using Deneme.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme.Persistence.Concrete
{
    internal class ICustomerService : ICostumerServices
    {
        public List<Customer> GetCustomers()
            => new() 
            {
                new() { id=1,Name="Evrim",Surname="Çalışkan",CostumerID=1 },
                new() { id=2,Name="Fatma",Surname="Aslan",CostumerID=1 },
                new() { id=3,Name="Ayşe",Surname="Çalışkan",CostumerID=1 },
                new() { id=4,Name="Ali",Surname="Çalışkan",CostumerID=1 }
            };
    }
}
