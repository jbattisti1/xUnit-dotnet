using System.Reflection;

public class TestCase
{
    protected string name;

    public TestCase(string name)
    {
        this.name = name;
    }

    public void Run()
    {
        Setup();
        this.GetType().InvokeMember(this.name, BindingFlags.InvokeMethod, null, this, null);
        TearDown();
    }

    public virtual void Setup(){}

    public virtual void TearDown(){}
}