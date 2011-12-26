using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class RabbitNumbering {
    public int theCount(int[] maxNumber)
    {
        Array.Sort(maxNumber);
        long mod = 1000000007;
        long now = 1;
        for (int i = 0; i < maxNumber.Length; i++)
        {
            now *= Math.Max(0, maxNumber[i] - i);
            now %= mod;
        }
        return (int)now;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
