using System.Collections.Generic;
using System.Linq;

public class GameService
{
    public List<Player> PlayerList { get; } = new List<Player>();
    public List<Event> EventList { get; } = new List<Event>();

    public List<PlayerScores> GetTotalScores()
    {
        var playerScores = new List<PlayerScores>();

        foreach (var player in PlayerList)
        {
            var totalScore = player.Scores.Values.Sum();
            var playerScore = new PlayerScores
            {
                PlayerName = player.Name,
                TotalScore = totalScore
            };

            playerScores.Add(playerScore);
        }

        return playerScores.OrderByDescending(ps => ps.TotalScore).ToList();
    }
}

public class Player
{
    public string Name { get; set; }
    public List<Event> AssignedEvents { get; } = new List<Event>();
    public Dictionary<Event, int> Scores { get; } = new Dictionary<Event, int>();
}

public class Event
{
    public string Name { get; set; }
}

public class PlayerScores
{
    public string PlayerName { get; set; }
    public int TotalScore { get; set; }
}
