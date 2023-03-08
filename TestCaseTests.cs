using System.Diagnostics;

public class TestCaseTests : TestCase
{
    private WasRun test;

    public TestCaseTests(string name) : base(name)
    {
    }

    public override void Setup()
    {
        this.test = new WasRun("TestMethod");
    }

    public void TestRunning()
    {
        test.Run();
        Debug.Assert(test.HasRun());
    }

    public void TestSetup()
    {
        test.Run();
        Debug.Assert(test.HasSetup());
    }
}