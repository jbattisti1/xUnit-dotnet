public class WasRun : TestCase
{
    public bool _wasRun { get; set; }

    public WasRun(string name) : base(name) { }

    public void TestMethod()
    {
        _wasRun = true;
    }
}