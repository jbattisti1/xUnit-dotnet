using System.Reflection;

public class TestCase
{
    public string _name { get; set; }

    public TestCase(string name)
    {
        _name = name;
    }

    public void Run()
    {
        this.GetType().InvokeMember(_name, BindingFlags.InvokeMethod, null, this, null);
    }
}