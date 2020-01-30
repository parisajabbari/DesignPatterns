namespace StrategyMethod
{
    public class NormalPricing : IBilling
    {
        public double GetPrice(double RawPrice)
        {
            return RawPrice;
        }


    }
}