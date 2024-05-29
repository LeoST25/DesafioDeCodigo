using System;

class Program {
    static bool VerificarAtributo(string atributo, int valorMinimo, int valorMaximo, int valorAtributo) {
        // Implementa a função VerificarAtributo
        if (valorAtributo >= valorMinimo && valorAtributo <= valorMaximo) {
            return true;
        }
        return false;
    }

    static void Main(string[] args) {
        Console.WriteLine("Digite o nome do atributo:");
        string atributo = Console.ReadLine();

        Console.WriteLine("Digite o valor mínimo do atributo:");
        int valorMinimo = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor máximo do atributo:");
        int valorMaximo = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor atual do atributo:");
        int valorAtributo = int.Parse(Console.ReadLine());

        bool resultado = VerificarAtributo(atributo, valorMinimo, valorMaximo, valorAtributo);
        if (resultado) {
            Console.WriteLine($"O valor do atributo {atributo} está dentro do intervalo.");
        }
        else {
            Console.WriteLine($"O valor do atributo {atributo} está fora do intervalo.");
        }
    }
}

