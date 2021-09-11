using System.Collections;
using System.Collections.Generic;

namespace PhytonInterpreter
{
    public sealed class Context : IEnumerable<KeyValuePair<string, Variable>>
    {
        Dictionary<string, Variable> _variables;

        public Context()
        {
            _variables = new Dictionary<string, Variable>(16);
        }

        public Variable GetVariable(string name)
        {
            return _variables[name];
        }

        public void AddVariable(string name, Variable variable)
        {
            _variables.Add(name, variable);
        }

        IEnumerator<KeyValuePair<string, Variable>> IEnumerable<KeyValuePair<string, Variable>>.GetEnumerator()
        {
            return _variables.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _variables.GetEnumerator();
        }
    }
}
