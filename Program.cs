/*
 * A program to demonstrate how to create a one dimensional array in C#.
 * Written by Jacob Seadorf on October 15, 2018
 * 
 * Success Criteria: Create an array of integers with 100 elements, and fill it with 
 * random numbers. Then find the mean, median and mode of the elements.
 */

using System;

namespace Arrays_NET_Core {
    class Program {
        //create an integer array 
      static int[] randNums = new int[100];

        //create a random number generator
       static Random RNG = new Random();

        static int Main(string[] args) {
            findMean();
            findMedian();
            findMode();
            Console.ReadLine();
            return 0;
        }

        static void findMean() {
            //interate through each element in the array
            for(int i = 0; i < 100; i++) {
                randNums[i] = RNG.Next(100);
            }

            //add each element in the array to sum. 
            int sum = 0;
            for(int j = 0; j < 100; j++) {
                sum = sum + randNums[j];
            }

            double dAverage = sum / 100.0;
            Console.WriteLine("The average is {0}", dAverage);
        }

        static void findMedian() {
            //sort the array in numerical order
            Array.Sort(randNums);
            Console.WriteLine("The median is: {0}", randNums[49] + randNums[50] / 2);
        }

        static void findMode() {
            //create a new array to count the amount of numbers 
            int[] count = new int[100];

            int newInd; //new index
            for(int i = 0; i < 100; i++) {
                newInd = randNums[i];
                count[newInd]++;
            }

            int maxValue = 0;
            int mode = 0;

            for(int j = 0; j < 100; j++) {
                if(count[j] > maxValue) {
                    maxValue = count[j];
                    mode = j;
                }               
            }
            Console.WriteLine("the mode is: {0} with the value of {1}", mode, maxValue);
        }
    }
}
