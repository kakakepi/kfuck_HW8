using System;
using System.Collections.Generic;

namespace HW9;

public class Team
{
    List<Player> players = new List<Player>();
    string country;
    public string nameOfTeam;
    public int score;

    public Team(string country, string nameOfTeam, params Player[] players)
    {
        this.country = country;
        this.nameOfTeam = nameOfTeam;
        AddPlayer(players);
    }

    public void AddPlayer(params Player[] players)
    {
        foreach (Player player in players)
        {
            if (player.country != country || this.players.Count >= 15)
            {
                Console.WriteLine($"Игрок {player.playerName} не добавлен: из другой страны или превышено количество.");
                continue;
            }
            this.players.Add(player);
        }
    }

    public void AddScore(int newScore)
    {
        if (newScore < 0)
        {
            Console.WriteLine("Счёт должен только добавляться.");
            return;
        }

        score += newScore;
    }
}
