using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class BinaryCards {
    public long largestNumber(long A, long B)
    {
        int i;
        for (i = 63; i >=0; i--)
        {
            if ((A >> i) != (B >> i))
            {
                return B | (((long)1 << (i + 1)) - 1);
            }
        }
        return B;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
