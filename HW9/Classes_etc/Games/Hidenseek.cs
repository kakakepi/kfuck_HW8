using System;
using System.Collections.Generic;

namespace HW9
{
    public class HideNSeek : Game
    {
        public override void DistributePoints(List<Team> teams)
        {
            if (teams == null || teams.Count < 2)
            {
                throw new ArgumentException("Должно быть минимум две команды.");
            }
            List<Team> shuffledTeams = new List<Team>(teams);
            for (int i = shuffledTeams.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                (shuffledTeams[i], shuffledTeams[j]) = (shuffledTeams[j], shuffledTeams[i]);
            }
            int points = shuffledTeams.Count * 10;
            for (int i = 0; i < shuffledTeams.Count; i++)
            {
                shuffledTeams[i].AddScore(points);
                points -= 10;
            }
            Console.WriteLine("Результаты игры Прятки:");
            for (int i = 0; i < shuffledTeams.Count; i++)
            {
                Console.WriteLine($"{i + 1} место: {shuffledTeams[i].nameOfTeam}, Очки: {shuffledTeams[i].score}");
            }
        }
    }
}
