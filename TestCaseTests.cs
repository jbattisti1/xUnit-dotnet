using System.Diagnostics;

public class TestCaseTests : TestCase
{
    public TestCaseTests(string name) : base(name) { }

    public void TestRunning()
    {
        var wasRun = new WasRun("TestMethod");
        Debug.Assert(!wasRun._wasRun);
        wasRun.Run();
        Debug.Assert(wasRun._wasRun);
    }
}