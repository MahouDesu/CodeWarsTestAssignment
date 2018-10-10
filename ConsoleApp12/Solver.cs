using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class Solver
    {
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public bool IsLochNessMonster(string sentence)
        {
            if (sentence == null)
            {
                return false;
            }
            if (sentence.ToLower().Contains("tree fiddy") || sentence.ToLower().Contains("3.50") || sentence.ToLower().Contains("three fifty"))
            {
                return true;
            }
            return false;
        }

        public string WhoIsNext(string[] names, long n)
        {
            throw new NotImplementedException();
        }

        public string NoSpace(string input)
        {
            throw new NotImplementedException();
        }

        public string[] FixTheMeerkat(string[] arr)
        {
            throw new NotImplementedException();
        }

        public string boolToWord(bool word)
        {
            throw new NotImplementedException();
        }

        public float Combat(float health, float damage)
        {
            throw new NotImplementedException();
        }

        public int Solution(int value)
        {
            throw new NotImplementedException();
        }

        public string[] Splitter(string str)
        {
            throw new NotImplementedException();
        }

        public bool IsPrime(int n)
        {
            throw new NotImplementedException();
        }

        public string MakeUpperCase(string str)
        {
            throw new NotImplementedException();
        }

        public string Rgb(int r, int g, int b)
        {
            throw new NotImplementedException();
        }

        public int SquareSum(int[] n)
        {
            throw new NotImplementedException();
        }
    }

}
