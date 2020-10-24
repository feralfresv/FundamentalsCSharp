using Amazon;

namespace AccessModifiers2
{

    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            //AccessModifier2_Amazon.RateCalculator rateCalculator = new RateCalculator();
            customer.Promote();

        }
    }
}
