namespace PhytonInterpreter
{
    public abstract class Variable
    {
        public abstract Variable Substract(Variable otherVariable);
        public abstract Variable Add(Variable otherVariable);
    }

    public sealed class IntVariable : Variable
    {
        int _value;

        public IntVariable(int value)
        {
            _value = value;
        }

        public override Variable Add(Variable otherVariable)
        {
            var otherIntVariable = (IntVariable)otherVariable;
            return new IntVariable(_value + otherIntVariable._value);
        }

        public override Variable Substract(Variable otherVariable)
        {
            var otherIntVariable = (IntVariable)otherVariable;
            return new IntVariable(_value - otherIntVariable._value);
        }

        public override string ToString()
        {
            return _value.ToString();
        }
    }
}
