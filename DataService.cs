using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroProject.Web
{
  public class Hero
  {
    public string Name { get; set; }
  }

  public class Villan
  {
    public string Name { get; set; }
  }

  public class Match
  {
    public Hero Hero { get; set; }
    public Villan Villan { get; set; }
    public string Winner { get; set; }
  }

  public class DataService
  {
    List<Hero> _heros = new List<Hero>();
    List<Villan> _villan = new List<Villan>();

    List<Match> _match = new List<Match>();

    public DataService()
    {
      _heros.Add(new Hero { Name = "Superman" });
      _heros.Add(new Hero { Name = "Batman" });
      _heros.Add(new Hero { Name = "Ironman" });
      _heros.Add(new Hero { Name = "Black Panther" });
      _heros.Add(new Hero { Name = "The Flash" });
      _heros.Add(new Hero { Name = "Spiderman" });
      _villan.Add(new Villan { Name =  "Lex Luthor" });
      _villan.Add(new Villan { Name =  "The Penguin" });
      _villan.Add(new Villan { Name =  "Joker" });
      _villan.Add(new Villan { Name =  "Poison Ivy" });
      _villan.Add(new Villan { Name =  "Zoom" });
      _villan.Add(new Villan { Name =  "Green Goblin" });
      _match.Add(new Match {Name = "Superman", Name = "Lex Luthor", Winner = "Superman"});
      _match.Add(new Match {Name = "Spiderman", Name = "Green Goblin", Winner = "Spiderman"});
      _match.Add(new Match {Name = "The Flash", Name = "Zoom", Winner = "Zoom"});
      _match.Add(new Match {Name = "Black Panther", Name = "The Penguin", Winner = "Black Panther"});
      _match.Add(new Match {Name = "Batman", Name = "Joker", Winner = "Joker"});
    }

    public List<Hero> GetHeros()
    {
      return _heros;
      return _villan;
    }

    public boolean HaveTheyFaught(Hero hero, Villan villan)
    {
        return _match;
    }
  }
}

