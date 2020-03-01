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

    public class DataService
    {
        List<Hero> _heros = new List<Hero>();

        public DataService()
        {
            _heros.Add(new Hero { Name = "Superman" });
            _heros.Add(new Hero { Name = "Batman" });
        }

        public List<Hero> GetHeros()
        {
            return _heros;
        }
    }
}
