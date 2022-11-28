namespace OperatorsInClass
{
    class Program
    {
        static void Main(string[] args) 
        {
            //Exercise 1
            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;
            
            Console.WriteLine($" {a} / {b} is {quotient} remainder {remainder}");

            //Exercise 2
            Console.WriteLine("Please enter the radius of your circle");
           
            var radius = double.Parse(Console.ReadLine());

            Console.WriteLine($"The area of a circle with the radius of {radius} is {AreaOfCircle(radius)}");
            
        }
        public static double AreaOfCircle(double radius) 
        {
            var area = Math.PI * Math.Pow(radius, 2);
            return area;

        }
    }
}


