using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Work
    {
        public void OddNumber(int[] arrayNumbers)
        {
            List<int> oddNumbers = new();
            for(int i = 0; i < arrayNumbers.Length; i++)
            {
                int counter = 0;
                foreach(int x in arrayNumbers)
                {
                    if(arrayNumbers[i] == x)
                    {
                        counter++;
                    }
                }
                if (counter % 2 == 0) { }
                else
                {
                    oddNumbers.Add(arrayNumbers[i]);
                }
            }
            for(int i = 0; i < oddNumbers.Count; i++)
            {
                Console.Write(oddNumbers[i]);
                if (oddNumbers.Count - 1 == i)
                {
                    Console.Write(".");
                }
                else { Console.Write(","); }
            }            
        }
        public void EvenNumber(int[] arrayNumbers)
        {
            List<int> evenNumber = new();
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                int counter = 0;
                foreach (int x in arrayNumbers)
                {
                    if (arrayNumbers[i] == x)
                    {
                        counter++;
                    }
                }
                if (counter % 2 == 0)
                {
                    if (evenNumber.Contains(arrayNumbers[i]) == false)
                    {
                        evenNumber.Add(arrayNumbers[i]);
                    }
                }
                else { };
            }
            for (int i = 0; i < evenNumber.Count; i++)
            {
                Console.Write(evenNumber[i]);
                if (evenNumber.Count - 1 == i)
                {
                    Console.Write(".");
                }
                else { Console.Write(","); }
            }
        }
        public int[] CreateUserArray()
        {
            Console.WriteLine($"Введите числа которые хотите записать в массив (числа нужно записать через пробел либо запятую");
            string enter = Console.ReadLine();
            var split= enter.Split(' ', ',');
            
            return ;
        }
    }
}
