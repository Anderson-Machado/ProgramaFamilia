using Familia.Domain.Entities;
using Familia.Domain.Enums;
using Familia.Domain.PointsFactory.Factory;
using System.Collections.Generic;
using Xunit;

namespace Familia.Tests.Domain.PointsFactory
{
    public class ProviderPointsTest
    {

        private readonly PointsProcessFactory _pointsProcessFactory;

        public ProviderPointsTest()
        {

            _pointsProcessFactory = new PointsProcessFactory();
        }

        private void Factory(IEnumerable<Family> families, List<Points> points)
        {
            _pointsProcessFactory.CreateValuesPoints(EPointsValueType.UpToNineHundred).Calculate(families, points);
            _pointsProcessFactory.CreateValuesPoints(EPointsValueType.FromNineHundredToOneThousandFiveHundred).Calculate(families, points);
            _pointsProcessFactory.CreateValuesPoints(EPointsValueType.WithThreeOrMoreDependents).Calculate(families, points);
            _pointsProcessFactory.CreateValuesPoints(EPointsValueType.WithOneOrTwoDependents).Calculate(families, points);
        }

        [Fact]
        [Trait("ProviderPointsTest", "Deve retornar sucesso contendo 5 e 2 points considerando regra de até 900 e com dois dependentes com idade menor que 18.")]
        public void ShouldReturnSuccessContainingFiveAndTwo()
        {
            var listPoints = new List<Points>();
            var listFamily = new List<Family>() { new Family()
                {

                    Name = "Bernado",
                    Dependents = new List<Dependent>() { new Dependent() { Age = 17, Income = 400 },
                                                         new Dependent() { Age = 15, Income = 300 }},
                }
            };

            Factory(listFamily, listPoints);

            Assert.Equal(2, listPoints.Count);
            Assert.Contains(listPoints, x => x.PointsFamily == 5);
            Assert.Contains(listPoints, x => x.PointsFamily == 2);

        }

        [Fact]
        [Trait("ProviderPointsTest", "Deve retornar sucesso contendo 5 pontos considerando regra de até 900 e com dois dependentes com idade maior que 18.")]
        public void MustReturnSuccessContainingFivePoints()
        {
            var listPoints = new List<Points>();
            var listFamily = new List<Family>() { new Family()
                {

                    Name = "Silva",
                    Dependents = new List<Dependent>() { new Dependent() { Age = 24, Income = 400 },
                                                         new Dependent() { Age = 25, Income = 300 }},
                }
            };

            Factory(listFamily, listPoints);

            Assert.Equal(1, listPoints.Count);
            Assert.Contains(listPoints, x => x.PointsFamily == 5);

        }

        [Fact]
        [Trait("ProviderPointsTest", "Deve retornar sucesso contendo 3 e 2 pontos considerando regra de 901 à 1500 e com um dependentes com idade menor que 18.")]
        public void ShouldReturnSuccessContainingThreeAndTwo()
        {
            var listPoints = new List<Points>();
            var listFamily = new List<Family>() { new Family()
                {

                    Name = "Silva",
                    Dependents = new List<Dependent>() { new Dependent() { Age = 17, Income = 400 },
                                                         new Dependent() { Age = 25, Income = 1000 }},
                }
            };

            Factory(listFamily, listPoints);

            Assert.Equal(2, listPoints.Count);
            Assert.Contains(listPoints, x => x.PointsFamily == 3);
            Assert.Contains(listPoints, x => x.PointsFamily == 2);

        }

        [Fact]
        [Trait("ProviderPointsTest", "Deve retornar sucesso contendo 5 e 3 pontos considerando regra de 900 e com 3 dependentes com idade menor que 18.")]
        public void ShouldReturnSuccessContainingFiveAndThree()
        {
            var listPoints = new List<Points>();
            var listFamily = new List<Family>() { new Family()
                {

                    Name = "Silva",
                    Dependents = new List<Dependent>() { new Dependent() { Age = 17, Income = 400 },
                                                         new Dependent() { Age = 16, Income = 400 },
                                                         new Dependent() { Age = 16, Income = 50 }},
                }
            };

            Factory(listFamily, listPoints);

            Assert.Equal(2, listPoints.Count);
            Assert.Contains(listPoints, x => x.PointsFamily == 5);
            Assert.Contains(listPoints, x => x.PointsFamily == 3);

        }

        [Fact]
        [Trait("ProviderPointsTest", "Deve retornar sucesso contendo 0 pontos considerando que não atende as regras.")]
        public void ShouldReturnSuccessContainingZeropoints()
        {
            var listPoints = new List<Points>();
            var listFamily = new List<Family>() { new Family()
                {

                    Name = "Bezerra",
                    Dependents = new List<Dependent>() { new Dependent() { Age = 35, Income = 2400 },
                                                         new Dependent() { Age = 45, Income = 1000 }},
                }
            };

            Factory(listFamily, listPoints);

            Assert.Empty(listPoints);


        }

    }
}
