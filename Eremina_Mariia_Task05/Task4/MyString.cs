using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task4
{
    class MyString
    {
        private char[] str;

        public MyString (string words)
        {
            str= words.ToCharArray();
        }

        public static MyString operator +(MyString s1, MyString s2)
        {
            string s = s1.ToString();
            string st = s2.ToString();
            string strng = s+st;
            return new MyString(strng);
        }


        public static MyString operator -(MyString s1, MyString s2)
        {

            //if (Regex.IsMatch(s1.ToString(), s2.ToString()))
            //{
            //    return new MyString(Regex.Replace(s1.ToString(), s2.ToString(), match => ""));
            //}
            //else throw new Exception("Substring is not found.");
            string s = s1.ToString();
            string st = s2.ToString();
            string strng = s.Replace(st, string.Empty);
            return new MyString(strng);
        }

        public static bool operator ==(MyString s1, MyString s2)
        {
            return (s1.str.Equals(s2.str));
        }

        public static bool operator !=(MyString s1, MyString s2)
        {
            return !(s1==s2);
        }

        public override bool Equals(object s2)
        {
            if (s2 == null || !(s2 is MyString))
            {
                return false;
            }
            else
            {
                return (Equals(s2));
            }
         
        }

        public override string ToString()
        {
            string charString = string.Join(string.Empty, str);
            return charString;
        }
    }
}
