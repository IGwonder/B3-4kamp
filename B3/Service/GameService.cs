using System.Collections.Generic;
using System.Linq;

public class GameService
{
    public List<Player> PlayerList { get; } = new List<Player>();
    public List<Event> EventList { get; } = new List<Event>();

}

public class Player
{
    public string Name { get; set; }
    public int Score { get; set; }
    public Event AssignedEvent { get; set; }
}

public class Event
{
    public string Name { get; set; }
}
