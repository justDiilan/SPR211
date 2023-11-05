using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyString1
{
    internal class String
    {
        public char[] str { get; set; }
        public int length { get; }
        public String(char[] str)
        {
            this.str = str;
        }

        public char StartWith() => str[0];
        public char EndWith() => str[str.Length - 1];
        public char[] Substring(int startIndex, int endIndex)
        {
            if (startIndex >= 0 && startIndex < length && endIndex >= 0 && endIndex <= length && startIndex <= endIndex)
            {
                int subLength = endIndex - startIndex + 1;
                char[] result = new char[subLength];
                Array.Copy(str, startIndex, result, 0, subLength);
                return result;
            }
            else
            {
                return new char[0]; // Возвращаем пустую строку в случае некорректных параметров
            }
        }
        public void Remove(int startIndex, int endIndex)
        {
            if (startIndex >= 0 && startIndex < length && endIndex >= 0 && endIndex <= length && startIndex <= endIndex)
            {
                int removeLength = endIndex - startIndex + 1;
                int newLength = length - removeLength;
                char[] result = new char[newLength];

                Array.Copy(str, 0, result, 0, startIndex);
                Array.Copy(str, endIndex + 1, result, startIndex, length - endIndex - 1);

                str = result;
            }
        }
        public void RemoveAll()
        {
            str = new char[0]; // Просто устанавливаем строку в пустую строку
        }
        public int IndexOf(char[] search)
        {
            for (int i = 0; i <= length - search.Length; i++)
            {
                bool found = true;
                for (int j = 0; j < search.Length; j++)
                {
                    if (str[i + j] != search[j])
                    {
                        found = false;
                        break;
                    }
                }

                if (found)
                {
                    return i;
                }
            }
            return -1; // Возвращаем -1, если не найдено
        }
        public void Concat(char[] str1, char[] str2)
        {
            str = new char[str1.Length + str2.Length];
            Array.Copy(str1, str, str1.Length);
            Array.Copy(str2, 0, str, str1.Length, str2.Length);
        }
        public void Replace(char[] newValue)
        {
            str = newValue;
        }
        public void Replace(char[] oldValue, char[] newValue)
        {
            string str1 = new string(str);
            string oldValueStr = new string(oldValue);
            string newValueStr = new string(newValue);
            str1 = str1.Replace(oldValueStr, newValueStr);
            str = str1.ToCharArray();
        }
        public void Trim(char ch)
        {
            str = new string(str).Replace(ch.ToString(), "").ToCharArray();
        }
        public bool CompareTo(char[] str1, char[] str2)
        {
            string str1Str = new string(str1);
            string str2Str = new string(str2);
            return str1Str.Equals(str2Str);
        }
        public override string ToString()
        {
            return new string(str);
        }
    }
}
