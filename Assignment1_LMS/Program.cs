namespace Assignment1_LMS
{
    internal class Program
    {
        static double ConvertToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        static void Main()
        {

            Console.Write("Enter Cel Temp: ");
            double celTemp = Convert.ToDouble(Console.ReadLine());


            double fahrenheitTemp = ConvertToFahrenheit(celTemp);


            Console.WriteLine("Fahrenheit Temperature is : " + fahrenheitTemp);
        }
    }
}
