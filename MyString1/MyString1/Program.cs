using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyString1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] initialStr = "Some text".ToCharArray();
            String myString = new String(initialStr);

            // Проверка методов
            Console.WriteLine("Initial String: " + myString);

            Console.WriteLine("Starts with: " + myString.StartWith());

            Console.WriteLine("Ends with: " + myString.EndWith());

            char[] substringResult = myString.Substring(3, 2);
            Console.WriteLine("Substring(3, 2): " + new string(substringResult));

            myString.Remove(1, 3);
            Console.WriteLine("After Remove(1, 3): " + myString);

            myString.RemoveAll();
            Console.WriteLine("After RemoveAll(): " + myString);

            char[] search = "hi".ToCharArray();
            int indexOfResult = myString.IndexOf(search);
            Console.WriteLine("IndexOf(\"hi\"): " + indexOfResult);

            char[] str1 = "Hello, ".ToCharArray();
            char[] str2 = "World!".ToCharArray();
            myString.Concat(str1, str2);
            Console.WriteLine("After Concat: " + myString);

            char[] newValue = "Hello".ToCharArray();
            myString.Replace(newValue);
            Console.WriteLine("After Replace(newValue): " + myString);

            char[] oldValue = "Hello".ToCharArray();
            char[] newValue2 = "Hi".ToCharArray();
            myString.Replace(oldValue, newValue2);
            Console.WriteLine("After Replace(oldValue, newValue2): " + myString);

            char ch = ' ';
            myString.Trim(ch);
            Console.WriteLine("After Trim(' '): " + myString);

            char[] str1ToCompare = "Hello".ToCharArray();
            char[] str2ToCompare = "Hello".ToCharArray();
            bool compareToResult = myString.CompareTo(str1ToCompare, str2ToCompare);
            Console.WriteLine("CompareTo: " + compareToResult);

            Console.ReadKey();
        }
    }
}
