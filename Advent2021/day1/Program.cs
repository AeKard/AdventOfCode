using System;
namespace AdventOfCode
{
    class adventofcode{

        static int SonarSweep(int[] arr)
        {
            int num = 0;
            for(int i = 1;i < arr.Length ;i++)
            {
                int result = (arr[i-1] < arr[i])? num+=1: 0;
            }
            return num;
        }

        static int SonarSweep2(int[] arr)
        {
            int count = 0;
            int currentNum = 0, NextNum = 0;
            for(int i = 0;i < arr.Length-2 ;i++)
            {
                for(int j = i; j < i + 3; j++)
                {
                    currentNum += arr[j];
                    Console.WriteLine(currentNum );
                    Console.WriteLine(currentNum < NextNum);
                    if() NextNum = currentNum; 
                }
                Console.WriteLine('/');
                currentNum *= 0;
            }
            return 1;
        }
        static void Main(){

            string[] array = File.ReadAllLines("file.txt"); 

            int[] newarray = new int[array.Length];
            for(int i = 0;i < array.Length ;i++)
            {
                newarray[i] = int.Parse(array[i]);
            }

            Console.WriteLine(SonarSweep2(newarray));
        }
    }
}