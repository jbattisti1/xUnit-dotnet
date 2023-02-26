using System.Diagnostics;

public class TestCaseTest : TestCase
{
    public TestCaseTest(string name) : base(name)
    {
    }

    public void TestRunning()
    {
        var test = new WasRun("TestMethod");
        Debug.Assert(!test.wasRun);
        test.Run();
        Debug.Assert(test.wasRun);
    }
}