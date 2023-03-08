using System.Reflection;

public class TestCase
{
    protected string name;

    public TestCase(string name)
    {
        this.name = name;
    }

    public TestResult Run()
    {
        var result = new TestResult();
        result.TestStarted();
        Setup();
        try
        {
            this.GetType().InvokeMember(this.name, BindingFlags.InvokeMethod, null, this, null);
        }
        catch (Exception)
        {
            result.TestFailed();
        }
        TearDown();
        return result;
    }

    public virtual void Setup() { }

    public virtual void TearDown() { }
}