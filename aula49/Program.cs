using System;

namespace aula49
{
    class Mat{
        public static double pi = 3.14;

        public static int dobro(int n){
            return n*2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double vpi = Mat.pi;
            int num = 10;

            Console.WriteLine(vpi);
            Console.WriteLine(Mat.dobro(num));
        }
    }
}
