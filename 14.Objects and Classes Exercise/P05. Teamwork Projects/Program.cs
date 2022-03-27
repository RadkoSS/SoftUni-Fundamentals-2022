using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace P05._Teamwork_Projects
{
    internal class Program
    {
        static void Main()
        {
            int teamsCount = int.Parse(Console.ReadLine());

            List<Team> teamsList = CreateTeams(teamsCount);

            GetMembers(teamsList);

            List<Team> teamsWithMembers = teamsList.Where(team => team.Members.Count > 0).OrderByDescending(team => team.Members.Count).ThenBy(team => team.TeamName).ToList();

            List<Team> teamsToDisband = teamsList.Where(team => team.Members.Count == 0).OrderBy(team => team.TeamName).ToList();

            PrintValidTeams(teamsWithMembers);

            PrintInvalidTeams(teamsToDisband);

        }
        static List<Team> CreateTeams(int teamsCount)
        {
            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamsCount; i++)
            {
                string[] currentTeam = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries);
                string creator = currentTeam[0];
                string teamName = currentTeam[1];

                if (teams.Any(team => team.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                else if (teams.Any(team => team.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                Team newTeam = new Team(creator, teamName);
                teams.Add(newTeam);

                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }

            return teams;
        }

        static void GetMembers(List<Team> teamsList)
        {
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] currentMember = command.Split("->", StringSplitOptions.RemoveEmptyEntries);

                string name = currentMember[0];
                string teamToJoin = currentMember[1];

                Team searchedTeam = teamsList.FirstOrDefault(team => team.TeamName == teamToJoin);

                //if (teamsList.Any(team => team.Members.Contains(name)))
                if (!teamsList.Exists(team => team.TeamName == teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                    continue;
                }

                else if (teamsList.Any(team => team.Members.Contains(name)))
                {
                    Console.WriteLine($"Member {name} cannot join team {teamToJoin}!");
                    continue;
                }

                else if (teamsList.Any(team => team.Creator == name))
                {
                    Console.WriteLine($"Member {name} cannot join team {teamToJoin}!");
                    continue;
                }

                searchedTeam.AddMember(name);

            }

        }

        static void PrintValidTeams(List<Team> validTeams)
        {
            foreach (Team team in validTeams)
            {
                Console.WriteLine(team);
            }
        }

        static void PrintInvalidTeams(List<Team> invalidTeams)
        {
            Console.WriteLine("Teams to disband:");

            foreach (Team team in invalidTeams)
            {
                Console.WriteLine(team.TeamName);
            }
        }

    }

    public class Team
    {
        public Team(string creator, string teamName)
        {
            this.Creator = creator;
            this.TeamName = teamName;
            this.Members = new List<string>();
        }

        public string Creator { get; set; }

        public string TeamName { get; set; }

        public List<string> Members { get; set; }

        public void AddMember(string memberToAdd)
        {
            this.Members.Add(memberToAdd);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(this.TeamName);

            stringBuilder.AppendLine($"- {this.Creator}");

            foreach (string member in this.Members.OrderBy(member => member))
            {
                stringBuilder.AppendLine($"-- {member}");
            }

            return stringBuilder.ToString().TrimEnd();
        }

    }
}
