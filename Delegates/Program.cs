using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var process = new PhotoProcessor();
            var filter = new PhotoFilters();

            // First Implementation "Es antigua"
            //PhotoProcessor.PhotoFilterHandler filterHandler = filter.ApplyBrightness;
            Action<Photo> filterHandler = filter.ApplyBrightness;
            filterHandler += filter.ApplyContrast;
            filterHandler += filter.Resize;
            filterHandler += RemoveRedEyeFilter;

            process.Process("photo.img", filterHandler);
            
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            System.Console.WriteLine("Remove Red Eye Filter");
        }
    }
}
