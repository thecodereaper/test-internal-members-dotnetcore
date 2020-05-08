using System.Collections.Generic;

namespace InternalsDemo
{
    public interface IHeroService
    {
        IEnumerable<Hero> GetAll();
    }
}