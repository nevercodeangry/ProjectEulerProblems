using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eulerprojects.Core
{
    public interface IProject
    {
        void Run();
    }
    public interface IOutput
    {
        void Write(string content);
        void Write(int number);
        void Write(long number);
    }
    public class OutputToConsole:IOutput
    {
        public void Write(string content)
        {
            Console.WriteLine(content);
        }
        public void Write(int number)
        {
            Console.WriteLine(number.ToString());
        }
        public void Write(long number)
        {
            Console.WriteLine(number.ToString());
        }
    }


}
