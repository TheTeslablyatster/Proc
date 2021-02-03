using System;
using System.Linq;

namespace Proc
{
    class Program
    {
 
        static int Sign(double a)
        {
            if (a < 0)
                return -1;
            if (a > 0)
                return 1;
            return 0;
        }

        static void Proc16()
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Sign(a) + Sign(b));
        }

        static int RootsCount(int a, int b, int c)
        {
            int D = b * b - 4 * a * c;
            if (D < 0)
                return 0;
            if (D > 0)
                return 2;
            return 1;

        }
        static void Proc17()
        {
            string[] a;
            for (int i = 0; i < 3; i++)
            {
                a = Console.ReadLine().Split(' ');
                Console.WriteLine(RootsCount(Convert.ToInt32(a[0]), Convert.ToInt32(a[1]), Convert.ToInt32(a[2])));
            }
        }

        static double CircleS(double R)
        {
            return R * R * Math.PI;
        }
        static void Proc18()
        {
            double R;
            for (int i = 0; i < 3; i++)
            {
                R = double.Parse(Console.ReadLine());
                Console.WriteLine(CircleS(R));
            }
        }

        static double RingS(double R1, double R2)
        {
            return CircleS(R1) - CircleS(R2);
        }

        static void Proc19()
        {
            string[] R;
            for (int i = 0; i < 3; i++)
            {
                R = Console.ReadLine().Split(' ');
                Console.WriteLine(RingS(Convert.ToDouble(R[0]), Convert.ToDouble(R[1])));
            }
        }

        static double TriangleP (int a, int h)
        {
            return Math.Sqrt(Math.Pow(a/2,2) + Math.Pow(h,2));
        }
        static void Proc20()
        {
            string[] Triangle;
            for (int i = 0; i < 3; i++)
            {
                Triangle = Console.ReadLine().Split(' ');
                Console.WriteLine(TriangleP(Convert.ToInt32(Triangle[0]), Convert.ToInt32(Triangle[1])));
            }
        }

        static int RangeSum(int a, int b)
        {
            int Sum = 0;
            if (a > b)
                return 0;
            for (int i = a; i <= b; i++)
                Sum += i;
            return Sum;
        }
        static void Proc21()
        {
            int[] readarray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine($"{RangeSum(readarray[0], readarray[1])} {RangeSum(readarray[1], readarray[2])}");
        }

        static double Calc(double a, double b, int Op)
        {
            switch (Op)
            {
                case 1:
                    return a - b;
                case 2:
                    return a * b;
                case 3:
                    return a / b;
                default:
                    return a + b;
            }
        }

        static void Proc22()
        {
            double[] nums = Console.ReadLine().Split(' ').Select(Double.Parse).ToArray();
            int[] operations = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            foreach (int operation in operations)
                Console.WriteLine(Calc(nums[0], nums[1], operation));
        }

        static int Quarter (double x, double y)
        {
            if ((y > 0) && (x > 0))
                return 1;
            if ((y > 0) && (x < 0))
                return 2;
            if ((y < 0) && (x < 0))
                return 3;
            return 4;
        }
        static void Proc23()
        {
            int[] dots;
            for (int i = 0; i < 3; i++)
            {
                dots = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Console.WriteLine(Quarter(dots[0], dots[1]));
            }
        }

        static bool Even(int K)
        {
            if (K % 2 == 0)
                return true;
            return false;
        }
        static void Proc24()
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int evencount = 0;
            for (int i = 0; i < 10; i++)
                if (Even(nums[i]) == true)
                    evencount += 1;
            Console.WriteLine(evencount);

        }

        static bool IsSquare(double K)
        {
            if (Math.Sqrt(K) % 1 == 0)
                return true;
            return false;
        }
        static void Proc25()
        {
            double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int squarecount = 0;
            for (int i = 0; i < 10; i++)
                if (IsSquare(nums[i]) == true)
                    squarecount += 1;
            Console.WriteLine(squarecount);
        }

        static void Main()
        {
            Proc25();
        }
    }
}
