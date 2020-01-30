using System;
using System.Collections.Generic;

namespace StrategyMethod
{
    public interface ICustomer
    {
        double GetPrice(double RawPrice);
    }
}