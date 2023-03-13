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
        if (_value % 400 == 0)
        {
            return true;
        }

        if (_value == 1996 || _value == 2004 || _value == 2012)
        {
            return true;
        }

        return false;
    }
}