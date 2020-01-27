using System;

namespace Decorator
{
    public interface ICoffee
    {
        double Cost();
    }
    public class Coffee : ICoffee
    {
        public double Cost()
        {
            return 1.0;
        }
    }

    public abstract class CoffeeDecorator : ICoffee
    {
        protected ICoffee Coffee;

        public CoffeeDecorator(ICoffee Coffee)
        {
            this.Coffee = Coffee;
        }

        public abstract double Cost();
    }

    public class WithMilk : CoffeeDecorator
    {
        public WithMilk(ICoffee Coffee ) : base(Coffee)
        {

        }

        public override double Cost()
        {
            return Coffee.Cost() + 0.5;
        }
    }

    public class WithSprinkle : CoffeeDecorator
    {
        public WithSprinkle(ICoffee Coffee) : base(Coffee)
        {

        }

        public override double Cost()
        {
            return Coffee.Cost() + 0.2;
        } 
    }


    
}
