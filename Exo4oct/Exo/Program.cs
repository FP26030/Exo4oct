using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q1 :\n" + Q1("abcd"));
            Console.WriteLine("\nQ2 :\n" + Q2(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 3, 4, 6 }));
            Console.WriteLine("\nQ3a :\n" + Q3a('g'));
            Console.WriteLine("\nQ3 :\n" + String.Concat(Q3("abcdh".ToCharArray())));
            Console.WriteLine("\nQ4 :\n" + Q4("p555ppp7www"));
            Console.WriteLine("\nQ5 :"); Q5();
            Console.WriteLine("\nQ6 :"); Q6("aahgeahkhk");
            Console.WriteLine("\nQ7 :\n" + Q7(3));
            Console.WriteLine("\nQ8 :\n" + Q8("My Name is Pramit"));
            Console.WriteLine("\nQ9 :"); Q9();


            Console.WriteLine("Done");
            Console.ReadKey();
        }

        static string Q1(string text)
        {
            return text.Length <= 1 ? text:String.Concat(text.Last(), text.Substring(1, text.Length - 2), text.First());
        }
        static bool Q2(int[] arr, int[] pattern)
        {
            bool test = true;
            for (int i = 0; i < arr.Length; i++)
            {
                test = true;
                for (int j = 0; j < pattern.Length; j++)
                {
                    test = arr[i + j] == pattern[j];
                    if (!test) break;
                }
                if (test) return true;
            }
            return false;
        }
        static int Q3a(char car)
        {
            return (byte)car;
        }
        static char[] Q3(char[] arr)
        {
            List<char> arrlist = arr.ToList();
            arrlist.Sort((a, b) => Q3a(b).CompareTo(Q3a(a)));
            return arrlist.ToArray();
        }
        static string Q4(string text)
        {
            string compress = "";
            int n = 1;
            for (int i = 0; i < text.Length-1; i++)
                if (text[i] == text[i + 1]) n++;
                else
                {
                    compress += text[i] + n.ToString();
                    n = 1;
                }
            compress += text.Last() + n.ToString();
            return compress;
        }
        static List<int> Q5()
        {
            List<int> armstrongNum = new List<int>();
            for (int i = 1; i < 1000; i++)
                if (Math.Pow(i % 10, 3) + Math.Pow(i / 10 % 10, 3) + Math.Pow(i / 100 % 10, 3) == i)
                {
                    armstrongNum.Add(i);
                    Console.WriteLine(i);
                }
            return armstrongNum;
        }
        static void Q6(string text)
        {
            List<char> allchar = new List<char>();
            foreach(char c in text)
                if (!allchar.Contains(c))
                {
                    allchar.Add(c);
                    Console.WriteLine(c + " : " + text.ToList().Count(x => x==c));
                }
        }
        static int Q7(int n)
        {
            int S = n<0?0:1;
            while (n > 0) S *= n--;
            return S;
        }
        static int Q8(string text)
        {
            return text.Count(x => x == ' ');
        }
        static public void Q9()
        {
            Person[] arr = new Person[3];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("person {0} : ", i+1);
                arr[i] = new Person(Console.ReadLine());
            }
        }
    }
}
