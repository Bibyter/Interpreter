using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhytonInterpreter
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var method = new Method();

            method.AddExpression(new CreateVariableExpression("a", new InputIntVariable()));
            method.AddExpression(new CreateIntVariableExpression("b", "20"));
            method.AddExpression(new CreateVariableExpression("c", new SubstractExpression("b", "a")));
            method.AddExpression(new PrintContext());

            method.Execute();

            Console.ReadKey();
        }
    }
}
