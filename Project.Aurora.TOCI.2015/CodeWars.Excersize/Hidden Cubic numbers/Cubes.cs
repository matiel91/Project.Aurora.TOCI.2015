using System;
using System.Linq;
using System.Text.RegularExpressions;
using static System.Math;

public class Cubes
{
    public static string isSumOfCubes(string s)
    {
        var regexScanResult = Regex.Matches(s, @"\d{1,3}"); //search for digits "\d"  {1,3} 1 to 3 chars
        int cubicNumSum = 0;
        int cubesCounter = 0;
        string result = "";
        foreach (Match item in regexScanResult)
        {
            var itemInt = int.Parse(item.Value);
            if(item.Value.Sum(x => Pow(int.Parse(x.ToString()), 3)) == itemInt)
            {
                cubesCounter++;
                cubicNumSum += itemInt;
                result += itemInt + " ";
            }
        }

        return cubesCounter == 0 ? "Unlucky" : result + cubicNumSum + " Lucky";
    }
}
