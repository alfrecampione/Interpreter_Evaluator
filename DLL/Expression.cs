namespace DLL;

public abstract class Expression
{
    public abstract double Evaluate();
}
public class BinaryGeneric : Expression
{
    Expression left;
    Expression right;
    Func<double, double, double> func;
    public BinaryGeneric(Expression left, Expression right, Func<double, double, double> func)
    {
        this.left = left;
        this.right = right;
        this.func = func;
    }
    public override double Evaluate()
    {
        return Evaluate(left.Evaluate(), right.Evaluate());
    }
    private double Evaluate(double leftValue, double rightValue)
    {
        return this.func(leftValue, rightValue);
    }
}
public class UnaryGeneric : Expression
{
    Expression expression;
    Func<double, double> func;
    public UnaryGeneric(Expression e, Func<double, double> func)
    {
        this.expression = e;
        this.func = func;
    }
    public override double Evaluate()
    {
        return Evaluate(expression.Evaluate());
    }
    protected double Evaluate(double value)
    {
        return this.func(value);
    }
}
public class Const : Expression
{
    readonly double _value;
    public Const(double value)
    {
        this._value = value;
    }

    public override double Evaluate()
    {
        return _value;
    }
}
public class Variable : Expression
{
    public readonly string Id;
    private double _x;
    public Variable(string id)
    {
        this.Id = id;
        Evaluator.ChangeValue += WatchValue;
    }

    public override double Evaluate()
    {
        return _x;
    }


    private void WatchValue(string? id, double x)
    {
        if (id == this.Id)
            this._x = x;
    }
}
