using System;

class opçoes{
    static void Main(){

        int opcao;
         Console.WriteLine("\nESCOLHA UMA OPÇÃO:\n\n(1) Para casa, (2)Para apartamento e (3) Para barraco:");

       opcao=int.Parse(Console.ReadLine());
switch (opcao)
{
    case 1:
    Console.WriteLine("OK, VAMOS PARA CASA!");
    break;

    case 2:
    Console.WriteLine("QUE CHIQUE VOCÊ HEIN!");
    break;
    case 3:
    Console.WriteLine("POBRE!");
    break;

default:
{
    Console.WriteLine("PÔ ESCOLHE CERTO");
    break;
}
}

    }
}