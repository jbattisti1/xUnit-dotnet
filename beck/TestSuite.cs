namespace beck;

public class TestSuite
{
    public List<TestCase> tests = new List<TestCase>();

    public TestSuite()
    {
    }

    public void Add(TestCase test)
    {
        tests.Add(test);
    }

    public void Run(TestResult result)
    {
        foreach (var test in tests)
        {
            test.Run(result);
        }
    }
}