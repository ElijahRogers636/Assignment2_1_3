using System;

namespace Assignment2_1_3
{
    //Overloading: Write a simple Maths class ( don’t use the keyword Math, it will be a conflict with standard class from system).
    //Write overloaded methods with logic and give choice to user to call different methods :
    //a.Add(int num1, int num2)
    //b.Add(decimal num1, decimal num2, decimal num3)
    //c.Multiply(float num1, float num2)
    //d.Multiply(float num1, float num2, float num3)
    //Declare these methods as public and static.

    public class Maths
	{
        public Maths() { }
		
        //Method for user selection with hardcoded numbers
        public void UserSelection(string selection)
        {
            switch (selection)
            {
                case "1":
                    Console.WriteLine(Add(5, 6));
                    break;
                case "2":
                    Console.WriteLine(Add(2, 3, 5));
                    break;
                case "3":
                    Console.WriteLine(Multiply(2, 8));
                    break;
                case "4":
                    Console.WriteLine(Multiply(2, 4, 8));
                    break;
                default:

                    break;
            }
        }

        //Overloaded Methods
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2, decimal num3)
        {
            return num1 + num2 + num3;
        }

        public static float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }

        public static float Multiply(float num1, float num2, float num3)
        {
            return num1 * num2 * num3;
        }

        //Challenge attempt: Method calls for an array of doubles and finds the summation of all doubles in the array
        public static double Add(double[] arr)
        {
            double ans = 0;
            foreach (double d in arr)
            {
                ans = ans + d;
            }
            return ans;
        }
    }
}
