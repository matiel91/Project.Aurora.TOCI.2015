using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Excersize.SoccerTable
{
    public class Kata
    {
        //Take data from result string
        public static List<TableRow> InjectNewResult(string newResult, List<TableRow> table)
        {
            var result = ParseResultFromString(newResult);
            //In below solution there is no validation if input string corresponding to teams in tables, 
            //no exception if some team name not corresponding to team in table
            //Find in the List and modify TableRow
            foreach (var item in table.Where(x=>x.TeamName == result.Team1 || x.TeamName == result.Team2))
            {
                switch (result.Result)
                {
                    case 0:
                        if(item.TeamName == result.Team1)
                        {
                            item.Game++;
                            item.Win++;
                            item.Point = item.Point+3;                            
                        }
                        if (item.TeamName == result.Team2)
                        {
                            item.Game++;
                            item.Loss++;
                        }
                        break;
                    case 1:
                        if (item.TeamName == result.Team2)
                        {
                            item.Game++;
                            item.Draw++;
                            item.Point = item.Point + 1;
                        }
                        if (item.TeamName == result.Team1)
                        {
                            item.Game++;
                            item.Draw++;
                            item.Point = item.Point + 1;
                        }
                        break;
                    case 2:
                        if (item.TeamName == result.Team2)
                        {
                            item.Game++;
                            item.Win++;
                            item.Point = item.Point + 3;
                        }
                        if (item.TeamName == result.Team1)
                        {
                            item.Game++;
                            item.Loss++;
                        }
                        break;
                    default:
                        throw new Exception("Unproper input");                      
                }
            }
            return table;
        }
        //"Arsenal 0:2 Rome"
        //"Arsenal 0,2 Rome"
        public static Match ParseResultFromString(string newResult)
        {
            var splittedResult = newResult.Split(':');
            var Team1Data = splittedResult[0].Split(' ');
            var Team2Data = splittedResult[1].Split(' ');
            var Team1Score = int.Parse(Team1Data[1]);
            var Team2Score = int.Parse(Team2Data[0]);
            var Result = 1;
            if (Team1Score > Team2Score)
            {
                Result = 0;
            } else if(Team1Score < Team2Score)
            {
                Result = 2;
            }
            else
            {
                Result = 1;
            }
            return new Match
            {
                Team1 = Team1Data[0],
                Team1Score = Team1Score,
                Team2 = Team2Data[1],
                Team2Score = Team2Score,
                Result = Result,
            };
        }

        public static void PrintTable(List<TableRow> table)
        {           
            foreach (var item in table)
            {
                Console.WriteLine(String.Concat(item.TeamName, "     ", item.Game, "   ", item.Win, "   ", item.Draw, "   ", item.Loss));
            }
        }
    }
}
