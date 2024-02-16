using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 0;
                int y = 1;
                int a = y / x;
                
            }catch (Exception e)
            {
                Console.WriteLine("Ex occ "+e.Message);
                throw;
            }
            Console.WriteLine("After ex");
        }
    }
}
