using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    internal class Methods
    {
        //public static int Add(int x, int y)
        //{
        //    return x + y;
        //}

        //public static int Subtract(int x, int y)
        //{
        //    return x - y;
        //}

        //public static int Multiply(int x, int y)
        //{
        //    return x * y;
        //}
        //public static int Divide(int x, int y)
        //{
        //    return x / y;
        //}
        //public static int Modulus(int x, int y)
        //{
        //    return x % y;
        //}

        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
    }
}


      