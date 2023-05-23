namespace Day2
{  
    class Day2
    {
        static void Main()
        {
            /*
                loss = 0
                win = 6
                draw = 3

                rock a x = 1
                paper b y = 2
                scissor c z = 3
                
                AY = 8
                AX = 3 + 1 = 4
                AZ = 0 + 3 = 3
                BY = 3 + 2 = 5
                BX = 0 + 1 = 1
                BZ = 6 + 3 = 9
                CY = 0 + 2 = 2
                CX = 6 + 1 = 7
                CZ = 3 + 3 = 6
            */
            string[] str = File.ReadAllLines("question.txt"); 
            int score = 0;
            for(int i = 0, LENGTH = str.Length; i < LENGTH ; i++)
            {
                switch(str[i])
                {
                    case "A Y": 
                        score += 8;
                        break;
                    case "A X":
                        score += 4;
                        break;
                    case "A Z":
                        score += 3;
                        break;
                    case "B Y":
                        score += 5;                        
                        break;
                    case "B X":
                        score += 1;
                        break;
                    case "B Z":
                        score += 9;                    
                        break;
                    case "C Y":
                        score += 2;                    
                        break;
                    case "C X":
                        score += 7;                    
                        break;
                    case "C Z":
                        score += 6;                    
                        break;
                }
            }

            /*
                loss = 0
                win = 6
                draw = 3

                rock a x = 1
                paper b y = 2
                scissor c z = 3
                
                AY = 2 + 6 = 8 then AX = 1 + 3 = 4
                BX = 1 + 0 = 1

                AY = 3 + 1 = 4
                AX = 3 + 0 = 3 
                AZ = 2 + 6 = 8
                
                BY = 2 + 3 = 5
                BX = 1 + 0 = 1
                BZ = 3 + 6 = 9
                
                CY = 3 + 3 = 6
                CX = 2 + 0 = 2
                CZ = 1 + 6 = 7
            */


            int newscore = 0; 
            for(int i = 0, LENGTH = str.Length; i < LENGTH ; i++)
            {
                switch(str[i])
                {
                    case "A Y": 
                        newscore += 4;
                        break;
                    case "A X":
                        newscore += 3;
                        break;
                    case "A Z":
                        newscore += 8;
                        break;
                    case "B Y":
                        newscore += 5;                        
                        break;
                    case "B X":
                        newscore += 1;
                        break;
                    case "B Z":
                        newscore += 9;                    
                        break;
                    case "C Y":
                        newscore += 6;                    
                        break;
                    case "C X":
                        newscore += 2;                    
                        break;
                    case "C Z":
                        newscore += 7;                    
                        break;
                }
            }
            Console.WriteLine(newscore);
        }
    }
}