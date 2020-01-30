using System;

namespace StrategyMethod
{
    public interface IBilling 
    {
        double GetPrice(double RawPrice);
    }
}
