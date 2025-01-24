using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Project_3
{
    internal class Program
    {
        class House
        {
            public string street;
            public int number;

            public void Print()
            {
                Console.WriteLine($"{street}, {number}");
            }
        }
        public void Exp()
        {
            int i = 1;
            object o = i;
            int j = (int)o;
        }

        public void TestFunc(ref int i)
        {
            i = 10;
            Debug.Log(i);
        }
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;
            int c = 10;

            int f;
            f = a + b;

            string s = "hello world";

            float t = 7.8f;
            double j = 5.8457;

            char ch = 'H';

            bool bl = true;

            byte k;
            sbyte sb;
            short sh;
            ushort ush;
            uint ui;
            long l;

            if (a < b)
            {
                Console.WriteLine($"Число {b} больше числа {a}");
            }
            if (a < b && c > b)
            {
                Console.WriteLine($"Число {c} больше всех чисел");
            }
            if (b < a)
            {
                Console.WriteLine($"Число {b} больше числа {a}");
            }
            else
            {
                Console.WriteLine($"Число {b} меньше числа {a}");
            }
            if (b > a) {
                Console.WriteLine($"Число {b} больше числа {a}");
            }
            else if (b < a) {
                Console.WriteLine($"Число {b} меньше числа {a}");
            }
            else
            {
                Console.WriteLine($"Число {b} равно числу {a}");
            }

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            int y = 0;

            while (y < 10)
            {
                Console.WriteLine(y);
                y++;
            }

            int[] numbers = new int[5];
            int[] numbers_2 = { 5, 8, 7, 6, 2, 5 };
            numbers_2[4] = 15;
            Console.WriteLine(numbers_2[3]);
            Console.WriteLine(numbers_2[4]);

            void Helloworld()
            {
                Console.WriteLine("Hello world");
            }
            Helloworld();
            Helloworld();

            void Sum(int n, int g)
            {
                int sum = n + g;
                Console.WriteLine(sum);
            }
            Sum(5, 7);

            void Human(string name, int age)
            {
                Console.WriteLine($"{name}, {age}");
            }
            Human("Александр", 23);

            House tower = new House();
            tower.street = "Красная";
            tower.number = 50;

            tower.Print();

            short s1 = 0;
            int i2 = 0;
            long l3 = 0;
            float f4 = 0;
            double d5 = 0;
            object o6 = 0;
            double d2 = (double)o6;

            i2 = (int)l3;
            l3 = i2;
            ushort a7 = 15050;
            byte b8 = (byte)a7;

            TestFunc(ref i2);

            var c9 = 0f;

            if (o6 != null)
            {
                int i20 = (int)o6;
            }

            int[] array = new int[10000];

            List<int> list = new List<int>(80);
        }
    }
}
