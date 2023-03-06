using System.Reflection;

public class TestCase
{
    public string name = "";

    public TestCase(string name)
    {
        this.name = name;
    }

    public virtual void Setup(){}

    public void Run(TestResult result)
    {
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
    }

    public virtual void TearDown(){}
}