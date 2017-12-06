using FluentAssertions;
using MicroPlayingCards.Core;
using MicroPlayingCards.ValueCompares;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MicroPlayingCards
{
    [TestClass]
    public class PlayingCardTests
    {
        [TestMethod, TestCategory("unit")]
        public void ShouldReturnFalseGivenSameCard()
        {
            //Arrange
            ICard card = new Card(Suit.Club);

            //Act
            IValueCompare compared = card.Compare(card);

            //Assert
            compared.IsEqual().Should().BeTrue();
        }
        [TestMethod, TestCategory("unit")]
        public void ShouldReturnGreaterGivenDiamondVsClub()
        {
            //Arrange
            ICard club = new Card(Suit.Club);
            ICard diamond = new Card(Suit.Diamond);

            //Act
            IValueCompare compared = diamond.Compare(club);

            //Assert
            compared.IsGreater().Should().BeTrue();
        }
        [TestMethod, TestCategory("unit")]
        public void ShouldReturnFalseGivenClubVsDiamond()
        {
            //Arrange
            ICard club = new Card(Suit.Club);
            ICard diamond = new Card(Suit.Diamond);

            //Act
            IValueCompare compared = club.Compare(diamond);

            //Assert
            compared.IsLesser().Should().BeTrue();
        }
        [TestMethod, TestCategory("unit")]
        public void ShouldReturnGreaterGivenHeartVsDiamond()
        {
            //Arrange
            ICard diamond = new Card(Suit.Diamond);
            ICard heart = new Card(Suit.Heart);

            //Act
            IValueCompare compared = heart.Compare(diamond);

            //Assert
            compared.Should().Be(ValueCompare.Greater);
        }
        [TestMethod, TestCategory("unit")]
        public void ShouldReturnFalseGivenDiamondVsHeart()
        {
            //Arrange
            ICard diamond = new Card(Suit.Diamond);
            ICard heart = new Card(Suit.Heart);

            //Act
            IValueCompare compared = diamond.Compare(heart);

            //Assert
            compared.IsLesser().Should().BeTrue();
        }
        [TestMethod, TestCategory("unit")]
        public void ShouldReturnGreaterGivenSpadeVsHeart()
        {
            //Arrange
            ICard heart = new Card(Suit.Heart);
            ICard spade = new Card(Suit.Spade);

            //Act
            IValueCompare compared = spade.Compare(heart);

            //Assert
            compared.IsGreater().Should().BeTrue();
        }
        [TestMethod, TestCategory("unit")]
        public void ShouldReturnFalseGivenHeartVsSpade()
        {
            //Arrange
            ICard heart = new Card(Suit.Heart);
            ICard spade = new Card(Suit.Spade);

            //Act
            IValueCompare compared = heart.Compare(spade);

            //Assert
            compared.IsLesser().Should().BeTrue();
        }

        [TestMethod, TestCategory("integration")]
        public void ShouldReturnExpectedSuitRankingForEveryPermutation()
        {
            ICard[] suits =
            {
                new Card(Suit.Club),
                new Card(Suit.Diamond),
                new Card(Suit.Heart),
                new Card(Suit.Spade)
            };
            for (int thisIdx = 0; thisIdx < suits.Length; thisIdx++)
            {
                for (int otherIdx = 0; otherIdx < suits.Length; otherIdx++)
                {
                    IValueCompare compare = suits[thisIdx].Compare(suits[otherIdx]);
                    if (thisIdx == otherIdx)
                    {
                        compare.IsEqual().Should().BeTrue();
                        compare.IsLesser().Should().BeFalse();
                    }
                    if (thisIdx < otherIdx)
                    {
                        compare.IsEqual().Should().BeFalse();
                        compare.IsLesser().Should().BeTrue();
                    }
                    if (thisIdx > otherIdx)
                    {
                        compare.IsEqual().Should().BeFalse();
                        compare.IsLesser().Should().BeFalse();
                    }
                }
            }
        }
        [TestMethod, TestCategory("integration")]
        public void ShouldReturnSuitExpectedRankingForEveryPermutation()
        {
            ISuit[] suits =
            {
                Suit.Club,
                Suit.Diamond,
                Suit.Heart,
                Suit.Spade
            };
            for (int thisIdx = 0; thisIdx < suits.Length; thisIdx++)
            {
                for (int otherIdx = 0; otherIdx < suits.Length; otherIdx++)
                {
                    IValueCompare compare = suits[thisIdx].Compare(suits[otherIdx]);
                    if (thisIdx == otherIdx)
                    {
                        compare.IsEqual().Should().BeTrue();
                        compare.IsLesser().Should().BeFalse();
                        compare.IsGreater().Should().BeFalse();
                    }
                    if (thisIdx < otherIdx)
                    {
                        compare.IsEqual().Should().BeFalse();
                        compare.IsLesser().Should().BeTrue();
                        compare.IsGreater().Should().BeFalse();
                    }
                    if (thisIdx > otherIdx)
                    {
                        compare.IsEqual().Should().BeFalse();
                        compare.IsLesser().Should().BeFalse();
                        compare.IsGreater().Should().BeTrue();
                    }
                }
            }
        }


        [TestMethod, TestCategory("unit")]
        public void ShouldReturnGreaterGivenThreeVsTwo()
        {
            //Arrange
            ICard two = new Card(Suit.Club, Rank.Two);
            ICard three = new Card(Suit.Club, Rank.Three);

            //Act
            IValueCompare compared = three.Compare(two);

            //Assert
            compared.IsGreater().Should().BeTrue();
        }

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnGreaterGivenAceVsKing()
        {
            //Arrange
            ICard ace = new Card(Suit.Club, Rank.Ace);
            ICard king = new Card(Suit.Club, Rank.King);

            //Act
            IValueCompare compared = ace.Compare(king);

            //Assert
            compared.IsGreater().Should().BeTrue();
        }

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnFalseGivenThreeVsFour()
        {
            //Arrange
            ICard four = new Card(Suit.Club, Rank.Four);
            ICard three = new Card(Suit.Club, Rank.Three);

            //Act
            IValueCompare compared = three.Compare(four);

            //Assert
            compared.IsLesser().Should().BeTrue();
        }
        [TestMethod, TestCategory("integration")]
        public void ShouldReturnExpectedRankRankingForEveryPermutation()
        {
            ICard[] ranks =
            {
                new Card(Suit.Club, Rank.Two),
                new Card(Suit.Club, Rank.Three),
                new Card(Suit.Club, Rank.Four),
                new Card(Suit.Club, Rank.Five),
                new Card(Suit.Club, Rank.Six),
                new Card(Suit.Club, Rank.Seven),
                new Card(Suit.Club, Rank.Eight),
                new Card(Suit.Club, Rank.Nine),
                new Card(Suit.Club, Rank.Ten),
                new Card(Suit.Club, Rank.Jack),
                new Card(Suit.Club, Rank.Queen),
                new Card(Suit.Club, Rank.King),
                new Card(Suit.Club, Rank.Ace)
    };
            for (int thisIdx = 0; thisIdx < ranks.Length; thisIdx++)
            {
                for (int otherIdx = 0; otherIdx < ranks.Length; otherIdx++)
                {
                    IValueCompare compare = ranks[thisIdx].Compare(ranks[otherIdx]);
                    if (thisIdx == otherIdx)
                    {
                        compare.IsEqual().Should().BeTrue();
                        compare.IsLesser().Should().BeFalse();
                        compare.IsGreater().Should().BeFalse();
                    }
                    if (thisIdx < otherIdx)
                    {
                        compare.IsEqual().Should().BeFalse();
                        compare.IsLesser().Should().BeTrue();
                        compare.IsGreater().Should().BeFalse();
                    }
                    if (thisIdx > otherIdx)
                    {
                        compare.IsEqual().Should().BeFalse();
                        compare.IsLesser().Should().BeFalse();
                        compare.IsGreater().Should().BeTrue();
                    }
                }
            }

        }
    }

}
