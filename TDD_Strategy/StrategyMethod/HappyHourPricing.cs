namespace StrategyMethod
{
    public class HappyHourPricing : IBilling
    {
        public double GetPrice(double RawPrice)
        {

            return RawPrice * 0.5;
        }


    }
}