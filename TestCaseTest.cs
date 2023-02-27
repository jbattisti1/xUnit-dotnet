using System.Diagnostics;

public class TestCaseTest : TestCase
{
    public TestCaseTest(string name) : base(name)
    {
    }

    public void TestTemplateMethod()
    {
        var test = new WasRun("TestMethod");
        test.Run();
        Debug.Assert("setup testmethod teardown " == test.log);
    }
}