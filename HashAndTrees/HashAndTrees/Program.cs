using System;
namespace HashAndTrees
{
    class Program
    {
        static void Main()
        {
            string statement ="To be Or Not To be";
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
        }
    }
}