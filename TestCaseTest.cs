using System.Diagnostics;

public class TestCaseTest : TestCase
{
    public WasRun test;

    public TestCaseTest(string name) : base(name)
    {
    }

    public override void Setup()
    {
        test = new WasRun("TestMethod");
    }

    public void TestRunning()
    {
        test.Run();
        Debug.Assert(test.wasRun);
    }

    public void TestSetup()
    {
        test.Run();
        Debug.Assert(test.wasSetup);
    }
}