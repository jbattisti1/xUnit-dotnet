using System.Reflection;

public class TestCase
{
    public string name = "";

    public TestCase(string name)
    {
        this.name = name;
    }

    public virtual void Setup(){}

    public TestResult Run()
    {
        var result = new TestResult();
        result.TestStarted();
        try
        {
            Setup();
            this.GetType().InvokeMember(name, BindingFlags.InvokeMethod, null, this, null);
            TearDown();
        }
        catch (Exception)
        {
            result.TestFailed();
        }
        return result;
    }

    public virtual void TearDown(){}
}