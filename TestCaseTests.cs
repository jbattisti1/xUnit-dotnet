using System.Diagnostics;

public class TestCaseTests : TestCase
{
    public TestCaseTests(string name) : base(name)
    {
    }

    public void TestTemplateSetup()
    {
        var test = new WasRun("TestMethod");
        test.Run();
        Debug.Assert("setup testmethod teardown ".Equals(test.GetLog()));
    }
}