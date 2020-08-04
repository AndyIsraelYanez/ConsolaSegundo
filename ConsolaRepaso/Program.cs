using System;

namespace ConsolaRepaso
{
    class Program
    {
       static void Main(string[] args)

        {
            Console.WriteLine("--------------");
            Console.WriteLine("** Presione Enter para continuar **");
            Console.ReadKey();
            Console.WriteLine("¿Ingrese su nombre para acceder a la información?");
            string nombreUsuario = Console.ReadLine();

            Vendedor vendedor = new Vendedor
            {
                Nombre = "Andy",
                Nacimiento = new DateTime(2000, 4, 14)

            };

            Console.WriteLine(vendedor.Saludar());
            Console.WriteLine(vendedor.Cobrar());
            Console.WriteLine(vendedor.DarVueltos());

            Console.WriteLine($"Muchas gracias  {nombreUsuario} por visitarnos");
        }
    }
}
