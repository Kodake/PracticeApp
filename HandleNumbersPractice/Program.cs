namespace HandleNumbersPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Manejo de entrada numérica");
        start:
            try
			{
                
                Console.WriteLine("Introduzca un valor numérico: ");
                string? number = Console.ReadLine();
                Convert.ToDecimal(number);
                Console.WriteLine($"El valor ingresado es: {number?.TrimStart().TrimEnd()}");
                Console.WriteLine("Presione Enter para salir");
                Console.ReadKey();
            }
			catch (Exception)
			{
                Console.WriteLine($"El valor ingresado no es válido. Sólo se aceptan valores numéricos...");
                Console.WriteLine();
                goto start;
            }
        }
    }
}