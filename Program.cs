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


            for(int contador = 10; contador >=1; contador--)
            { 
                // Código a se repetir
                
                resultado = resposta * contador;
                Console.WriteLine($"{resposta} * {contador} = {resultado}");
                System.Threading.Thread.Sleep(1000);
            }
           }
            
            


            
           
        }
    }
