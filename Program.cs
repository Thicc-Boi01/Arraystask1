using System;

namespace Arraystask
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] names = new string[5];

            int index = 0;

            while (index < names.Length)
            {
                System.Console.WriteLine("Please Enter Name {0}", index + 1);
                names[index] = System.Console.ReadLine();
                index++;
            }
            Console.WriteLine("=======================================");
            foreach (string item in names)
            {
                Console.WriteLine("Hello " + item);
            }
        }
    }
}
