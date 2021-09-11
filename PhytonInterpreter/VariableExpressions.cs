using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhytonInterpreter
{
    public abstract class VariableExpression : IExpression
    {
        public abstract Variable Interpret(Context context);

        void IExpression.Interpret(Context context)
        {
            Interpret(context);
        }
    }

    public sealed class SubstractExpression : VariableExpression
    {
        string _varNameA;
        string _varNameB;

        public SubstractExpression(string varNameA, string varNameB)
        {
            _varNameA = varNameA;
            _varNameB = varNameB;
        }

        public override Variable Interpret(Context context)
        {
            var varA = context.GetVariable(_varNameA);
            var varB = context.GetVariable(_varNameB);
            return varA.Substract(varB);
        }
    }

    public sealed class AddExpression : VariableExpression
    {
        string _varNameA;
        string _varNameB;

        public AddExpression(string varNameA, string varNameB)
        {
            _varNameA = varNameA;
            _varNameB = varNameB;
        }

        public override Variable Interpret(Context context)
        {
            var varA = context.GetVariable(_varNameA);
            var varB = context.GetVariable(_varNameB);
            return varA.Add(varB);
        }
    }


    public sealed class InputIntVariable : VariableExpression
    {
        public override Variable Interpret(Context context)
        {
            var input = Console.ReadLine();
            return new IntVariable(int.Parse(input));
        }
    }
}
