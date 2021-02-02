using System;

namespace SpaceX
{
    class Program
    {
        static void Main(string[] args)
        {
            var rocket = new Rocket();
            var cargo = new Cargo();
            cargo.pounds = 120;
            rocket._cargo.Add(cargo);
            Console.WriteLine("Your rocket has: {0} cargos", rocket._cargo.Count);

            var cargo2 = new Cargo();
            cargo2.pounds = 1220;
            rocket._cargo.Add(cargo);
            Console.WriteLine("Your rocket has: {0} cargos", rocket._cargo.Count);

            Console.WriteLine("The total weight of cargo is {0} cargos", rocket.CargoWeight());
        }
    }
}
