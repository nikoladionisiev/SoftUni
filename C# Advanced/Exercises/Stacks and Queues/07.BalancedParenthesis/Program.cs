using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string parenthese = Console.ReadLine();

            char[] openParanthese = new char[] {'(', '[', '{' };

            Stack<char> stackOfParenthese = new Stack<char>();

            bool isValid = true;

            for (int i = 0; i < parenthese.Length; i++)
            {
                char currentBracket = parenthese[i];

                if (openParanthese.Contains(currentBracket))
                {
                    stackOfParenthese.Push(currentBracket);
                    continue;
                }

                if (stackOfParenthese.Count == 0)
                {
                    isValid = false;
                    break;
                }

                if (stackOfParenthese.Peek() == '(' && currentBracket == ')')
                {
                    stackOfParenthese.Pop(); 
                }
                else if (stackOfParenthese.Peek() == '[' && currentBracket == ']')
                {
                    stackOfParenthese.Pop();
                }
                else if (stackOfParenthese.Peek() == '{' && currentBracket == '}')
                {
                    stackOfParenthese.Pop();
                }


            }

            if (isValid && stackOfParenthese.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
