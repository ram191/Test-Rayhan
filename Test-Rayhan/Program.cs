using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Test_Rayhan
{
    class Program
    {
        static void Main(string[] args)
        {
            //Code for assignment Number 11
            double sum = 0;
            double[] doubleArgs = Array.ConvertAll(args, double.Parse);
            foreach (double arg in doubleArgs)
            {
                sum += arg;
            }
            Console.WriteLine(sum);

            //Assignments 1, 2, 3
            Console.WriteLine("Hello World!");
            Console.WriteLine("Would you care to tell me who your name is?");
            NumberOne.GetName();
            NumberTwo.GetBirthday();
            Console.WriteLine("Let's play a letter counting game. Input a word and I'll count the letters!");
            string characters = Console.ReadLine();
            NumberThree.CountString(characters);
            Console.ReadLine();
            Console.WriteLine("Bad Words Censor:");

            //Assignment 4
            Console.WriteLine(NumberFour.ReplaceBadWords("Lorem ipsum dolor sit amet, imperdiet vituperata duo in, nonumy."));
            Console.ReadLine();

            //Assignment 5
            Console.WriteLine("IsOdd and IsEven Assignment:");
            Console.WriteLine(NumberFive.IsOdd(2));
            Console.WriteLine(NumberFive.IsEven(2));
            Console.ReadLine();

            //Assignment 6
            Console.WriteLine("Grade Assignment: (Input a number between 1-100...)");
            string grade = Console.ReadLine();
            int intGrade = Int32.Parse(grade);
            Console.WriteLine(NumberSix.Grade(intGrade));
            Console.ReadLine();

            //Assignment 7
            Console.WriteLine("Temperature Converter Assignment:");
            Console.WriteLine(NumberSeven.FahrenheitToKelvin(12));
            Console.ReadLine();

            //Assignment 8
            Console.WriteLine("Leap Year Assignment: (Input a year......)");
            string leapYear = Console.ReadLine();
            int intYear = Int32.Parse(leapYear);
            Console.WriteLine($"{intYear} is a leap year: ");
            Console.Write(NumberEight.IsLeapYear(intYear));
            Console.ReadLine();

            //Assignment 9
            Console.WriteLine("\nTimezone Assignment:");
            Console.WriteLine(NumberNine.ShowTimezone());
            Console.ReadLine();

            //Assignment 10
            Console.WriteLine("Calculator Assignment:");
            Console.WriteLine(NumberTen.Sum(20, 4));
            Console.WriteLine(NumberTen.Divide(20, 4));
            Console.WriteLine(NumberTen.Multiply(20, 4));
            Console.WriteLine(NumberTen.Substract(20, 4));
            Console.ReadLine();

            //Assignment 12
            Console.WriteLine("Uppercase Assignment: (Input string to be changed to uppercase....)");
            string uppercase = Console.ReadLine();
            Console.WriteLine(NumberTwelve.Uppercase(uppercase));
            Console.ReadLine();

            //Assignment 13
            Console.WriteLine("Word Count Assignment: (Input a sentence containing several words...)");
            string insertWord = Console.ReadLine();
            Console.WriteLine(NumberThirteen.CountWord(insertWord));
            Console.ReadLine();

            //Assignment 14
            Console.WriteLine("Palindrome Assignment: (Input a word for palindrome check)");
            string palindrome = Console.ReadLine();
            Console.WriteLine(NumberFourteen.IsPalindrome(palindrome));
            Console.ReadLine();

            //Assignment 15
            Console.WriteLine("Mirror Assignment: (Input characters to be mirrored...)");
            string mirror = Console.ReadLine();
            Console.WriteLine(NumberFifteen.Mirror(mirror));
            Console.ReadLine();

            //Assignment 16
            Console.WriteLine("Fruit Index Assignment:");
            Console.WriteLine(NumberSixteen.ShowResult());
            Console.ReadLine();

            //Assignment 17
            Console.WriteLine("Thousand Loop Assignment:");
            NumberSeventeen.LoopThousand();
            Console.ReadLine();

            //Assignment 18
            Console.WriteLine("Math Method Assignment:");
            NumberEighteen.ShowResult();
            Console.ReadLine();

            //Assignment 19
            Console.WriteLine("Array Sort Assignment:");
            NumberNineteen.SortArray();
            Console.ReadLine();

            //Assignment 20
            Console.WriteLine("\nConstructor Assignment:");
            Item item = new Item();
            item.Name = "Indomie Goreng";
            item.Price = 3500;
            item.OnSale = true;
            Console.WriteLine(item.Print());
            Console.ReadLine();

            Console.WriteLine("Thank you!  -Ram");
            Console.ReadLine();
        }
    }

    class NumberOne
    {
        public static string name = Console.ReadLine();
        public static void GetName()
        {
            Console.WriteLine($"Hello {name}, nice to meet you!\n");
        }
    }

    class NumberTwo
    {
        public static DateTime birthday = new DateTime(1997, 01, 19);
        public static DateTime today = DateTime.Today;
        public static DateTime nextBirthday = new DateTime(today.Year, birthday.Month, birthday.Day);

        public static void GetBirthday()
        {
            if (nextBirthday < today)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }

            int countDown = (nextBirthday - today).Days;
            Console.WriteLine($"It's {countDown} days to my next birthday. I just had one this month :)\n");
        }

    }

    class NumberThree
    {
        public static void CountString(string value)
        {
            int stringLength = value.Length;
            Console.WriteLine($"The word {value} has {stringLength} characters!");
        }
    }

    class NumberFour
    {
        public static List<string> censoredWords = new List<string>()
        {
            "imperdiet",
            "dolor",
            "duo"
        };

        static string paragraph = "Lorem ipsum dolor sit amet, imperdiet vituperata duo in, nonumy.";

        public static string ReplaceBadWords(string str)
        {
            string cleaned = Regex.Replace(str, "\\b" + string.Join("\\b|\\b", censoredWords) + "\\b", "*****");
            return cleaned;
        }

        public static string ShowResult()
        {
            return ReplaceBadWords(paragraph);
        }
    }

    class NumberFive
    {
        public static bool IsOdd(int number) => number % 2 == 0 ? false : true;

        public static bool IsEven(int number) => number % 2 == 0 ? true : false;
    }

    class NumberSix
    {
        public static Char Grade(int grade)
        {
            if (grade >= 90)
            {
                return 'A';
            }
            else if (grade >= 80)
            {
                return 'B';
            }
            else if (grade >= 70)
            {
                return 'C';
            }
            else if (grade >= 60)
            {
                return 'D';
            }
            else
            {
                return 'E';
            }
        }
    }

    class NumberSeven
    {
        public static double CelciusToFahrenheit(double degree)
        {
            return (degree * 9) / 5 + 32;
        }
        public static double FahrenheitToCelcius(double degree)
        {
            return (degree - 32) * 5 / 9;
        }
        public static double CelciusToKelvin(double degree)
        {
            return degree + 273.15;
        }
        public static double KelvinToCelcius(double degree)
        {
            return degree - 273.15;
        }
        public static double KelvinToFahrenheit(double degree)
        {
            return (degree - 273.15) * 9 / 5 + 32;
        }
        public static double FahrenheitToKelvin(double degree)
        {
            return (degree - 32) * 5 / 9 + 273.15;
        }
    }

    class NumberEight
    {
        public static bool IsLeapYear(int year)
        {
            return DateTime.IsLeapYear(year);
        }
    }

    class NumberNine
    {
        public static Tuple<string, int> jakarta = Tuple.Create("Jakarta", 7);
        public static Tuple<string, int> bali = Tuple.Create("Bali", 8);
        public static Tuple<string, int> london = Tuple.Create("London", 0);
        public static Tuple<string, int> cairo = Tuple.Create("Cairo", 2);
        public static Tuple<string, int> denver = Tuple.Create("Denver", -6);
        public static Tuple<string, int> chicago = Tuple.Create("Chicago", -5);

        public static string TimezoneDiff(Tuple<string, int> town1, Tuple<string, int> town2)
        {

            string preposition;
            int hourDiff = town1.Item2 - town2.Item2;

            if (town1.Item2 < town2.Item2)
            {
                preposition = "behind";
            }
            else
            {
                preposition = "ahead";
            }
            return $"{town1.Item1} is {Math.Abs(hourDiff)} hours {preposition} {town2.Item1}";
        }

        public static string ShowTimezone()
        {
            //The method is called here
            return TimezoneDiff(denver, chicago);
        }
    }

    class NumberTen
    {
        public static double Sum(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Substract(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }

    class NumberEleven
    {
        //Written in the Main Program Class.
    }

    class NumberTwelve
    {
        public static string Uppercase(string str)
        {
            return str.ToUpper();
        }
    }

    class NumberThirteen
    {
        public static int CountWord(string str)
        {
            int wordCount = 0;
            int index = 0;

            // skip whitespace until first word
            while (index < str.Length && char.IsWhiteSpace(str[index]))
                index++;

            while (index < str.Length)
            {
                // check if current char is part of a word
                while (index < str.Length && !char.IsWhiteSpace(str[index]))
                    index++;

                wordCount++;

                // skip whitespace until next word
                while (index < str.Length && char.IsWhiteSpace(str[index]))
                    index++;
            }

            return wordCount;
        }
    }

    class NumberFourteen
    {
        public static bool IsPalindrome(string str)
        {
            int length = str.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (str[i] != str[length - i - 1])
                    return false;
            }
            return true;
        }
    }

    class NumberFifteen
    {
        public static string Mirror(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            string newStr = string.Join("", arr);
            return str + newStr;
        }
    }

    class NumberSixteen
    {
        public static string[] fruits = {
                                "Jeruk",
                                "Apel",
                                "Anggur",
                                "Pepaya",
                                "Pisang",
                                "Kiwi",
                                "Markisa",
                            };

        public static void IndexFinder(string[] arr, string fruitName)
        {
            Array.IndexOf(arr, fruitName);
        }

        public static int ShowResult()
        {
            return Array.IndexOf(fruits, "Markisa");
        }
    }

    class NumberSeventeen
    {
        public static void LoopThousand()
        {
            for (int x = 1; x <= 1000; x++)
            {
                if (x % 100 == 0)
                {
                    Console.WriteLine(x + ". Baz");
                }
                else if (x % 20 == 0)
                {
                    Console.WriteLine(x + ". Bar");
                }
                else if (x % 5 == 0)
                {
                    Console.WriteLine(x + ". Foo");
                }
                else { Console.WriteLine(x); }
            }
        }
    }

    class NumberEighteen
    {
        static int[] numbers = { 2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54 };

        public static int FindMax(int[] arr) => arr.Max();
        public static int FindMin(int[] arr) => arr.Min();
        public static double FindAverage(int[] arr) => arr.Average();

        public static void ShowResult()
        {
            Console.WriteLine(FindAverage(numbers));
        }
    }

    class NumberNineteen
    {
        public static void SortArray()
        {
            int[] points = { 2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 45 };
            Array.Sort(points);
            foreach(int num in points)
            {
                Console.Write(num + ",");
            }
        }
    }

    //Number Twenty
    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public bool OnSale { get; set; }
        public string Print()
        {
            if(this.OnSale == true)
            {
                this.Price = this.Price - (this.Price * 20 / 100);
            }

            return $"{this.Name} {this.Price}";
        }
    }
}
