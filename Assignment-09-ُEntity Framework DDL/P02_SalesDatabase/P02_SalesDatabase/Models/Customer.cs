﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.Models
{
    internal class Customer
    {
            public int CustomerId { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }

            // navigation
            public Sale? Sale { get;}


    }
}
