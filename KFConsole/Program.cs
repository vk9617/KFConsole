using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hello = "fhjk";
            int gh = 67;
            Console.WriteLine(hello);
            Console.WriteLine(gh);
            Console.WriteLine(gh + hello);
            string y = "i am dk";
            Console.WriteLine(hello + gh + y);
            int num = 15;
            double numDouble = 7.19;
            char myLetter = 'A';
            bool MyBool = false;
            string myText = "hello world";
            Console.WriteLine(myText);
            Console.WriteLine(MyBool);
            Console.WriteLine(myLetter);
            Console.WriteLine(num + numDouble + myLetter + myText);
            string firstName = "vijay";
            string lastName = "khatarkar";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);
            int x = 5, Y = 8, z = 50;
            Console.WriteLine(x + Y + z);
            int X, a, Z;
            X = a = Z = 60;
            Console.WriteLine(X + a + Z);
            //identifier in c#
            int secondsPerHour = 60;
            int s = secondsPerHour;
            Console.WriteLine(s);

            Console.ReadLine();
        }
    }
}
