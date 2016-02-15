using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eulerprojects.Core;

namespace eulerprojects.Projects
{
    public class EulerProject4 : IProject
    {
        private readonly IOutput _output;
        public EulerProject4(IOutput output)
        {
            _output = output;
        }
        public void Run()
        {
            _output.Write(LargestPalindrome(3));
        }
        /// <summary>
        /// https://projecteuler.net/problem=4
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        private long LargestPalindrome(int digits)
        {
            var initial = "9";
            var startvalue = initial.PadLeft(digits, '9');
            var maxloop = int.Parse(startvalue.Substring(0,digits-1));
            int maxValue= int.Parse(startvalue);
            long max=0;
            for (int i=maxValue;i > maxloop; i--)
            {
                for (int j = maxValue; j > maxloop; j--)
                {
                    var total = (i * j);
                    if (IsPalindrome(total))
                        max = Math.Max(max, total);                        
                }
            }
         

            return max;
        }
        private bool IsPalindrome(long number)
        {
            var total = (number).ToString();
            var totalLength = total.Length;
            var beginning = total.Substring(0, (totalLength / 2));
            var ending = new string(beginning.ToArray().Reverse().ToArray());
            return (total.EndsWith(ending) && total == (beginning + ending)) ;
        }
    }
}
