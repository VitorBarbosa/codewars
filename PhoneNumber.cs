using System;
using System.Linq;

public class PhoneNumber
{
    public static string CreatePhoneNumber(int[] numbers)
    {
        var numString = string.Join("", numbers);
        return $"({numString.Substring(0,3)}) {numString.Substring(3,3)}-{numString.Substring(6)}";
    }
}