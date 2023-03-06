using System.Diagnostics;

public class TestCaseTest : TestCase
{
    public TestResult result = new TestResult();

    public TestCaseTest(string name) : base(name)
    {
    }

    public override void Setup()
    {
        result = new TestResult();
    }

    public void TestTemplateMethod()
    {
        var test = new WasRun("TestMethod");
        test.Run(result);
        Debug.Assert("setup testmethod teardown " == test.log);
    }

    public void TestResult()
    {
        var test = new WasRun("TestMethod");
        test.Run(result);
        Debug.Assert("1 run, 0 failed" == result.Summary());
    }

    public void TestFailedResultFormatting()
    {
        result.TestStarted();
        result.TestFailed();
        Debug.Assert("1 run, 1 failed" == result.Summary());
    }

    public void TestFailedResult()
    {
        var test = new WasRun("TestBrokenMethod");
        test.Run(result);
        Debug.Assert("1 run, 1 failed" == result.Summary());
    }

    public void TestFailedResultSetup()
    {
        var test = new BrokenSetup("TestMethod");
        test.Run(result);
        Debug.Assert("1 run, 1 failed" == result.Summary());
    }

    public void TestFailedResultTearDown()
    {
        var test = new BrokenTearDown("TestMethod");
        test.Run(result);
        Debug.Assert("1 run, 1 failed" == result.Summary());
    }

    public void TestSuite()
    {
        var suite = new TestSuite();
        suite.Add(new WasRun("TestMethod"));
        suite.Add(new WasRun("TestBrokenMethod"));
        suite.Run(result);
        Debug.Assert("2 run, 1 failed" == result.Summary());
    }
}