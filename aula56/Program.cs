using System;
using System.Collections.Generic;

namespace aula56
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> transp = new LinkedList<string>();

            transp.AddFirst("Carro");
            transp.AddFirst("Aviao");
            transp.AddFirst("Navio");
            transp.AddFirst("Motocicleta");

            transp.AddLast("Bicicleta");

            LinkedListNode<string>no;
            no = transp.FindLast("Navio");
            transp.AddAfter(no, "Patins");
            no = transp.FindLast("Carro");
            transp.AddAfter(no, "Patinete");

            if(transp.Find("Carro") == null){
                Console.WriteLine("Não Encontrado");
            }else{
                Console.WriteLine("Elemento encontrado");
            }

            transp.Remove("Navio");


            foreach(string t in transp){
                Console.WriteLine("Transporte: {0}", t);
            }
        }
    }
}
