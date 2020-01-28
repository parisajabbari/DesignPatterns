using System;
using System.Collections.Generic;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            NormalStrategy NormalStrategy = new NormalStrategy();
            HappyHourStrategy HappyHourStrategy = new HappyHourStrategy();

            Customer FirstCustomer = new Customer(NormalStrategy);
            //Normal
            FirstCustomer.Add(1.0, 2);

            //Happy Hour starts
            FirstCustomer.BillingStartegy = HappyHourStrategy;
            FirstCustomer.Add(2, 2);

            FirstCustomer.PrintBill();

            Customer SecondCustomer = new Customer(HappyHourStrategy);
            SecondCustomer.Add(4, 2);
            SecondCustomer.Add(6, 2);

            SecondCustomer.PrintBill();

            //Happy hour finishes
            Customer ThirdCustomer = new Customer(NormalStrategy);
            ThirdCustomer.Add(2, 3);
            ThirdCustomer.PrintBill();

        }

        public interface IBillingStrategy
        {
            double GetPrice(double RawPrice);
        }

        public class NormalStrategy : IBillingStrategy
        {
            public double GetPrice(double RawPrice)
            {
                return RawPrice;
            }
        }

        public class HappyHourStrategy : IBillingStrategy
        {
            public double GetPrice(double RawPrice)
            {
                return RawPrice * 0.5;
            }
        }

        public class Customer
        {
            private List<double> drinks = new List<double>();
            public IBillingStrategy BillingStartegy{get; set;}

            public Customer(IBillingStrategy BillingStrategy)
            {
                this.BillingStartegy = BillingStrategy;

            }

            public void Add(double Price, int Quantity)
            {
                drinks.Add(this.BillingStartegy.GetPrice(Price * Quantity));
            }

            public void PrintBill()
            {
                double sum = 0.0;
                foreach(var drinksCost in drinks)
                {
                    sum += drinksCost;
                }

                Console.WriteLine("Total cost is : {0}", sum);
                drinks.Clear();

            }
        }


    }
}
