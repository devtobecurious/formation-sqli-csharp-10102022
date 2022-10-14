using HarryPotter.Core.Library.Models;

namespace TestJeuHarryPotter
{
    public class CharacterUnitTest
    {
        public void Calculer() { }

        [Fact]
        public void ShouldBeDead()
        {
            // Arrange
            var voldemort = new MechantCharacter("Voldemort");
            voldemort.PointsDeVie = 100;

            // Act
            voldemort.PointsDeVie -= 100;

            // Assert
            Assert.Equal(voldemort.PointsDeVie, 0);

        }

        [Fact]
        public void ShouldBeDeadWithLife0()
        {
            // Arrange
            var voldemort = new MechantCharacter("Voldemort");
            voldemort.PointsDeVie = 100;

            // Act
            voldemort.PointsDeVie -= 120;

            // Assert
            Assert.Equal(voldemort.PointsDeVie, 0);
        }

        [Fact]
        public void ShouldBeDeadAndGetInfoAboutIt()
        {
            // Arrange
            var voldemort = new MechantCharacter("Voldemort");
            voldemort.PointsDeVie = 100;

            voldemort.Mourrir += character =>
            {
                Assert.True(true);
            };

            // Act
            voldemort.PointsDeVie -= 120;
            
        }

        [Fact]
        public void ShouldBeBeAliveWith100()
        {
            
        }
    }
}