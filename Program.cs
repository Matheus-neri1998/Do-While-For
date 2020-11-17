using System;

namespace Do_While_For
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Deseja ver a tabuada de qual número?");
            int resposta = int.Parse(Console.ReadLine());

            int resultado;


            do
            {
            for(int contador = 1; contador <=10; contador++)
            { 
                // Código a se repetir
                resultado = resposta * contador;
                Console.WriteLine($"{resposta} * {contador} = {resultado}");
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine("Novo cálculo");

            }while(resposta != 10);
            
           }
            
            


            
           
        }
    }
