namespace Day3{
    class Day3
    {
        static int getletterthree(string[] arrayOfracksack)
        {
            int sum = 0;
            string repeatedchar = "";
            string  currentracksack = "";
            int everythirdrack = 0;
            int count = 0;
            foreach(string racksack in arrayOfracksack)
            {
                // Console.WriteLine(racksack);
                if(currentracksack != "") //cheking 1st and 2nd racksack for accurence.
                {
                    if(count == everythirdrack - 2)
                    {
                        for(int racksackindex = 0; racksackindex < currentracksack.Length ;racksackindex++)
                        {
                            for(int secondrackindex = 0; secondrackindex< racksack.Length;secondrackindex++)
                            {
                                if(currentracksack[racksackindex] == racksack[secondrackindex]) repeatedchar += currentracksack[racksackindex];
                                // add the letter in repeatedchar! if same
                            }
                        }
                    }
                    if(count == everythirdrack - 1) // cheking repeated char with 3rd racksack.
                    {
                        for(int racksackindex = 0, LENGTH = repeatedchar.Length; racksackindex < LENGTH;racksackindex++)
                        {
                            for(int thirdrack = 0; thirdrack < racksack.Length ;thirdrack++)
                            {
                                if(repeatedchar[racksackindex] == racksack[thirdrack]) // return the letter
                                {
                                    if(repeatedchar[racksackindex] >= 97) sum += repeatedchar[racksackindex] - 96;
                                    else sum += repeatedchar[racksackindex] - 38;
                                    LENGTH = 0;
                                    break;
                                }
                            }
                        }
                    }
                }
                if(count == everythirdrack && everythirdrack <= arrayOfracksack.Length)
                {
                    repeatedchar = "";
                    currentracksack = ""; // empty racksack
                    for(int racksackindex = 0; racksackindex < racksack.Length ;racksackindex++)
                    {
                        currentracksack += racksack[racksackindex]; //insert racksack individual index
                    }
                    everythirdrack+=3; //every third step
                }
                count++; // steps or every racksack index
            }


            // for(int i = 0; i < str.Length; i+=3) // i racksack
            // {
            //     for(int j = i; j < i + 2;j++)
            //     {
            //         for(int letterOne = 0; letterOne < str[j].Length; letterOne++)
            //         {
            //             for(int letterTwo = 0; letterTwo < str[j + 1].Length;letterTwo++)
            //             {
            //                 Console.Write($"{str[j][letterOne]} < {str[j+1][letterTwo]} ");
            //             }
            //         }
            //         Console.WriteLine("/");
            //     }
            // }
            return sum;
        }
        static char getLetter(string str)
        {
            char letter = ' ';
            for(int j = 0, HALF = str.Length / 2; j < HALF; j++)
            {
                for(int l = HALF,varLENGTH = str.Length; l < varLENGTH; l++)
                {
                    if(str[j] == str[l])
                    {
                        letter = str[j];
                        break;
                    } 
                }
            }
            
            return letter;
        }
        static void Main()
        {
            string[] str = File.ReadAllLines("question.txt"); 

            Console.WriteLine(getletterthree(str));
            // int total = 0;
            // for(int i = 0; i < str.Length; i++)
            // {
            //     if(getLetter(str[i]) >= 97) total += getLetter(str[i]) - 96;
            //     else total += getLetter(str[i]) - 38;
            //     Console.Write($"{getLetter(str[i]) >= 97} ,");
            //     Console.WriteLine(total);
            // }
        }   
    }
}