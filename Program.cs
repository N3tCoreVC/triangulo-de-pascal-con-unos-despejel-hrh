using System;

namespace TrianguloPascal
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.Write("Cuantas filas desea tener en su triangulo? -->  ");
            Console.ForegroundColor = ConsoleColor.White;
            int buffer;
            if (int.TryParse(Console.ReadLine(), out buffer))
            {
                PrintShape(buffer);
            }
            else
            {
                Console.WriteLine("Por favor ingrese solo números enteros...");
                Console.WriteLine();  
            }
        }

        static void PrintShape(int target)
        {
            System.Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write("\n\n\n\n");

            int buffer= target-1;

            for(int iterator=1; iterator<=target; iterator++)
            {
                for(int innerIterator=0; innerIterator<buffer; innerIterator++)
                {
                    Console.Write(" ");
                }
                
                for(int auxIterator=0; auxIterator<iterator; auxIterator++)
                {
                    Console.Write("1 ");
                }
                Console.Write("\n");
                buffer--;
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\n\n\n");
        }
    }
}

