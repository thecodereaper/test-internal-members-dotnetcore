using System.Collections.Generic;

namespace InternalsDemo
{
    public interface IHeroRepository
    {
        IEnumerable<Hero> FetchAll();
    }
}