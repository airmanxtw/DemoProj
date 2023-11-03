using LanguageExt;
using static LanguageExt.Prelude;
namespace NewProj.lib;
public class Method
{
    public string Hello()
    {
        return "hello";
    }
    public int Add(int a, int b)
    {
        return a + b + 2;
    }

    public Either<string, double> Div(double x)
    {
        if (x == 0)
            return Left<string, double>("div by zero");
        return Right<string, double>(1 / x);
    }

    public Try<double> Div2(double x)
    {
        return () => 1 / x;
    }
}
