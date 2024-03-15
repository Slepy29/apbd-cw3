using System.Diagnostics;

namespace cw3.Exceptions;

public class OverFillException : Exception
{
    public OverFillException(string message)
    {
        Console.Error.WriteLine(message);
    }
}