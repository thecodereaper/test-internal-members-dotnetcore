using System.Collections.Generic;
using System.Linq;
using AutoFixture;
using FluentAssertions;
using Moq;
using Xunit;

namespace InternalsDemo.Tests
{
    public sealed class HeroServiceTests
    {
        private readonly IFixture _fixture;
        private readonly IHeroService _heroService;
        private readonly Mock<IHeroRepository> _mockHeroRepository;

        public HeroServiceTests()
        {
            _fixture = new Fixture();
            _mockHeroRepository = new Mock<IHeroRepository>();
            _heroService = new HeroService(_mockHeroRepository.Object);
        }

        [Fact]
        public void GetAll_WhenHeroesExist_ThenShouldReturnAllHeroes()
        {
            Hero mockHero = _fixture.Create<Hero>();
            IEnumerable<Hero> expectedHeroes = new[] { mockHero };
            _mockHeroRepository.Setup(call => call.FetchAll()).Returns(expectedHeroes);

            IList<Hero> actualHeroes = _heroService.GetAll().ToList();

            actualHeroes.Should().HaveCount(expectedHeroes.Count());
            actualHeroes.FirstOrDefault().Should().Be(mockHero);
        }
    }
}