namespace Day4
{
    class Day4
    {
        
        static (int start, int end) ReadInterval(string assignment)
        {
            var intervalParts = assignment.Split('-');
            return (int.Parse(intervalParts[0]), int.Parse(intervalParts[1]));
        }


        static int ifContain(int[] numberset)
        {
            int result = 0;
            int LENGTH = numberset.Length;
            bool ctr1 = false;
            bool ctr2 = false;
            for(int index = 0; index < LENGTH / 2 ;index++)
            {
                for(int secondindex = 2; secondindex < LENGTH ;secondindex++)
                {
                    if(index == 0)
                    {
                        if(numberset[index] <= numberset[secondindex])ctr1 = true;
                    }
                    if(index == 1)
                    {   
                        if(numberset[index] <= numberset[secondindex])ctr2 = true;
                    }
                    if(ctr1 && ctr2) result++;
                }
            }
            return result;
        }
        
        static int numberset(string rawset)
        {
            int LENGTH = rawset.Length;
            int[] numberset = new int[4];
            int currentindex = 0;
            
            
            string current = "";
            // [98 - 99, 3 - 97]
            for(int index = 0; index < LENGTH ; index++)
            {
                // numberset[index] = int.Parse(rawset[index]);
                // Console.WriteLine(rawset[index]);
                if(rawset[index] >= 48) current += Convert.ToString(rawset[index]); // grouping numbers
                if(rawset[index] == 44 || rawset[index] == 45 || index == LENGTH -1) 
                {
                    numberset[currentindex] = int.Parse(current); //inserting in array
                    currentindex ++; // adding index in numberset
                    current = ""; // reset current num
                }
            }
            return ifContain(numberset);
        }
        static void Main()
        {
            string[] setOfNumbers = File.ReadAllLines("question.txt");
            int result = 0;
            int overlapresult = 0;
            foreach(string sets in setOfNumbers)
            {
                var arrayOfSet = sets.Split(",");
                var interval1 = ReadInterval(arrayOfSet[0]);
                var interval2 = ReadInterval(arrayOfSet[1]);
                
                // int result = 0;
                if((interval1.start <= interval2.start && interval2.end <= interval1.end) 
                            || (interval2.start <= interval1.start && interval1.end <= interval2.end)) 
                {
                    result++;
                }

                if((interval1.start <= interval2.end && interval1.end >= interval2.start))
                {
                    overlapresult++;
                }

            }
            Console.WriteLine($"How many sets contain each other? = {result} and how many sets overlaps {overlapresult}");

            // using (StreamReader reader = new StreamReader("question.txt"))
            // {
            //     string line;
            //     while((line = reader.ReadLine()) != null) Console.WriteLine(line);
            // }




            // string[] setOfNumbers = File.ReadAllLines("question.txt");
            // int LENGTH = setOfNumbers.Length;
            
            // for(int index = 0; index < LENGTH ;index++)
            // {
            //     Console.WriteLine(numberset(setOfNumbers[index]));
            // }
        }
    }
}