using System;

namespace aula42
{
    class Carro{
        private int[] velMax = new int[5]{80,120,160,240,300};

        public int this[int i]{
            get{
                return velMax[i];
            }
            set{
                if(value < 0){
                    velMax[i] =0;
                }else if(value > 300){
                    velMax[i] = 300;
                }else{
                    velMax[i] = value;
                }

            }
        }

        public Carro(){
        }

        

    }
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();

            c1[3] = 200; //usa o acessor set
            Console.WriteLine("Velocidade: {0}", c1[3]); //usa o acessor get
        }
    }
}

