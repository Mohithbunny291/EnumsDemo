using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsDemo
{
    enum MyEnum
    {
        east,
        west,
        north,
        south
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyEnum myEnum;
            Enum.TryParse("east", out myEnum);
            
            int parseVal = (int)myEnum;
            Console.WriteLine(parseVal);
        }
    }
}
