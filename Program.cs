using System;

namespace Do_While_For
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Deseja ver a tabuada de qual número?");
            int resposta = int.Parse(Console.ReadLine());
            System.Threading.Thread.Sleep(1000);

           for(int r = 0; r <=10; r++)
            { 
                Console.WriteLine($"{resposta} * {r} = {resposta * r}");
                // $ = Interpolação 
                // r de resposta
            } 
            

           
            
           }
            
            


            
           
        }
    }
