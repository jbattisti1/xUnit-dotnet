public class WasRun : TestCase
{
    private bool hasRun;
    private bool hasSetup;

    public WasRun(string name) : base(name)
    {
    }

    public override void Setup()
    {
        this.hasRun = false;
        this.hasSetup = true;
    }

    public void TestMethod()
    {
        this.hasRun = true;
    }

    public bool HasRun()
    {
        return this.hasRun;
    }

    public bool HasSetup()
    {
        return this.hasSetup;
    }
}