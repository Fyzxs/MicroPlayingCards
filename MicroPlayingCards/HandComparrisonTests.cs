using FluentAssertions;
using MicroPlayingCards.Core;
using MicroPlayingCards.Scoring.HighCard;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace MicroPlayingCards
{
    [TestClass]
    public class HandComparrisonTests
    {
        private static readonly IHand AceOfSpadesHigh = new Hand(Deck.Spades.Ace, Deck.Clubs.Six, Deck.Diamonds.Four,
            Deck.Hearts.Two, Deck.Hearts.Three);

        private static readonly IHand KingOfSpadesHigh = new Hand(Deck.Spades.King, Deck.Clubs.Six, Deck.Diamonds.Four,
            Deck.Hearts.Two, Deck.Hearts.Three);

        private static readonly IHand QueenOfSpadesHigh = new Hand(Deck.Spades.Queen, Deck.Clubs.Six, Deck.Diamonds.Four,
            Deck.Hearts.Two, Deck.Hearts.Three);

        private static readonly IHand JackOfSpadesHigh = new Hand(Deck.Spades.Jack, Deck.Clubs.Six, Deck.Diamonds.Four,
            Deck.Hearts.Two, Deck.Hearts.Three);

        private static readonly IHand TenOfSpadesHigh = new Hand(Deck.Spades.Ten, Deck.Clubs.Six, Deck.Diamonds.Four,
            Deck.Hearts.Two, Deck.Hearts.Three);

        private static readonly IHand NineOfSpadesHigh = new Hand(Deck.Spades.Nine, Deck.Clubs.Six, Deck.Diamonds.Four,
            Deck.Hearts.Two, Deck.Hearts.Three);

        private static readonly IHand EightOfSpadesHigh = new Hand(Deck.Spades.Eight, Deck.Clubs.Six, Deck.Diamonds.Four,
            Deck.Hearts.Two, Deck.Hearts.Three);

        private static readonly IHand SevenOfSpadesHigh = new Hand(Deck.Spades.Seven, Deck.Clubs.Six, Deck.Diamonds.Four,
            Deck.Hearts.Two, Deck.Hearts.Three);

        private static readonly IHand AceOfDiamondsHigh = new Hand(Deck.Diamonds.Ace, Deck.Clubs.Six, Deck.Diamonds.Four,
            Deck.Hearts.Two, Deck.Hearts.Three);

        private static readonly IHand KingOfDiamondsHigh = new Hand(Deck.Diamonds.King, Deck.Clubs.Six, Deck.Diamonds.Four,
            Deck.Hearts.Two, Deck.Hearts.Three);

        private static readonly IHand QueenOfDiamondsHigh = new Hand(Deck.Diamonds.Queen, Deck.Clubs.Six,
            Deck.Diamonds.Four, Deck.Hearts.Two, Deck.Hearts.Three);

        private static readonly IHand JackOfDiamondsHigh = new Hand(Deck.Diamonds.Jack, Deck.Clubs.Six, Deck.Diamonds.Four,
            Deck.Hearts.Two, Deck.Hearts.Three);

        private static readonly IHand TenOfDiamondsHigh = new Hand(Deck.Diamonds.Ten, Deck.Clubs.Six, Deck.Diamonds.Four,
            Deck.Hearts.Two, Deck.Hearts.Three);

        private static readonly IHand NineOfDiamondsHigh = new Hand(Deck.Diamonds.Nine, Deck.Clubs.Six, Deck.Diamonds.Four,
            Deck.Hearts.Two, Deck.Hearts.Three);

        private static readonly IHand EightOfDiamondsHigh = new Hand(Deck.Diamonds.Eight, Deck.Clubs.Six,
            Deck.Diamonds.Four, Deck.Hearts.Two, Deck.Hearts.Three);

        private static readonly IHand SevenOfDiamondsHigh = new Hand(Deck.Diamonds.Seven, Deck.Clubs.Six,
            Deck.Diamonds.Four, Deck.Hearts.Two, Deck.Hearts.Three);

        private static readonly IHand AceOfHeartsHigh = new Hand(Deck.Hearts.Ace, Deck.Clubs.Six, Deck.Hearts.Four,
            Deck.Hearts.Two, Deck.Hearts.Three);

        private static readonly IHand KingOfHeartsHigh = new Hand(Deck.Hearts.King, Deck.Clubs.Six, Deck.Hearts.Four,
            Deck.Hearts.Two, Deck.Hearts.Three);

        private static readonly IHand QueenOfHeartsHigh = new Hand(Deck.Hearts.Queen, Deck.Clubs.Six, Deck.Hearts.Four,
            Deck.Hearts.Two, Deck.Hearts.Three);

        private static readonly IHand JackOfHeartsHigh = new Hand(Deck.Hearts.Jack, Deck.Clubs.Six, Deck.Hearts.Four,
            Deck.Hearts.Two, Deck.Hearts.Three);

        private static readonly IHand TenOfHeartsHigh = new Hand(Deck.Hearts.Ten, Deck.Clubs.Six, Deck.Hearts.Four,
            Deck.Hearts.Two, Deck.Hearts.Three);

        private static readonly IHand NineOfHeartsHigh = new Hand(Deck.Hearts.Nine, Deck.Clubs.Six, Deck.Hearts.Four,
            Deck.Hearts.Two, Deck.Hearts.Three);

        private static readonly IHand EightOfHeartsHigh = new Hand(Deck.Hearts.Eight, Deck.Clubs.Six, Deck.Hearts.Four,
            Deck.Hearts.Two, Deck.Hearts.Three);

        private static readonly IHand SevenOfHeartsHigh = new Hand(Deck.Hearts.Seven, Deck.Clubs.Six, Deck.Hearts.Four,
            Deck.Hearts.Two, Deck.Hearts.Three);

        private static readonly IHand AceOfClubsHigh = new Hand(Deck.Clubs.Ace, Deck.Hearts.Six, Deck.Clubs.Four,
            Deck.Clubs.Two, Deck.Clubs.Three);

        private static readonly IHand KingOfClubsHigh = new Hand(Deck.Clubs.King, Deck.Hearts.Six, Deck.Clubs.Four,
            Deck.Clubs.Two, Deck.Clubs.Three);

        private static readonly IHand QueenOfClubsHigh = new Hand(Deck.Clubs.Queen, Deck.Hearts.Six, Deck.Clubs.Four,
            Deck.Clubs.Two, Deck.Clubs.Three);

        private static readonly IHand JackOfClubsHigh = new Hand(Deck.Clubs.Jack, Deck.Hearts.Six, Deck.Clubs.Four,
            Deck.Clubs.Two, Deck.Clubs.Three);

        private static readonly IHand TenOfClubsHigh = new Hand(Deck.Clubs.Ten, Deck.Hearts.Six, Deck.Clubs.Four,
            Deck.Clubs.Two, Deck.Clubs.Three);

        private static readonly IHand NineOfClubsHigh = new Hand(Deck.Clubs.Nine, Deck.Hearts.Six, Deck.Clubs.Four,
            Deck.Clubs.Two, Deck.Clubs.Three);

        private static readonly IHand EightOfClubsHigh = new Hand(Deck.Clubs.Eight, Deck.Hearts.Six, Deck.Clubs.Four,
            Deck.Clubs.Two, Deck.Clubs.Three);

        private static readonly IHand SevenOfClubsHigh = new Hand(Deck.Clubs.Seven, Deck.Hearts.Six, Deck.Clubs.Four,
            Deck.Clubs.Two, Deck.Clubs.Three);


        [TestMethod, TestCategory("unit")]
        public void ShouldReturnAceOfSpadesHigh() => HandShouldScore(AceOfSpadesHigh, Score.AceSpadeHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnKingOfSpadesHigh() => HandShouldScore(KingOfSpadesHigh, Score.KingSpadeHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnQueenOfSpadesHigh() => HandShouldScore(QueenOfSpadesHigh, Score.QueenSpadeHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnJackOfSpadesHigh() => HandShouldScore(JackOfSpadesHigh, Score.JackSpadeHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnTenOfSpadesHigh() => HandShouldScore(TenOfSpadesHigh, Score.TenSpadeHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnNineOfSpadesHigh() => HandShouldScore(NineOfSpadesHigh, Score.NineSpadeHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnEightOfSpadesHigh() => HandShouldScore(EightOfSpadesHigh, Score.EightSpadeHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnSevenOfSpadesHigh() => HandShouldScore(SevenOfSpadesHigh, Score.SevenSpadeHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnAceOfDiamondsHigh() => HandShouldScore(AceOfDiamondsHigh, Score.AceDiamondHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnKingOfDiamondsHigh() => HandShouldScore(KingOfDiamondsHigh, Score.KingDiamondHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnQueenOfDiamondsHigh() => HandShouldScore(QueenOfDiamondsHigh, Score.QueenDiamondHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnJackOfDiamondsHigh() => HandShouldScore(JackOfDiamondsHigh, Score.JackDiamondHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnTenOfDiamondsHigh() => HandShouldScore(TenOfDiamondsHigh, Score.TenDiamondHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnNineOfDiamondsHigh() => HandShouldScore(NineOfDiamondsHigh, Score.NineDiamondHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnEightOfDiamondsHigh() => HandShouldScore(EightOfDiamondsHigh, Score.EightDiamondHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnSevenOfDiamondsHigh() => HandShouldScore(SevenOfDiamondsHigh, Score.SevenDiamondHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnAceOfHeartsHigh() => HandShouldScore(AceOfHeartsHigh, Score.AceHeartHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnKingOfHeartsHigh() => HandShouldScore(KingOfHeartsHigh, Score.KingHeartHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnQueenOfHeartsHigh() => HandShouldScore(QueenOfHeartsHigh, Score.QueenHeartHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnJackOfHeartsHigh() => HandShouldScore(JackOfHeartsHigh, Score.JackHeartHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnTenOfHeartsHigh() => HandShouldScore(TenOfHeartsHigh, Score.TenHeartHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnNineOfHeartsHigh() => HandShouldScore(NineOfHeartsHigh, Score.NineHeartHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnEightOfHeartsHigh() => HandShouldScore(EightOfHeartsHigh, Score.EightHeartHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnSevenOfHeartsHigh() => HandShouldScore(SevenOfHeartsHigh, Score.SevenHeartHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnAceOfClubsHigh() => HandShouldScore(AceOfClubsHigh, Score.AceClubHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnKingOfClubsHigh() => HandShouldScore(KingOfClubsHigh, Score.KingClubHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnQueenOfClubsHigh() => HandShouldScore(QueenOfClubsHigh, Score.QueenClubHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnJackOfClubsHigh() => HandShouldScore(JackOfClubsHigh, Score.JackClubHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnTenOfClubsHigh() => HandShouldScore(TenOfClubsHigh, Score.TenClubHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnNineOfClubsHigh() => HandShouldScore(NineOfClubsHigh, Score.NineClubHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnEightOfClubsHigh() => HandShouldScore(EightOfClubsHigh, Score.EightClubHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnSevenOfClubsHigh() => HandShouldScore(SevenOfClubsHigh, Score.SevenClubHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnAceOfHeartHighGivenHasLowerSpade() => HandShouldScore(
            new Hand(Deck.Hearts.Ace, Deck.Spades.King, Deck.Clubs.Four, Deck.Clubs.Two, Deck.Diamonds.Three),
            Score.AceHeartHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnAceOfDiamondsHighGivenHasLowerSpade() => HandShouldScore(
            new Hand(Deck.Diamonds.Ace, Deck.Spades.King, Deck.Clubs.Four, Deck.Clubs.Two, Deck.Diamonds.Three),
            Score.AceDiamondHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnAceOfClubGivenHasLowerClub() => HandShouldScore(
            new Hand(Deck.Clubs.Ace, Deck.Spades.King, Deck.Clubs.Four, Deck.Clubs.Two, Deck.Diamonds.Three),
            Score.AceClubHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnKingOfHeartHighGivenHasLowerSpade() => HandShouldScore(
            new Hand(Deck.Hearts.King, Deck.Spades.Queen, Deck.Clubs.Four, Deck.Clubs.Two, Deck.Diamonds.Three),
            Score.KingHeartHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnKingOfDiamondsHighGivenHasLowerSpade() => HandShouldScore(
            new Hand(Deck.Diamonds.King, Deck.Spades.Queen, Deck.Clubs.Four, Deck.Clubs.Two, Deck.Diamonds.Three),
            Score.KingDiamondHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnKingOfClubGivenHasLowerClub() => HandShouldScore(
            new Hand(Deck.Clubs.King, Deck.Spades.Queen, Deck.Clubs.Queen, Deck.Clubs.Two, Deck.Diamonds.Three),
            Score.KingClubHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnQueenOfHeartHighGivenHasLowerSpade() => HandShouldScore(
            new Hand(Deck.Hearts.Queen, Deck.Spades.Jack, Deck.Clubs.Four, Deck.Clubs.Two, Deck.Diamonds.Three),
            Score.QueenHeartHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnQueenOfDiamondsHighGivenHasLowerSpade() => HandShouldScore(
            new Hand(Deck.Diamonds.Queen, Deck.Spades.Jack, Deck.Clubs.Four, Deck.Clubs.Two, Deck.Diamonds.Three),
            Score.QueenDiamondHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnQueenOfClubGivenHasLowerClub() => HandShouldScore(
            new Hand(Deck.Clubs.Queen, Deck.Spades.Jack, Deck.Clubs.Jack, Deck.Clubs.Two, Deck.Diamonds.Three),
            Score.QueenClubHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnJackOfHeartHighGivenHasLowerSpade() => HandShouldScore(
            new Hand(Deck.Hearts.Jack, Deck.Spades.Ten, Deck.Clubs.Four, Deck.Clubs.Two, Deck.Diamonds.Three),
            Score.JackHeartHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnJackOfDiamondsHighGivenHasLowerSpade() => HandShouldScore(
            new Hand(Deck.Diamonds.Jack, Deck.Spades.Ten, Deck.Clubs.Four, Deck.Clubs.Two, Deck.Diamonds.Three),
            Score.JackDiamondHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnJackOfClubGivenHasLowerClub() => HandShouldScore(
            new Hand(Deck.Clubs.Jack, Deck.Spades.Ten, Deck.Clubs.Four, Deck.Clubs.Two, Deck.Diamonds.Three),
            Score.JackClubHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnTenOfHeartHighGivenHasLowerSpade() => HandShouldScore(
            new Hand(Deck.Hearts.Ten, Deck.Spades.Nine, Deck.Clubs.Four, Deck.Clubs.Two, Deck.Diamonds.Three),
            Score.TenHeartHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnTenOfDiamondsHighGivenHasLowerSpade() => HandShouldScore(
            new Hand(Deck.Diamonds.Ten, Deck.Spades.Nine, Deck.Clubs.Four, Deck.Clubs.Two, Deck.Diamonds.Three),
            Score.TenDiamondHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnTenOfClubGivenHasLowerClub() => HandShouldScore(
            new Hand(Deck.Clubs.Ten, Deck.Spades.Nine, Deck.Clubs.Four, Deck.Clubs.Two, Deck.Diamonds.Three),
            Score.TenClubHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnNineOfHeartHighGivenHasLowerSpade() => HandShouldScore(
            new Hand(Deck.Hearts.Nine, Deck.Spades.Eight, Deck.Clubs.Four, Deck.Clubs.Two, Deck.Diamonds.Three),
            Score.NineHeartHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnNineOfDiamondsHighGivenHasLowerSpade() => HandShouldScore(
            new Hand(Deck.Diamonds.Nine, Deck.Spades.Eight, Deck.Clubs.Four, Deck.Clubs.Two, Deck.Diamonds.Three),
            Score.NineDiamondHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnNineOfClubGivenHasLowerClub() => HandShouldScore(
            new Hand(Deck.Clubs.Nine, Deck.Spades.Eight, Deck.Clubs.Four, Deck.Clubs.Two, Deck.Diamonds.Three),
            Score.NineClubHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnEightOfHeartHighGivenHasLowerSpade() => HandShouldScore(
            new Hand(Deck.Hearts.Eight, Deck.Spades.Seven, Deck.Clubs.Four, Deck.Clubs.Two, Deck.Diamonds.Three),
            Score.EightHeartHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnEightOfDiamondsHighGivenHasLowerSpade() => HandShouldScore(
            new Hand(Deck.Diamonds.Eight, Deck.Spades.Seven, Deck.Clubs.Four, Deck.Clubs.Two, Deck.Diamonds.Three),
            Score.EightDiamondHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnEightOfClubGivenHasLowerClub() => HandShouldScore(
            new Hand(Deck.Clubs.Eight, Deck.Spades.Seven, Deck.Clubs.Four, Deck.Clubs.Two, Deck.Diamonds.Three),
            Score.EightClubHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnSevenOfHeartHighGivenHasLowerSpade() => HandShouldScore(
            new Hand(Deck.Hearts.Seven, Deck.Spades.Six, Deck.Clubs.Four, Deck.Clubs.Two, Deck.Diamonds.Three),
            Score.SevenHeartHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnSevenOfDiamondsHighGivenHasLowerSpade() => HandShouldScore(
            new Hand(Deck.Diamonds.Seven, Deck.Spades.Six, Deck.Clubs.Four, Deck.Clubs.Two, Deck.Diamonds.Three),
            Score.SevenDiamondHigh);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnSevenOfClubGivenHasLowerClub() => HandShouldScore(
            new Hand(Deck.Clubs.Seven, Deck.Spades.Six, Deck.Clubs.Four, Deck.Clubs.Two, Deck.Diamonds.Three),
            Score.SevenClubHigh);


        private void HandShouldScore(IHand hand, IScore score) => hand.HandScore().Should().Be(score);

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnPairAceSpadeHigh()
        {
            //Arrange
            

            //Act

            //Assert
        }
    }

    public class Hand : IHand
    {
        private readonly ICard[] _cards;

        public Hand(params ICard[] cards) => _cards = cards;

        public IScore HandScore()
        {
            return ScoreSingleCard();
        }

        public bool HasCard(ICard card) => _cards.Contains(card);

        private IScore ScoreSingleCard()
        {
            return new SingleCardScoring().Scoring(this);
        }
    }
}