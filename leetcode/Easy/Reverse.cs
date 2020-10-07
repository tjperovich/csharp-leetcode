using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

/*
 * https://leetcode.com/problems/reverse-integer/
 * 
 * Given a 32-bit signed integer, reverse digits of an integer.
 * Note: Assume we are dealing with an environment that could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.
 */
public class _Reverse
{
    public int Reverse(int input)
    {
        var inputAsString = input.ToString();
        string result = "";

        if (inputAsString[0] == '-')
        {
            result = "-";
            inputAsString = inputAsString.TrimStart('-');
        }
            
        for (var x = inputAsString.Length - 1; x >= 0; --x)
        {
            result += inputAsString[x];
        }
        try
        {
            return Convert.ToInt32(result);
        }
        catch (OverflowException)
        {
            return 0;
        }
    }
}

