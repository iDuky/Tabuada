﻿using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
           int numero;
        //    Limpar a tela de console
        Console.Clear();
        Console.WriteLine("########################################");
        Console.WriteLine("#        Programa de Tabuada           #");
        Console.WriteLine("########################################");
        Console.WriteLine();
        Console.WriteLine("Digite um numero > ");
        numero = int.Parse(Console.ReadLine());


        for(int x = 0; x <= 10; x++){
            Console.WriteLine(numero+" x "+x+" = "+numero*x);
        }
        }
    }
}
