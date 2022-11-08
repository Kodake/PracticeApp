namespace HandleTwoIntegerPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Manejo de dos números enteros");
        start:
            try
            {
                Console.WriteLine("Introduzca el primer valor entero: ");
                string? first = Console.ReadLine();
                int value1 = Convert.ToInt32(first);
                Console.WriteLine($"Primer valor: {value1}");
            }
            catch (Exception)
            {
                Console.WriteLine($"El valor ingresado no es válido. Sólo se aceptan valores enteros...");
                Console.WriteLine();
                goto start;
            }

        second:
            try
            {
                Console.WriteLine("Introduzca el segundo valor entero: ");
                string? second = Console.ReadLine();
                int value2 = Convert.ToInt32(second);
                Console.WriteLine($"Segundo valor: {value2}");
            }
            catch (Exception)
            {
                Console.WriteLine($"El valor ingresado no es válido. Sólo se aceptan valores enteros...");
                Console.WriteLine();
                goto second;
            }
        }
    }
}