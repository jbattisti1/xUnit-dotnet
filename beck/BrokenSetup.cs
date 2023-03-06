namespace beck;

public class BrokenSetup: TestCase
{

    public BrokenSetup(string name) : base(name)
    {
    }

    public override void Setup()
    {
        throw new Exception();
    }
    
    public void TestMethod()
    {
    }
}