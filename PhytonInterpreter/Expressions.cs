namespace PhytonInterpreter
{
    public interface IExpression
    {
        void Interpret(Context context);
    }

    public sealed class PrintContext : IExpression
    {
        public void Interpret(Context context)
        {
            foreach (var item in context)
            {
                Console.WriteLine($"var {item.Key} = {item.Value}");
            }
        }
    }

    public sealed class CreateIntVariableExpression : IExpression
    {
        string _varName;
        string _varValue;

        public CreateIntVariableExpression(string varName, string varValue)
        {
            _varName = varName;
            _varValue = varValue;
        }

        public void Interpret(Context context)
        {
            context.AddVariable(_varName, new IntVariable(int.Parse(_varValue)));
        }
    }

    public sealed class CreateVariableExpression : IExpression
    {
        VariableExpression _variableExpression;
        string _varName;

        public CreateVariableExpression(string varName, VariableExpression variableExpression)
        {
            _variableExpression = variableExpression;
            _varName = varName;
        }

        public void Interpret(Context context)
        {
            context.AddVariable(_varName, _variableExpression.Interpret(context));
        }
    }
}
