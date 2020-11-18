using System;

namespace Do_While_For
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Deseja qual número?");
            int resposta = int.Parse(Console.ReadLine());

           for(int r = 0; r <=10; r++)
            { 
                Console.WriteLine($"{resposta} * {r} = {resposta * r}");
                // $ = Interpolação 
                // r de resposta
            } 
            

           
            
           }
            
            


            
           
        }
    }
