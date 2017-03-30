using ChainOfResponsibilityPoker.Enums;

namespace ChainOfResponsibilityPoker.Catagorizers
{
    class FourOfAKindCatagorizer : HandCatagorizer
    {
        public override HandRanking Catagorize(Hand hand)
        {
            if (HasNofKind(4, hand))
            {
                return HandRanking.FourOfAKind;
            }

            return Next.Catagorize(hand);
        }
    }
}