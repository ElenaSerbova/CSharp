using System;

namespace MulticastDelegates
{
    class Program
    {
        delegate void Operation(int a, int b);
        static void Main(string[] args)
        {
            Operation op1 = new Operation(CalculationHelper.Sum);
            Operation op2 = CalculationHelper.Sub;

            Operation operation = (Operation)Operation.Combine(op1, op2);           

            operation = operation + new Operation(CalculationHelper.Mult);
            
            operation += CalculationHelper.Div;

            operation(10, 20);


        }
    }
}
