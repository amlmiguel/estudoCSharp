using System;

class Base {
    
    public Base(){
        Console.WriteLine("Construtor da classe base");
    }

    virtual public void info(){ // virtual posbilita a subescricao do metodo
        Console.WriteLine("base");
    }


}

class Derivada1:Base{

    public Derivada1(){
        Console.WriteLine("Construtor da classe derivada 1");
    }

     override public void info(){
        Console.WriteLine("derivada 1");
    }

}

class Derivada2:Derivada1{

    public Derivada2(){
        Console.WriteLine("Construtor da classe derivada 2");
    }

     override public void info(){
        Console.WriteLine("derivada 2");
    }

}

class Aula38 {
    static void Main(){
        Base Ref;
        Derivada1 derivada1 = new Derivada1();
        Derivada2 derivada2 = new Derivada2();
        Ref = derivada1;
        Ref.info();


    }
}

// A ordem sempre é da classe base para a classe derivada