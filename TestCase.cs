using System.Reflection;

public class TestCase
{
    public string name = "";

    public TestCase(string name)
    {
        this.name = name;
    }

    public void Run()
    {
        Setup();
        this.GetType().InvokeMember(name, BindingFlags.InvokeMethod, null, this, null);
    }

    public virtual void Setup()
    {

    }

}