namespace DLL;
public class Evaluator
{
    public List<string>? IDs;
    private readonly Expression? _expression;
    public static event Action<string?, double>? ChangeValue;
    public Evaluator(Expression exp, List<string> ids)
    {
        IDs?.Sort();
        this.IDs = ids;
        this._expression = exp;
    }
    public double Evaluate(params double[] values)
    {
        if (_expression == null)
        {
            throw new Exception("Expression is not assigned");
        }
        //Le asigna el valor de la x actual a la(s) variable(s) contenida(s) en la expresión para obtener el f(x1,...,xn)
        for (int i = 0; i < values.Length; i++)
        {
            ChangeValue?.Invoke(IDs?[i], values[i]);
        }
        return _expression.Evaluate();
    }
    /// <summary>
    ///  Evalua una expresion q no tenga variables
    /// </summary>
    /// <returns></returns>
    public double Evaluate()
    {
        if (_expression == null)
        {
            throw new Exception("Expression is not assigned");
        }
        return _expression.Evaluate();
    }
}