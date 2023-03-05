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

    public void TestResult()
    {
        var test = new WasRun("TestMethod");
        var result = test.Run();
        Debug.Assert("1 run, 0 failed" == result.Summary());
    }

    public void TestFailedResultFormatting()
    {
        var result = new TestResult();
        result.TestStarted();
        result.TestFailed();
        Debug.Assert("1 run, 1 failed" == result.Summary());
    }

    public void TestFailedResult()
    {
        var test = new WasRun("TestBrokenMethod");
        var result = test.Run();
        Debug.Assert("1 run, 1 failed" == result.Summary());
    }

    public void TestFailedResultSetup()
    {
        var test = new BrokenSetup("TestMethod");
        var result = test.Run();
        Debug.Assert("1 run, 1 failed" == result.Summary());
    }

    public void TestFailedResultTearDown()
    {
        var test = new BrokenTearDown("TestMethod");
        var result = test.Run();
        Debug.Assert("1 run, 1 failed" == result.Summary());
    }
}