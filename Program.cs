using System;

namespace Do_While_For
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Deseja ver a tabuada de qual número?");
            int resposta = int.Parse(Console.ReadLine());

           for(int rp = 1; rp <=10; rp++)
            { 
                Console.WriteLine($"{resposta} * {rp} = {resposta * rp}");
                System.Threading.Thread.Sleep(1000);
                
                // $ = Interpolação 
                // rp de resposta

            } 
            

           
            
           }
            
            


            
           
        }
    }
