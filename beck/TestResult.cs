namespace beck;

public class TestResult
{
    public int runCount;
    public int errorCount;

    public TestResult()
    {
        runCount = 0;
        errorCount = 0;
    }

    public void TestStarted()
    {
        runCount++;
    }

    public void TestFailed()
    {
        errorCount++;
    }

    public string Summary()
    {
        return $"{runCount} run, {errorCount} failed";
    }
}