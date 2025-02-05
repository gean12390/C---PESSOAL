using System;

class mp{
    static void Main(){
        Console.WriteLine("Qual o seu nome?");
        String nome = Console.ReadLine();
        Console.WriteLine("Qual a sua idade?");
        int idade = int.Parse(Console.ReadLine());
        Console.WriteLine($"Seu nome é {nome} e sua idade é {idade}");
    }
}