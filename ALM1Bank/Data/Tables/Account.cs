﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALM1Bank.Data.Tables
{
    public class Account
    {
       
        public int AccountID { get; set; }

        public decimal Balance { get; set; }

        public int CustomerID { get; set; }
    }
}
