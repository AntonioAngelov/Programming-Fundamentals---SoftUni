using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague
{
    public class FootballLeague
    {
        public static void Main(string[] args)
        {
            string key = Console.ReadLine();
            Dictionary<string, ulong> pointsByTeam = new Dictionary<string, ulong>();
            Dictionary<string, ulong> goalsByTeam = new Dictionary<string, ulong>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "final")
                {
                    break;
                }

                List<string> teamsAndScore = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
                string team1 = GetTeamName(teamsAndScore[0], key);
                string team2 = GetTeamName(teamsAndScore[1], key);
                ulong[] score = teamsAndScore[2].Split(new char[] {':'}, StringSplitOptions.RemoveEmptyEntries).Select(ulong.Parse).ToArray();
                if (pointsByTeam.ContainsKey(team1))
                {
                    pointsByTeam[team1] += GetPoints(score, "firstTeam");
                }
                else
                {
                    pointsByTeam[team1] = GetPoints(score, "firstTeam");
                }

                if (pointsByTeam.ContainsKey(team2))
                {
                    pointsByTeam[team2] += GetPoints(score, "secondTeam");
                }
                else
                {
                    pointsByTeam[team2] = GetPoints(score, "secondTeam");
                }

                if (goalsByTeam.ContainsKey(team1))
                {
                    goalsByTeam[team1] += score[0];
                }
                else
                {
                    goalsByTeam[team1] = score[0];
                }

                if (goalsByTeam.ContainsKey(team2))
                {
                    goalsByTeam[team2] += score[1];
                }
                else
                {
                    goalsByTeam[team2] = score[1];
                }
            }

            List<string> teamsOrderedByPoints = Sort(pointsByTeam);
            List<string> teamsOrderedByGoals = Sort(goalsByTeam);


            Console.WriteLine("League standings:");
            int place = 1;
            foreach (var team in teamsOrderedByPoints)
            {
                Console.WriteLine("{0}. {1} {2}", place, team, pointsByTeam[team]);
                ++place;
            }
            List<string> top3 = teamsOrderedByGoals.Take(3).ToList();
            Console.WriteLine("Top 3 scored goals:");
            foreach (var team in top3)
            {
                Console.WriteLine("- {0} -> {1}", team, goalsByTeam[team]);
            }


        }

        private static List<string> Sort(Dictionary<string, ulong> pointsByTeam)
        {
            List<string> teams = new List<string>();
            foreach (var key in pointsByTeam.Keys)
            {
                teams.Add(key);
            }
            teams = teams.OrderByDescending(x => pointsByTeam[x]).ToList();
            for (int i = 0; i < teams.Count - 1; i++)
            {
                for (int j = i + 1; j < teams.Count; j++)
                {
                    if (pointsByTeam[teams[i]] == pointsByTeam[teams[j]] && string.Compare(teams[i], teams[j]) > 0)
                    {
                        string buffer = teams[i];
                        teams[i] = teams[j];
                        teams[j] = buffer;
                    }
                }
            }
            return teams;

        }

        private static ulong GetPoints(ulong[] score, string team)
        {
            if (team == "firstTeam")
            {
                if (score[0] > score[1])
                {
                    return 3;
                }
                else if (score[0] < score[1])
                {
                    return 0;
                }              
            }
            else 
            {
                if (score[0] < score[1])
                {
                    return 3;
                }
                else if (score[0] > score[1])
                {
                    return 0;
                }                
            }
            return 1;
        }

        private static string GetTeamName(string encrypted, string key)
        {

            int start = encrypted.IndexOf(key) + key.Length;
            int end = encrypted.IndexOf(key, start + 1);
            string currentTeam = encrypted.Substring(start, end - start);
            char[] reversed = currentTeam.ToCharArray();
            Array.Reverse(reversed);
            currentTeam = string.Join("", reversed).ToUpper();
            return currentTeam;
        }
    }
}
