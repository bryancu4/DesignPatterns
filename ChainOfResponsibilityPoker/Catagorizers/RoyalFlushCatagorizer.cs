using ChainOfResponsibilityPoker.Enums;

namespace ChainOfResponsibilityPoker.Catagorizers
{
    class RoyalFlushCatagorizer : HandCatagorizer
    {
        public override HandRanking Catagorize(Hand hand)
        {
            if(HasFlush(hand) && HasStraight(hand) && hand.HighCard.Value == Value.Ace)
            {
                return HandRanking.RoyalFlush;
            }

            return Next.Catagorize(hand);
        }
    }
}
