using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_bulls_and_cows
{
    class Program
    {
        /*
         static void Main(string[] args)
        {

            String[,] arr_mb = new String[10000, 4];
            int len = 10000;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        for (int l = 0; l < 10; l++)
                        {
                            if ((i == j) || (j == k) || (k == l)||(i == k) || (j == l) || (i == l))
                            { len--; } else
                            {
                                arr_mb[i * 1000 + j * 100 + k * 10 + l, 0] = i.ToString();
                                arr_mb[i * 1000 + j * 100 + k * 10 + l, 1] = j.ToString();
                                arr_mb[i * 1000 + j * 100 + k * 10 + l, 2] = k.ToString();
                                arr_mb[i * 1000 + j * 100 + k * 10 + l, 3] = l.ToString();
                            }


                        }


                    }


                }
            }


            Console.WriteLine("Rest is " + len + " rows");

            
        string inputString = "";
        Console.WriteLine("Game is started!!! (Write 'exit' to left the game)");
            while (inputString != "exit")
            {
                string bulls, cows;
        int bulls1, cows1;


        Console.WriteLine("Input 4 numbers");
                String[] mas = new String[4];
        bulls = "0";
                cows = "0";
                bulls1 = 0;
                cows1 = 0;
                for (int g = 0; g< 4; g++)
                {

                    mas[g] = Console.ReadLine().ToString();


    }
    bulls= Console.ReadLine().ToString();
    cows = Console.ReadLine().ToString();

                for (int a = 0; a< 10*9*8*7; a++)
                {

                    for (int b = 0; b< 4; b++)
                    {

                        if (arr_mb[a, b] == mas[b]) { bulls1++; }
                        else if ((arr_mb[a, b] == mas[0]) || (arr_mb[a, b] == mas[1]) || (arr_mb[a, b] == mas[2]))
{
    cows1++;
}
                        


                    }
                    if ((bulls != bulls1.ToString()) || (cows != cows1.ToString())) { if (arr_mb[a, 0] == "") { arr_mb[a, 0] = ""; arr_mb[a, 1] = ""; arr_mb[a, 2] = ""; arr_mb[a, 3] = ""; } else { arr_mb[a, 0] = ""; arr_mb[a, 1] = ""; arr_mb[a, 2] = ""; arr_mb[a, 3] = ""; len--; } }


                }

                Console.WriteLine("Rest is " + len + " rows");



            }


        }
*/
        static void Main(string[] args)
        {

            String[,] arr_mb = new String[10000, 4];
            int len = 10000;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        for (int l = 0; l < 10; l++)
                        {
                            if ((i == j) || (j == k) || (k == l) || (i == k) || (j == l) || (i == l))
                            { len--; }
                            else
                            {
                                arr_mb[i * 1000 + j * 100 + k * 10 + l, 0] = i.ToString();
                                arr_mb[i * 1000 + j * 100 + k * 10 + l, 1] = j.ToString();
                                arr_mb[i * 1000 + j * 100 + k * 10 + l, 2] = k.ToString();
                                arr_mb[i * 1000 + j * 100 + k * 10 + l, 3] = l.ToString();
                            }


                        }


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


                Console.WriteLine("Input 4 numbers");
                String[] mas = new String[4];
                bulls = "0";
                cows = "0";
                bulls1 = 0;
                cows1 = 0;
                for (int g = 0; g < 4; g++)
                {

                    mas[g] = Console.ReadLine().ToString();

                    
                }
                bulls= Console.ReadLine().ToString();
                cows = Console.ReadLine().ToString();
                int len_mb = 0;
                for (int a = 0; a < 10000; a++)
                {
                    bulls1 = 0;
                    cows1 = 0;
                    for (int b = 0; b < 4; b++)
                    {

                        if (arr_mb[a, b] == mas[b]) { bulls1++; } 
                        else if ((arr_mb[a, b] == mas[0])|| (arr_mb[a, b] == mas[1]) || (arr_mb[a, b] == mas[2]) || (arr_mb[a, b] == mas[3]))
                        {
                            cows1++;
                        }
                        


                    }

                    if ((bulls == bulls1.ToString()) && (cows == cows1.ToString())) { len_mb++; } else { arr_mb[a, 0] = ""; arr_mb[a, 1] = ""; arr_mb[a, 2] = ""; arr_mb[a, 3] = ""; len--;  }


                }


                int counter=0;
                bool check = false;
                for (int i = 0; i < 10000; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (arr_mb[i, 0] != "") { counter++; Console.Write("{0}\t", arr_mb[i, j]); check = true; }
                        
                    }
                    if (check) { Console.WriteLine(); check = false; }
                }
                Console.WriteLine("There is " + len_mb + " possible variants.");
                

            }


        }
    }
}
