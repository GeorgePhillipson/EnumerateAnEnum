using System;

namespace Example
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            EnumerateOverDogs();
        }

        private enum Dogs
        {
            GermanShepherd,
            GreatPyrenees,
            IrishSetter,
            Keeshond
        }

        private static void EnumerateOverDogs()
        {
            foreach (Dogs dog in Enum.GetValues(typeof(Dogs)))
            {
                Console.WriteLine(dog);
            }
            Console.Read();
        }
    }
}
