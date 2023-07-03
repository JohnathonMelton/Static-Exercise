namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Fahrenheit -> Celsuis: {TempConverter.FahrenheitToCelsius(52)}");
            Console.WriteLine();

            Console.Write($"Celsuis -> Fahrenheit: {TempConverter.CelsiusToFahrenheit(27)}");
            Console.WriteLine();
        }
    }
}
