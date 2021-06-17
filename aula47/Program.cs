using System;

namespace aula47
{
    class Calc {

         public int soma(params int[]n){
             int s = 0;
             for(int i =0;i<n.Length; i++){
                 s += n[i];
             }
            return s;
        }     
        public double soma(params double[]n){
            double s = 0;
             for(int i =0;i<n.Length; i++){
                 s += n[i];
             }
            return s;
        }        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            
            var res = calc.soma(10.2,5.4,5.55,4.8,9);

            Console.WriteLine(res);
            
        }
    }
}
