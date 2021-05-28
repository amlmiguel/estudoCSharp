using System;

class Jogador {
    private int energia;
    private string nome;

    public Jogador(){
        energia = 100;
    }

    //Como os atributos energia e nome são private temos que criar um método para poder acessa-los

    public int getEnergia(){
        return energia;
    }

    public string getNome(){
        return nome;
    }

    public void setName(string nome ){
        if(nome.Length > 10){
            this.nome = null;
            Console.WriteLine("O nome é muito grande");
        }else{
            this.nome = nome;
            Console.WriteLine("Nome cadastrado com sucesso");
        }

    }
    public void setEnergia(int e){
        if(e<0){
            if(energia + e < 0){
                energia = 0;
            }else{
                energia += e;
            }

        }else if(e>0){
            if(energia + e > 100){
                energia = 100;
            }else{
                energia += e;
            }

        }
    }
}


class Aula33 {
    static void Main(){
        Jogador j1 = new Jogador();
        
        j1.setName("Satoshi");
        j1.setEnergia(-10);
        Console.WriteLine("Nome...: {0}", j1.getNome());
        Console.WriteLine("Energia: {0}", j1.getEnergia());
    }
}