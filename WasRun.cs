
public class WasRun : TestCase
{
    public bool wasRun;
    public bool wasSetup;

    public WasRun(string name) : base(name)
    {
    }

    public void TestMethod()
    {
        wasRun = true;
    }

    public override void Setup()
    {
        this.wasRun = false;
        this.wasSetup = true;
    }
}