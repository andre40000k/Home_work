namespace Home_work_8_1
{
    internal class HW_8_1
    {

        static double Exponentiation(double baseOfDegree, double exponent)
        {

            if (exponent == 1)
                return baseOfDegree;

            else if (exponent == 0) 
                return 1;

            else if(exponent > 0)
                return baseOfDegree * Exponentiation(baseOfDegree, exponent - 1);

            else
            {
                exponent = Math.Abs(exponent);
                return 1 / (baseOfDegree * Exponentiation(baseOfDegree, exponent - 1));
            }
                
        }

        static void GettingNumbers(out double baseOfDegree, out double exponent)
        {
            try
            {
                Console.Write("Entered base of degree: ");
                baseOfDegree = double.Parse(Console.ReadLine());

                Console.Write("Entered exponent: ");
                exponent = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("\nErrors!\nIncorrd data entry!\nRepeat data entry!\n");
                GettingNumbers(out baseOfDegree, out exponent);
            }
        }

        static void Main(string[] args)
        {
            //Task 8_1
            //Написать рекурсивную функцию нахождения степени числа.

            double baseOfDegree, exponent;

            GettingNumbers(out baseOfDegree, out exponent);

            Console.WriteLine($"The result of raising the number {baseOfDegree} to the power of {exponent} is {Exponentiation(baseOfDegree, exponent)}");
        }
    }
}