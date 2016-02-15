using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eulerprojects.Core;

namespace eulerprojects.Projects
{
    public class EulerProject3 : IProject
    {
        private readonly IOutput _output;
        public EulerProject3(IOutput output)
        {
            _output = output;
        }
        public void Run()
        {
            _output.Write(LargestPrimeFactor(600851475143));
        }
        /// <summary>
        /// https://projecteuler.net/problem=3
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        private long LargestPrimeFactor(long max)
        {
            for (long i = 2; max > i; i++)
            {
                //goes into max
                if (max % i == 0)
                {
                    var largest = max / i;
                    if (IsPrime(largest))
                        return largest;
                }
            }

            return max;
        }
        private bool IsPrime(long value)
        {
            for (long i = 2; value > i; i++)
            {
                //goes into max
                if (value % i == 0)
                    return false;
            }
            return true;
        }
    }
}
