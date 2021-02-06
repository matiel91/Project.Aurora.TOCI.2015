using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Excersize
{
    /**
     Complete the solution so that it splits the string into pairs of two characters. If the string contains an odd number of characters then it should replace the missing second character of the final pair with an underscore ('_').

    Examples:

    SplitString.Solution("abc"); // should return ["ab", "c_"]
    SplitString.Solution("abcdef"); // should return ["ab", "cd", "ef"] 
     **/
    public class SplitString
    {
        public static string[] Solution(string str)
        {
            //dodaj podloge jak nieparzysta
            if (str.Length % 2 != 0) str += '_';
            List<string> solution = new List<string>(); // później opakujemy to do tablicy
            while(str.Length > 0)
            {
                solution.Add(str.Substring(0, 2));
                str = str.Remove(0, 2);
            }

            return solution.ToArray();
        }
           
    }
}

