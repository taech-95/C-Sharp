using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Learning
{ 
    class Program
    {

        public static int Add(int param1, int param2) => param1 + param2;
        public static int Multiply(int param1, int param2) => param1 * param2;
        public static double Devide(double param1, double param2) => param1 / param2;
        public static void WriteSomething()
        {
            Console.WriteLine("I'm called from the method;");
            Console.Read();
        }
        public static void GreetFriend(string name)
        {
             Console.WriteLine($"Hi {name}, my friend");
        }
        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            //int age = 26;
            /**//*string name = "Mykola";*//*
            Console.WriteLine("Hello my name is " + name + ", I am " + age + "years old");
            Console.WriteLine("Hello my name is {0}, I am {1} years old", name, age);
            Console.WriteLine($"Hello my name is {name}, I am {age} years old");
            Console.WriteLine(@"Lorem ipsum dolor sit amet consectetur adipisicing elit.
            Dolor consequuntur tempore numquam placeat debitis, totam quibusdam perferendis dolores, 
            reiciendis quam saepe dolorem aliquam magni. Nisi culpa nostrum laborum alias pariatur!");
            Console.WriteLine("Hello world");*/
            /* Console.WriteLine("Enter your name: ");
             string yourName = Console.ReadLine();
             Console.WriteLine(yourName.ToUpper());
             Console.WriteLine(yourName.ToLower());
             Console.WriteLine(yourName.Trim());
             Console.WriteLine(yourName.Substring(1, 5));
             string input = Console.ReadLine();
             char searchInInput = Console.ReadLine()[0];
             int searchIndex = input.IndexOf(searchInInput);
             Console.WriteLine($"Index of character {searchIndex}  in string is {searchIndex}");
             Console.WriteLine("Enter your name: ");
             string name = Console.ReadLine();
             Console.WriteLine("Enter your surname: ");
             string surname = Console.ReadLine();
             string fullName = String.Concat(name, " ", surname);
             Console.WriteLine(fullName);
             Console.ReadLine();*/
            /* string friendsName = "Sasha";
             WriteSomething();
             WriteSomethingSpecific("Mykola");
             Console.WriteLine(Add(5, 19));
             Console.WriteLine(Devide(7, 4));*/
            //GreetFriend(friendsName);
            //int result = Calculate();
            //Console.WriteLine(result);
            //Console.ReadLine();


            //try
            //{
            //    int userInputIsInt = int.Parse(num1);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Please enter only numbers");

            //}

            ////operators 
            //int number1 = 5;
            //int number3 = -number1;
            //number1++;
            //++number1;
            //bool isTrue = !true;
            //number3--;
            //--number3;

            ////TryParse
            //Console.WriteLine("Please enter the first number");

            //int parsedInt;
            //bool succes = int.TryParse(Console.ReadLine(), out parsedInt);
            //if (succes)
            //{
            //    Console.WriteLine(parsedInt);
            //}


            //int temp = -5;
            //string stateOfMatter;
            //if (temp <5)
            //{
            //    stateOfMatter = "solid";
            //}
            //else
            //{
            //    stateOfMatter = "liquid";
            //}

            //stateOfMatter = temp < 0 ? "solid" : "liquid";
            //Console.WriteLine($"State of matter is {stateOfMatter}");

            //Console.WriteLine("Enter a temperature");
            //string validTemp = Console.ReadLine();
            //string response;
            //bool parseSuccess = int.TryParse(validTemp, out int temperature);
            //if (parseSuccess)
            //{
            //    response = temperature > 28 ? "it is hot here" : temperature <= 15 ? "it is too cold here" : "it is ok";
            //    Console.WriteLine(response);
            //}

            //Person_Class Mykola = new Person_Class("Mykola", "Maksymov","brown",26);
            //Box box = new Box();
            //box.SetLength(3);
            //Console.WriteLine("Box length is " + box.GetLength());
            //box.Width = 6;
            //Console.WriteLine("Box width is " + box.Width);
            //Box box2 = new Box(5, 3, 8);
            //box.DisplayInfo();

            int [] grades = new int[5];
            grades[0] = 5;
            grades[1] = 15;
            grades[2] = 45;
            grades[3] = 25;
            grades[4] = 10;

            int[] nums = new int[10];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
            }
            int counter = 0;
            foreach (int  i in nums) 
            {
                Console.WriteLine($"Element {counter} = {i} ");
                counter++;
            }


            string[,] matrix;
            int[,] array2D = new int[,]
            {
                {1,5,8,10 },
                {4,9,17,22},
                {15,99,41,32 }
            };

            Console.WriteLine("Central value is: " + array2D[1,2]);
            foreach (int num in array2D)
            {
                Console.WriteLine(num + " ");
            }

            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                //Console.WriteLine();
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    if (array2D[i,j]%2==0)
                    {
                        Console.Write(array2D[i, j] + " ");
                    }
                    
                }
                
            }
            Console.WriteLine();
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                //Console.WriteLine();
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    if (i==j)
                    {
                        Console.WriteLine((array2D[i, j] + " "));
                    }

                }

            }
            Hashtable table = new Hashtable();
            Stack<int> stack = new Stack<int>();
            Console.WriteLine("Stacks");
            stack.Push(1);
            Console.WriteLine(stack.Peek());
            stack.Push(2);
            Console.WriteLine(stack.Peek());
            stack.Push(3);
            Console.WriteLine(stack.Peek());
            stack.Push(4);
            Console.WriteLine(stack.Peek());

            if (stack.Count >0)
            {
                stack.Pop();
            }

            while (stack.Count > 0 )
            {
                stack.Pop();
                Console.WriteLine("Stack count " + stack.Count);
            }

            int[] numbers = new int[] { 1, 2, 3, 4 };
            Stack<int> newStack = new Stack<int>();
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
                newStack.Push(item);
            }

            while (newStack.Count > 0)
            {
                int number = newStack.Pop();
                Console.WriteLine(number);
            }
            Console.WriteLine("_____________________________");

            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[]
            {
                2,3,5,7,11
            };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 13, 21 };

            int[][] jaggedArray2 = new int[][]
            {
                new int[] {2,3,5,7,11},
                new int[] {1,2,3}
                
            };
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(jaggedArray2[0][2]);
            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.WriteLine("Element {0}",i);
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.WriteLine(jaggedArray2[i][j]);
                }
            }

            //for (int i = 100; i < 170; i=+ 2)
            //{
            //    Console.Write(i + " ");
            //}

            int[] grades1 = new int[] { 15, 18, 23, 12, 6, 13 };
            double averageResult = GetAverage(grades1);
            Console.WriteLine(averageResult);


            string[][] friends = new string[][]
            {
                new string [] {"Mykola", "Olena", "Stefan"},
                new string [] {"Oksana", "Michail"},
                new string [] {"Oleg", "Oksana"}
            };

            Console.WriteLine("Hi {0}, i would like to introduce {1} to you.", friends[0][0], friends[1][1] );

            int[] happiness = new int[] { 2, 3, 4, 5, 6 };
            SunIsShining(happiness);
            foreach (int i in happiness)
            {
                Console.WriteLine(i);
            }

            var nums1 = new List<int>();
            //for (int i = 100; i <= 170; i = +2)
            //{
            //    nums1.Add(i);
            //}
            //foreach (int num in nums1)
            //{
            //    Console.Write(num +" ");
            //}
            Console.WriteLine("Queue");
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            Console.WriteLine(queue.Peek());
            int queueItem = queue.Dequeue();
            Console.WriteLine("removed item " + queueItem);



            ArrayList arrayList = new ArrayList();
            arrayList.Add(5);
            arrayList.Add("hello");
            arrayList.Add(3.14);
            arrayList.Remove(5);
            arrayList.Add(17);
            double sum = 0;
            foreach (object obj  in arrayList)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    sum += (double)obj;
                }

            }
            Console.WriteLine(sum);
        }


        public static int MinV2(params int[] numbers)
        {
            int min = int.MaxValue;
            foreach (int number in numbers)
            {
                if (min > number)
                {
                    min = number;
                }
            }
            return min;
        }

        public static void ParamsMethod2(params object[] stuff)
        {
            foreach (object obj in stuff)
            {
                Console.Write(obj + " ");
            }

            Console.WriteLine();
        }

        public static void ParamsMethod (params string[] sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.Write(sentence[i] + " ");
            }
        }


        public static int Calculate()
        {
            Console.WriteLine("Please enter the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the first number");
            int num2 = int.Parse(Console.ReadLine());
            return num1 + num2;
        }
        
        public static double GetAverage(int [] gradesArray)
        {
            int size = gradesArray.Length;
            double average =0, sum=0;
            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
                
            }
            average = (double)sum / size;
            return average;
        }

        public static void  SunIsShining(int [] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] += 2;
            }
        }

    }


}
