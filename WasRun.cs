
public class WasRun : TestCase
{
    public bool wasRun;

    public WasRun(string name) : base(name)
    {
        this.wasRun = false;
    }

    public void TestMethod()
    {
        wasRun = true;
    }
}