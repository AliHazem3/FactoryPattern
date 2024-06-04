using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using static C__Studing.Program;
using System;
using System.Reflection;
using System.Text;
using System.Collections;

namespace C__Studing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cardNumber, bankcode;
            Bank_Factory bank_factory = new Bank_Factory();


            Console.WriteLine("Enter your card Number");
            cardNumber=Console.ReadLine();
            bankcode = cardNumber.Substring(0, 6);
            IBank_Product bank= bank_factory.GetBank(bankcode);
            Console.WriteLine(bank.withdrow());


        }
    }
}




        /*
        static int max(int[] arr)
        {

            int counter = 0;
            int maxcounter = 0;
            int mostsecti = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != arr[i - 1])
                {
                    counter = 0;
                }
                else
                {
                    counter++;
                }
                
                if(counter > maxcounter)
                {
                    maxcounter = counter;

                    mostsecti = arr[i];
                }
                    
            }

            return mostsecti;
        }
        







        /*
        static int GetMaxNumber(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("The array is null or empty.");
            }

            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }


        ###############

        class Sort
        {   

            public void sort(int[] arr)
            {
                int n = arr.Length;
                // One by one move boundary of unsorted subarray 
                for (int i = 0; i < n - 1; i++)
                {
                    // Find the minimum element in unsorted array 
                    int min_idx = i;
                    for (int j = i + 1; j < n; j++)
                        if (arr[j] < arr[min_idx])
                            min_idx = j;

                    // Swap the found minimum element with the first 
                    // element 
                    int temp = arr[min_idx];
                    arr[min_idx] = arr[i];
                    arr[i] = temp;
                }
            }

            // Prints the array 
            public void printArray(int[] arr)
            {
                int n = arr.Length;
                for (int i = 0; i < n; ++i)
                    Console.Write(arr[i] + " ");
                Console.WriteLine();
            }
        }

         */








 