namespace ClassLib;

public class DemoException : Exception
{
    public override string Message { get; } = "Detta är ett test!";
}