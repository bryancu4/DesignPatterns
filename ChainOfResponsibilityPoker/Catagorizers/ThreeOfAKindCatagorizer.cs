using ChainOfResponsibilityPoker.Enums;

namespace ChainOfResponsibilityPoker.Catagorizers
{
    class ThreeOfAKindCatagorizer : HandCatagorizer
    {
        public override HandRanking Catagorize(Hand hand)
        {
            if (HasNofKind(3, hand))
            {
                return HandRanking.ThreeOfAKind;
            }

            return Next.Catagorize(hand);
        }
    }
}