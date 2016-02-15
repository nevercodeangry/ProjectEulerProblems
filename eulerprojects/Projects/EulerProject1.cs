using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eulerprojects.Core;
namespace eulerprojects.Projects
{
    
    public class EulerProject1 : IProject
    {
        private readonly IOutput _output;
        public EulerProject1(IOutput output)
        {
            _output = output;
        }
        public void Run()
        {
            _output.Write(Multiply(1000));
        }
        private int Multiply(int max)
        {
            var sumOfMultiples = 0;
            for (int i = 0; i < max; i++)
            {
                if (((i % 3) == 0) || ((i % 5) == 0))
                {
                    _output.Write(i);
                    sumOfMultiples += i;
                }

            }
            return sumOfMultiples;
        }

    }
}
