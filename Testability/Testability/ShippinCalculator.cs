namespace Testability
{
    public interface IShippingCalculator
    {
        float CalculatedShipping(Order order);
    }

    public class ShippinCalculator : IShippingCalculator
    {
        public float CalculatedShipping(Order order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;

            return 0;
        }
    }
}
