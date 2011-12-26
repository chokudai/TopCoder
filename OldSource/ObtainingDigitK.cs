using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ObtainingDigitK {
    public int minNumberToAdd(string originalNumber, int k)
    {
        int[] digit = new int[101];
        int i,j;
        for (i = 0; i < originalNumber.Length; i++) digit[originalNumber.Length - i - 1] = originalNumber[i] - '0';
        for (i = 0; i < 10; i++)
        {
            for (j = 0; j < originalNumber.Length + 1; j++)
            {
                if (j == originalNumber.Length && digit[originalNumber.Length] == 0) continue;
                if (digit[j] >= 10) { digit[j + 1]++; digit[j] -= 10; }
                if (digit[j]==k) return i;
            }
            digit[0]++;
        }
        return 9;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
