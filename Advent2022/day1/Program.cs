namespace Day1{
    class Day1{

        static int caloriesCount(string[] num)
        {
            int count = 0;
            for(int i = 0, LENGTH = num.Length; i < LENGTH ; i++)
            {
                if(num[i] == "")count++;
            }
            return count;
        }  

        static int threeHighestCalories(int[] nums)
        {
            Array.Sort(nums);
            Array.Reverse(nums);
            int totalcalories = 0;
            for(int i = 0; i <= 2; i++)
            {
                Console.WriteLine(nums[i]);
                totalcalories += nums[i];
            }
            return totalcalories;
        }
        static void Main()
        {
            string[] calories = File.ReadAllLines("question.txt");
            
            int[] intcalories = new int[caloriesCount(calories)];
            
            int current = 0;
            int Length = 0;
            for(int i = 0, LENGTH = calories.Length; i < LENGTH ;i++)
            {
                if(calories[i] != "")
                {
                    current += int.Parse(calories[i]); 
                    continue;
                }
                intcalories[Length] = current;
                Length++;
                current = 0;
            }
            // Console.WriteLine(intcalories.Max());
            Console.WriteLine(threeHighestCalories(intcalories));
        }
    }
}