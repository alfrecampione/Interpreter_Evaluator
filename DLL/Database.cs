namespace DLL;

public static class Database
{
    public static Dictionary<string, Func<double, double, double>> BynaryStringToExpression = new()
    {
        {"sum" , (x,y)=>x+y},
        {"sub" , (x,y)=>x-y},
        {"mult" , (x,y)=>x*y},
        {"div" , (x,y)=>x/y},
        {"pow" , (x,y)=>Math.Pow((double)x,(double)y)}
        };
    public static Dictionary<string, Func<double, double>> UnaryStringToExpression = new()
    {
        {"arccos",(x)=>Math.Acos((double)x)},
        {"arcsin",(x)=>Math.Asin((double)x)},
        {"sinh",(x)=>Math.Sinh((double)x)},
        {"cosh",(x)=>Math.Cosh((double)x)},
        {"arcsinh",(x)=>Math.Asinh((double)x)},
        {"arccosh",(x)=>Math.Acosh((double)x)},
        { "sin",(x)=> Math.Sin((double)x)},
        { "cos",(x)=> Math.Cos((double)x)},
        { "tan",(x)=> Math.Tan((double)x)},
        { "cot",(x)=> 1/Math.Tan((double)x)},
        { "sec",(x)=> 1/Math.Cos((double)x)},
        { "csc",(x)=> 1/Math.Sin((double)x)},
        {"log2" , (x)=>Math.Log((double)x,2)},
        {"log10" , (x)=>Math.Log10((double)x)},
        {"log" , (x)=>Math.Log10((double)x)},
        {"ln" , (x)=>Math.Log((double)x)}
    };
    public static readonly Dictionary<string, string> BinaryOperators = new()
    {
        { "+", "sum" },
        { "-", "sub" },
        { "*", "mult" },
        { "/", "div" },
        { "^", "pow" }
    };
    public static readonly Dictionary<string, string> UnaryOperators = new()
    {
        {"arccos","arccos"},
        {"arcsin","arcsin"},
        {"sinh","sinh"},
        {"cosh","cosh"},
        {"arcsinh","arcsinh"},
        {"arccosh","arccosh"},
        { "log2", "log2" },
        { "log10", "log10" },
        { "log", "log" },
        { "ln", "ln" },
        { "sin", "sin" },
        { "cos", "cos" },
        { "tan", "tan" },
        { "cot", "cot" },
        { "sec", "sec" },
        { "csc", "csc" }
    };
    public static Dictionary<string, double> constToNumber = new()
    {
        {"e",Math.E},
        {"pi",Math.PI},
        {"inf",double.PositiveInfinity}
    };
}