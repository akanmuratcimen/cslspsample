static class TestClass
{
    public static string TestMethod(string str) => str;
}

class Program
{
    private static void Main()
    {
        var testVariable = TestClass.TestMethod("test");

        Console.WriteLine(testVariable);
    }
}
