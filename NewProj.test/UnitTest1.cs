using LanguageExt.UnsafeValueAccess;
using NewProj.lib;
namespace NewProj.test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        Method md = new();
        var result = md.Div(0);
        Assert.IsTrue(result.IsLeft);
    }

    [TestMethod]
    public void TestMethod2()
    {
        Method md = new();
        var result = md.Div(2);
        Assert.AreEqual(0.5, result.Value());
    }

    [TestMethod]
    public void TestMethod3()
    {
        Method md = new();
        var result = md.Div2(0);
        Assert.IsTrue(result.IsFail());
    }

}