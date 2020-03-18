using System;

namespace FluentInterfaceDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var spaceship = Spaceship.Create().WithName("Saturn V").OfSize(100, 100).WithThrusters();
            var spaceship2 = Spaceship.Create().WithName("Teeny Rocket").OfSmallSize().WithThrusters();
            Console.WriteLine(spaceship);
            Console.WriteLine();
            Console.WriteLine(spaceship2);
        }
    }
}
