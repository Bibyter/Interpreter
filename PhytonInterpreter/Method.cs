using System.Collections.Generic;

namespace PhytonInterpreter
{
    public sealed class Method
    {
        List<IExpression> _expressions;

        public Method()
        {
            _expressions = new List<IExpression>(8);
        }

        public void AddExpression(IExpression expression)
        {
            _expressions.Add(expression);
        }

        public void Execute()
        {
            var context = new Context();
            for (int i = 0; i < _expressions.Count; i++)
            {
                _expressions[i].Interpret(context);
            }
        }
    }
}
