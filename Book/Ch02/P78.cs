using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch01
{
    internal class P78
    {
        static void Main(string[] args)
{
    Console.WriteLine(DateTime.Now.Hour <3 || 8 <DateTime.Now.Hour);
    Console.WriteLine(3 < DateTime.Now.Hour && DateTime.Now.Hour < 8);

}
    }
}
