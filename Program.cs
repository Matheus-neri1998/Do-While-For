using System;

namespace Do_While_For
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Deseja ver a tabuada de qual número?");
            int resposta = int.Parse(Console.ReadLine());
            System.Threading.Thread.Sleep(700);

           for(int rp = 0; rp <=10; rp++)
            { 
                Console.WriteLine($"{resposta} * {rp} = {resposta * rp}");
                
                // $ = Interpolação 
                // rp de resposta

            } 
            

           
            
           }
            
            


            
           
        }
    }
