using System;

namespace Open_Lab_03._11
{
    public class Checker
    {
        public bool IsPalindrome(string str) => str == new string(str.Reverse().ToArray());         
    }
}
