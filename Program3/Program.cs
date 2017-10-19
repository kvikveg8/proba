using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            //PRVI ZADATAK
            //var names = new List<string>();
            //while (true)
            //{
            //    Console.WriteLine("Enter names or hit ENTER to quit:");
            //    var input = Console.ReadLine();
            //    if (String.IsNullOrWhiteSpace(input))
            //        break;
            //    names.Add(input);

            //}
            //var count = names.Count;
            //if (count==1)
            //    Console.WriteLine("{0} likes your post",names[0]);
            //else if (count==2)
            //    Console.WriteLine("{0} and {1} like your post",names[0], names[1]);
            //else if (count>2)
            //{
            //    Console.WriteLine("{0} and {1} and {2} people like your post ", names[0], names[1], count - 2);
            //}
            //else
            //{
            //    Console.WriteLine();
            //}

            //DRUGI ZADATAK
            //Console.Write("Write your name: ");
            //var input = Console.ReadLine();

            //var array = new char[input.Length];

            //for (int i = input.Length; i > 0; i--)
            //{
            //    array[input.Length - i] = input[i - 1];

            //}
            //var revesred = new string(array);
            //Console.WriteLine(revesred);

            //TRECI ZADATAK

            //var numbers = new List<int>();

            //while (numbers.Count<5)
            //{
            //    Console.Write("Enter 5 unique numbers: ");
            //    var number = Convert.ToInt32(Console.ReadLine());
            //    if (numbers.Contains(number))
            //    {
            //        Console.WriteLine("You already entered that number");
            //        continue;
            //    }
            //    numbers.Add(number);

            //}
            //numbers.Sort();
            //foreach (var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            //var numbers = new List<int>();

            //while (numbers.Count < 5)
            //{
            //    Console.Write("Enter a number: ");
            //    var number = Convert.ToInt32(Console.ReadLine());
            //    if (numbers.Contains(number))
            //    {
            //        Console.WriteLine("You've previously entered " + number);
            //        continue;
            //    }

            //    numbers.Add(number);
            //}

            //numbers.Sort();

            //foreach (var number in numbers)
            //    Console.WriteLine(number);

            //CETVRTI ZADATAK

            //var numbers = new List<int>();
            //while (true)
            //{
            //    Console.Write("Enter a number or Quit to exit:");
            //    var input = Console.ReadLine();
            //    if (input.ToLower() == "quit")
            //    break;

            //    numbers.Add(Convert.ToInt32(input));
            //}
            //var uniques = new List<int>();
            //foreach (var number in numbers)
            //{
            //    if (!uniques.Contains(number))
            //    {
            //        uniques.Add(number);
            //    }

            //}
            //Console.WriteLine("Unique numbers:");
            //foreach (var unique in uniques)
            //{
            //    Console.WriteLine(unique);
            //}

            //PETI ZADATAK
            //var numbers = new List<int>();
            //Console.Write("Enter 5 coma separated numbers");
            //var input = Console.ReadLine();
            //var list = Convert.ToInt32(input.Split(','));

            //numbers.Add(list);
            //if (numbers.Count==0 || numbers.Count<5)
            //{
            //    Console.WriteLine("Invalid LIst");
            //}
            string[] elements;
            while (true)
            {
                Console.Write("Enter a list of comma-separated numbers: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                        break;
                }

                Console.WriteLine("Invalid List");
            }

            var numbers = new List<int>();
            foreach (var number in elements)
                numbers.Add(Convert.ToInt32(number));

            var smallests = new List<int>();
            while (smallests.Count < 3)
            {
                // Assume the first number is the smallest
                var min = numbers[0];
                foreach (var number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                smallests.Add(min);

                numbers.Remove(min);
            }

            Console.WriteLine("The 3 smallest numbers are: ");
            foreach (var number in smallests)
                Console.WriteLine(number);
        }
    }
}
