using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_bulls_and_cows
{
    class Program
    {
        
        static void Main(string[] args)
        {

            String[,] arr_mb = new String[100, 2];
            int len = 100;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == j)
                            { len--; } else
                            {
                                arr_mb[i * 10 + j, 0] = i.ToString();
                                arr_mb[i * 10 + j, 1] = j.ToString();
                            }



                }
            }


            Console.WriteLine("Rest is " + len + " rows");

            /*
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("{0}\t", arr_mb[i, j]);
                }
                Console.WriteLine();
            }
            */
            string inputString = "";
            Console.WriteLine("Game is started!!! (Write 'exit' to left the game)");
            while (inputString != "exit")
            {
                string bulls, cows;
                int bulls1, cows1;


                Console.WriteLine("Input 2 numbers");
                String[] mas = new String[2];
                bulls = "0";
                cows = "0";
                bulls1 = 0;
                cows1 = 0;
                for (int g = 0; g < 2; g++)
                {

                    mas[g] = Console.ReadLine().ToString();

                    
                }
                bulls= Console.ReadLine().ToString();
                cows = Console.ReadLine().ToString();
                int len_mb = 0;
                for (int a = 0; a < 100; a++)
                {
                    bulls1 = 0;
                    cows1 = 0;
                    for (int b = 0; b < 2; b++)
                    {

                        if (arr_mb[a, b] == mas[b]) { bulls1++; } 
                        else if ((arr_mb[a, b] == mas[0])|| (arr_mb[a, b] == mas[1])){
                            cows1++;
                        }
                        


                    }
                    /*
                    Console.WriteLine("Number is " + arr_mb[a, 0] + arr_mb[a, 1]);
                    Console.WriteLine("Bulls is " + bulls );
                    Console.WriteLine("Cows is " + cows);
                    Console.WriteLine("Bulls1 is " + bulls1);
                    Console.WriteLine("Cows is " + cows1);
                    Console.WriteLine("");*/

                    if ((bulls == bulls1.ToString()) && (cows == cows1.ToString())) { len_mb++; } else { arr_mb[a, 0] = ""; arr_mb[a, 1] = "";  len--;  }


                }

                Console.WriteLine("Rest is "+len+" rows");
                Console.WriteLine("len_mb is " + len_mb + " rows");

                int counter=0;
                bool check = false;
                for (int i = 0; i < 100; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        if (arr_mb[i, 0] != "") { counter++; Console.Write("{0}\t", arr_mb[i, j]); check = true; }
                        
                    }
                    if (check) { Console.WriteLine(); check = false; }
                }
                Console.WriteLine("counter is " + counter/2 + " rows");
                

            }


        }
    }
}
