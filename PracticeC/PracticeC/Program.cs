using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PracticeC
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
                 Random question = new Random();
                 
                 string[] array = new string[5];
                 array[0] = "-What is the capital of France";
                 array[1] = "-What is the capital of Spain";
                 array[2] = "-What is the captial of Russia";
                 array[3] = "-What is the capital of Ukraine";
                 array[4] = "-What is the capital of Egypt";

                 string[] answer = new string[5];
                 answer[0] = "Paris";
                 answer[1] = "Madrid";
                 answer[2] = "x";
                 answer[3] = "Kiev";
                 answer[4] = "Cairo";

            ArrayList rep = new ArrayList();


            int score = 0;
            int cou = 0;
            while (cou < 3) {
                int x = question.Next(5);
                if (rep.Contains(x))
                {
                    // int y = question.Next(5);
                    // Console.WriteLine(array[y]+" "+y);
                    
                }
                else {
                    Console.WriteLine(array[x] );
                    string a = Console.ReadLine();
                    if (a == answer[x])
                    {
                        Console.WriteLine("Correct answer");
                        score = score + 10;
                    }
                    else {
                        Console.WriteLine("Incorrect answer");
                    }
                    rep.Add(x);
                    cou++;
                }
               
                Console.WriteLine(cou);
                Console.WriteLine();
                
            }

            Console.WriteLine("score = "+score+"/30");

            /*
            for (int i = 0; i < rep.Count; i++)
            {
                Console.WriteLine(rep[i]);
            }
            */

        }

    }
    
}
