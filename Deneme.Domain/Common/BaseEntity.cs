﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme.Domain.Common
{
    public class BaseEntity
    {   
        public int id { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
