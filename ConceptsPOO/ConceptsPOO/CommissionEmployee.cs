﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConceptsPOO
{
    public class CommissionEmployee : Employee
    {
        public float CommissionPercentaje { get; set; }
        public decimal Sales { get; set; }
        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommissionPercentaje;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\tCommission percentaje: {$"{CommissionPercentaje:P2}", 18}" +
                $"\n\tSales................: {$"{Sales:C2}", 18}" +
                $"\n\tValue to Pay.........: {$"{GetValueToPay():C2}", 18}";
        }
    }
}