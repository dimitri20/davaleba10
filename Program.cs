using System;
using System.Collections.Generic;

namespace gamocda
{
    class Program
    {

        static int vowelOrConsonant (String str) 
        {
            //int masivshi vinaxav chars radgan pirdapir ASCII - shi sheinaxos    
            int[] vowels = new int[5] {'A','E','I','O','U'};
            
            //count[0] iyos xmovani
            //count[1] iyos tanxmovani
            int vowelCount = 0;
            int consonantCount = 0;

            //gadaiyvans yvelas capital-shi
            str = str.ToUpper();

            //moacilebs yvela space-s
            str = str.Replace(" ", "");

            //nebismier simbolos garda asosa daaignorebs da sheinaxavs formattedshi
            foreach(char ch in str)
            {
                for(int i = 65; i < 65 + 26; i++)
                {
                    if(ch == Convert.ToChar(i))
                    {
                        //daivlis xmovnebis masivs
                        for(int j = 0; j < vowels.Length; j++)
                        {
                            //tu romelime aso iqneba xmovani shesruldeba piroba 
                            if(ch == Convert.ToChar(vowels[j]))
                            {
                                vowelCount++;
                            }
                        }
                    }
                }
            }

            consonantCount = str.Length - vowelCount;


            if(vowelCount > consonantCount)
            {
                return 1;
            } 
            else 
            {
                return 2;
            }
        }


        static void drawMatrix(int row, int column)
        {
            for(int i = 0; i < column; i++)
            {
                for(int j = 0; j < row; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }
        }


        static void Main(string[] args)
        {
            //xmovani da tanxmovani
            Console.WriteLine("Shemoiyvanet sityva an fraza");
            String input = Console.ReadLine();
            Console.WriteLine(vowelOrConsonant(input));




            //matricis dawera 
            Console.Write("shemoiyvanet svetebis raodenoba:  ");
            int column = Convert.ToInt32(Console.ReadLine());

            Console.Write("shemoiyvanet rigis raodenoba:  ");
            int row = Convert.ToInt32(Console.ReadLine()); 

            drawMatrix(row, column);
        }
    }
}
