using System;

namespace ChainOfResponsibility
{
    public interface IExpenseReport
    {
        Decimal Total { get; }
    }
}