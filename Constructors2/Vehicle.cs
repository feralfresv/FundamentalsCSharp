namespace Constructors2
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            System.Console.WriteLine("1 - Vehicle is being initialized .{0}", registrationNumber);
        }
    }
}
