using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Excersize.Lazy_Repeater
{
    public class Kata
    {
        public static Func<char> MakeLooper(string str)
        {
            int idx = 0;
            //do obczajenia jak sie zmienia idx dodaje addwatch na ten w returnie
            return () => str[idx++ % str.Length];
        }
    }
}
