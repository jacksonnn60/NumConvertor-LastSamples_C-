using System;

namespace UdemyLessons
{
    class Program
    {
        static void Main(string[] args)
        {
            LastSamples();
        }


        
        static void Convertor()
        {
            string[] ones = { "one", "two", "three", "for", "five", "six", " seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "forteen", "fifteen", "sixteen", "seventeen", "eighteen", "ninteen" };
            string[] tens = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            Console.WriteLine("Enter the Number:");
            string num = Console.ReadLine();
            Console.Clear();




            if (num.Length < 2)
            {
                int n = int.Parse(num) - 1;
                Console.WriteLine(ones[n]);
            }
            else
            {
                char[] s = new char[2] { num[0], num[1] };
                char first = s[0];
                char second = s[1];

                int fir = Convert.ToInt32(new string(first, 1));
                int sec = Convert.ToInt32(new string(second, 1));

                if (sec == 0)
                {
                    Console.WriteLine(tens[fir - 2]);
                }
                else
                {

                    Console.WriteLine(tens[fir - 2] + " " + ones[sec - 1]);
                }
            }
        }
        static void LastSamples()
        {
            Console.WriteLine("Enter the number:");

            int length = int.Parse(Console.ReadLine());
            //int[] num = new int[length - 1];
            int sum = 0;


            Console.WriteLine("Enter the count of numbers before before: ");

            int counter = int.Parse(Console.ReadLine());


            for (int k = length; k != counter; k--)
            {
                sum++;



                length--;

                if (sum <= 4)
                {
                    Console.WriteLine(k);
                }

            }
        }
    } 
}