
using classeheranca;

namespace classeheranca
{
    
    // Classe base (superclasse)
    internal class Animal
    {
        // Propriedade da classe Animal
        public string Nome { get; set; }

        // Método que será sobrecarregado nas classes derivadas
        public virtual void EmitirSom()
        {
            Console.WriteLine("O animal emite um som.");
        }
    }

    // Classe derivada (subclasse)
    internal class Cachorro : Animal
    {
        // Sobrescrevendo o método EmitirSom
        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} late: Au Au!");
        }
    }

    // Outra classe derivada
    internal class Gato : Animal
    {
        // Sobrescrevendo o método EmitirSom
        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} mia: Miau!");
        }
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        // Criando instãncias das classes derivadas
        Animal meuCachorro = new Cachorro { Nome = "Rex" };
        Animal meuGato = new Gato { Nome = "Felix" };

        // Chamando o método EmitirSom para cada animal
        meuCachorro.EmitirSom();    // Saída: Rex late: Au Au!
        meuGato.EmitirSom();        // Saída: Felix mia: Miau!

        // Utilizando polimorfismo : Array de animais
        Animal[] animals = { meuCachorro, meuGato };

        foreach (var animal in animals)
        {
            animal.EmitirSom(); // Cada objeto chama o método adequado de sua classe
        }
    }
}