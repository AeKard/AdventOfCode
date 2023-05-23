using System.Collections.Generic;
namespace  day5
{
    class day5
    {
        static (int StorageLength, int gap) textfile(string[] lines)
        {
            string numbers = "";
            int gap = 0;
            for(int index = 0; index < lines.Length ;index++)
            {
                if(lines[index] == "")
                {
                    break;
                }
                gap++;
            }
            
            foreach(char i in lines[gap-1])
            {
                if(i >= 48) numbers+= i;
            }
    
            return (numbers.Length,gap);
        }

        // static List<string> convertingToList(string[] OriginalList)
        // {

        // }
        static List<string[]> sortingAlgo(List<List<string>> storage, int start,string[] lines)
        {
            List<string[]> sortedStorage = new List<string[]>();
            int gap = textfile(lines).gap;
            int index = 0;
            //CALL THE MOVEMENT HERE
            foreach(string i in lines)
            {
                if(index > start - 1)
                {
                    int move = movement(i).move;
                    int from = movement(i).from;
                    int to = movement(i).to;
                
                    for(int numberOfMove = 0; numberOfMove < move;numberOfMove++)
                    {
                        // storage[to].Add(storage[from]);
                    }
                }
                index++;
            }
            Console.WriteLine(string.Join(",",storage[0]));
            return sortedStorage;
        }
        static (int move, int from, int to) movement(string line)
        {
            int[] arrayOfMoves = new int[3]; 

            var parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            arrayOfMoves[0] = int.Parse(parts[1]);
            arrayOfMoves[1] = int.Parse(parts[3]);
            arrayOfMoves[2] = int.Parse(parts[5]);
            //Console.WriteLine(string.Join(",",arrayOfMoves)); // pritns the movement
            return(arrayOfMoves[0], arrayOfMoves[1], arrayOfMoves[2]);
        }

        static int IndividualStorage(int numberOfList, string[] lines)
        {
            List<List<string>> Storage = new List<List<string>>();

            for(int i = 0; i < numberOfList ;i++) // adding the compartment to storage
            {
                Storage.Add(lines[i].Split(' ').ToList());
            }

            // CALL SORTING ALGO HERE!!!!
            sortingAlgo(Storage,textfile(lines).gap, lines);
            return 1;
        }
        static void Main()
        {
            string[] lines = File.ReadAllLines("question.txt");
            
            Console.WriteLine(IndividualStorage(textfile(lines).StorageLength,lines));
        }
    }
}