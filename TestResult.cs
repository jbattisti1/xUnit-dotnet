public class TestResult
{
    public int runCount;

    public TestResult()
    {
        runCount = 0;
    }

    public void TestStarted()
    {
        runCount++;
    }

    public string Summary()
    {
        return $"{runCount} run, 0 failed";
    }
}