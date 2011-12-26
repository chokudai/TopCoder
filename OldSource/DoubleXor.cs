using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class DoubleXor {
    public int calculate(int N)
    {
        int i;
        int a = N;
        for (i = N - 1; i >= 1; i--)
        {
            int next = 0;
            int b = 1;
            while (b <= a || b <= i)
            {
                int na = (a / b) % 10;
                int ni = (i / b) % 10;
                next += ((na ^ ni)%10) * b;
                b *= 10;
            }
            a = next;
        }
        return a;
    }

    public static int Main()
    {
        Console.WriteLine(new DoubleXor().calculate(888888));
        return 0;
    }


}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
