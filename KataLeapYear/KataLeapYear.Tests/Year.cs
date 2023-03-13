namespace KataLeapYear.Tests;

public class Year
{
    private readonly int _value;

    public Year(int value)
    {
        _value = value;
    }

    public bool IsLeap()
    {
        return _value % 400 == 0  || _value % 4 == 0 && _value % 100 != 0;
    }
}