namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var calculate = new RateCalculator();
            var rating = calculate.Calculate(this);
            if(rating == 0)
                System.Console.WriteLine("Promote logic Change!!!!!!");
            else
                System.Console.WriteLine("Game Over");
        }
    }
}
