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

    public void TestResult()
    {
        var test = new WasRun("TestMethod");
        var result = test.Run();
        Debug.Assert("1 run, 0 failed".Equals(result.Summary()));
    }

    public void TestFailedResult()
    {
        var test = new WasRun("TestBrokenMethod");
        var result = test.Run();
        Debug.Assert("1 run, 1 failed".Equals(result.Summary()));
    }

    public void TestFailedResultFormatting()
    {
        var result = new TestResult();
        result.TestStarted();
        result.TestFailed();
        Debug.Assert("1 run, 1 failed".Equals(result.Summary()));
    }
}