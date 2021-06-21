using System;

class Area{
    public static float Quad(float bas, float alt){
        if(bas == 0 || alt ==0){
            throw new Exception("Base ou Altura não podem ter valor nulo");
        }
        return bas * alt;
    }

}

namespace aula53
{
    class Program
    {
        static void Main(string[] args)
        {
            float area = 0;

            try{
                area = Area.Quad(10F,5F);
                Console.WriteLine("Area do quadrado: {0}",area);
            }catch(Exception e){
                Console.WriteLine("ERRO:{0}",e.Message);
            }finally{
                Console.WriteLine("Fim do processo");

            }

            
        }
    }
}
