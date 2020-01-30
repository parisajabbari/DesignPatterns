using System;
using System.Collections.Generic;

namespace StrategyMethod
{
    public class Customer : ICustomer
    {
        
        public IBilling BillingStrategy{get; set;}
        
        public Customer(IBilling BillingStrategy)
        {
            this.BillingStrategy = BillingStrategy;
        }

        public double GetPrice(double RawPrice)
        {
            
            return BillingStrategy.GetPrice(RawPrice);
        }


    }
}