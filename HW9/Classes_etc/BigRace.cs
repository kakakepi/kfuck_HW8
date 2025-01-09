using System;
using System.Collections.Generic;
using System.Linq;

namespace HW9
{
    public class BigRace
    {
        List<Game> selectedGames = new List<Game>();
        List<Team> teamList = new List<Team>();
        private Random random = new Random();
        string bigPapaName;

        public BigRace(string bigPapaName)
        {
            this.bigPapaName = bigPapaName;
        }

        public void SelectRandomGames(List<Game> games)
        {
            if (games == null || games.Count < 7)
            {
                throw new ArgumentException("Список игр должен содержать минимум 7 элементов.");
            }

            List<Game> shuffledGames = new List<Game>(games);
            for (int i = 0; i < shuffledGames.Count; i++)
            {
                int j = random.Next(i, shuffledGames.Count);
                (shuffledGames[i], shuffledGames[j]) = (shuffledGames[j], shuffledGames[i]);
            }

            for (int i = 0; i < 6; i++)
            {
                selectedGames.Add(shuffledGames[i]);
            }
        }

        public void AddTeams(Team team)
        {
            teamList.Add(team);
        }

        public void StartCompetition()
        {
            var shuffledGames = selectedGames.OrderBy(_ => random.Next()).ToList();
            foreach (var game in shuffledGames)
            {
                game.DistributePoints(teamList);
            }

            AnnounceResults();
        }

        private void AnnounceResults()
        {
            Console.WriteLine($"\nИтоговые результаты соревнования, объявлённые {bigPapaName}:");
            foreach (var team in teamList.OrderByDescending(t => t.score))
            {
                Console.WriteLine($"Команда {team.nameOfTeam} - {team.score} очков");
            }
        }
    }
}
