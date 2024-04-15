namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            var EvenNumbers = numbers.Where(n => n % 2 == 0);

            foreach (var number in EvenNumbers)
            {
                Console.WriteLine(number);
            }

            List<double> grades = new List<double> { 85.5, 90.0, 78.0, 92.5, 76.0 };
            double AverageGrade = grades.Average();
            Console.WriteLine("The average grade is: " + AverageGrade);

            Console.WriteLine(GreetUser("Maha"));

            double boxVolume = CalculateBoxVolume(10, 5, 2);
            Console.WriteLine("The volume of the box is: " + boxVolume);
        }

        static string GreetUser(string name)
        {
            return $"Hello, {name}! Welcome to our program.";
        }

        static double CalculateBoxVolume(double length, double width, double height)
        {
            return length * width * height;
        }
    }
}