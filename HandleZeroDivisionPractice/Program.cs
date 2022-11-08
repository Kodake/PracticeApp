namespace HandleZeroDivisionPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Manejo de división por cero");
        start:
            try
            {
                Console.WriteLine("Introduzca el primer valor entero: ");
                string? first = Console.ReadLine();
                int value1 = Convert.ToInt32(first);
                Console.WriteLine("Introduzca el segundo valor entero: ");
                string? second = Console.ReadLine();
                int value2 = Convert.ToInt32(second);
                int result = value1 / value2;
                Console.WriteLine($"El producto dividido es: {result}");
            }
            catch (Exception)
            {
                Console.WriteLine($"Error: división por cero...");
                Console.WriteLine();
                goto start;
            }
        }
    }
}