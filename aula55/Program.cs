using System;
using System.Collections.Generic;

namespace aula55
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary <int, string> veiculos = new Dictionary<int, string>();

            veiculos.Add(10, "Carro");
            veiculos.Add(5, "Aviao");
            veiculos.Add(0, "Navio");
            veiculos.Add(20, "Moto");
            veiculos.Add(15, "Patinete");

            //veiculos.Clear();

            veiculos.Remove(20);
            Console.WriteLine("Tamanho do Dictionary: {0}", veiculos.Count);
            int chave = 20;
            if(veiculos.ContainsKey(chave)){
                Console.WriteLine("A chave {0} está na coleção", chave);
            }else{
                Console.WriteLine("A chave {0} não está na coleção", chave);
            }

            veiculos[15] = "bike";

            string valor = "bike";
            if(veiculos.ContainsValue(valor)){
                Console.WriteLine("O valor {0} está na coleção", valor);
            }else{
                Console.WriteLine("O valor {0} não está na coleção", valor);
            }

            foreach(KeyValuePair<int,string> v in veiculos){
                Console.WriteLine(v.Value);
                Console.WriteLine(v.Key);
            }
                
            
        
        }
    }
}
