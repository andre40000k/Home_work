namespace Home_work_7_1
{
    class HW_7_1
    {
        static double Exponentiation(double baseOfDegree, double exponent)
        {
            return Math.Pow(baseOfDegree, exponent); 
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

        static void Main()
        {

            // Task 7_1
            // Написать функцию, которая принимает два параметра:
            // основание степени и показатель степени, и
            // вычисляет степень числа на основе полученных данных.

            double baseOfDegree, exponent;

            GettingNumbers(out baseOfDegree, out exponent);

            Console.WriteLine($"The result of raising the number {baseOfDegree} to the power of {exponent} is {Exponentiation(baseOfDegree, exponent)}");

        }
    }
}