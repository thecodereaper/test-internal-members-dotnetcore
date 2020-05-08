using System.Collections.Generic;

namespace InternalsDemo
{
    internal sealed class HeroService : IHeroService
    {
        private readonly IHeroRepository _heroRepository;

        public HeroService(IHeroRepository heroRepository)
        {
            _heroRepository = heroRepository;
        }

        public IEnumerable<Hero> GetAll()
        {
            return _heroRepository.FetchAll();
        }
    }
}