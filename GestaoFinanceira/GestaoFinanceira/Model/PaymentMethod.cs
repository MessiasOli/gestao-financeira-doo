﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Model
{
    public class PaymentMethod
    {
        public int Id { get; set; }
        public string Holder { get; set; }
        public double Limit { get; set; }
    }
}
