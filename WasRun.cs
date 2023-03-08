public class WasRun : TestCase
{
    private string log;

    public WasRun(string name) : base(name)
    {
        this.log = string.Empty;
    }

    public override void Setup()
    {
        this.log += "setup ";
    }

    public void TestMethod()
    {
        this.log += "testmethod ";
    }

    public override void TearDown()
    {
        this.log += "teardown ";
    }

    public string GetLog()
    {
        return this.log;
    }
}