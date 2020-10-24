namespace Constructors2
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber) : base(registrationNumber)
        {
            System.Console.WriteLine("2 - Car is being initialized .{0}", registrationNumber);
        }
    }
}
