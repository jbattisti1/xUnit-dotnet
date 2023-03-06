public class BrokenTearDown: TestCase
{

    public BrokenTearDown(string name) : base(name)
    {
    }

    public override void TearDown()
    {
        throw new Exception();
    }

    public void TestMethod()
    {
    }
}