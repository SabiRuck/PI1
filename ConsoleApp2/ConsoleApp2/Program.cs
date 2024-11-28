using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //setup
            StreamReader fileR = new StreamReader("project.txt");
            const int columns = 5;
            const int rows = 5;
            string[,] symbols = new string[rows,columns];
            string line,symbol;
            int x, y;

            //load file into array
            for(int i=0; i<rows;i++)
            {
                line = fileR.ReadLine();
                for(int j=0; j<columns; j++)
                { 
                    symbols[i,j] = line.Split(' ')[j];
                }
            }
            fileR.Close();
            
            //print the table
            for(int i=0; i<rows;i++)
                {
                    for(int j=0; j<columns-1; j++)
                        Console.Write(symbols[i,j] + " ");
                    Console.WriteLine(symbols[i,columns-1]);
                }
            Console.Write("\n");

            //main loop
            while(true)
            {
                //get input
                Console.Write("Enter coordinates(1-5) and symbol (X, O) in format 'x y symbol' or 'q': ");
                line = Console.ReadLine();
                Console.Write("\n");

                // if "q" -  write current table to file and quit
                if(line=="q")
                { 
                    StreamWriter fileW = new StreamWriter("project.txt");
                    for(int i=0; i<rows;i++)
                    {
                        for(int j=0; j<columns-1; j++)
                            fileW.Write(symbols[i,j] + ' ');

                        fileW.Write("{0}\n", symbols[i,columns-1]);
                    }
                    fileW.Close();
                    return;
                }

                //handle input and validate coordinates and symbol
                string[] input = line.Split(' ');
                if(input.Length != 3)
                { 
                    Console.WriteLine("!Incorrect input!\n");
                    continue;
                }
                x = Convert.ToInt32(input[0])-1;
                y = Convert.ToInt32(input[1])-1;
                symbol = input[2];

                //check if the data is correct
                if((x>columns||x<0) || (y>rows||y<0))
                { 
                    Console.WriteLine("!Incorrect coordinates!\n");
                    continue;
                }
                if(!(new List<string> { "O", "X"}).Contains(symbol))
                {
                    Console.WriteLine("!Incorrect symbol!\n");
                    continue;
                }

                //change the symbol, print the table
                symbols[x,y] = symbol;

                for(int i=0; i<rows;i++)
                {
                    for(int j=0; j<columns-1; j++)
                        Console.Write(symbols[i,j] + " ");
                    Console.WriteLine(symbols[i,columns-1]);
                }
                Console.Write("\n");
            }
        }
    }
}