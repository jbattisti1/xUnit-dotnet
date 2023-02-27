public class WasRun : TestCase
{
    public string? log;

    public WasRun(string name) : base(name)
    {
    }

    public override void Setup()
    {
        this.log = "setup ";
    }

    public void TestMethod()
    {
        this.log += "testmethod ";
    }
}