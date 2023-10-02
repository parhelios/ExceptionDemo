namespace ClassLib;

public class CartIndexException : Exception
{
    public override string Message { get; } = "Nu gick det på röven hörredu! Den indexpositionen finns inte!";
}