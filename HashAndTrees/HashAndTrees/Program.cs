﻿using System;
using System.Xml.Linq;

namespace HashAndTrees
{
    class Program
    {
        static void Main()
        {
           /* string statement = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
             string[] sentence = statement.Split(" ");
             MyMapNode<string, string> hash = new MyMapNode<string, string>(sentence.Length);
             for (int i = 0; i < sentence.Length; i++)
             {
                 hash.Add(Convert.ToString(i), sentence[i]);
             }
             for (int i=0;i<sentence.Length;i++)
             {
                 int Count = 1;
                 for (int j = i+1; j < sentence.Length; j++)
                 {
                     if (hash.get(Convert.ToString(i)) == hash.get(Convert.ToString(j)))
                     {
                         Count++;
                         sentence[j] = null;
                     }
                 }
                 if (sentence[i]!=null)
                     Console.WriteLine("The Frequency of the Word " + sentence[i] + " is " + Count);
             }
             string word = "avoidable";
             int count = 0;
             for (int i = 0; i < sentence.Length; i++)
             {
                 if(hash.get(Convert.ToString(i)) == word)
                 {
                     hash.Remove(Convert.ToString(i));
                     count++;
                 }
             }
             if(count==0)
                 Console.WriteLine("You Entered the Wrong Word. Enter the correct word to Remove");
         }*/


            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            binarySearch.Insert(22);
            binarySearch.Insert(40);
            binarySearch.Insert(60);
            binarySearch.Insert(95);
            binarySearch.Insert(11);
            binarySearch.Insert(65);
            binarySearch.Insert(3);
            binarySearch.Insert(16);
            binarySearch.Insert(63);
            binarySearch.Insert(67);
            binarySearch.Display();
            binarySearch.GetSize();
            bool result = binarySearch.IfExists(67, binarySearch);
        }
    }
}