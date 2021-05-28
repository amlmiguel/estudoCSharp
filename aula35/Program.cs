using System;

    class Veiculo //Classe base
    {   
        private int rodas;
        public int velMax;
        private bool ligado;

        public void ligar(){
            ligado = true;
        }

        //Construtores ===================
        public Veiculo(int rodas){
            this.rodas = rodas;
        }

        //Métodos ===========================

        public int getRodas(){
            return rodas;
        }

        public void setRodas(int rodas){
            if(rodas < 0){
                this.rodas = 0;
            }else if(rodas > 40){
                this.rodas = 40;
            }
        }
        public void desligar(){
            ligado = false;
        }

        public string getLigado(){
            return (ligado ? "sim" : "não");
           
        }
       
    }

    class Carro:Veiculo{ // Classe derivada
        public string nome;
        public string cor;
        public Carro(string nome, string cor):base(4){
            ligar();
            velMax = 120;
            this.nome = nome;
            this.cor = cor;
        }
    }

    class CarroCombate:Carro{
        public int municao;
        
        // Construtor

        public CarroCombate():base("carro de combate","verde"){
            municao = 100;
            setRodas(6);
        }

        
    }

    class Aula34 {

            static void Main(){
            Carro c1 = new Carro("Rapidão","Vermelho");
            CarroCombate cc1 = new CarroCombate();

            Console.WriteLine("Cor: {0}", c1.cor);
            Console.WriteLine("nome: {0}", c1.nome);
            Console.WriteLine("rodas: {0}", c1.getRodas());
            Console.WriteLine("vel. max: {0}", c1.velMax);
            Console.WriteLine("Ligado: {0}", c1.getLigado());

            Console.WriteLine("------------------------------------");

            Console.WriteLine("Cor: {0}", cc1.cor);
            Console.WriteLine("nome: {0}", cc1.nome);
            Console.WriteLine("rodas: {0}", cc1.getRodas());
            Console.WriteLine("vel. max: {0}", cc1.velMax);
            Console.WriteLine("Ligado: {0}", cc1.getLigado());
            Console.WriteLine("municao: {0}", cc1.municao);

        }
    }

