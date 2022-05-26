using System;
using System.Collections.Generic;

namespace FreqCalculation
{
    class Program
    {
        static void displayFreqOfEachElement(int [] arr)
        {
            Dictionary<int,int> freqDictionary = new Dictionary<int,int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (freqDictionary.ContainsKey(arr[i]))
                {
                    freqDictionary[arr[i]]++;
                }else{
                    freqDictionary[arr[i]]=1;
                }
            }

            foreach (KeyValuePair<int,int> x in freqDictionary)
            {
                Console.WriteLine(x.Key + "-->" + x.Value);
            }
        }

        static void Main(string[] args)
        {
             displayFreqOfEachElement(new int [] {1,1,1,3,4,5,6,6,8,9,0,3,2,2,24,3,2});
        }
    }
} 
