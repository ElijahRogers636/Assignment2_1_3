namespace Assignment2_1_3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Maths maths = new Maths();

            Console.WriteLine("Which method would you like to use");
            Console.WriteLine("(1) Add(int num1, int num2)");
            Console.WriteLine("(2) Add(decimal num1, decimal num2, decimal num3");
            Console.WriteLine("(3) Multiply(float num1, float num2)");
            Console.WriteLine("(4) Multiply(float num1, float num2, float num3)");
            Console.Write("Choice: ");
            string selection = Console.ReadLine();

            maths.UserSelection(selection);

        }
    }
}
