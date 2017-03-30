using ChainOfResponsibilityPoker.Enums;

namespace ChainOfResponsibilityPoker.Catagorizers
{
    class HighCardCatagorizer : HandCatagorizer
    {
        public override HandRanking Catagorize(Hand hand)
        {
            return HandRanking.HighCard;
        }
    }
}