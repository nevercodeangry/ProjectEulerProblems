using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eulerprojects.Core;
namespace eulerprojects.Projects
{
    public class EulerProject2:IProject
    {
        private readonly IOutput _output;
        public EulerProject2(IOutput output)
        {
            _output = output;
        }
        public void Run()
        {
            _output.Write(Fibonacci(4000000));
        }
        /// <summary>
        /// https://projecteuler.net/problem=2
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        private static int Fibonacci(int max)
        {
            var evenSum = 0;
            var prevValue = 1;
            var nextValue = 1;
            var breakFlag = false;
            int nextSum;
            while (!breakFlag)
            {
                evenSum = SumEvenValues(evenSum, nextValue);

                nextSum = SumTwoValues(prevValue, nextValue);
                if (nextSum > max)
                {
                    breakFlag = true;
                    break;
                }

                Console.WriteLine("Next Value: " + nextSum.ToString());
                prevValue = nextValue;
                nextValue = nextSum;

            }
            return evenSum;
        }
        private static int SumEvenValues(int evenSum, int nextValue)
        {
            if ((nextValue % 2) == 0)
            {
                evenSum += nextValue;
            }
            return evenSum;
        }
        private static int SumTwoValues(int first, int second)
        {
            return first + second;
        }
    }

    

}
