using System;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;
        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("=== CALCULADORA COOPERATIVA TECHBANK ===");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            // Los alumnos agregarán más opciones aquí en sus ramas
            Console.WriteLine("0. Salir");
            Console.Write("\nSelecciona una opción: ");
            
            string opcion = Console.ReadLine();
            if (opcion == "0") break;

            Console.Write("Ingresa el primer número: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingresa el segundo número: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            switch (opcion)
            {
                case "1":
                    Console.WriteLine($"Resultado: {Operaciones.Sumar(n1, n2)}");
                    break;
                case "2":
                    Console.WriteLine($"Resultado: {Operaciones.Restar(n1, n2)}");
                    break;
                default:
                    Console.WriteLine("Opción no implementada aún.");
                    break;
            }
            Console.WriteLine("\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
